namespace BertolaLibri.Page
{
    partial class pageEditori
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
            this.grbEditori = new System.Windows.Forms.GroupBox();
            this.btnAnnullaEditori = new System.Windows.Forms.Button();
            this.btnConfermaEditori = new System.Windows.Forms.Button();
            this.txtNomeEditori = new System.Windows.Forms.TextBox();
            this.txtCodiceEditori = new System.Windows.Forms.TextBox();
            this.chkAnnullatoEditori = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dgvEditori = new System.Windows.Forms.DataGridView();
            this.chkAnnullatiEditori = new System.Windows.Forms.CheckBox();
            this.btnAggiungiEditori = new System.Windows.Forms.Button();
            this.grbEditori.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEditori)).BeginInit();
            this.SuspendLayout();
            // 
            // grbEditori
            // 
            this.grbEditori.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.grbEditori.Controls.Add(this.btnAnnullaEditori);
            this.grbEditori.Controls.Add(this.btnConfermaEditori);
            this.grbEditori.Controls.Add(this.txtNomeEditori);
            this.grbEditori.Controls.Add(this.txtCodiceEditori);
            this.grbEditori.Controls.Add(this.chkAnnullatoEditori);
            this.grbEditori.Controls.Add(this.label6);
            this.grbEditori.Controls.Add(this.label7);
            this.grbEditori.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbEditori.ForeColor = System.Drawing.Color.White;
            this.grbEditori.Location = new System.Drawing.Point(631, 56);
            this.grbEditori.Name = "grbEditori";
            this.grbEditori.Size = new System.Drawing.Size(489, 437);
            this.grbEditori.TabIndex = 11;
            this.grbEditori.TabStop = false;
            this.grbEditori.Text = "Gestione Dati Editori";
            this.grbEditori.Visible = false;
            // 
            // btnAnnullaEditori
            // 
            this.btnAnnullaEditori.BackColor = System.Drawing.Color.Red;
            this.btnAnnullaEditori.FlatAppearance.BorderSize = 0;
            this.btnAnnullaEditori.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnnullaEditori.Location = new System.Drawing.Point(275, 336);
            this.btnAnnullaEditori.Name = "btnAnnullaEditori";
            this.btnAnnullaEditori.Size = new System.Drawing.Size(200, 50);
            this.btnAnnullaEditori.TabIndex = 6;
            this.btnAnnullaEditori.Text = "ANNULLA";
            this.btnAnnullaEditori.UseVisualStyleBackColor = false;
            this.btnAnnullaEditori.Click += new System.EventHandler(this.btnAnnullaEditori_Click);
            // 
            // btnConfermaEditori
            // 
            this.btnConfermaEditori.BackColor = System.Drawing.Color.Green;
            this.btnConfermaEditori.FlatAppearance.BorderSize = 0;
            this.btnConfermaEditori.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfermaEditori.Location = new System.Drawing.Point(15, 336);
            this.btnConfermaEditori.Name = "btnConfermaEditori";
            this.btnConfermaEditori.Size = new System.Drawing.Size(200, 50);
            this.btnConfermaEditori.TabIndex = 5;
            this.btnConfermaEditori.Text = "C O N F E R M A";
            this.btnConfermaEditori.UseVisualStyleBackColor = false;
            this.btnConfermaEditori.Click += new System.EventHandler(this.btnConfermaEditori_Click);
            // 
            // txtNomeEditori
            // 
            this.txtNomeEditori.Location = new System.Drawing.Point(170, 157);
            this.txtNomeEditori.MaxLength = 100;
            this.txtNomeEditori.Name = "txtNomeEditori";
            this.txtNomeEditori.Size = new System.Drawing.Size(305, 27);
            this.txtNomeEditori.TabIndex = 4;
            // 
            // txtCodiceEditori
            // 
            this.txtCodiceEditori.Enabled = false;
            this.txtCodiceEditori.Location = new System.Drawing.Point(170, 79);
            this.txtCodiceEditori.MaxLength = 1;
            this.txtCodiceEditori.Name = "txtCodiceEditori";
            this.txtCodiceEditori.Size = new System.Drawing.Size(133, 27);
            this.txtCodiceEditori.TabIndex = 3;
            // 
            // chkAnnullatoEditori
            // 
            this.chkAnnullatoEditori.AutoSize = true;
            this.chkAnnullatoEditori.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkAnnullatoEditori.Location = new System.Drawing.Point(31, 250);
            this.chkAnnullatoEditori.Name = "chkAnnullatoEditori";
            this.chkAnnullatoEditori.Size = new System.Drawing.Size(113, 25);
            this.chkAnnullatoEditori.TabIndex = 2;
            this.chkAnnullatoEditori.Text = "Annullato";
            this.chkAnnullatoEditori.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 160);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 21);
            this.label6.TabIndex = 1;
            this.label6.Text = "Nome";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(27, 82);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 21);
            this.label7.TabIndex = 0;
            this.label7.Text = "Codice";
            // 
            // dgvEditori
            // 
            this.dgvEditori.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.dgvEditori.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvEditori.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvEditori.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEditori.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvEditori.ColumnHeadersHeight = 30;
            this.dgvEditori.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvEditori.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvEditori.EnableHeadersVisualStyles = false;
            this.dgvEditori.GridColor = System.Drawing.Color.SteelBlue;
            this.dgvEditori.Location = new System.Drawing.Point(18, 56);
            this.dgvEditori.Name = "dgvEditori";
            this.dgvEditori.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEditori.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvEditori.RowHeadersWidth = 62;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 8F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dgvEditori.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvEditori.RowTemplate.Height = 28;
            this.dgvEditori.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEditori.Size = new System.Drawing.Size(595, 950);
            this.dgvEditori.TabIndex = 2;
            this.dgvEditori.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEditori_CellClick);
            // 
            // chkAnnullatiEditori
            // 
            this.chkAnnullatiEditori.AutoSize = true;
            this.chkAnnullatiEditori.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkAnnullatiEditori.Location = new System.Drawing.Point(497, 21);
            this.chkAnnullatiEditori.Name = "chkAnnullatiEditori";
            this.chkAnnullatiEditori.Size = new System.Drawing.Size(96, 24);
            this.chkAnnullatiEditori.TabIndex = 1;
            this.chkAnnullatiEditori.Text = "Annullati";
            this.chkAnnullatiEditori.UseVisualStyleBackColor = true;
            this.chkAnnullatiEditori.CheckedChanged += new System.EventHandler(this.chkAnnullatiEditori_CheckedChanged);
            // 
            // btnAggiungiEditori
            // 
            this.btnAggiungiEditori.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAggiungiEditori.Location = new System.Drawing.Point(18, 15);
            this.btnAggiungiEditori.Name = "btnAggiungiEditori";
            this.btnAggiungiEditori.Size = new System.Drawing.Size(102, 35);
            this.btnAggiungiEditori.TabIndex = 0;
            this.btnAggiungiEditori.Text = "Aggiungi";
            this.btnAggiungiEditori.UseVisualStyleBackColor = true;
            this.btnAggiungiEditori.Click += new System.EventHandler(this.btnAggiungiEditori_Click);
            // 
            // pageEditori
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.Controls.Add(this.dgvEditori);
            this.Controls.Add(this.grbEditori);
            this.Controls.Add(this.chkAnnullatiEditori);
            this.Controls.Add(this.btnAggiungiEditori);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "pageEditori";
            this.Size = new System.Drawing.Size(1202, 1124);
            this.Load += new System.EventHandler(this.pageEditori_Load);
            this.grbEditori.ResumeLayout(false);
            this.grbEditori.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEditori)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbEditori;
        private System.Windows.Forms.Button btnAnnullaEditori;
        private System.Windows.Forms.Button btnConfermaEditori;
        private System.Windows.Forms.TextBox txtNomeEditori;
        private System.Windows.Forms.TextBox txtCodiceEditori;
        private System.Windows.Forms.CheckBox chkAnnullatoEditori;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dgvEditori;
        private System.Windows.Forms.CheckBox chkAnnullatiEditori;
        private System.Windows.Forms.Button btnAggiungiEditori;
    }
}
