namespace GESTAPP.Views
{
    partial class FrmCompteCourant
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCompteCourant));
            lblBatiment = new Label();
            label3 = new Label();
            ComboIDLOc = new ComboBox();
            label2 = new Label();
            DGVCompte = new DataGridView();
            BtnSupprimer = new Button();
            groupBox1 = new GroupBox();
            TxtReference = new TextBox();
            label9 = new Label();
            ComboMatricule = new ComboBox();
            label8 = new Label();
            ComboTypePaiment = new ComboBox();
            label6 = new Label();
            TxtMotif = new TextBox();
            label5 = new Label();
            lblSolde = new Label();
            TxtMontantPaye = new TextBox();
            ComboMois = new ComboBox();
            TxtMontanntLoyer = new TextBox();
            label4 = new Label();
            DatePaie = new DateTimePicker();
            label1 = new Label();
            BtnModifier = new Button();
            TxtSolde = new TextBox();
            TxtNumero = new TextBox();
            BtnEnregistrer = new Button();
            LblPrix = new Label();
            LblCodebat = new Label();
            LblNum = new Label();
            BtnBatiment = new Button();
            pictureBox1 = new PictureBox();
            BtnQuitter = new Button();
            PanelMenu = new Panel();
            BtnDeconnecter = new Button();
            BtnDossier = new Button();
            ComboRechercher = new ComboBox();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)DGVCompte).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            PanelMenu.SuspendLayout();
            SuspendLayout();
            // 
            // lblBatiment
            // 
            lblBatiment.AutoSize = true;
            lblBatiment.FlatStyle = FlatStyle.Flat;
            lblBatiment.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBatiment.ForeColor = Color.White;
            lblBatiment.Location = new Point(508, 17);
            lblBatiment.Name = "lblBatiment";
            lblBatiment.Size = new Size(210, 24);
            lblBatiment.TabIndex = 18;
            lblBatiment.Text = "COMPTE COURANT";
            lblBatiment.TextAlign = ContentAlignment.TopCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Roboto", 12F);
            label3.Location = new Point(10, 92);
            label3.Name = "label3";
            label3.Size = new Size(144, 19);
            label3.TabIndex = 36;
            label3.Text = "Mois du payement ";
            // 
            // ComboIDLOc
            // 
            ComboIDLOc.FormattingEnabled = true;
            ComboIDLOc.Location = new Point(347, 241);
            ComboIDLOc.Name = "ComboIDLOc";
            ComboIDLOc.Size = new Size(304, 23);
            ComboIDLOc.TabIndex = 35;
            ComboIDLOc.SelectedIndexChanged += ComboIDLOc_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Roboto", 12F);
            label2.Location = new Point(347, 219);
            label2.Name = "label2";
            label2.Size = new Size(101, 19);
            label2.TabIndex = 34;
            label2.Text = "ID locataire : ";
            // 
            // DGVCompte
            // 
            DGVCompte.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGVCompte.Dock = DockStyle.Bottom;
            DGVCompte.Location = new Point(3, 295);
            DGVCompte.Name = "DGVCompte";
            DGVCompte.Size = new Size(1161, 383);
            DGVCompte.TabIndex = 33;
            DGVCompte.CellContentClick += DGVCompte_CellContentClick;
            // 
            // BtnSupprimer
            // 
            BtnSupprimer.Location = new Point(1012, 185);
            BtnSupprimer.Name = "BtnSupprimer";
            BtnSupprimer.Size = new Size(149, 37);
            BtnSupprimer.TabIndex = 16;
            BtnSupprimer.Text = "Supprimer";
            BtnSupprimer.UseVisualStyleBackColor = true;
            BtnSupprimer.Click += BtnSupprimer_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(TxtReference);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(ComboMatricule);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(ComboTypePaiment);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(TxtMotif);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(lblSolde);
            groupBox1.Controls.Add(TxtMontantPaye);
            groupBox1.Controls.Add(ComboMois);
            groupBox1.Controls.Add(TxtMontanntLoyer);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(DatePaie);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(ComboIDLOc);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(DGVCompte);
            groupBox1.Controls.Add(BtnSupprimer);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(BtnModifier);
            groupBox1.Controls.Add(TxtSolde);
            groupBox1.Controls.Add(TxtNumero);
            groupBox1.Controls.Add(BtnEnregistrer);
            groupBox1.Controls.Add(LblPrix);
            groupBox1.Controls.Add(LblCodebat);
            groupBox1.Controls.Add(LblNum);
            groupBox1.Dock = DockStyle.Bottom;
            groupBox1.Location = new Point(186, 68);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1167, 681);
            groupBox1.TabIndex = 16;
            groupBox1.TabStop = false;
            // 
            // TxtReference
            // 
            TxtReference.Font = new Font("Roboto", 12F);
            TxtReference.Location = new Point(680, 121);
            TxtReference.Multiline = true;
            TxtReference.Name = "TxtReference";
            TxtReference.Size = new Size(304, 35);
            TxtReference.TabIndex = 53;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Roboto", 12F);
            label9.Location = new Point(680, 93);
            label9.Name = "label9";
            label9.Size = new Size(171, 19);
            label9.TabIndex = 52;
            label9.Text = "Référence du paiement";
            // 
            // ComboMatricule
            // 
            ComboMatricule.FormattingEnabled = true;
            ComboMatricule.Items.AddRange(new object[] { "Janvier", "Fevrier", "Mars", "Avril", "Mais", "Juin", "Juillet", "Aout", "Septembre", "Novembre", "Decembre" });
            ComboMatricule.Location = new Point(680, 193);
            ComboMatricule.Name = "ComboMatricule";
            ComboMatricule.Size = new Size(209, 23);
            ComboMatricule.TabIndex = 51;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Roboto", 12F);
            label8.Location = new Point(680, 159);
            label8.Name = "label8";
            label8.Size = new Size(131, 19);
            label8.TabIndex = 50;
            label8.Text = "Matricule agent : ";
            // 
            // ComboTypePaiment
            // 
            ComboTypePaiment.FormattingEnabled = true;
            ComboTypePaiment.Items.AddRange(new object[] { "Espèce", "Mobile money", "Virement bancaire" });
            ComboTypePaiment.Location = new Point(680, 47);
            ComboTypePaiment.Name = "ComboTypePaiment";
            ComboTypePaiment.Size = new Size(209, 23);
            ComboTypePaiment.TabIndex = 47;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Roboto", 12F);
            label6.Location = new Point(680, 19);
            label6.Name = "label6";
            label6.Size = new Size(146, 19);
            label6.TabIndex = 46;
            label6.Text = "Type de paiement : ";
            // 
            // TxtMotif
            // 
            TxtMotif.Font = new Font("Roboto", 12F);
            TxtMotif.Location = new Point(347, 47);
            TxtMotif.Multiline = true;
            TxtMotif.Name = "TxtMotif";
            TxtMotif.Size = new Size(304, 35);
            TxtMotif.TabIndex = 45;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Roboto", 12F);
            label5.Location = new Point(347, 19);
            label5.Name = "label5";
            label5.Size = new Size(59, 19);
            label5.TabIndex = 44;
            label5.Text = "Motif : ";
            // 
            // lblSolde
            // 
            lblSolde.AutoSize = true;
            lblSolde.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSolde.Location = new Point(742, 241);
            lblSolde.Name = "lblSolde";
            lblSolde.Size = new Size(0, 30);
            lblSolde.TabIndex = 43;
            // 
            // TxtMontantPaye
            // 
            TxtMontantPaye.Font = new Font("Roboto", 12F);
            TxtMontantPaye.Location = new Point(347, 181);
            TxtMontantPaye.Multiline = true;
            TxtMontantPaye.Name = "TxtMontantPaye";
            TxtMontantPaye.Size = new Size(304, 35);
            TxtMontantPaye.TabIndex = 42;
            TxtMontantPaye.TextChanged += TxtMontantPaye_TextChanged;
            // 
            // ComboMois
            // 
            ComboMois.FormattingEnabled = true;
            ComboMois.Items.AddRange(new object[] { "Janvier", "Fevrier", "Mars", "Avril", "Mais", "Juin", "Juillet", "Aout", "Septembre", "Octobre", "Novembre", "Decembre" });
            ComboMois.Location = new Point(10, 114);
            ComboMois.Name = "ComboMois";
            ComboMois.Size = new Size(304, 23);
            ComboMois.TabIndex = 41;
            // 
            // TxtMontanntLoyer
            // 
            TxtMontanntLoyer.Font = new Font("Roboto", 12F);
            TxtMontanntLoyer.Location = new Point(347, 121);
            TxtMontanntLoyer.Multiline = true;
            TxtMontanntLoyer.Name = "TxtMontanntLoyer";
            TxtMontanntLoyer.Size = new Size(304, 35);
            TxtMontanntLoyer.TabIndex = 40;
            TxtMontanntLoyer.TextChanged += TxtMontanntLoyer_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Roboto", 12F);
            label4.Location = new Point(10, 147);
            label4.Name = "label4";
            label4.Size = new Size(146, 19);
            label4.TabIndex = 38;
            label4.Text = "Date du paiement : ";
            // 
            // DatePaie
            // 
            DatePaie.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DatePaie.Format = DateTimePickerFormat.Short;
            DatePaie.Location = new Point(10, 178);
            DatePaie.Name = "DatePaie";
            DatePaie.Size = new Size(144, 27);
            DatePaie.TabIndex = 37;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Roboto", 12F);
            label1.Location = new Point(347, 93);
            label1.Name = "label1";
            label1.Size = new Size(124, 19);
            label1.TabIndex = 14;
            label1.Text = "Montant Loyer : ";
            // 
            // BtnModifier
            // 
            BtnModifier.Location = new Point(1012, 136);
            BtnModifier.Name = "BtnModifier";
            BtnModifier.Size = new Size(149, 37);
            BtnModifier.TabIndex = 13;
            BtnModifier.Text = "Modifier";
            BtnModifier.UseVisualStyleBackColor = true;
            BtnModifier.Click += BtnModifier_Click;
            // 
            // TxtSolde
            // 
            TxtSolde.Font = new Font("Roboto", 12F);
            TxtSolde.Location = new Point(10, 244);
            TxtSolde.Multiline = true;
            TxtSolde.Name = "TxtSolde";
            TxtSolde.ReadOnly = true;
            TxtSolde.Size = new Size(304, 35);
            TxtSolde.TabIndex = 9;
            TxtSolde.TextChanged += TxtSolde_TextChanged;
            // 
            // TxtNumero
            // 
            TxtNumero.Font = new Font("Roboto", 12F);
            TxtNumero.Location = new Point(8, 47);
            TxtNumero.Multiline = true;
            TxtNumero.Name = "TxtNumero";
            TxtNumero.Size = new Size(304, 35);
            TxtNumero.TabIndex = 6;
            TxtNumero.TextChanged += TxtNumero_TextChanged;
            // 
            // BtnEnregistrer
            // 
            BtnEnregistrer.Location = new Point(1012, 93);
            BtnEnregistrer.Name = "BtnEnregistrer";
            BtnEnregistrer.Size = new Size(149, 37);
            BtnEnregistrer.TabIndex = 3;
            BtnEnregistrer.Text = "Enregistrer";
            BtnEnregistrer.UseVisualStyleBackColor = true;
            BtnEnregistrer.Click += BtnEnregistrer_Click;
            // 
            // LblPrix
            // 
            LblPrix.AutoSize = true;
            LblPrix.Font = new Font("Roboto", 12F);
            LblPrix.Location = new Point(10, 219);
            LblPrix.Name = "LblPrix";
            LblPrix.Size = new Size(49, 19);
            LblPrix.TabIndex = 5;
            LblPrix.Text = "Solde";
            // 
            // LblCodebat
            // 
            LblCodebat.AutoSize = true;
            LblCodebat.Font = new Font("Roboto", 12F);
            LblCodebat.Location = new Point(347, 159);
            LblCodebat.Name = "LblCodebat";
            LblCodebat.Size = new Size(119, 19);
            LblCodebat.TabIndex = 4;
            LblCodebat.Text = "Montant payé : ";
            // 
            // LblNum
            // 
            LblNum.AutoSize = true;
            LblNum.Font = new Font("Roboto", 12F);
            LblNum.Location = new Point(8, 25);
            LblNum.Name = "LblNum";
            LblNum.Size = new Size(77, 19);
            LblNum.TabIndex = 2;
            LblNum.Text = "Numéro : ";
            // 
            // BtnBatiment
            // 
            BtnBatiment.FlatStyle = FlatStyle.Flat;
            BtnBatiment.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnBatiment.ForeColor = Color.White;
            BtnBatiment.ImageAlign = ContentAlignment.BottomCenter;
            BtnBatiment.Location = new Point(3, 8);
            BtnBatiment.Name = "BtnBatiment";
            BtnBatiment.Size = new Size(180, 45);
            BtnBatiment.TabIndex = 1;
            BtnBatiment.Text = "Frais";
            BtnBatiment.UseVisualStyleBackColor = true;
            BtnBatiment.Click += BtnBatiment_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(2, 195);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(181, 551);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // BtnQuitter
            // 
            BtnQuitter.FlatStyle = FlatStyle.Flat;
            BtnQuitter.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnQuitter.ForeColor = Color.White;
            BtnQuitter.ImageAlign = ContentAlignment.BottomCenter;
            BtnQuitter.Location = new Point(0, 144);
            BtnQuitter.Name = "BtnQuitter";
            BtnQuitter.Size = new Size(183, 45);
            BtnQuitter.TabIndex = 6;
            BtnQuitter.Text = "Quitter";
            BtnQuitter.UseVisualStyleBackColor = true;
            BtnQuitter.Click += BtnQuitter_Click;
            // 
            // PanelMenu
            // 
            PanelMenu.Controls.Add(pictureBox1);
            PanelMenu.Controls.Add(BtnQuitter);
            PanelMenu.Controls.Add(BtnDeconnecter);
            PanelMenu.Controls.Add(BtnDossier);
            PanelMenu.Controls.Add(BtnBatiment);
            PanelMenu.Dock = DockStyle.Left;
            PanelMenu.Location = new Point(0, 0);
            PanelMenu.Name = "PanelMenu";
            PanelMenu.Size = new Size(186, 749);
            PanelMenu.TabIndex = 15;
            // 
            // BtnDeconnecter
            // 
            BtnDeconnecter.FlatStyle = FlatStyle.Flat;
            BtnDeconnecter.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnDeconnecter.ForeColor = Color.White;
            BtnDeconnecter.ImageAlign = ContentAlignment.BottomCenter;
            BtnDeconnecter.Location = new Point(2, 98);
            BtnDeconnecter.Name = "BtnDeconnecter";
            BtnDeconnecter.Size = new Size(181, 45);
            BtnDeconnecter.TabIndex = 5;
            BtnDeconnecter.Text = "Se déconnecter";
            BtnDeconnecter.UseVisualStyleBackColor = true;
            BtnDeconnecter.Click += BtnDeconnecter_Click;
            // 
            // BtnDossier
            // 
            BtnDossier.FlatStyle = FlatStyle.Flat;
            BtnDossier.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnDossier.ForeColor = Color.White;
            BtnDossier.ImageAlign = ContentAlignment.BottomCenter;
            BtnDossier.Location = new Point(3, 53);
            BtnDossier.Name = "BtnDossier";
            BtnDossier.Size = new Size(180, 45);
            BtnDossier.TabIndex = 2;
            BtnDossier.Text = "Dossier Locatif";
            BtnDossier.UseVisualStyleBackColor = true;
            BtnDossier.Click += BtnDossier_Click;
            // 
            // ComboRechercher
            // 
            ComboRechercher.FormattingEnabled = true;
            ComboRechercher.Items.AddRange(new object[] { "Espèce", "Mobile money", "Virement bancaire" });
            ComboRechercher.Location = new Point(1022, 39);
            ComboRechercher.Name = "ComboRechercher";
            ComboRechercher.Size = new Size(319, 23);
            ComboRechercher.TabIndex = 55;
            ComboRechercher.SelectedIndexChanged += ComboRechercher_SelectedIndexChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Roboto", 12F);
            label7.Location = new Point(1022, 17);
            label7.Name = "label7";
            label7.Size = new Size(255, 19);
            label7.TabIndex = 54;
            label7.Text = "Rechercher par le l'ID du locataire : ";
            // 
            // FrmCompteCourant
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1353, 749);
            Controls.Add(ComboRechercher);
            Controls.Add(lblBatiment);
            Controls.Add(label7);
            Controls.Add(groupBox1);
            Controls.Add(PanelMenu);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FrmCompteCourant";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmCompteCourant";
            WindowState = FormWindowState.Maximized;
            Load += FrmCompteCourant_Load;
            ((System.ComponentModel.ISupportInitialize)DGVCompte).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            PanelMenu.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblBatiment;
        private Label label3;
        private ComboBox ComboIDLOc;
        private Label label2;
        private DataGridView DGVCompte;
        private Button BtnSupprimer;
        private GroupBox groupBox1;
        private Label label1;
        private Button BtnModifier;
        private TextBox TxtSolde;
        private TextBox TxtNumero;
        private Button BtnEnregistrer;
        private Label LblPrix;
        private Label LblCodebat;
        private Label LblNum;
        private Button BtnBatiment;
        private PictureBox pictureBox1;
        private Button BtnQuitter;
        private Panel PanelMenu;
        private Button BtnDossier;
        private Button BtnDeconnecter;
        private DateTimePicker DatePaie;
        private Label label4;
        private TextBox TxtMontanntLoyer;
        private ComboBox ComboMois;
        private TextBox TxtMontantPaye;
        private Label lblSolde;
        private TextBox TxtMotif;
        private Label label5;
        private ComboBox ComboTypePaiment;
        private Label label6;
        private ComboBox ComboMatricule;
        private Label label8;
        private TextBox TxtReference;
        private Label label9;
        private ComboBox ComboRechercher;
        private Label label7;
    }
}