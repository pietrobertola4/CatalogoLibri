using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient; // ?

using BertolaLibri.Model;
using System.Drawing.Text;
namespace BertolaLibri.Control
{
    internal class clsLibriController
    {
        public clsLibri modLibro;
        private adoNetSQL sqlLibro;
        private bool pErrore;
        private string pStrSQL;
        private string pStrSQLibri;
        private List<clsLibri> listaLibri;

        private List<clsReparti> listaReparti;
        private List<clsOfferte> listaOfferte;
        private List<clsEditori> listaEditori;

        private DataTable tabellaLibri;

        public string msgElaborazione;

        public clsLibriController()
        {
            string pathDB = Application.StartupPath + "\\CatalogoLibri.mdf";
            sqlLibro = new adoNetSQL(pathDB);
            msgElaborazione = String.Empty;

            // Gestisco il MODELLO
            modLibro = new clsLibri();
            modLibro.CodLibro = 0;
            modLibro.TitoloLibro = string.Empty;
            modLibro.PrezzoLibro = 0;
            modLibro.DataLibro = DateTime.Now;
            modLibro.NPagLibro = 0;
            modLibro.CodRepLibro = string.Empty;
            modLibro.CodOffLibro = 0;
            modLibro.CodEdiLibro = 0;
            modLibro.ValLibro = ' ';
        }

        public bool aggiungi()
        {
            pErrore = false;

            sqlLibro.cmd.Parameters.AddWithValue("@CdLibro", modLibro.CodLibro);
            sqlLibro.cmd.Parameters.AddWithValue("@TitoloLibro", modLibro.TitoloLibro);
            sqlLibro.cmd.Parameters.AddWithValue("@PrezzoLibro", modLibro.PrezzoLibro);
            sqlLibro.cmd.Parameters.AddWithValue("@DataLibro", modLibro.DataLibro);
            sqlLibro.cmd.Parameters.AddWithValue("@NPagLibro", modLibro.NPagLibro);
            sqlLibro.cmd.Parameters.AddWithValue("@CdRepLibro", modLibro.CodRepLibro);
            sqlLibro.cmd.Parameters.AddWithValue("@CdOffLibro", modLibro.CodOffLibro);
            sqlLibro.cmd.Parameters.AddWithValue("@CdEdiLibro", modLibro.CodEdiLibro);
            sqlLibro.cmd.Parameters.AddWithValue("@VLibro", modLibro.ValLibro);

            pStrSQL = "INSERT INTO Libri " +
                       "(CodLibro, TitoloLibro, PrezzoLibro, DataLibro, NPagLibro, CodRepLibro, CodOffLibro, CodEdiLibro, ValLibro) " +
                       "VALUES(@CdLibro, @TitoloLibro, @PrezzoLibro, @DataLibro, @NPagLibro, @CdRepLibro, @CdOffLibro, @CdEdiLibro, @VLibro)";

            try
            {
                sqlLibro.eseguiNonQuery(pStrSQL, CommandType.Text);
                msgElaborazione = "Libro inserito con successo !!!";
            }
            catch (Exception ex)
            {
                msgElaborazione = ex.Message;
                pErrore = true;
            }

            return pErrore;
        }

        public bool modifica()
        {
            pErrore = false;

            sqlLibro.cmd.Parameters.AddWithValue("@CdLibro", modLibro.CodLibro);
            sqlLibro.cmd.Parameters.AddWithValue("@TitoloLibro", modLibro.TitoloLibro);
            sqlLibro.cmd.Parameters.AddWithValue("@PrezzoLibro", modLibro.PrezzoLibro);
            sqlLibro.cmd.Parameters.AddWithValue("@DataLibro", modLibro.DataLibro);
            sqlLibro.cmd.Parameters.AddWithValue("@NPagLibro", modLibro.NPagLibro);
            sqlLibro.cmd.Parameters.AddWithValue("@CdRepLibro", modLibro.CodRepLibro);
            sqlLibro.cmd.Parameters.AddWithValue("@CdOffLibro", modLibro.CodOffLibro);
            sqlLibro.cmd.Parameters.AddWithValue("@CdEdiLibro", modLibro.CodEdiLibro);
            sqlLibro.cmd.Parameters.AddWithValue("@VLibro", modLibro.ValLibro);

            pStrSQL = "UPDATE Libri " +
                        "SET TitoloLibro=@TitoloLibro, PrezzoLibro=@PrezzoLibro, DataLibro=@DataLibro, NPagLibro=@NPagLibro, CodRepLibro=@CdRepLibro, CodOffLibro=@CdOffLibro, CodEdiLibro=@CdEdiLibro,ValLibro=@VLibro " +
                        "WHERE CodLibro=@CdLibro";

            try
            {
                sqlLibro.eseguiNonQuery(pStrSQL, CommandType.Text);
                msgElaborazione = "Libro modificato con successo !!!";
            }
            catch (Exception ex)
            {
                msgElaborazione = ex.Message;
                pErrore = true;
            }

            return pErrore;
        }

