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
    internal class clsRepartiController
    {
        public clsReparti modReparto;
        private adoNetSQL sqlReparto;
        //private string pathDB = Application.StartupPath + "\\CatalogoLibri.mdf";
        private bool pErrore;
        private string pStrSQL;
        private List<clsReparti> listaReparti;
        private DataTable tabellaReparto;

        public string msgElaborazione;

        public clsRepartiController()
        {
            //string pathDB = Application.StartupPath + "\\" + nomeDB;
            string pathDB = Application.StartupPath + "\\CatalogoLibri.mdf";
            sqlReparto = new adoNetSQL(pathDB);
            msgElaborazione = String.Empty;

            // Gestisco il MODELLO
            modReparto = new clsReparti();
            modReparto.CodReparto = string.Empty;
            modReparto.DesReparto = string.Empty;
            modReparto.ValReparto = ' ';
        }

        public bool aggiungi()
        {
            pErrore = false;

            sqlReparto.cmd.Parameters.AddWithValue("@CdReparto", modReparto.CodReparto);
            sqlReparto.cmd.Parameters.AddWithValue("@DeReparto", modReparto.DesReparto);
            sqlReparto.cmd.Parameters.AddWithValue("@VReparto", modReparto.ValReparto);

            pStrSQL = "INSERT INTO Reparti " +
                       "(CodReparto, DesReparto, ValReparto) " +
                       "VALUES(@CdReparto, @DeReparto, @VReparto)";

            try
            {
                sqlReparto.eseguiNonQuery(pStrSQL, CommandType.Text);
                msgElaborazione = "Reparto inserito con successo !!!";
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

            sqlReparto.cmd.Parameters.AddWithValue("@CdReparto", modReparto.CodReparto);
            sqlReparto.cmd.Parameters.AddWithValue("@DeReparto", modReparto.DesReparto);
            sqlReparto.cmd.Parameters.AddWithValue("@VReparto", modReparto.ValReparto);

            pStrSQL = "UPDATE Reparti " +
                        "SET DesReparto=@DeReparto, ValReparto=@VReparto " +
                        "WHERE CodReparto=@CdReparto";

            try
            {
                sqlReparto.eseguiNonQuery(pStrSQL, CommandType.Text);
                msgElaborazione = "Reparto modificato con successo !!!";
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

            sqlReparto.cmd.Parameters.AddWithValue("@CdReparto", modReparto.CodReparto);
            sqlReparto.cmd.Parameters.AddWithValue("@VReparto", modReparto.DesReparto);

            pStrSQL = "UPDATE Reparti " +
                        "SET ValReparto=@VReparto " +
                        "WHERE CodReparto=@CdReparto";

            try
            {
                sqlReparto.eseguiNonQuery(pStrSQL, CommandType.Text);
            }
            catch (Exception ex)
            {
                msgElaborazione = ex.Message;
                pErrore = true;
            }
            finally
            {
                if (!pErrore)
                    if (modReparto.ValReparto == 'A')
                        msgElaborazione = "Reparto annullato con successo !!!";
                    else
                        msgElaborazione = "Reparto ripristinato con successo !!!";
            }

            return pErrore;
        }

        public bool verificaReparto()
        {
            pErrore = false;
            string risultato = string.Empty;
            msgElaborazione = string.Empty;

            sqlReparto.cmd.Parameters.AddWithValue("@CdReparto", modReparto.CodReparto);

            pStrSQL = "SELECT COUNT(*) FROM Reparti where CodReparto = @CdReparto";
            try
            {
                risultato = sqlReparto.eseguiScalar(pStrSQL, CommandType.Text);
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
                    msgElaborazione = "Reparto già esistente";
                    pErrore = true;
                }

            }

            return pErrore;
        }

        public List<clsReparti> elencoReparti(char validita)
        {
            pErrore = false;
            listaReparti = new List<clsReparti>();
            SqlDataReader dataReader;
            string strValidita = "('')";

            if (validita == 'A')
                strValidita = "('', 'A')";

            pStrSQL = "SELECT * FROM Reparti " +
                       "WHERE ValReparto IN " + strValidita;

            try
            {
                dataReader = sqlReparto.creaLettore(pStrSQL, CommandType.Text);
                while (dataReader.Read())
                {
                    clsReparti detReparto = new clsReparti();
                    detReparto.CodReparto = dataReader["CodReparto"].ToString();
                    detReparto.DesReparto = dataReader["DesReparto"].ToString();
                    detReparto.ValReparto = Convert.ToChar(dataReader["ValReparto"]);
                    listaReparti.Add(detReparto);
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
                sqlReparto.chiudiLettore();
            }

            return listaReparti;
        }

        public List<clsReparti> elencoRepartiInt(char validita)
        {
            pErrore = false;
            listaReparti = new List<clsReparti>();
            SqlDataReader dataReader;
            string strValidita = "('')";

            if (validita == 'A')
                strValidita = "('', 'A')";

            pStrSQL = "SELECT CodReparto AS Codice, DesReparto AS Descrizione, ValReparto AS Validità FROM Reparti " +
                       "WHERE ValReparto IN " + strValidita;

            try
            {
                dataReader = sqlReparto.creaLettore(pStrSQL, CommandType.Text);
                while (dataReader.Read())
                {
                    clsReparti detReparto = new clsReparti();
                    detReparto.CodReparto = dataReader["Codice"].ToString();
                    detReparto.DesReparto = dataReader["Descrizione"].ToString();
                    detReparto.ValReparto = Convert.ToChar(dataReader["Validità"]);
                    listaReparti.Add(detReparto);
                }
            }
            catch (Exception ex)
            {
                msgElaborazione = ex.Message;
                pErrore = true;
            }
            finally
            {
                if (!pErrore)
                {
                    msgElaborazione = "Lista creata con successo !!!";
                    sqlReparto.chiudiLettore();
                }
            }

            return listaReparti;
        }

        public clsReparti datiReparto()
        {
            pErrore = false;
            clsReparti detReparto = new clsReparti();

            sqlReparto.cmd.Parameters.AddWithValue("@CdReparto", modReparto.CodReparto);

            pStrSQL = "SELECT DesReparto, ValReparto " +
                       "FROM Reparti " +
                       "WHERE CodReparto = @CdReparto";

            try
            {
                tabellaReparto = sqlReparto.eseguiQuery(pStrSQL, CommandType.Text);
            }
            catch (Exception ex)
            {
                msgElaborazione = ex.Message;
                pErrore = true;
            }

            if (!pErrore)
            {
                detReparto.CodReparto = modReparto.CodReparto;
                detReparto.DesReparto = tabellaReparto.Rows[0].ItemArray[0].ToString();
                detReparto.ValReparto = Convert.ToChar(tabellaReparto.Rows[0].ItemArray[1]);
            }

            return detReparto;
        }

        public List<clsReparti> elencoRepartiLibri(char validita)
        {
            pErrore = false;
            listaReparti = new List<clsReparti>();
            SqlDataReader dataReader;
            string strValidita = "('')";

            if (validita == 'A')
                strValidita = "('', 'A')";

            pStrSQL = "SELECT CodReparto, DesReparto FROM Reparti " +
                       "WHERE ValReparto IN " + strValidita;

            try
            {
                dataReader = sqlReparto.creaLettore(pStrSQL, CommandType.Text);
                while (dataReader.Read())
                {
                    clsReparti detReparto = new clsReparti();
                    detReparto.CodReparto = dataReader["CodReparto"].ToString();
                    detReparto.DesReparto = dataReader["DesReparto"].ToString();
                    listaReparti.Add(detReparto);
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
                sqlReparto.chiudiLettore();
            }

            return listaReparti;
        }
    }
}
