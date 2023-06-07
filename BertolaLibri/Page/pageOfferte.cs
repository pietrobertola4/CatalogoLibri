using BertolaLibri.Control;
using BertolaLibri.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BertolaLibri
{
    public partial class pageOfferte : UserControl
    {
        public pageOfferte()
        {
            InitializeComponent();
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void pageOfferte_Load(object sender, EventArgs e)
        {
            clsOfferteController listaOfferte = new clsOfferteController();
            caricaOfferte(listaOfferte.elencoOfferte(' '));
        }

        private void btnAggiungiOfferte_Click(object sender, EventArgs e)
        {
            abilitaVideo(false);
            clsOfferteController codOfferta = new clsOfferteController();
            txtCodiceOfferte.Text = codOfferta.lastCodice();
            txtCodiceOfferte.Focus();
        }

        private void chkAnnulatiOfferte_CheckedChanged(object sender, EventArgs e)
        {
            dgvOfferte.DataSource = null;
            clsOfferteController listaOfferte = new clsOfferteController();
            if (chkAnnulatiOfferte.Checked)
                caricaOfferte(listaOfferte.elencoOfferte('A'));
            else
                caricaOfferte(listaOfferte.elencoOfferte(' '));
        }

        private void btnConfermaOfferte_Click(object sender, EventArgs e)
        {
            bool errore = false;
            if (chkDatiOfferta())
            {
                clsOfferteController insOfferta = new clsOfferteController();
                insOfferta.modOfferta.CodOfferta = Convert.ToInt32(txtCodiceOfferte.Text);
                insOfferta.modOfferta.DesOfferta = txtDescrizioneOfferte.Text;
                insOfferta.modOfferta.ScontoOfferta = Convert.ToInt32(nudOfferta.Value);
                if (chkAnnullatoOfferte.Checked)
                    insOfferta.modOfferta.ValOfferta = 'A';

                if (btnConfermaOfferte.Text == "C O N F E R M A")
                    errore = insOfferta.aggiungi();
                else
                    errore = insOfferta.modifica();

                if (!errore)
                {
                    pulisciDatiOfferta();
                    caricaOfferte(insOfferta.elencoOfferte(' '));
                }
                MessageBox.Show(insOfferta.msgElaborazione);
            }
        }

        private void btnAnnullaOfferte_Click(object sender, EventArgs e)
        {
            pulisciDatiOfferta();
            dgvOfferte.ClearSelection();
        }
        private void pulisciDatiOfferta()
        {
            txtCodiceOfferte.Text = string.Empty;
            txtDescrizioneOfferte.Text = string.Empty;
            nudOfferta.Value = 0;
            chkAnnullatoOfferte.Checked = false;
            btnConfermaOfferte.Text = "C O N F E R M A";
            chkAnnulatiOfferte.Checked = false;
            abilitaVideo(true);
        }

        private bool chkDatiOfferta()
        {
            clsOfferteController detOfferta = new clsOfferteController();
            bool esito = true;

            if (txtCodiceOfferte.Text == string.Empty)
            {
                MessageBox.Show("Il Codice non è stato inserito");
                txtCodiceOfferte.Focus();
                esito = false;
            }
            else if (txtDescrizioneOfferte.Text == string.Empty)
            {
                MessageBox.Show("La Descrizione non è stata inserita");
                txtDescrizioneOfferte.Focus();
                esito = false;
            }
            else if(nudOfferta.Value < 0 || nudOfferta.Value > 99)
            {
                MessageBox.Show("Lo Sconto non è stato inserito correttamente");
                nudOfferta.Focus();
                esito = false;
            }
            else
            {
                if (btnConfermaOfferte.Text == "C O N F E R M A")
                {
                    // Controllo la Validità del mio Codice
                    detOfferta.modOfferta.CodOfferta = Convert.ToInt32(txtCodiceOfferte.Text);
                    if (detOfferta.verificaOfferta())
                    {
                        MessageBox.Show("ATTENZIONE !!! " + detOfferta.msgElaborazione);
                        txtCodiceOfferte.Focus();
                        esito = false;
                    }
                }
            }

            return esito;
        }

        private void caricaOfferte(List<clsOfferte> lista)
        {
            dgvOfferte.DataSource = lista;
            dgvOfferte.Columns[0].HeaderText = "Codice";
            dgvOfferte.Columns[1].HeaderText = "Descrizione";
            dgvOfferte.Columns[2].HeaderText = "Sconto";
            dgvOfferte.Columns[3].HeaderText = "Validità";
            dgvOfferte.ClearSelection();
        }

        private void abilitaVideo(bool abilita)
        {
            btnAggiungiOfferte.Enabled = abilita;
            chkAnnulatiOfferte.Enabled = abilita;
            dgvOfferte.Enabled = abilita;

            grbOfferte.Visible = !abilita;
        }

        private void dgvOfferte_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCodiceOfferte.Text = dgvOfferte.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtDescrizioneOfferte.Text = dgvOfferte.Rows[e.RowIndex].Cells[1].Value.ToString();
            nudOfferta.Value = Convert.ToInt32(dgvOfferte.Rows[e.RowIndex].Cells[2].Value);
            if (dgvOfferte.Rows[e.RowIndex].Cells[3].Value.ToString() == " ")
                chkAnnullatoOfferte.Checked = false;
            else
                chkAnnullatoOfferte.Checked = true;

            btnConfermaOfferte.Text = "M O D I F I C A";

            abilitaVideo(false);
        }
    }
}
