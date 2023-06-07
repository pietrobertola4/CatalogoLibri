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
    public partial class pageLibri : UserControl
    {
        public pageLibri()
        {
            InitializeComponent();
        }

        private void btnAggiungi_Click(object sender, EventArgs e)
        {

            abilitaVideo(false);
            txtCodiceLibro.Enabled = true;
            txtCodiceLibro.Focus();
        }

        private void pageLibri_Load(object sender, EventArgs e)
        {
            clsLibriController listaLibri = new clsLibriController();
            caricaLibri(listaLibri.elencoLibri(' '));

            clsRepartiController listaRep = new clsRepartiController();
            caricaComboReparti(listaRep.elencoRepartiLibri(' '));

            clsOfferteController listaOff = new clsOfferteController();
            caricaComboOfferte(listaOff.elencoOfferteLibri(' '));

            clsEditoriController listaEdi = new clsEditoriController();
            caricaComboEditori(listaEdi.elencoEditoriLibri(' '));
        }

        private void caricaLibri(List<clsLibri> lista)
        {
            dgvLibri.DataSource = lista;
            dgvLibri.Columns[0].HeaderText = "Codice";
            dgvLibri.Columns[1].HeaderText = "Titolo";
            dgvLibri.Columns[2].HeaderText = "Prezzo";
            dgvLibri.Columns[3].HeaderText = "Data";
            dgvLibri.Columns[4].HeaderText = "N° Pagine";
            dgvLibri.Columns[5].HeaderText = "Reparto";
            dgvLibri.Columns[6].HeaderText = "Offerta";
            dgvLibri.Columns[7].HeaderText = "Editore";
            dgvLibri.Columns[8].HeaderText = "Validità";
            dgvLibri.ClearSelection();
            
        }

        private void caricaComboReparti(List<clsReparti> lista)
        {
            cmbReparto.DataSource = lista;
            cmbReparto.DisplayMember = "DesReparto";
            cmbReparto.ValueMember = "CodReparto";
            cmbReparto.SelectedIndex = 0;
        }

        private void caricaComboOfferte(List<clsOfferte> lista)
        {
            cmbOfferta.DataSource = lista;
            cmbOfferta.DisplayMember = "DesOfferta";
            cmbOfferta.ValueMember = "CodOfferta";
            cmbOfferta.SelectedIndex = 0;
        }
        private void caricaComboEditori(List<clsEditori> lista)
        {
            cmbEditore.DataSource = lista;
            cmbEditore.DisplayMember = "NomeEditore";
            cmbEditore.ValueMember = "CodEditore";
            cmbEditore.SelectedIndex = 0;
        }

        private void chkAnnullati_CheckedChanged(object sender, EventArgs e)
        {
            dgvLibri.DataSource = null;
            clsLibriController listaLibri = new clsLibriController();
            clsRepartiController listaRep = new clsRepartiController();
            clsOfferteController listaOff = new clsOfferteController();
            clsEditoriController listaEdi = new clsEditoriController();

            if (chkAnnullati.Checked)
            {
                caricaLibri(listaLibri.elencoLibri('A'));
                caricaComboReparti(listaRep.elencoRepartiLibri('A'));
                
                caricaComboOfferte(listaOff.elencoOfferteLibri('A'));
                caricaComboEditori(listaEdi.elencoEditoriLibri('A'));
            }
                
            else
            {
                caricaLibri(listaLibri.elencoLibri(' '));
                caricaComboReparti(listaRep.elencoRepartiLibri(' '));

                caricaComboOfferte(listaOff.elencoOfferteLibri(' '));
                caricaComboEditori(listaEdi.elencoEditoriLibri(' '));
            }
               
        }

        private void btnAnnulla_Click(object sender, EventArgs e)
        {
            abilitaVideo(true);
            pulisciDatiLibro();
            dgvLibri.ClearSelection();
        }

        private void abilitaVideo(bool abilita)
        {
            btnAggiungi.Visible = abilita;
            chkAnnullati.Visible = abilita;
            dgvLibri.Visible = abilita;
            grbLibro.Visible = !abilita;
        }

        private void btnConferma_Click(object sender, EventArgs e)
        {
            bool errore = false;
            if (chkDatiLibro())
            {
                clsRepartiController listaRep = new clsRepartiController();
                clsLibriController insLibro = new clsLibriController();
                clsOfferteController listaOff = new clsOfferteController();
                clsEditoriController listaEdi = new clsEditoriController();
                insLibro.modLibro.CodLibro = Convert.ToInt32(txtCodiceLibro.Text);
                insLibro.modLibro.TitoloLibro = txtTitoloLibro.Text;
                insLibro.modLibro.PrezzoLibro = Convert.ToDouble(txtPrezzoLibro.Text);
                insLibro.modLibro.DataLibro = dtpDataLibro.Value;
                insLibro.modLibro.NPagLibro = Convert.ToInt32(nudNPagLibro.Value);
                insLibro.modLibro.CodRepLibro = (cmbReparto.SelectedValue).ToString();
                insLibro.modLibro.CodOffLibro = Convert.ToInt32(cmbOfferta.SelectedValue);
                insLibro.modLibro.CodEdiLibro = Convert.ToInt32(cmbEditore.SelectedValue);
                if (chkAnnullatoLibri.Checked)
                    insLibro.modLibro.ValLibro = 'A';

                if (btnConferma.Text == "C O N F E R M A")
                    errore = insLibro.aggiungi();
                else
                    errore = insLibro.modifica();

                if (!errore)
                {
                    pulisciDatiLibro();
                    caricaLibri(insLibro.elencoLibri(' '));
                    caricaComboReparti(listaRep.elencoRepartiLibri(' '));
                    caricaComboOfferte(listaOff.elencoOfferteLibri(' '));
                    caricaComboEditori(listaEdi.elencoEditoriLibri(' '));
                }
                MessageBox.Show(insLibro.msgElaborazione);
            }
        }

        private void pulisciDatiLibro()
        {
            txtCodiceLibro.Text = string.Empty;
            txtTitoloLibro.Text = string.Empty;
            txtPrezzoLibro.Text = string.Empty;
            dtpDataLibro.Value = DateTime.Now;
            nudNPagLibro.Value = 1;
            //cmbReparto.SelectedIndex = 0;
            //cmbOfferta.SelectedIndex = 0;
            //cmbEditore.SelectedIndex = 0;
            chkAnnullatoLibri.Checked = false;
            btnConferma.Text = "C O N F E R M A";
            chkAnnullati.Checked = false;
            abilitaVideo(true);
        }

        private bool chkDatiLibro()
        {
            clsLibriController detLibro = new clsLibriController();
            bool esito = true;

            if (txtCodiceLibro.Text == string.Empty)
            {
                MessageBox.Show("Il Codice non è stato inserito");
                txtCodiceLibro.Focus();
                esito = false;
            }
            else if (txtTitoloLibro.Text == string.Empty)
            {
                MessageBox.Show("Il Titolo non è stato inserito");
                txtTitoloLibro.Focus();
                esito = false;
            }
            else if (txtPrezzoLibro.Text == string.Empty)
            {
                MessageBox.Show("Il Prezzo non è stato inserito");
                txtPrezzoLibro.Focus();
                esito = false;
            }
            else
            {
                if (btnConferma.Text == "C O N F E R M A")
                {
                    // Controllo la Validità del mio Codice
                    detLibro.modLibro.CodLibro = Convert.ToInt32(txtCodiceLibro.Text);
                    if (detLibro.verificaLibro())
                    {
                        MessageBox.Show("ATTENZIONE !!! " + detLibro.msgElaborazione);
                        txtCodiceLibro.Focus();
                        esito = false;
                    }
                }
            }

            return esito;
        }

        private void dgvLibri_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCodiceLibro.Enabled = false;
            txtCodiceLibro.Text = dgvLibri.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtTitoloLibro.Text = dgvLibri.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtPrezzoLibro.Text = dgvLibri.Rows[e.RowIndex].Cells[2].Value.ToString();
            dtpDataLibro.Value = Convert.ToDateTime(dgvLibri.Rows[e.RowIndex].Cells[3].Value);
            nudNPagLibro.Value = Convert.ToInt32(dgvLibri.Rows[e.RowIndex].Cells[4].Value);
            cmbReparto.SelectedValue = (dgvLibri.Rows[e.RowIndex].Cells[5].Value);
            cmbOfferta.SelectedValue = dgvLibri.Rows[e.RowIndex].Cells[6].Value;
            cmbEditore.SelectedValue = dgvLibri.Rows[e.RowIndex].Cells[7].Value;
            if (dgvLibri.Rows[e.RowIndex].Cells[8].Value.ToString() == " ")
                chkAnnullatoLibri.Checked = false;
            else
                chkAnnullatoLibri.Checked = true;

            btnConferma.Text = "M O D I F I C A";

            abilitaVideo(false);
        }
    }
}
