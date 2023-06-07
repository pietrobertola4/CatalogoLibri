namespace BertolaLibri
{
    partial class Form1
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

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.barraTitolo = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.btnRes = new System.Windows.Forms.PictureBox();
            this.btnMin = new System.Windows.Forms.PictureBox();
            this.btnMax = new System.Windows.Forms.PictureBox();
            this.btnClose = new System.Windows.Forms.PictureBox();
            this.barraMenu = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.btnLibri = new System.Windows.Forms.Button();
            this.divLibri = new System.Windows.Forms.Panel();
            this.btnInserisciLibro = new System.Windows.Forms.Button();
            this.pInserisci = new System.Windows.Forms.Panel();
            this.divAnagrafiche = new System.Windows.Forms.Panel();
            this.btnAutori = new System.Windows.Forms.Button();
            this.pAutori = new System.Windows.Forms.Panel();
            this.btnReparti = new System.Windows.Forms.Button();
            this.pReparti = new System.Windows.Forms.Panel();
            this.btnEditori = new System.Windows.Forms.Button();
            this.pEditori = new System.Windows.Forms.Panel();
            this.btnOfferte = new System.Windows.Forms.Button();
            this.pOfferte = new System.Windows.Forms.Panel();
            this.btnDomande = new System.Windows.Forms.Label();
            this.btnAnagrafiche = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.containerPanel = new System.Windows.Forms.Panel();
            this.barraTitolo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnRes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            this.barraMenu.SuspendLayout();
            this.divLibri.SuspendLayout();
            this.divAnagrafiche.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // barraTitolo
            // 
            this.barraTitolo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.barraTitolo.Controls.Add(this.label3);
            this.barraTitolo.Controls.Add(this.btnRes);
            this.barraTitolo.Controls.Add(this.btnMin);
            this.barraTitolo.Controls.Add(this.btnMax);
            this.barraTitolo.Controls.Add(this.btnClose);
            this.barraTitolo.Dock = System.Windows.Forms.DockStyle.Top;
            this.barraTitolo.Location = new System.Drawing.Point(0, 0);
            this.barraTitolo.Name = "barraTitolo";
            this.barraTitolo.Size = new System.Drawing.Size(1000, 38);
            this.barraTitolo.TabIndex = 0;
            this.barraTitolo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.barraTitolo_MouseDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(3, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(286, 28);
            this.label3.TabIndex = 3;
            this.label3.Text = "Gestione Catalogo Libri";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnRes
            // 
            this.btnRes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRes.Image = ((System.Drawing.Image)(resources.GetObject("btnRes.Image")));
            this.btnRes.Location = new System.Drawing.Point(923, 7);
            this.btnRes.Name = "btnRes";
            this.btnRes.Size = new System.Drawing.Size(25, 25);
            this.btnRes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnRes.TabIndex = 3;
            this.btnRes.TabStop = false;
            this.btnRes.Visible = false;
            this.btnRes.Click += new System.EventHandler(this.btnRes_Click);
            // 
            // btnMin
            // 
            this.btnMin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMin.Image = ((System.Drawing.Image)(resources.GetObject("btnMin.Image")));
            this.btnMin.Location = new System.Drawing.Point(881, 7);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(25, 25);
            this.btnMin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMin.TabIndex = 2;
            this.btnMin.TabStop = false;
            this.btnMin.Click += new System.EventHandler(this.btnMin_Click);
            // 
            // btnMax
            // 
            this.btnMax.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMax.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMax.Image = ((System.Drawing.Image)(resources.GetObject("btnMax.Image")));
            this.btnMax.Location = new System.Drawing.Point(923, 7);
            this.btnMax.Name = "btnMax";
            this.btnMax.Size = new System.Drawing.Size(25, 25);
            this.btnMax.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMax.TabIndex = 1;
            this.btnMax.TabStop = false;
            this.btnMax.Click += new System.EventHandler(this.btnMax_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(963, 7);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(25, 25);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnClose.TabIndex = 0;
            this.btnClose.TabStop = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // barraMenu
            // 
            this.barraMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.barraMenu.Controls.Add(this.label10);
            this.barraMenu.Controls.Add(this.btnLibri);
            this.barraMenu.Controls.Add(this.divLibri);
            this.barraMenu.Controls.Add(this.divAnagrafiche);
            this.barraMenu.Controls.Add(this.btnDomande);
            this.barraMenu.Controls.Add(this.btnAnagrafiche);
            this.barraMenu.Controls.Add(this.label2);
            this.barraMenu.Controls.Add(this.label1);
            this.barraMenu.Controls.Add(this.pictureBox1);
            this.barraMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.barraMenu.Location = new System.Drawing.Point(0, 38);
            this.barraMenu.Name = "barraMenu";
            this.barraMenu.Size = new System.Drawing.Size(220, 674);
            this.barraMenu.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Magneto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(53, 637);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(132, 28);
            this.label10.TabIndex = 13;
            this.label10.Text = "5^A Inf.";
            // 
            // btnLibri
            // 
            this.btnLibri.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnLibri.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnLibri.FlatAppearance.BorderSize = 0;
            this.btnLibri.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnLibri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLibri.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLibri.ForeColor = System.Drawing.Color.White;
            this.btnLibri.Location = new System.Drawing.Point(-1, 371);
            this.btnLibri.Name = "btnLibri";
            this.btnLibri.Size = new System.Drawing.Size(221, 44);
            this.btnLibri.TabIndex = 6;
            this.btnLibri.Text = "Libri";
            this.btnLibri.UseVisualStyleBackColor = false;
            this.btnLibri.Click += new System.EventHandler(this.btnLibri_Click);
            // 
            // divLibri
            // 
            this.divLibri.Controls.Add(this.btnInserisciLibro);
            this.divLibri.Controls.Add(this.pInserisci);
            this.divLibri.Location = new System.Drawing.Point(3, 421);
            this.divLibri.Name = "divLibri";
            this.divLibri.Size = new System.Drawing.Size(211, 61);
            this.divLibri.TabIndex = 12;
            // 
            // btnInserisciLibro
            // 
            this.btnInserisciLibro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnInserisciLibro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInserisciLibro.FlatAppearance.BorderSize = 0;
            this.btnInserisciLibro.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnInserisciLibro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInserisciLibro.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInserisciLibro.ForeColor = System.Drawing.Color.White;
            this.btnInserisciLibro.Location = new System.Drawing.Point(3, 3);
            this.btnInserisciLibro.Name = "btnInserisciLibro";
            this.btnInserisciLibro.Size = new System.Drawing.Size(211, 38);
            this.btnInserisciLibro.TabIndex = 5;
            this.btnInserisciLibro.Text = "Vedi";
            this.btnInserisciLibro.UseVisualStyleBackColor = false;
            this.btnInserisciLibro.Click += new System.EventHandler(this.btnInserisciLibro_Click);
            // 
            // pInserisci
            // 
            this.pInserisci.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.pInserisci.Location = new System.Drawing.Point(-2, 3);
            this.pInserisci.Name = "pInserisci";
            this.pInserisci.Size = new System.Drawing.Size(10, 38);
            this.pInserisci.TabIndex = 4;
            this.pInserisci.Visible = false;
            // 
            // divAnagrafiche
            // 
            this.divAnagrafiche.Controls.Add(this.btnAutori);
            this.divAnagrafiche.Controls.Add(this.pAutori);
            this.divAnagrafiche.Controls.Add(this.btnReparti);
            this.divAnagrafiche.Controls.Add(this.pReparti);
            this.divAnagrafiche.Controls.Add(this.btnEditori);
            this.divAnagrafiche.Controls.Add(this.pEditori);
            this.divAnagrafiche.Controls.Add(this.btnOfferte);
            this.divAnagrafiche.Controls.Add(this.pOfferte);
            this.divAnagrafiche.Location = new System.Drawing.Point(3, 173);
            this.divAnagrafiche.Name = "divAnagrafiche";
            this.divAnagrafiche.Size = new System.Drawing.Size(214, 182);
            this.divAnagrafiche.TabIndex = 0;
            // 
            // btnAutori
            // 
            this.btnAutori.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnAutori.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAutori.FlatAppearance.BorderSize = 0;
            this.btnAutori.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnAutori.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAutori.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAutori.ForeColor = System.Drawing.Color.White;
            this.btnAutori.Location = new System.Drawing.Point(3, 135);
            this.btnAutori.Name = "btnAutori";
            this.btnAutori.Size = new System.Drawing.Size(208, 38);
            this.btnAutori.TabIndex = 11;
            this.btnAutori.Text = "Autori";
            this.btnAutori.UseVisualStyleBackColor = false;
            this.btnAutori.Click += new System.EventHandler(this.btnAutori_Click);
            // 
            // pAutori
            // 
            this.pAutori.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.pAutori.Location = new System.Drawing.Point(-2, 135);
            this.pAutori.Name = "pAutori";
            this.pAutori.Size = new System.Drawing.Size(5, 38);
            this.pAutori.TabIndex = 10;
            this.pAutori.Visible = false;
            // 
            // btnReparti
            // 
            this.btnReparti.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnReparti.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReparti.FlatAppearance.BorderSize = 0;
            this.btnReparti.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnReparti.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReparti.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReparti.ForeColor = System.Drawing.Color.White;
            this.btnReparti.Location = new System.Drawing.Point(3, 3);
            this.btnReparti.Name = "btnReparti";
            this.btnReparti.Size = new System.Drawing.Size(211, 38);
            this.btnReparti.TabIndex = 5;
            this.btnReparti.Text = "Reparti";
            this.btnReparti.UseVisualStyleBackColor = false;
            this.btnReparti.Click += new System.EventHandler(this.btnReparti_Click);
            // 
            // pReparti
            // 
            this.pReparti.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.pReparti.Location = new System.Drawing.Point(-2, 3);
            this.pReparti.Name = "pReparti";
            this.pReparti.Size = new System.Drawing.Size(10, 38);
            this.pReparti.TabIndex = 4;
            this.pReparti.Visible = false;
            // 
            // btnEditori
            // 
            this.btnEditori.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnEditori.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditori.FlatAppearance.BorderSize = 0;
            this.btnEditori.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnEditori.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditori.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditori.ForeColor = System.Drawing.Color.White;
            this.btnEditori.Location = new System.Drawing.Point(3, 91);
            this.btnEditori.Name = "btnEditori";
            this.btnEditori.Size = new System.Drawing.Size(211, 38);
            this.btnEditori.TabIndex = 9;
            this.btnEditori.Text = "Editori";
            this.btnEditori.UseVisualStyleBackColor = false;
            this.btnEditori.Click += new System.EventHandler(this.btnEditori_Click);
            // 
            // pEditori
            // 
            this.pEditori.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.pEditori.Location = new System.Drawing.Point(-2, 91);
            this.pEditori.Name = "pEditori";
            this.pEditori.Size = new System.Drawing.Size(5, 38);
            this.pEditori.TabIndex = 8;
            this.pEditori.Visible = false;
            // 
            // btnOfferte
            // 
            this.btnOfferte.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnOfferte.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOfferte.FlatAppearance.BorderSize = 0;
            this.btnOfferte.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnOfferte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOfferte.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOfferte.ForeColor = System.Drawing.Color.White;
            this.btnOfferte.Location = new System.Drawing.Point(3, 47);
            this.btnOfferte.Name = "btnOfferte";
            this.btnOfferte.Size = new System.Drawing.Size(208, 38);
            this.btnOfferte.TabIndex = 7;
            this.btnOfferte.Text = "Offerte";
            this.btnOfferte.UseVisualStyleBackColor = false;
            this.btnOfferte.Click += new System.EventHandler(this.btnOfferte_Click);
            // 
            // pOfferte
            // 
            this.pOfferte.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.pOfferte.Location = new System.Drawing.Point(-2, 47);
            this.pOfferte.Name = "pOfferte";
            this.pOfferte.Size = new System.Drawing.Size(5, 38);
            this.pOfferte.TabIndex = 6;
            this.pOfferte.Visible = false;
            // 
            // btnDomande
            // 
            this.btnDomande.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDomande.AutoSize = true;
            this.btnDomande.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDomande.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDomande.ForeColor = System.Drawing.Color.White;
            this.btnDomande.Location = new System.Drawing.Point(12, 628);
            this.btnDomande.Name = "btnDomande";
            this.btnDomande.Size = new System.Drawing.Size(35, 37);
            this.btnDomande.TabIndex = 4;
            this.btnDomande.Text = "?";
            this.btnDomande.Click += new System.EventHandler(this.btnDomande_Click);
            // 
            // btnAnagrafiche
            // 
            this.btnAnagrafiche.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnAnagrafiche.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnAnagrafiche.FlatAppearance.BorderSize = 0;
            this.btnAnagrafiche.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnagrafiche.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnagrafiche.ForeColor = System.Drawing.Color.White;
            this.btnAnagrafiche.Location = new System.Drawing.Point(-1, 123);
            this.btnAnagrafiche.Name = "btnAnagrafiche";
            this.btnAnagrafiche.Size = new System.Drawing.Size(221, 44);
            this.btnAnagrafiche.TabIndex = 3;
            this.btnAnagrafiche.Text = "Anagrafiche";
            this.btnAnagrafiche.UseVisualStyleBackColor = false;
            this.btnAnagrafiche.Click += new System.EventHandler(this.btnAnagrafiche_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Magneto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(118, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 28);
            this.label2.TabIndex = 2;
            this.label2.Text = "Pietro";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Magneto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(108, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "Bertola";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(103, 102);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // containerPanel
            // 
            this.containerPanel.Location = new System.Drawing.Point(220, 38);
            this.containerPanel.Name = "containerPanel";
            this.containerPanel.Size = new System.Drawing.Size(780, 674);
            this.containerPanel.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(1000, 712);
            this.Controls.Add(this.containerPanel);
            this.Controls.Add(this.barraMenu);
            this.Controls.Add(this.barraTitolo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BertolaLibri";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.barraTitolo.ResumeLayout(false);
            this.barraTitolo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnRes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            this.barraMenu.ResumeLayout(false);
            this.barraMenu.PerformLayout();
            this.divLibri.ResumeLayout(false);
            this.divAnagrafiche.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel barraTitolo;
        private System.Windows.Forms.PictureBox btnClose;
        private System.Windows.Forms.Panel barraMenu;
        private System.Windows.Forms.PictureBox btnRes;
        private System.Windows.Forms.PictureBox btnMin;
        private System.Windows.Forms.PictureBox btnMax;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAnagrafiche;
        private System.Windows.Forms.Label btnDomande;
        private System.Windows.Forms.Panel divAnagrafiche;
        private System.Windows.Forms.Button btnReparti;
        private System.Windows.Forms.Panel pReparti;
        private System.Windows.Forms.Button btnOfferte;
        private System.Windows.Forms.Panel pOfferte;
        private System.Windows.Forms.Button btnAutori;
        private System.Windows.Forms.Panel pAutori;
        private System.Windows.Forms.Button btnEditori;
        private System.Windows.Forms.Panel pEditori;
        private System.Windows.Forms.Panel divLibri;
        private System.Windows.Forms.Button btnInserisciLibro;
        private System.Windows.Forms.Panel pInserisci;
        private System.Windows.Forms.Button btnLibri;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel containerPanel;
    }
}

