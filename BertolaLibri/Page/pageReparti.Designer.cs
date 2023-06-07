namespace BertolaLibri
{
    partial class pageReparti
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
            this.btnAnnulla = new System.Windows.Forms.Button();
            this.btnConferma = new System.Windows.Forms.Button();
            this.txtDescrizione = new System.Windows.Forms.TextBox();
            this.txtCodice = new System.Windows.Forms.TextBox();
            this.chkAnnullato = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.chkAnnullati = new System.Windows.Forms.CheckBox();
            this.btnAggiungi = new System.Windows.Forms.Button();
            this.dgvReparti = new System.Windows.Forms.DataGridView();
            this.grbGestione = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReparti)).BeginInit();
            this.grbGestione.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAnnulla
            // 
            this.btnAnnulla.BackColor = System.Drawing.Color.Red;
            this.btnAnnulla.FlatAppearance.BorderSize = 0;
            this.btnAnnulla.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnnulla.Location = new System.Drawing.Point(279, 350);
            this.btnAnnulla.Name = "btnAnnulla";
            this.btnAnnulla.Size = new System.Drawing.Size(200, 50);
            this.btnAnnulla.TabIndex = 6;
            this.btnAnnulla.Text = "ANNULLA";
            this.btnAnnulla.UseVisualStyleBackColor = false;
            this.btnAnnulla.Click += new System.EventHandler(this.btnAnnulla_Click);
            // 
            // btnConferma
            // 
            this.btnConferma.BackColor = System.Drawing.Color.Green;
            this.btnConferma.FlatAppearance.BorderSize = 0;
            this.btnConferma.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConferma.Location = new System.Drawing.Point(19, 350);
            this.btnConferma.Name = "btnConferma";
            this.btnConferma.Size = new System.Drawing.Size(200, 50);
            this.btnConferma.TabIndex = 5;
            this.btnConferma.Text = "C O N F E R M A";
            this.btnConferma.UseVisualStyleBackColor = false;
            this.btnConferma.Click += new System.EventHandler(this.btnConferma_Click);
            // 
            // txtDescrizione
            // 
            this.txtDescrizione.Location = new System.Drawing.Point(167, 142);
            this.txtDescrizione.MaxLength = 50;
            this.txtDescrizione.Name = "txtDescrizione";
            this.txtDescrizione.Size = new System.Drawing.Size(305, 26);
            this.txtDescrizione.TabIndex = 4;
            // 
            // txtCodice
            // 
            this.txtCodice.Location = new System.Drawing.Point(167, 64);
            this.txtCodice.MaxLength = 3;
            this.txtCodice.Name = "txtCodice";
            this.txtCodice.Size = new System.Drawing.Size(133, 26);
            this.txtCodice.TabIndex = 3;
            // 
            // chkAnnullato
            // 
            this.chkAnnullato.AutoSize = true;
            this.chkAnnullato.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkAnnullato.Location = new System.Drawing.Point(28, 235);
            this.chkAnnullato.Name = "chkAnnullato";
            this.chkAnnullato.Size = new System.Drawing.Size(102, 24);
            this.chkAnnullato.TabIndex = 2;
            this.chkAnnullato.Text = "Annullato";
            this.chkAnnullato.UseVisualStyleBackColor = true;
            this.chkAnnullato.CheckedChanged += new System.EventHandler(this.chkAnnullato_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 145);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 20);
            this.label6.TabIndex = 1;
            this.label6.Text = "Descrizione";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(24, 67);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "Codice";
            // 
            // chkAnnullati
            // 
            this.chkAnnullati.AutoSize = true;
            this.chkAnnullati.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkAnnullati.Location = new System.Drawing.Point(637, 20);
            this.chkAnnullati.Name = "chkAnnullati";
            this.chkAnnullati.Size = new System.Drawing.Size(96, 24);
            this.chkAnnullati.TabIndex = 1;
            this.chkAnnullati.Text = "Annullati";
            this.chkAnnullati.UseVisualStyleBackColor = true;
            this.chkAnnullati.CheckedChanged += new System.EventHandler(this.chkAnnullati_CheckedChanged);
            // 
            // btnAggiungi
            // 
            this.btnAggiungi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAggiungi.Location = new System.Drawing.Point(18, 14);
            this.btnAggiungi.Name = "btnAggiungi";
            this.btnAggiungi.Size = new System.Drawing.Size(102, 35);
            this.btnAggiungi.TabIndex = 0;
            this.btnAggiungi.Text = "Aggiungi";
            this.btnAggiungi.UseVisualStyleBackColor = true;
            this.btnAggiungi.Click += new System.EventHandler(this.btnAggiungi_Click);
            // 
            // dgvReparti
            // 
            this.dgvReparti.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.dgvReparti.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvReparti.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvReparti.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvReparti.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvReparti.ColumnHeadersHeight = 30;
            this.dgvReparti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvReparti.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvReparti.EnableHeadersVisualStyles = false;
            this.dgvReparti.GridColor = System.Drawing.Color.SteelBlue;
            this.dgvReparti.Location = new System.Drawing.Point(18, 55);
            this.dgvReparti.Name = "dgvReparti";
            this.dgvReparti.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvReparti.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvReparti.RowHeadersWidth = 62;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 8F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dgvReparti.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvReparti.RowTemplate.Height = 28;
            this.dgvReparti.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvReparti.Size = new System.Drawing.Size(689, 890);
            this.dgvReparti.TabIndex = 2;
            this.dgvReparti.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvReparti_CellClick);
            this.dgvReparti.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvReparti_CellContentClick);
            // 
            // grbGestione
            // 
            this.grbGestione.Controls.Add(this.label7);
            this.grbGestione.Controls.Add(this.label6);
            this.grbGestione.Controls.Add(this.btnAnnulla);
            this.grbGestione.Controls.Add(this.chkAnnullato);
            this.grbGestione.Controls.Add(this.txtCodice);
            this.grbGestione.Controls.Add(this.btnConferma);
            this.grbGestione.Controls.Add(this.txtDescrizione);
            this.grbGestione.ForeColor = System.Drawing.Color.White;
            this.grbGestione.Location = new System.Drawing.Point(319, 132);
            this.grbGestione.Name = "grbGestione";
            this.grbGestione.Size = new System.Drawing.Size(500, 440);
            this.grbGestione.TabIndex = 8;
            this.grbGestione.TabStop = false;
            this.grbGestione.Text = "Gestione Reparto";
            this.grbGestione.Visible = false;
            // 
            // pageReparti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.Controls.Add(this.grbGestione);
            this.Controls.Add(this.dgvReparti);
            this.Controls.Add(this.chkAnnullati);
            this.Controls.Add(this.btnAggiungi);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "pageReparti";
            this.Size = new System.Drawing.Size(1178, 1039);
            this.Load += new System.EventHandler(this.pageReparti_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReparti)).EndInit();
            this.grbGestione.ResumeLayout(false);
            this.grbGestione.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAnnulla;
        private System.Windows.Forms.Button btnConferma;
        private System.Windows.Forms.TextBox txtDescrizione;
        private System.Windows.Forms.TextBox txtCodice;
        private System.Windows.Forms.CheckBox chkAnnullato;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox chkAnnullati;
        private System.Windows.Forms.Button btnAggiungi;
        private System.Windows.Forms.DataGridView dgvReparti;
        private System.Windows.Forms.GroupBox grbGestione;
    }
}
