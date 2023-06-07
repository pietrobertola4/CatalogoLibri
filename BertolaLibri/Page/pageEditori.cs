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

namespace BertolaLibri.Page
{
    public partial class pageEditori : UserControl
    {
        public pageEditori()
        {
            InitializeComponent();
        }

        private void pageEditori_Load(object sender, EventArgs e)
        {
            clsEditoriController listaEditori = new clsEditoriController();
            caricaEditori(listaEditori.elencoEditori(' '));
        }

        private void btnAggiungiEditori_Click(object sender, EventArgs e)
        {
            abilitaVideo(false);
            clsEditoriController codEditore = new clsEditoriController();
            txtCodiceEditori.Text = codEditore.lastCodice();
            txtCodiceEditori.Focus();
        }

        private void chkAnnullatiEditori_CheckedChanged(object sender, EventArgs e)
        {
            dgvEditori.DataSource = null;
            clsEditoriController listaEditori = new clsEditoriController();
            if (chkAnnullatiEditori.Checked)
                caricaEditori(listaEditori.elencoEditori('A'));
            else
                caricaEditori(listaEditori.elencoEditori(' '));
        }

        private void btnConfermaEditori_Click(object sender, EventArgs e)
        {
            bool errore = false;
            if (chkDatiOfferta())
            {
                clsEditoriController insEditore = new clsEditoriController();
                insEditore.modEditore.CodEditore= Convert.ToInt32(txtCodiceEditori.Text);
                insEditore.modEditore.NomeEditore = txtNomeEditori.Text;
                if (chkAnnullatoEditori.Checked)
                    insEditore.modEditore.ValEditore= 'A';

                if (btnConfermaEditori.Text == "C O N F E R M A")
                    errore = insEditore.aggiungi();
                else
                    errore = insEditore.modifica();

                if (!errore)
                {
                    pulisciDatiOfferta();
                    caricaEditori(insEditore.elencoEditori(' '));
                }
                MessageBox.Show(insEditore.msgElaborazione);
            }
        }

        private void btnAnnullaEditori_Click(object sender, EventArgs e)
        {
            pulisciDatiOfferta();
            dgvEditori.ClearSelection();
        }

        private void pulisciDatiOfferta()
        {
            txtCodiceEditori.Text = string.Empty;
            txtNomeEditori.Text = string.Empty;
            chkAnnullatoEditori.Checked = false;
            btnConfermaEditori.Text = "C O N F E R M A";
            chkAnnullatiEditori.Checked = false;
            abilitaVideo(true);
        }

        private bool chkDatiOfferta()
        {
            clsEditoriController detEditore = new clsEditoriController();
            bool esito = true;

            if (txtCodiceEditori.Text == string.Empty)
            {
                MessageBox.Show("Il Codice non è stato inserito");
                txtCodiceEditori.Focus();
                esito = false;
            }
            else if (txtNomeEditori.Text == string.Empty)
            {
                MessageBox.Show("Il Nome non è stato inserito");
                txtNomeEditori.Focus();
                esito = false;
            }
            else
            {
                if (btnConfermaEditori.Text == "C O N F E R M A")
                {
                    // Controllo la Validità del mio Codice
                    detEditore.modEditore.CodEditore = Convert.ToInt32(txtCodiceEditori.Text);
                    if (detEditore.verificaEditore())
                    {
                        MessageBox.Show("ATTENZIONE !!! " + detEditore.msgElaborazione);
                        txtCodiceEditori.Focus();
                        esito = false;
                    }
                }
            }

            return esito;
        }

        private void caricaEditori(List<clsEditori> lista)
        {
            dgvEditori.DataSource = lista;
            dgvEditori.Columns[0].HeaderText = "Codice";
            dgvEditori.Columns[1].HeaderText = "Nome";
            dgvEditori.Columns[2].HeaderText = "Validità";
            dgvEditori.ClearSelection();
        }

        private void abilitaVideo(bool abilita)
        {
            btnAggiungiEditori.Enabled = abilita;
            chkAnnullatiEditori.Enabled = abilita;
            dgvEditori.Enabled = abilita;

            grbEditori.Visible = !abilita;
        }

        private void dgvEditori_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCodiceEditori.Text = dgvEditori.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtNomeEditori.Text = dgvEditori.Rows[e.RowIndex].Cells[1].Value.ToString();
            if (dgvEditori.Rows[e.RowIndex].Cells[2].Value.ToString() == " ")
                chkAnnullatoEditori.Checked = false;
            else
                chkAnnullatoEditori.Checked = true;

            btnConfermaEditori.Text = "M O D I F I C A";

            abilitaVideo(false);
        }
    }
}
