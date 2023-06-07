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

namespace BertolaLibri
{
    public partial class pageReparti : UserControl
    {
        public pageReparti()
        {
            InitializeComponent();
        }
        private void pageReparti_Load(object sender, EventArgs e)
        {
            //dgvReparti.ScrollBars = ScrollBars.None;
            clsRepartiController listaReparti = new clsRepartiController();
            caricaReparti(listaReparti.elencoReparti(' '));
        }

        private void btnAggiungi_Click(object sender, EventArgs e)
        {
            txtCodice.Enabled = true;
            abilitaVideo(false);
            // NON recupero l'ultimo Codice Valido

            txtCodice.Focus();
        }

        private void chkAnnullati_CheckedChanged(object sender, EventArgs e)
        {
            dgvReparti.DataSource = null;
            clsRepartiController listaReparti = new clsRepartiController();
            if (chkAnnullati.Checked)
                caricaReparti(listaReparti.elencoReparti('A'));
            else
                caricaReparti(listaReparti.elencoReparti(' '));
        }

        private void btnConferma_Click(object sender, EventArgs e)
        {
            bool errore = false;
            if (chkDatiReparto())
            {
                clsRepartiController insReparto = new clsRepartiController();
                insReparto.modReparto.CodReparto = txtCodice.Text;
                insReparto.modReparto.DesReparto = txtDescrizione.Text;
                if (chkAnnullato.Checked)
                    insReparto.modReparto.ValReparto = 'A';

                if (btnConferma.Text == "C O N F E R M A")
                    errore = insReparto.aggiungi();
                else
                    errore = insReparto.modifica();

                if (!errore)
                {
                    pulisciDatiReparto();
                    caricaReparti(insReparto.elencoReparti(' '));
                }
                MessageBox.Show(insReparto.msgElaborazione);
            }
        }

        private void btnAnnulla_Click(object sender, EventArgs e)
        {
            pulisciDatiReparto();
            dgvReparti.ClearSelection();
        }

        private void pulisciDatiReparto()
        {
            txtCodice.Text = string.Empty;
            txtCodice.Enabled = true;
            txtDescrizione.Text = string.Empty;
            chkAnnullato.Checked = false;
            btnConferma.Text = "C O N F E R M A";
            chkAnnullati.Checked = false;
            abilitaVideo(true);
        }

        private bool chkDatiReparto()
        {
            clsRepartiController detReparto = new clsRepartiController();
            bool esito = true;

            if (txtCodice.Text == string.Empty)
            {
                MessageBox.Show("Il Codice non è stato inserito");
                txtCodice.Focus();
                esito = false;
            }
            else if (txtDescrizione.Text == string.Empty)
            {
                MessageBox.Show("La Descrizione non è stata inserita");
                txtDescrizione.Focus();
                esito = false;
            }
            else
            {
                if (btnConferma.Text == "C O N F E R M A")
                {
                    // Controllo la Validità del mio Codice
                    detReparto.modReparto.CodReparto = txtCodice.Text;
                    if (detReparto.verificaReparto())
                    {
                        MessageBox.Show("ATTENZIONE !!! " + detReparto.msgElaborazione);
                        txtCodice.Focus();
                        esito = false;
                    }
                }
            }

            return esito;
        }

        private void caricaReparti(List<clsReparti> lista)
        {
            dgvReparti.DataSource = lista;
            dgvReparti.Columns[0].HeaderText = "Codice";
            dgvReparti.Columns[1].HeaderText = "Descrizione";
            dgvReparti.Columns[2].HeaderText = "Validità";
            dgvReparti.ClearSelection();
        }

        private void abilitaVideo(bool abilita)
        {
            btnAggiungi.Visible = abilita;
            chkAnnullati.Visible = abilita;
            dgvReparti.Visible = abilita;

            grbGestione.Visible = !abilita;
        }

        private void dgvReparti_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCodice.Enabled = false;
            txtCodice.Text = dgvReparti.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtDescrizione.Text = dgvReparti.Rows[e.RowIndex].Cells[1].Value.ToString();
            if (dgvReparti.Rows[e.RowIndex].Cells[2].Value.ToString() == " ")
                chkAnnullato.Checked = false;
            else
                chkAnnullato.Checked = true;

            btnConferma.Text = "M O D I F I C A";

            abilitaVideo(false);
        }

        private void chkAnnullato_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void dgvReparti_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