        public bool cancella()
        {
            pErrore = false;

            sqlLibro.cmd.Parameters.AddWithValue("@CdLibro", modLibro.CodLibro);
            sqlLibro.cmd.Parameters.AddWithValue("@VLibro", modLibro.ValLibro);

            pStrSQL = "UPDATE Libri " +
                        "SET ValLibro=@VLibro " +
                        "WHERE CodLibro=@CdLibro";

            try
            {
                sqlLibro.eseguiNonQuery(pStrSQL, CommandType.Text);
            }
            catch (Exception ex)
            {
                msgElaborazione = ex.Message;
                pErrore = true;
            }
            finally
            {
                if (!pErrore)
                    if (modLibro.ValLibro == 'A')
                        msgElaborazione = "Libro annullato con successo !!!";
                    else
                        msgElaborazione = "Libro ripristinato con successo !!!";
            }

            return pErrore;
        }

        public bool verificaLibro()
        {
            pErrore = false;
            string risultato = string.Empty;
            msgElaborazione = string.Empty;

            sqlLibro.cmd.Parameters.AddWithValue("@CdLibro", modLibro.CodLibro);

            pStrSQL = "SELECT COUNT(*) FROM Libri where CodLibro = @CdLibro";
            try
            {
                risultato = sqlLibro.eseguiScalar(pStrSQL, CommandType.Text);
            }
            catch (Exception ex)
            {
                msgElaborazione = ex.Message;
                pErrore = true;
            }
            finally
            {
                if (Convert.ToInt32(risultato) != 0)
                {
                    msgElaborazione = "Libro già esistente";
                    pErrore = true;
                }

            }

            return pErrore;
        }

        public List<clsLibri> elencoLibri(char validita)
        {
            pErrore = false;
            listaLibri = new List<clsLibri>();
            SqlDataReader dataReader;
            string strValidita = "('')";

            if (validita == 'A')
                strValidita = "('', 'A')";

            pStrSQL = "SELECT * FROM Libri " +
                       "WHERE ValLibro IN " + strValidita;

            try
            {
                dataReader = sqlLibro.creaLettore(pStrSQL, CommandType.Text);
                while (dataReader.Read())
                {
                    clsLibri detLibro = new clsLibri();
                    detLibro.CodLibro = Convert.ToInt32(dataReader["CodLibro"]);
                    detLibro.TitoloLibro = dataReader["TitoloLibro"].ToString();
                    detLibro.PrezzoLibro = Convert.ToDouble(dataReader["PrezzoLibro"]);
                    detLibro.DataLibro = Convert.ToDateTime(dataReader["DataLibro"]);
                    detLibro.NPagLibro = Convert.ToInt32(dataReader["NPagLibro"]);
                    detLibro.CodRepLibro = (dataReader["CodRepLibro"]).ToString();
                    detLibro.CodOffLibro = Convert.ToInt32(dataReader["CodOffLibro"]);
                    detLibro.CodEdiLibro = Convert.ToInt32(dataReader["CodEdiLibro"]);
                    detLibro.ValLibro = Convert.ToChar(dataReader["ValLibro"]);
                    listaLibri.Add(detLibro);
                }
            }
            catch (Exception ex)
            {
                msgElaborazione = ex.Message;
                pErrore = true;
            }
            finally
            {
                msgElaborazione = "Lista creata con successo !!!";
                sqlLibro.chiudiLettore();
            }

            return listaLibri;
        }


        public clsLibri datiLibri()
        {
            pErrore = false;
            clsLibri detLibro = new clsLibri();

            sqlLibro.cmd.Parameters.AddWithValue("@CdLibro", modLibro.CodLibro);

            pStrSQL = "SELECT CodLibro, TitoloLibro, PrezzoLibro, DataLibro, NPagLibro, CodRepLibro, CodOffLibro, CodEdiLibro, ValLibro " +
                       "FROM Libri " +
                       "WHERE CodLibro = @CdLibro";

            try
            {
                tabellaLibri = sqlLibro.eseguiQuery(pStrSQL, CommandType.Text);
            }
            catch (Exception ex)
            {
                msgElaborazione = ex.Message;
                pErrore = true;
            }

            if (!pErrore)
            {
                detLibro.CodLibro = Convert.ToInt32(modLibro.CodLibro);
                detLibro.TitoloLibro = tabellaLibri.Rows[0].ItemArray[0].ToString();
                detLibro.PrezzoLibro = Convert.ToDouble(tabellaLibri.Rows[0].ItemArray[1]);
                detLibro.DataLibro = Convert.ToDateTime(tabellaLibri.Rows[0].ItemArray[2]);
                detLibro.NPagLibro = Convert.ToInt32(tabellaLibri.Rows[0].ItemArray[3]);
                detLibro.CodRepLibro = tabellaLibri.Rows[0].ItemArray[4].ToString();
                detLibro.CodOffLibro = Convert.ToInt32(tabellaLibri.Rows[0].ItemArray[5]);
                detLibro.CodEdiLibro = Convert.ToInt32(tabellaLibri.Rows[0].ItemArray[6]);
                detLibro.ValLibro = Convert.ToChar(tabellaLibri.Rows[0].ItemArray[7]);
            }

            return detLibro;
        }

        public string lastCodice()
        {
            string nuovoCodice = string.Empty;
            string risultato = string.Empty;

            pStrSQL = "SELECT TOP 1 CodLibro " +
                       "FROM Libri " +
                       "ORDER BY CodLibro DESC";

            try
            {
                risultato = sqlLibro.eseguiScalar(pStrSQL, CommandType.Text);
                nuovoCodice = (Convert.ToInt32(risultato) + 1).ToString();
            }
            catch (Exception ex)
            {
                msgElaborazione = ex.Message;
            }

            return nuovoCodice;

        }
    }
}
