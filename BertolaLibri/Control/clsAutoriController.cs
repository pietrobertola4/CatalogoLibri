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
    internal class clsAutoriController
    {

        public clsAutori modAutore;
        private adoNetSQL sqlAutore;
        private adoNetSQL sqlLibro;
        private bool pErrore;
        private string pStrSQL;
        private string pStrSQLLibri;
        private List<clsAutori> listaAutori;
        private DataTable tabellaAutori;

        public string msgElaborazione;

        public clsAutoriController()
        {
            string pathDB = Application.StartupPath + "\\CatalogoLibri.mdf";
            sqlAutore = new adoNetSQL(pathDB);
            msgElaborazione = String.Empty;

            // Gestisco il MODELLO
            modAutore = new clsAutori();
            modAutore.CodAutore = 0;
            modAutore.CognAutore = string.Empty;
            modAutore.NomeAutore = string.Empty;
            modAutore.DataNasAutore = DateTime.Now;
            modAutore.ValAutore = ' ';
        }

        public bool aggiungi()
        {
            pErrore = false;

            sqlAutore.cmd.Parameters.AddWithValue("@CdAutore", modAutore.CodAutore);
            sqlAutore.cmd.Parameters.AddWithValue("@NoAutore", modAutore.NomeAutore);
            sqlAutore.cmd.Parameters.AddWithValue("@CoAutore", modAutore.CognAutore);
            sqlAutore.cmd.Parameters.AddWithValue("@DaAutore", modAutore.DataNasAutore);
            sqlAutore.cmd.Parameters.AddWithValue("@VAutore", modAutore.ValAutore);

            pStrSQL = "INSERT INTO Autori " +
                       "(CodAutore, CognAutore, NomeAutore, DataNasAutore, ValAutore) " +
                       "VALUES(@CdAutore, @CoAutore, @NoAutore, @DaAutore, @VAutore)";

            try
            {
                sqlAutore.eseguiNonQuery(pStrSQL, CommandType.Text);
                msgElaborazione = "Autore inserito con successo !!!";
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

            sqlAutore.cmd.Parameters.AddWithValue("@CdAutore", modAutore.CodAutore);
            sqlAutore.cmd.Parameters.AddWithValue("@NoAutore", modAutore.NomeAutore);
            sqlAutore.cmd.Parameters.AddWithValue("@CoAutore", modAutore.CognAutore);
            sqlAutore.cmd.Parameters.AddWithValue("@DaAutore", modAutore.DataNasAutore);
            sqlAutore.cmd.Parameters.AddWithValue("@VAutore", modAutore.ValAutore);

            pStrSQL = "UPDATE Autori " +
                        "SET CognAutore=@CoAutore, NomeAutore=@NoAutore, DataNasAutore=@DaAutore, ValAutore=@VAutore " +
                        "WHERE CodAutore=@CdAutore";

            //pStrSQLLibri = "UPDATE Libri SET ValLibro=@VAutore WHERE ";
;
            try
            {
                sqlAutore.eseguiNonQuery(pStrSQL, CommandType.Text);
                //sqlLibro.eseguiNonQuery(pStrSQLLibri, CommandType.Text);
                msgElaborazione = "Autore e Libri modificati con successo !!!";
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

            sqlAutore.cmd.Parameters.AddWithValue("@CdAutore", modAutore.CodAutore);
            sqlAutore.cmd.Parameters.AddWithValue("@VAutore", modAutore.ValAutore);

            pStrSQL = "UPDATE Autori " +
                        "SET ValEditore=@VAutore " +
                        "WHERE CodAutore=@CdAutore";

            try
            {
                sqlAutore.eseguiNonQuery(pStrSQL, CommandType.Text);
            }
            catch (Exception ex)
            {
                msgElaborazione = ex.Message;
                pErrore = true;
            }
            finally
            {
                if (!pErrore)
                    if (modAutore.ValAutore == 'A')
                        msgElaborazione = "Autore annullato con successo !!!";
                    else
                        msgElaborazione = "Autore ripristinato con successo !!!";
            }

            return pErrore;
        }

        public bool verificaAutore()
        {
            pErrore = false;
            string risultato = string.Empty;
            msgElaborazione = string.Empty;

            sqlAutore.cmd.Parameters.AddWithValue("@CdAutore", modAutore.CodAutore);

            pStrSQL = "SELECT COUNT(*) FROM Autori where CodAutore = @CdAutore";
            try
            {
                risultato = sqlAutore.eseguiScalar(pStrSQL, CommandType.Text);
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
                    msgElaborazione = "Autore già esistente";
                    pErrore = true;
                }

            }

            return pErrore;
        }

        public List<clsAutori> elencoAutori(char validita)
        {
            pErrore = false;
            listaAutori = new List<clsAutori>();
            SqlDataReader dataReader;
            string strValidita = "('')";

            if (validita == 'A')
                strValidita = "('', 'A')";

            pStrSQL = "SELECT * FROM Autori " +
                       "WHERE ValAutore IN " + strValidita;

            try
            {
                dataReader = sqlAutore.creaLettore(pStrSQL, CommandType.Text);
                while (dataReader.Read())
                {
                    clsAutori detAutore = new clsAutori();
                    detAutore.CodAutore = Convert.ToInt32(dataReader["CodAutore"]);
                    detAutore.CognAutore = dataReader["CognAutore"].ToString();
                    detAutore.NomeAutore = dataReader["NomeAutore"].ToString();
                    detAutore.DataNasAutore = Convert.ToDateTime(dataReader["DataNasAutore"]);
                    detAutore.ValAutore = Convert.ToChar(dataReader["ValAutore"]);
                    listaAutori.Add(detAutore);
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
                sqlAutore.chiudiLettore();
            }

            return listaAutori;
        }


        public clsAutori datiAutore()
        {
            pErrore = false;
            clsAutori detAutore = new clsAutori();

            sqlAutore.cmd.Parameters.AddWithValue("@CdAutore", modAutore.CodAutore);

            pStrSQL = "SELECT CognAutore, NomeAutore, DataNasAutore, ValAutore " +
                       "FROM Autori " +
                       "WHERE CodAutore = @CdAutore";

            try
            {
                tabellaAutori = sqlAutore.eseguiQuery(pStrSQL, CommandType.Text);
            }
            catch (Exception ex)
            {
                msgElaborazione = ex.Message;
                pErrore = true;
            }

            if (!pErrore)
            {
                detAutore.CodAutore = Convert.ToInt32(modAutore.CodAutore);
                detAutore.CognAutore = tabellaAutori.Rows[0].ItemArray[0].ToString();
                detAutore.NomeAutore = tabellaAutori.Rows[0].ItemArray[1].ToString();
                detAutore.DataNasAutore = Convert.ToDateTime(tabellaAutori.Rows[0].ItemArray[2]);
                detAutore.ValAutore = Convert.ToChar(tabellaAutori.Rows[0].ItemArray[3]);
            }

            return detAutore;
        }

        public string lastCodice()
        {
            string nuovoCodice = string.Empty;
            string risultato = string.Empty;

            pStrSQL = "SELECT TOP 1 CodAutore " +
                       "FROM Autori " +
                       "ORDER BY CodAutore DESC";

            try
            {
                risultato = sqlAutore.eseguiScalar(pStrSQL, CommandType.Text);
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
