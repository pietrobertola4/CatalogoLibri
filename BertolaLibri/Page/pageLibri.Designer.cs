namespace BertolaLibri.Page
{
    partial class pageLibri
    {
        /// <summary> 
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione componenti

        /// <summary> 
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare 
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvLibri = new System.Windows.Forms.DataGridView();
            this.btnAggiungi = new System.Windows.Forms.Button();
            this.chkAnnullati = new System.Windows.Forms.CheckBox();
            this.containerPanelLibri = new System.Windows.Forms.Panel();
            this.grbLibro = new System.Windows.Forms.GroupBox();
            this.txtPrezzoLibro = new System.Windows.Forms.TextBox();
            this.cmbEditore = new System.Windows.Forms.ComboBox();
            this.cmbOfferta = new System.Windows.Forms.ComboBox();
            this.cmbReparto = new System.Windows.Forms.ComboBox();
            this.dtpDataLibro = new System.Windows.Forms.DateTimePicker();
            this.nudNPagLibro = new System.Windows.Forms.NumericUpDown();
            this.txtTitoloLibro = new System.Windows.Forms.TextBox();
            this.txtCodiceLibro = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.btnAnnulla = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.btnConferma = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.chkAnnullatoLibri = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLibri)).BeginInit();
            this.containerPanelLibri.SuspendLayout();
            this.grbLibro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNPagLibro)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvLibri
            // 
            this.dgvLibri.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.dgvLibri.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvLibri.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvLibri.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLibri.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvLibri.ColumnHeadersHeight = 30;
            this.dgvLibri.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvLibri.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvLibri.EnableHeadersVisualStyles = false;
            this.dgvLibri.GridColor = System.Drawing.Color.SteelBlue;
            this.dgvLibri.Location = new System.Drawing.Point(3, 95);
            this.dgvLibri.Name = "dgvLibri";
            this.dgvLibri.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLibri.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvLibri.RowHeadersWidth = 62;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 8F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dgvLibri.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvLibri.RowTemplate.Height = 28;
            this.dgvLibri.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLibri.Size = new System.Drawing.Size(1085, 864);
            this.dgvLibri.TabIndex = 15;
            this.dgvLibri.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLibri_CellClick);
            // 
            // btnAggiungi
            // 
            this.btnAggiungi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAggiungi.Location = new System.Drawing.Point(3, 23);
            this.btnAggiungi.Name = "btnAggiungi";
            this.btnAggiungi.Size = new System.Drawing.Size(102, 35);
            this.btnAggiungi.TabIndex = 16;
            this.btnAggiungi.Text = "Aggiungi";
            this.btnAggiungi.UseVisualStyleBackColor = true;
            this.btnAggiungi.Click += new System.EventHandler(this.btnAggiungi_Click);
            // 
            // chkAnnullati
            // 
            this.chkAnnullati.AutoSize = true;
            this.chkAnnullati.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkAnnullati.Location = new System.Drawing.Point(1002, 23);
            this.chkAnnullati.Name = "chkAnnullati";
            this.chkAnnullati.Size = new System.Drawing.Size(96, 24);
            this.chkAnnullati.TabIndex = 19;
            this.chkAnnullati.Text = "Annullati";
            this.chkAnnullati.UseVisualStyleBackColor = true;
            this.chkAnnullati.CheckedChanged += new System.EventHandler(this.chkAnnullati_CheckedChanged);
            // 
            // containerPanelLibri
            // 
            this.containerPanelLibri.Controls.Add(this.grbLibro);
            this.containerPanelLibri.Controls.Add(this.dgvLibri);
            this.containerPanelLibri.Controls.Add(this.chkAnnullati);
            this.containerPanelLibri.Controls.Add(this.btnAggiungi);
            this.containerPanelLibri.Location = new System.Drawing.Point(12, 16);
            this.containerPanelLibri.Name = "containerPanelLibri";
            this.containerPanelLibri.Size = new System.Drawing.Size(1132, 1028);
            this.containerPanelLibri.TabIndex = 20;
            // 
            // grbLibro
            // 
            this.grbLibro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.grbLibro.Controls.Add(this.txtPrezzoLibro);
            this.grbLibro.Controls.Add(this.cmbEditore);
            this.grbLibro.Controls.Add(this.cmbOfferta);
            this.grbLibro.Controls.Add(this.cmbReparto);
            this.grbLibro.Controls.Add(this.dtpDataLibro);
            this.grbLibro.Controls.Add(this.nudNPagLibro);
            this.grbLibro.Controls.Add(this.txtTitoloLibro);
            this.grbLibro.Controls.Add(this.txtCodiceLibro);
            this.grbLibro.Controls.Add(this.label7);
            this.grbLibro.Controls.Add(this.label10);
            this.grbLibro.Controls.Add(this.label11);
            this.grbLibro.Controls.Add(this.label13);
            this.grbLibro.Controls.Add(this.label14);
            this.grbLibro.Controls.Add(this.label15);
            this.grbLibro.Controls.Add(this.btnAnnulla);
            this.grbLibro.Controls.Add(this.label17);
            this.grbLibro.Controls.Add(this.btnConferma);
            this.grbLibro.Controls.Add(this.label18);
            this.grbLibro.Controls.Add(this.chkAnnullatoLibri);
            this.grbLibro.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbLibro.ForeColor = System.Drawing.Color.White;
            this.grbLibro.Location = new System.Drawing.Point(369, 127);
            this.grbLibro.Name = "grbLibro";
            this.grbLibro.Size = new System.Drawing.Size(513, 721);
            this.grbLibro.TabIndex = 20;
            this.grbLibro.TabStop = false;
            this.grbLibro.Text = "Gestione Dati Libri";
            this.grbLibro.Visible = false;
            // 
            // txtPrezzoLibro
            // 
            this.txtPrezzoLibro.Location = new System.Drawing.Point(131, 183);
            this.txtPrezzoLibro.MaxLength = 5;
            this.txtPrezzoLibro.Name = "txtPrezzoLibro";
            this.txtPrezzoLibro.Size = new System.Drawing.Size(206, 27);
            this.txtPrezzoLibro.TabIndex = 43;
            // 
            // cmbEditore
            // 
            this.cmbEditore.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEditore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbEditore.FormattingEnabled = true;
            this.cmbEditore.Location = new System.Drawing.Point(131, 507);
            this.cmbEditore.Name = "cmbEditore";
            this.cmbEditore.Size = new System.Drawing.Size(319, 29);
            this.cmbEditore.TabIndex = 42;
            // 
            // cmbOfferta
            // 
            this.cmbOfferta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOfferta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbOfferta.FormattingEnabled = true;
            this.cmbOfferta.Location = new System.Drawing.Point(132, 434);
            this.cmbOfferta.Name = "cmbOfferta";
            this.cmbOfferta.Size = new System.Drawing.Size(318, 29);
            this.cmbOfferta.TabIndex = 41;
            // 
            // cmbReparto
            // 
            this.cmbReparto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbReparto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbReparto.FormattingEnabled = true;
            this.cmbReparto.Location = new System.Drawing.Point(131, 367);
            this.cmbReparto.Name = "cmbReparto";
            this.cmbReparto.Size = new System.Drawing.Size(319, 29);
            this.cmbReparto.TabIndex = 40;
            // 
            // dtpDataLibro
            // 
            this.dtpDataLibro.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataLibro.Location = new System.Drawing.Point(132, 243);
            this.dtpDataLibro.Name = "dtpDataLibro";
            this.dtpDataLibro.Size = new System.Drawing.Size(205, 27);
            this.dtpDataLibro.TabIndex = 39;
            // 
            // nudNPagLibro
            // 
            this.nudNPagLibro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nudNPagLibro.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudNPagLibro.Location = new System.Drawing.Point(132, 304);
            this.nudNPagLibro.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.nudNPagLibro.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudNPagLibro.Name = "nudNPagLibro";
            this.nudNPagLibro.Size = new System.Drawing.Size(205, 27);
            this.nudNPagLibro.TabIndex = 38;
            this.nudNPagLibro.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudNPagLibro.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // txtTitoloLibro
            // 
            this.txtTitoloLibro.Location = new System.Drawing.Point(132, 115);
            this.txtTitoloLibro.MaxLength = 20;
            this.txtTitoloLibro.Name = "txtTitoloLibro";
            this.txtTitoloLibro.Size = new System.Drawing.Size(318, 27);
            this.txtTitoloLibro.TabIndex = 37;
            // 
            // txtCodiceLibro
            // 
            this.txtCodiceLibro.Enabled = false;
            this.txtCodiceLibro.Location = new System.Drawing.Point(132, 46);
            this.txtCodiceLibro.MaxLength = 7;
            this.txtCodiceLibro.Name = "txtCodiceLibro";
            this.txtCodiceLibro.Size = new System.Drawing.Size(205, 27);
            this.txtCodiceLibro.TabIndex = 36;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(29, 510);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 21);
            this.label7.TabIndex = 35;
            this.label7.Text = "Editore";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(29, 437);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 21);
            this.label10.TabIndex = 34;
            this.label10.Text = "Offerta";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(29, 370);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(74, 21);
            this.label11.TabIndex = 33;
            this.label11.Text = "Reparto";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(29, 306);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(86, 21);
            this.label13.TabIndex = 32;
            this.label13.Text = "N° Pagine";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(29, 186);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(58, 21);
            this.label14.TabIndex = 31;
            this.label14.Text = "Prezzo";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(29, 248);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(51, 21);
            this.label15.TabIndex = 30;
            this.label15.Text = "Data";
            // 
            // btnAnnulla
            // 
            this.btnAnnulla.BackColor = System.Drawing.Color.Red;
            this.btnAnnulla.FlatAppearance.BorderSize = 0;
            this.btnAnnulla.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnnulla.Location = new System.Drawing.Point(283, 648);
            this.btnAnnulla.Name = "btnAnnulla";
            this.btnAnnulla.Size = new System.Drawing.Size(200, 50);
            this.btnAnnulla.TabIndex = 29;
            this.btnAnnulla.Text = "ANNULLA";
            this.btnAnnulla.UseVisualStyleBackColor = false;
            this.btnAnnulla.Click += new System.EventHandler(this.btnAnnulla_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(29, 49);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(67, 21);
            this.label17.TabIndex = 25;
            this.label17.Text = "Codice";
            // 
            // btnConferma
            // 
            this.btnConferma.BackColor = System.Drawing.Color.Green;
            this.btnConferma.FlatAppearance.BorderSize = 0;
            this.btnConferma.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConferma.Location = new System.Drawing.Point(23, 648);
            this.btnConferma.Name = "btnConferma";
            this.btnConferma.Size = new System.Drawing.Size(200, 50);
            this.btnConferma.TabIndex = 28;
            this.btnConferma.Text = "C O N F E R M A";
            this.btnConferma.UseVisualStyleBackColor = false;
            this.btnConferma.Click += new System.EventHandler(this.btnConferma_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(29, 115);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(51, 21);
            this.label18.TabIndex = 26;
            this.label18.Text = "Titolo";
            // 
            // chkAnnullatoLibri
            // 
            this.chkAnnullatoLibri.AutoSize = true;
            this.chkAnnullatoLibri.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkAnnullatoLibri.Location = new System.Drawing.Point(23, 579);
            this.chkAnnullatoLibri.Name = "chkAnnullatoLibri";
            this.chkAnnullatoLibri.Size = new System.Drawing.Size(113, 25);
            this.chkAnnullatoLibri.TabIndex = 27;
            this.chkAnnullatoLibri.Text = "Annullato";
            this.chkAnnullatoLibri.UseVisualStyleBackColor = true;
            // 
            // pageLibri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.Controls.Add(this.containerPanelLibri);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "pageLibri";
            this.Size = new System.Drawing.Size(1200, 1100);
            this.Load += new System.EventHandler(this.pageLibri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLibri)).EndInit();
            this.containerPanelLibri.ResumeLayout(false);
            this.containerPanelLibri.PerformLayout();
            this.grbLibro.ResumeLayout(false);
            this.grbLibro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNPagLibro)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvLibri;
        private System.Windows.Forms.Button btnAggiungi;
        private System.Windows.Forms.CheckBox chkAnnullati;
        private System.Windows.Forms.Panel containerPanelLibri;
        private System.Windows.Forms.GroupBox grbLibro;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btnAnnulla;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button btnConferma;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.CheckBox chkAnnullatoLibri;
        private System.Windows.Forms.TextBox txtTitoloLibro;
        private System.Windows.Forms.TextBox txtCodiceLibro;
        private System.Windows.Forms.NumericUpDown nudNPagLibro;
        private System.Windows.Forms.DateTimePicker dtpDataLibro;
        private System.Windows.Forms.ComboBox cmbEditore;
        private System.Windows.Forms.ComboBox cmbOfferta;
        private System.Windows.Forms.ComboBox cmbReparto;
        private System.Windows.Forms.TextBox txtPrezzoLibro;
    }
}
