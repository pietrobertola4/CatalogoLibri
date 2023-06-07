namespace BertolaLibri
{
    partial class pageOfferte
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
            this.grbOfferte = new System.Windows.Forms.GroupBox();
            this.nudOfferta = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.btnAnnullaOfferte = new System.Windows.Forms.Button();
            this.btnConfermaOfferte = new System.Windows.Forms.Button();
            this.txtDescrizioneOfferte = new System.Windows.Forms.TextBox();
            this.txtCodiceOfferte = new System.Windows.Forms.TextBox();
            this.chkAnnullatoOfferte = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dgvOfferte = new System.Windows.Forms.DataGridView();
            this.chkAnnulatiOfferte = new System.Windows.Forms.CheckBox();
            this.btnAggiungiOfferte = new System.Windows.Forms.Button();
            this.grbOfferte.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudOfferta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOfferte)).BeginInit();
            this.SuspendLayout();
            // 
            // grbOfferte
            // 
            this.grbOfferte.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.grbOfferte.Controls.Add(this.nudOfferta);
            this.grbOfferte.Controls.Add(this.label12);
            this.grbOfferte.Controls.Add(this.btnAnnullaOfferte);
            this.grbOfferte.Controls.Add(this.btnConfermaOfferte);
            this.grbOfferte.Controls.Add(this.txtDescrizioneOfferte);
            this.grbOfferte.Controls.Add(this.txtCodiceOfferte);
            this.grbOfferte.Controls.Add(this.chkAnnullatoOfferte);
            this.grbOfferte.Controls.Add(this.label8);
            this.grbOfferte.Controls.Add(this.label9);
            this.grbOfferte.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbOfferte.ForeColor = System.Drawing.Color.White;
            this.grbOfferte.Location = new System.Drawing.Point(654, 58);
            this.grbOfferte.Name = "grbOfferte";
            this.grbOfferte.Size = new System.Drawing.Size(489, 435);
            this.grbOfferte.TabIndex = 8;
            this.grbOfferte.TabStop = false;
            this.grbOfferte.Text = "Gestione Dati Offerte";
            this.grbOfferte.Visible = false;
            // 
            // nudOfferta
            // 
            this.nudOfferta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nudOfferta.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudOfferta.Location = new System.Drawing.Point(170, 224);
            this.nudOfferta.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.nudOfferta.Name = "nudOfferta";
            this.nudOfferta.Size = new System.Drawing.Size(120, 27);
            this.nudOfferta.TabIndex = 8;
            this.nudOfferta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(27, 226);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(65, 21);
            this.label12.TabIndex = 7;
            this.label12.Text = "Sconto";
            // 
            // btnAnnullaOfferte
            // 
            this.btnAnnullaOfferte.BackColor = System.Drawing.Color.Red;
            this.btnAnnullaOfferte.FlatAppearance.BorderSize = 0;
            this.btnAnnullaOfferte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnnullaOfferte.Location = new System.Drawing.Point(275, 358);
            this.btnAnnullaOfferte.Name = "btnAnnullaOfferte";
            this.btnAnnullaOfferte.Size = new System.Drawing.Size(200, 50);
            this.btnAnnullaOfferte.TabIndex = 6;
            this.btnAnnullaOfferte.Text = "ANNULLA";
            this.btnAnnullaOfferte.UseVisualStyleBackColor = false;
            this.btnAnnullaOfferte.Click += new System.EventHandler(this.btnAnnullaOfferte_Click);
            // 
            // btnConfermaOfferte
            // 
            this.btnConfermaOfferte.BackColor = System.Drawing.Color.Green;
            this.btnConfermaOfferte.FlatAppearance.BorderSize = 0;
            this.btnConfermaOfferte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfermaOfferte.Location = new System.Drawing.Point(15, 358);
            this.btnConfermaOfferte.Name = "btnConfermaOfferte";
            this.btnConfermaOfferte.Size = new System.Drawing.Size(200, 50);
            this.btnConfermaOfferte.TabIndex = 5;
            this.btnConfermaOfferte.Text = "C O N F E R M A";
            this.btnConfermaOfferte.UseVisualStyleBackColor = false;
            this.btnConfermaOfferte.Click += new System.EventHandler(this.btnConfermaOfferte_Click);
            // 
            // txtDescrizioneOfferte
            // 
            this.txtDescrizioneOfferte.Location = new System.Drawing.Point(170, 157);
            this.txtDescrizioneOfferte.MaxLength = 50;
            this.txtDescrizioneOfferte.Name = "txtDescrizioneOfferte";
            this.txtDescrizioneOfferte.Size = new System.Drawing.Size(305, 27);
            this.txtDescrizioneOfferte.TabIndex = 4;
            // 
            // txtCodiceOfferte
            // 
            this.txtCodiceOfferte.Enabled = false;
            this.txtCodiceOfferte.Location = new System.Drawing.Point(170, 79);
            this.txtCodiceOfferte.MaxLength = 1;
            this.txtCodiceOfferte.Name = "txtCodiceOfferte";
            this.txtCodiceOfferte.Size = new System.Drawing.Size(133, 27);
            this.txtCodiceOfferte.TabIndex = 3;
            // 
            // chkAnnullatoOfferte
            // 
            this.chkAnnullatoOfferte.AutoSize = true;
            this.chkAnnullatoOfferte.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkAnnullatoOfferte.Location = new System.Drawing.Point(31, 286);
            this.chkAnnullatoOfferte.Name = "chkAnnullatoOfferte";
            this.chkAnnullatoOfferte.Size = new System.Drawing.Size(113, 25);
            this.chkAnnullatoOfferte.TabIndex = 2;
            this.chkAnnullatoOfferte.Text = "Annullato";
            this.chkAnnullatoOfferte.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(27, 160);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 21);
            this.label8.TabIndex = 1;
            this.label8.Text = "Descrizione";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(27, 82);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 21);
            this.label9.TabIndex = 0;
            this.label9.Text = "Codice";
            // 
            // dgvOfferte
            // 
            this.dgvOfferte.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.dgvOfferte.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvOfferte.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvOfferte.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvOfferte.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvOfferte.ColumnHeadersHeight = 30;
            this.dgvOfferte.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvOfferte.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvOfferte.EnableHeadersVisualStyles = false;
            this.dgvOfferte.GridColor = System.Drawing.Color.SteelBlue;
            this.dgvOfferte.Location = new System.Drawing.Point(16, 58);
            this.dgvOfferte.Name = "dgvOfferte";
            this.dgvOfferte.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvOfferte.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvOfferte.RowHeadersWidth = 62;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 8F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dgvOfferte.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvOfferte.RowTemplate.Height = 28;
            this.dgvOfferte.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOfferte.Size = new System.Drawing.Size(632, 849);
            this.dgvOfferte.TabIndex = 2;
            this.dgvOfferte.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOfferte_CellClick);
            // 
            // chkAnnulatiOfferte
            // 
            this.chkAnnulatiOfferte.AutoSize = true;
            this.chkAnnulatiOfferte.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkAnnulatiOfferte.Location = new System.Drawing.Point(534, 23);
            this.chkAnnulatiOfferte.Name = "chkAnnulatiOfferte";
            this.chkAnnulatiOfferte.Size = new System.Drawing.Size(96, 24);
            this.chkAnnulatiOfferte.TabIndex = 1;
            this.chkAnnulatiOfferte.Text = "Annullati";
            this.chkAnnulatiOfferte.UseVisualStyleBackColor = true;
            this.chkAnnulatiOfferte.CheckedChanged += new System.EventHandler(this.chkAnnulatiOfferte_CheckedChanged);
            // 
            // btnAggiungiOfferte
            // 
            this.btnAggiungiOfferte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAggiungiOfferte.Location = new System.Drawing.Point(16, 17);
            this.btnAggiungiOfferte.Name = "btnAggiungiOfferte";
            this.btnAggiungiOfferte.Size = new System.Drawing.Size(102, 35);
            this.btnAggiungiOfferte.TabIndex = 0;
            this.btnAggiungiOfferte.Text = "Aggiungi";
            this.btnAggiungiOfferte.UseVisualStyleBackColor = true;
            this.btnAggiungiOfferte.Click += new System.EventHandler(this.btnAggiungiOfferte_Click);
            // 
            // pageOfferte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.Controls.Add(this.dgvOfferte);
            this.Controls.Add(this.chkAnnulatiOfferte);
            this.Controls.Add(this.btnAggiungiOfferte);
            this.Controls.Add(this.grbOfferte);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "pageOfferte";
            this.Size = new System.Drawing.Size(1450, 1066);
            this.Load += new System.EventHandler(this.pageOfferte_Load);
            this.grbOfferte.ResumeLayout(false);
            this.grbOfferte.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudOfferta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOfferte)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox grbOfferte;
        private System.Windows.Forms.NumericUpDown nudOfferta;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnAnnullaOfferte;
        private System.Windows.Forms.Button btnConfermaOfferte;
        private System.Windows.Forms.TextBox txtDescrizioneOfferte;
        private System.Windows.Forms.TextBox txtCodiceOfferte;
        private System.Windows.Forms.CheckBox chkAnnullatoOfferte;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dgvOfferte;
        private System.Windows.Forms.CheckBox chkAnnulatiOfferte;
        private System.Windows.Forms.Button btnAggiungiOfferte;
    }
}
