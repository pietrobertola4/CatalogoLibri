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
    internal class clsEditoriController
    {

        public clsEditori modEditore;
        private adoNetSQL sqlEditore;
        private bool pErrore;
        private string pStrSQL;
        private List<clsEditori> listaEditori;
        private DataTable tabellaEditori;

        public string msgElaborazione;

        public clsEditoriController()
        {
            string pathDB = Application.StartupPath + "\\CatalogoLibri.mdf";
            sqlEditore = new adoNetSQL(pathDB);
            msgElaborazione = String.Empty;

            // Gestisco il MODELLO
            modEditore = new clsEditori();
            modEditore.CodEditore = 0;
            modEditore.NomeEditore = string.Empty;
            modEditore.ValEditore = ' ';
        }

        public bool aggiungi()
        {
            pErrore = false;

            sqlEditore.cmd.Parameters.AddWithValue("@CdEditore", modEditore.CodEditore);
            sqlEditore.cmd.Parameters.AddWithValue("@NoEditore", modEditore.NomeEditore);
            sqlEditore.cmd.Parameters.AddWithValue("@VEditore", modEditore.ValEditore);

            pStrSQL = "INSERT INTO Editori " +
                       "(CodEditore, NomeEditore, ValEditore) " +
                       "VALUES(@CdEditore, @NoEditore, @VEditore)";

            try
            {
                sqlEditore.eseguiNonQuery(pStrSQL, CommandType.Text);
                msgElaborazione = "Editore inserito con successo !!!";
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

            sqlEditore.cmd.Parameters.AddWithValue("@CdEditore", modEditore.CodEditore);
            sqlEditore.cmd.Parameters.AddWithValue("@NoEditore", modEditore.NomeEditore);
            sqlEditore.cmd.Parameters.AddWithValue("@VEditore", modEditore.ValEditore);

            pStrSQL = "UPDATE Editori " +
                        "SET NomeEditore=@NoEditore, ValEditore=@VEditore " +
                        "WHERE CodEditore=@CdEditore";

            try
            {
                sqlEditore.eseguiNonQuery(pStrSQL, CommandType.Text);
                msgElaborazione = "Editore modificato con successo !!!";
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

            sqlEditore.cmd.Parameters.AddWithValue("@CdEditore", modEditore.CodEditore);
            sqlEditore.cmd.Parameters.AddWithValue("@VEditore", modEditore.ValEditore);

            pStrSQL = "UPDATE Editori " +
                        "SET ValEditore=@VEditore " +
                        "WHERE CodEditore=@CdEditore";

            try
            {
                sqlEditore.eseguiNonQuery(pStrSQL, CommandType.Text);
            }
            catch (Exception ex)
            {
                msgElaborazione = ex.Message;
                pErrore = true;
            }
            finally
            {
                if (!pErrore)
                    if (modEditore.ValEditore == 'A')
                        msgElaborazione = "Editore annullato con successo !!!";
                    else
                        msgElaborazione = "Editore ripristinato con successo !!!";
            }

            return pErrore;
        }

        public bool verificaEditore()
        {
            pErrore = false;
            string risultato = string.Empty;
            msgElaborazione = string.Empty;

            sqlEditore.cmd.Parameters.AddWithValue("@CdEditore", modEditore.CodEditore);

            pStrSQL = "SELECT COUNT(*) FROM Editori where CodEditore = @CdEditore";
            try
            {
                risultato = sqlEditore.eseguiScalar(pStrSQL, CommandType.Text);
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
                    msgElaborazione = "Editore già esistente";
                    pErrore = true;
                }

            }

            return pErrore;
        }

        public List<clsEditori> elencoEditori(char validita)
        {
            pErrore = false;
            listaEditori = new List<clsEditori>();
            SqlDataReader dataReader;
            string strValidita = "('')";

            if (validita == 'A')
                strValidita = "('', 'A')";

            pStrSQL = "SELECT * FROM Editori " +
                       "WHERE ValEditore IN " + strValidita;

            try
            {
                dataReader = sqlEditore.creaLettore(pStrSQL, CommandType.Text);
                while (dataReader.Read())
                {
                    clsEditori detEditore = new clsEditori();
                    detEditore.CodEditore = Convert.ToInt32(dataReader["CodEditore"]);
                    detEditore.NomeEditore = dataReader["NomeEditore"].ToString();
                    detEditore.ValEditore = Convert.ToChar(dataReader["ValEditore"]);
                    listaEditori.Add(detEditore);
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
                sqlEditore.chiudiLettore();
            }

            return listaEditori;
        }


        public clsEditori datiEditore()
        {
            pErrore = false;
            clsEditori detEditore = new clsEditori();

            sqlEditore.cmd.Parameters.AddWithValue("@CdEditore", modEditore.CodEditore);

            pStrSQL = "SELECT NomeEditore, ValEditore " +
                       "FROM Editori " +
                       "WHERE CodEditore = @CdEditore";

            try
            {
                tabellaEditori = sqlEditore.eseguiQuery(pStrSQL, CommandType.Text);
            }
            catch (Exception ex)
            {
                msgElaborazione = ex.Message;
                pErrore = true;
            }

            if (!pErrore)
            {
                detEditore.CodEditore = Convert.ToInt32(modEditore.CodEditore);
                detEditore.NomeEditore = tabellaEditori.Rows[0].ItemArray[0].ToString();
                detEditore.ValEditore = Convert.ToChar(tabellaEditori.Rows[0].ItemArray[1]);
            }

            return detEditore;
        }

        public string lastCodice()
        {
            string nuovoCodice = string.Empty;
            string risultato = string.Empty;

            pStrSQL = "SELECT TOP 1 CodEditore " +
                       "FROM Editori " +
                       "ORDER BY CodEditore DESC";

            try
            {
                risultato = sqlEditore.eseguiScalar(pStrSQL, CommandType.Text);
                nuovoCodice = (Convert.ToInt32(risultato) + 1).ToString();
            }
            catch (Exception ex)
            {
                msgElaborazione = ex.Message;
            }

            return nuovoCodice;

        }

        public List<clsEditori> elencoEditoriLibri(char validita)
        {
            pErrore = false;
            listaEditori = new List<clsEditori>();
            SqlDataReader dataReader;
            string strValidita = "('')";

            if (validita == 'A')
                strValidita = "('', 'A')";

            pStrSQL = "SELECT CodEditore, NomeEditore FROM Editori " +
                       "WHERE ValEditore IN " + strValidita;

            try
            {
                dataReader = sqlEditore.creaLettore(pStrSQL, CommandType.Text);
                while (dataReader.Read())
                {
                    clsEditori detEditore = new clsEditori();
                    detEditore.CodEditore = Convert.ToInt32(dataReader["CodEditore"]);
                    detEditore.NomeEditore = dataReader["NomeEditore"].ToString();
                    listaEditori.Add(detEditore);
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
                sqlEditore.chiudiLettore();
            }

            return listaEditori;
        }
    }
}
