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
    internal class clsOfferteController
    {
        
        public clsOfferte modOfferta;
        private adoNetSQL sqlOfferta;
        private bool pErrore;
        private string pStrSQL;
        private List<clsOfferte> listaOfferte;
        private DataTable tabellaOfferta;

        public string msgElaborazione;

        public clsOfferteController()
        {
            string pathDB = Application.StartupPath + "\\CatalogoLibri.mdf";
            sqlOfferta = new adoNetSQL(pathDB);
            msgElaborazione = String.Empty;

            // Gestisco il MODELLO
            modOfferta = new clsOfferte();
            modOfferta.CodOfferta = 0;
            modOfferta.DesOfferta = string.Empty;
            modOfferta.ScontoOfferta = 0;
            modOfferta.ValOfferta = ' ';
        }

        public bool aggiungi()
        {
            pErrore = false;

            //sqlOfferta.cmd.Parameters.AddWithValue("@CdOfferta", modOfferta.CodOfferta);
            sqlOfferta.cmd.Parameters.AddWithValue("@DeOfferta", modOfferta.DesOfferta);
            sqlOfferta.cmd.Parameters.AddWithValue("@ScOfferta", modOfferta.ScontoOfferta);
            sqlOfferta.cmd.Parameters.AddWithValue("@VOfferta", modOfferta.ValOfferta);

            pStrSQL = "INSERT INTO Offerte " +
                       "(DesOfferta, ScontoOfferta, ValOfferta) " +
                       "VALUES(@DeOfferta, @ScOfferta, @VOfferta)";

            try
            {
                sqlOfferta.eseguiNonQuery(pStrSQL, CommandType.Text);
                msgElaborazione = "Offerta inserita con successo !!!";
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

            sqlOfferta.cmd.Parameters.AddWithValue("@CdOfferta", modOfferta.CodOfferta);
            sqlOfferta.cmd.Parameters.AddWithValue("@DeOfferta", modOfferta.DesOfferta);
            sqlOfferta.cmd.Parameters.AddWithValue("@ScOfferta", modOfferta.ScontoOfferta);
            sqlOfferta.cmd.Parameters.AddWithValue("@VOfferta", modOfferta.ValOfferta);

            pStrSQL = "UPDATE Offerte " +
                        "SET DesOfferta=@DeOfferta, ScontoOfferta=@ScOfferta, ValOfferta=@VOfferta " +
                        "WHERE CodOfferta=@CdOfferta";

            try
            {
                sqlOfferta.eseguiNonQuery(pStrSQL, CommandType.Text);
                msgElaborazione = "Offerta modificata con successo !!!";
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

            sqlOfferta.cmd.Parameters.AddWithValue("@CdOfferta", modOfferta.CodOfferta);
            sqlOfferta.cmd.Parameters.AddWithValue("@VOfferta", modOfferta.ValOfferta);

            pStrSQL = "UPDATE Offerte " +
                        "SET ValOfferta=@VOfferta " +
                        "WHERE CodOfferta=@CdOfferta";

            try
            {
                sqlOfferta.eseguiNonQuery(pStrSQL, CommandType.Text);
            }
            catch (Exception ex)
            {
                msgElaborazione = ex.Message;
                pErrore = true;
            }
            finally
            {
                if (!pErrore)
                    if (modOfferta.ValOfferta == 'A')
                        msgElaborazione = "Offerta annullata con successo !!!";
                    else
                        msgElaborazione = "Offerta ripristinata con successo !!!";
            }

            return pErrore;
        }

        public bool verificaOfferta()
        {
            pErrore = false;
            string risultato = string.Empty;
            msgElaborazione = string.Empty;

            sqlOfferta.cmd.Parameters.AddWithValue("@CdOfferta", modOfferta.CodOfferta);

            pStrSQL = "SELECT COUNT(*) FROM Offerte where CodOfferta = @CdOfferta";
            try
            {
                risultato = sqlOfferta.eseguiScalar(pStrSQL, CommandType.Text);
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
                    msgElaborazione = "Offerta già esistente";
                    pErrore = true;
                }

            }

            return pErrore;
        }

        public List<clsOfferte> elencoOfferte(char validita)
        {
            pErrore = false;
            listaOfferte = new List<clsOfferte>();
            SqlDataReader dataReader;
            string strValidita = "('')";

            if (validita == 'A')
                strValidita = "('', 'A')";

            pStrSQL = "SELECT * FROM Offerte " +
                       "WHERE ValOfferta IN " + strValidita;

            try
            {
                dataReader = sqlOfferta.creaLettore(pStrSQL, CommandType.Text);
                while (dataReader.Read())
                {
                    clsOfferte detOfferta = new clsOfferte();
                    detOfferta.CodOfferta = Convert.ToInt32(dataReader["CodOfferta"]);
                    detOfferta.DesOfferta = dataReader["DesOfferta"].ToString();
                    detOfferta.ScontoOfferta = Convert.ToInt32(dataReader["ScontoOfferta"]);
                    detOfferta.ValOfferta = Convert.ToChar(dataReader["ValOfferta"]);
                    listaOfferte.Add(detOfferta);
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
                sqlOfferta.chiudiLettore();
            }

            return listaOfferte;
        }


        public clsOfferte datiOfferta()
        {
            pErrore = false;
            clsOfferte detOfferta = new clsOfferte();

            sqlOfferta.cmd.Parameters.AddWithValue("@CdOfferta", modOfferta.CodOfferta);

            pStrSQL = "SELECT DesOfferta, ScontoOfferta, ValOfferta " +
                       "FROM Offerte " +
                       "WHERE CodOfferta = @CdOfferta";

            try
            {
                tabellaOfferta = sqlOfferta.eseguiQuery(pStrSQL, CommandType.Text);
            }
            catch (Exception ex)
            {
                msgElaborazione = ex.Message;
                pErrore = true;
            }

            if (!pErrore)
            {
                detOfferta.CodOfferta = Convert.ToInt32(modOfferta.CodOfferta);
                detOfferta.DesOfferta = tabellaOfferta.Rows[0].ItemArray[0].ToString();
                detOfferta.ScontoOfferta = Convert.ToInt32(tabellaOfferta.Rows[0].ItemArray[1]);
                detOfferta.ValOfferta = Convert.ToChar(tabellaOfferta.Rows[0].ItemArray[2]);
            }

            return detOfferta;
        }

        public string lastCodice()
        {
            string nuovoCodice = string.Empty;
            string risultato = string.Empty;

            pStrSQL = "SELECT TOP 1 CodOfferta " +
                       "FROM Offerte " +
                       "ORDER BY CodOfferta DESC";

            try
            {
                risultato = sqlOfferta.eseguiScalar(pStrSQL, CommandType.Text);
                nuovoCodice = (Convert.ToInt32(risultato) + 1).ToString();
            }
            catch (Exception ex)
            {
                msgElaborazione = ex.Message;
            }

            return nuovoCodice;
            
        }

        public List<clsOfferte> elencoOfferteLibri(char validita)
        {
            pErrore = false;
            listaOfferte = new List<clsOfferte>();
            SqlDataReader dataReader;
            string strValidita = "('')";

            if (validita == 'A')
                strValidita = "('', 'A')";

            pStrSQL = "SELECT CodOfferta, DesOfferta FROM Offerte " +
                       "WHERE ValOfferta IN " + strValidita;

            try
            {
                dataReader = sqlOfferta.creaLettore(pStrSQL, CommandType.Text);
                while (dataReader.Read())
                {
                    clsOfferte detOfferta = new clsOfferte();
                    detOfferta.CodOfferta = Convert.ToInt32(dataReader["CodOfferta"]);
                    detOfferta.DesOfferta = dataReader["DesOfferta"].ToString();
                    listaOfferte.Add(detOfferta);
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
                sqlOfferta.chiudiLettore();
            }

            return listaOfferte;
        }
    }
}
