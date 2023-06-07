using BertolaLibri.Control;
using BertolaLibri.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BertolaLibri.Page
{
    public partial class pageAutori : UserControl
    {
        public pageAutori()
        {
            InitializeComponent();
        }

        private void pageAutori_Load(object sender, EventArgs e)
        {
            clsAutoriController listaAutori = new clsAutoriController();
            caricaAutori(listaAutori.elencoAutori(' '));
        }

        private void btnAggiungiAutori_Click(object sender, EventArgs e)
        {
            abilitaVideo(false);
            txtCodiceAutori.Enabled = true;
            txtCodiceAutori.Focus();
        }

        private void chkAnnullatiAutori_CheckedChanged(object sender, EventArgs e)
        {
            dgvAutori.DataSource = null;
            clsAutoriController listaAutori = new clsAutoriController();
            if (chkAnnullatiAutori.Checked)
                caricaAutori(listaAutori.elencoAutori('A'));
            else
                caricaAutori(listaAutori.elencoAutori(' '));
        }

        private void btnConfermaAutori_Click(object sender, EventArgs e)
        {
            bool errore = false;
            if (chkDatiAutore())
            {
                clsAutoriController insAutore = new clsAutoriController();
                insAutore.modAutore.CodAutore = Convert.ToInt32(txtCodiceAutori.Text);
                insAutore.modAutore.CognAutore = txtCognAutori.Text;
                insAutore.modAutore.NomeAutore = txtNomeAutori.Text;
                insAutore.modAutore.DataNasAutore = dtpDataNascita.Value;
                if (chkAnnullatoAutori.Checked)
                    insAutore.modAutore.ValAutore = 'A';

                if (btnConfermaAutori.Text == "C O N F E R M A")
                    errore = insAutore.aggiungi();
                else
                    errore = insAutore.modifica();

                if (!errore)
                {
                    pulisciDatiAutore();
                    caricaAutori(insAutore.elencoAutori(' '));
                }
                MessageBox.Show(insAutore.msgElaborazione);
            }
        }

        private void btnAnnullaAutori_Click(object sender, EventArgs e)
        {
            pulisciDatiAutore();
            dgvAutori.ClearSelection();
        }

        private void pulisciDatiAutore()
        {
            txtCodiceAutori.Text = string.Empty;
            txtCognAutori.Text = string.Empty;
            txtNomeAutori.Text = string.Empty;
            dtpDataNascita.Value = DateTime.Now;
            chkAnnullatoAutori.Checked = false;
            btnConfermaAutori.Text = "C O N F E R M A";
            chkAnnullatiAutori.Checked = false;
            abilitaVideo(true);
        }

        private bool chkDatiAutore()
        {
            clsAutoriController detAutore = new clsAutoriController();
            bool esito = true;

            if (txtCodiceAutori.Text == string.Empty)
            {
                MessageBox.Show("Il Codice non è stato inserito");
                txtCodiceAutori.Focus();
                esito = false;
            }
            else if (txtCognAutori.Text == string.Empty)
            {
                MessageBox.Show("Il Cognome non è stato inserito");
                txtCognAutori.Focus();
                esito = false;
            }
            else if (txtNomeAutori.Text == string.Empty)
            {
                MessageBox.Show("Il Nome non è stato inserito");
                txtNomeAutori.Focus();
                esito = false;
            }
            else
            {
                if (btnConfermaAutori.Text == "C O N F E R M A")
                {
                    // Controllo la Validità del mio Codice
                    detAutore.modAutore.CodAutore = Convert.ToInt32(txtCodiceAutori.Text);
                    if (detAutore.verificaAutore())
                    {
                        MessageBox.Show("ATTENZIONE !!! " + detAutore.msgElaborazione);
                        txtCodiceAutori.Focus();
                        esito = false;
                    }
                }
            }

            return esito;
        }

        private void caricaAutori(List<clsAutori> lista)
        {
            dgvAutori.DataSource = lista;
            dgvAutori.Columns[0].HeaderText = "Codice";
            dgvAutori.Columns[1].HeaderText = "Nome";
            dgvAutori.Columns[2].HeaderText = "Cognome";
            dgvAutori.Columns[3].HeaderText = "Data Nascita";
            dgvAutori.Columns[4].HeaderText = "Validità";
            dgvAutori.ClearSelection();
        }

        private void abilitaVideo(bool abilita)
        {
            btnAggiungiAutori.Visible = abilita;
            chkAnnullatiAutori.Visible = abilita;
            dgvAutori.Visible = abilita;

            grbAutori.Visible = !abilita;
        }

        private void dgvAutori_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dgvAutori_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCodiceAutori.Enabled = false;
            txtCodiceAutori.Text = dgvAutori.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtCognAutori.Text = dgvAutori.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtNomeAutori.Text = dgvAutori.Rows[e.RowIndex].Cells[2].Value.ToString();
            dtpDataNascita.Value = Convert.ToDateTime(dgvAutori.Rows[e.RowIndex].Cells[3].Value);
            if (dgvAutori.Rows[e.RowIndex].Cells[4].Value.ToString() == " ")
                chkAnnullatoAutori.Checked = false;
            else
                chkAnnullatoAutori.Checked = true;

            btnConfermaAutori.Text = "M O D I F I C A";

            abilitaVideo(false);
        }
    }
}
