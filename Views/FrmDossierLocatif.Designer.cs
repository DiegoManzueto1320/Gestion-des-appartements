namespace GESTAPP.Views
{
    partial class FrmDossierLocatif
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDossierLocatif));
            BtnModifier = new Button();
            BtnSupprimer = new Button();
            DGVDosssier = new DataGridView();
            ComboIDLOc = new ComboBox();
            BtnEnregistrer = new Button();
            CodeNote = new ComboBox();
            ComboMatricule = new ComboBox();
            lblFonction = new Label();
            lblGrade = new Label();
            lblAdresseAgent = new Label();
            lblSexeAgent = new Label();
            TxtNature = new TextBox();
            TxtLibelle = new TextBox();
            TxtCodeDossier = new TextBox();
            lblPrenomAgent = new Label();
            lblPostnomAgent = new Label();
            lblNomAgent = new Label();
            lblBatiment = new Label();
            lblMatricule = new Label();
            pictureBox1 = new PictureBox();
            BtnCompteCourant = new Button();
            groupBox1 = new GroupBox();
            DateDossier = new DateTimePicker();
            ComboCodeContrat = new ComboBox();
            PanelMenu = new Panel();
            BtnQuitter = new Button();
            BtnSeDeconnecter = new Button();
            BtnLocataire = new Button();
            ((System.ComponentModel.ISupportInitialize)DGVDosssier).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            PanelMenu.SuspendLayout();
            SuspendLayout();
            // 
            // BtnModifier
            // 
            BtnModifier.Location = new Point(803, 13);
            BtnModifier.Name = "BtnModifier";
            BtnModifier.Size = new Size(237, 37);
            BtnModifier.TabIndex = 33;
            BtnModifier.Text = "Modifier";
            BtnModifier.UseVisualStyleBackColor = true;
            BtnModifier.Click += BtnModifier_Click;
            // 
            // BtnSupprimer
            // 
            BtnSupprimer.Location = new Point(803, 61);
            BtnSupprimer.Name = "BtnSupprimer";
            BtnSupprimer.Size = new Size(237, 37);
            BtnSupprimer.TabIndex = 19;
            BtnSupprimer.Text = "Supprimer";
            BtnSupprimer.UseVisualStyleBackColor = true;
            BtnSupprimer.Click += BtnSupprimer_Click;
            // 
            // DGVDosssier
            // 
            DGVDosssier.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGVDosssier.Dock = DockStyle.Bottom;
            DGVDosssier.Location = new Point(3, 250);
            DGVDosssier.Name = "DGVDosssier";
            DGVDosssier.Size = new Size(1189, 426);
            DGVDosssier.TabIndex = 32;
            // 
            // ComboIDLOc
            // 
            ComboIDLOc.FormattingEnabled = true;
            ComboIDLOc.Items.AddRange(new object[] { "Masculin", "Feminin" });
            ComboIDLOc.Location = new Point(257, 158);
            ComboIDLOc.Name = "ComboIDLOc";
            ComboIDLOc.Size = new Size(263, 23);
            ComboIDLOc.TabIndex = 9;
            // 
            // BtnEnregistrer
            // 
            BtnEnregistrer.Location = new Point(493, 17);
            BtnEnregistrer.Name = "BtnEnregistrer";
            BtnEnregistrer.Size = new Size(304, 37);
            BtnEnregistrer.TabIndex = 18;
            BtnEnregistrer.Text = "Enregistrer";
            BtnEnregistrer.UseVisualStyleBackColor = true;
            BtnEnregistrer.Click += BtnEnregistrer_Click;
            // 
            // CodeNote
            // 
            CodeNote.FormattingEnabled = true;
            CodeNote.Location = new Point(257, 221);
            CodeNote.Name = "CodeNote";
            CodeNote.Size = new Size(263, 23);
            CodeNote.TabIndex = 10;
            // 
            // ComboMatricule
            // 
            ComboMatricule.FormattingEnabled = true;
            ComboMatricule.Location = new Point(534, 158);
            ComboMatricule.Name = "ComboMatricule";
            ComboMatricule.Size = new Size(263, 23);
            ComboMatricule.TabIndex = 11;
            // 
            // lblFonction
            // 
            lblFonction.AutoSize = true;
            lblFonction.Font = new Font("Roboto", 12F);
            lblFonction.Location = new Point(534, 136);
            lblFonction.Name = "lblFonction";
            lblFonction.Size = new Size(132, 19);
            lblFonction.TabIndex = 13;
            lblFonction.Text = "Matricule Agent : ";
            // 
            // lblGrade
            // 
            lblGrade.AutoSize = true;
            lblGrade.Font = new Font("Roboto", 12F);
            lblGrade.Location = new Point(257, 199);
            lblGrade.Name = "lblGrade";
            lblGrade.Size = new Size(186, 19);
            lblGrade.TabIndex = 12;
            lblGrade.Text = "Code du note de remise : ";
            // 
            // lblAdresseAgent
            // 
            lblAdresseAgent.AutoSize = true;
            lblAdresseAgent.Font = new Font("Roboto", 12F);
            lblAdresseAgent.Location = new Point(11, 192);
            lblAdresseAgent.Name = "lblAdresseAgent";
            lblAdresseAgent.Size = new Size(133, 19);
            lblAdresseAgent.TabIndex = 11;
            lblAdresseAgent.Text = "Code du contrat : ";
            // 
            // lblSexeAgent
            // 
            lblSexeAgent.AutoSize = true;
            lblSexeAgent.Font = new Font("Roboto", 12F);
            lblSexeAgent.Location = new Point(257, 133);
            lblSexeAgent.Name = "lblSexeAgent";
            lblSexeAgent.Size = new Size(123, 19);
            lblSexeAgent.TabIndex = 10;
            lblSexeAgent.Text = "ID du locataire : ";
            // 
            // TxtNature
            // 
            TxtNature.Font = new Font("Roboto", 12F);
            TxtNature.Location = new Point(375, 83);
            TxtNature.Multiline = true;
            TxtNature.Name = "TxtNature";
            TxtNature.Size = new Size(353, 30);
            TxtNature.TabIndex = 8;
            // 
            // TxtLibelle
            // 
            TxtLibelle.Font = new Font("Roboto", 12F);
            TxtLibelle.Location = new Point(11, 83);
            TxtLibelle.Multiline = true;
            TxtLibelle.Name = "TxtLibelle";
            TxtLibelle.Size = new Size(353, 30);
            TxtLibelle.TabIndex = 7;
            // 
            // TxtCodeDossier
            // 
            TxtCodeDossier.Font = new Font("Roboto", 12F);
            TxtCodeDossier.Location = new Point(134, 22);
            TxtCodeDossier.Multiline = true;
            TxtCodeDossier.Name = "TxtCodeDossier";
            TxtCodeDossier.Size = new Size(353, 30);
            TxtCodeDossier.TabIndex = 6;
            TxtCodeDossier.TextChanged += TxtCodeDossier_TextChanged;
            // 
            // lblPrenomAgent
            // 
            lblPrenomAgent.AutoSize = true;
            lblPrenomAgent.Font = new Font("Roboto", 12F);
            lblPrenomAgent.Location = new Point(11, 128);
            lblPrenomAgent.Name = "lblPrenomAgent";
            lblPrenomAgent.Size = new Size(157, 19);
            lblPrenomAgent.TabIndex = 5;
            lblPrenomAgent.Text = "Date de la création  : ";
            // 
            // lblPostnomAgent
            // 
            lblPostnomAgent.AutoSize = true;
            lblPostnomAgent.Font = new Font("Roboto", 12F);
            lblPostnomAgent.Location = new Point(375, 61);
            lblPostnomAgent.Name = "lblPostnomAgent";
            lblPostnomAgent.Size = new Size(68, 19);
            lblPostnomAgent.TabIndex = 4;
            lblPostnomAgent.Text = "Nature : ";
            // 
            // lblNomAgent
            // 
            lblNomAgent.AutoSize = true;
            lblNomAgent.Font = new Font("Roboto", 12F);
            lblNomAgent.Location = new Point(11, 61);
            lblNomAgent.Name = "lblNomAgent";
            lblNomAgent.Size = new Size(67, 19);
            lblNomAgent.TabIndex = 3;
            lblNomAgent.Text = "Libellé : ";
            // 
            // lblBatiment
            // 
            lblBatiment.AutoSize = true;
            lblBatiment.FlatStyle = FlatStyle.Flat;
            lblBatiment.Font = new Font("Roboto", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBatiment.ForeColor = Color.White;
            lblBatiment.Location = new Point(563, 9);
            lblBatiment.Name = "lblBatiment";
            lblBatiment.Size = new Size(167, 23);
            lblBatiment.TabIndex = 7;
            lblBatiment.Text = "DOSSIER LOCATIF";
            // 
            // lblMatricule
            // 
            lblMatricule.AutoSize = true;
            lblMatricule.Font = new Font("Roboto", 12F);
            lblMatricule.Location = new Point(9, 28);
            lblMatricule.Name = "lblMatricule";
            lblMatricule.Size = new Size(134, 19);
            lblMatricule.TabIndex = 2;
            lblMatricule.Text = "Code du dossier : ";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-1, 185);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(170, 561);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // BtnCompteCourant
            // 
            BtnCompteCourant.FlatStyle = FlatStyle.Flat;
            BtnCompteCourant.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnCompteCourant.ForeColor = Color.White;
            BtnCompteCourant.ImageAlign = ContentAlignment.BottomCenter;
            BtnCompteCourant.Location = new Point(3, 45);
            BtnCompteCourant.Name = "BtnCompteCourant";
            BtnCompteCourant.Size = new Size(170, 45);
            BtnCompteCourant.TabIndex = 6;
            BtnCompteCourant.Text = "Compte Courant";
            BtnCompteCourant.UseVisualStyleBackColor = true;
            BtnCompteCourant.Click += BtnCompteCourant_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(DateDossier);
            groupBox1.Controls.Add(ComboCodeContrat);
            groupBox1.Controls.Add(BtnModifier);
            groupBox1.Controls.Add(BtnSupprimer);
            groupBox1.Controls.Add(DGVDosssier);
            groupBox1.Controls.Add(ComboIDLOc);
            groupBox1.Controls.Add(BtnEnregistrer);
            groupBox1.Controls.Add(CodeNote);
            groupBox1.Controls.Add(ComboMatricule);
            groupBox1.Controls.Add(lblFonction);
            groupBox1.Controls.Add(lblGrade);
            groupBox1.Controls.Add(lblAdresseAgent);
            groupBox1.Controls.Add(lblSexeAgent);
            groupBox1.Controls.Add(TxtNature);
            groupBox1.Controls.Add(TxtLibelle);
            groupBox1.Controls.Add(TxtCodeDossier);
            groupBox1.Controls.Add(lblPrenomAgent);
            groupBox1.Controls.Add(lblPostnomAgent);
            groupBox1.Controls.Add(lblNomAgent);
            groupBox1.Controls.Add(lblMatricule);
            groupBox1.Dock = DockStyle.Bottom;
            groupBox1.Location = new Point(175, 70);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1195, 679);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            // 
            // DateDossier
            // 
            DateDossier.CalendarFont = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DateDossier.Format = DateTimePickerFormat.Short;
            DateDossier.Location = new Point(11, 155);
            DateDossier.Name = "DateDossier";
            DateDossier.Size = new Size(212, 23);
            DateDossier.TabIndex = 35;
            // 
            // ComboCodeContrat
            // 
            ComboCodeContrat.FormattingEnabled = true;
            ComboCodeContrat.Location = new Point(11, 221);
            ComboCodeContrat.Name = "ComboCodeContrat";
            ComboCodeContrat.Size = new Size(221, 23);
            ComboCodeContrat.TabIndex = 34;
            // 
            // PanelMenu
            // 
            PanelMenu.Controls.Add(BtnQuitter);
            PanelMenu.Controls.Add(BtnSeDeconnecter);
            PanelMenu.Controls.Add(pictureBox1);
            PanelMenu.Controls.Add(BtnCompteCourant);
            PanelMenu.Controls.Add(BtnLocataire);
            PanelMenu.Dock = DockStyle.Left;
            PanelMenu.Location = new Point(0, 0);
            PanelMenu.Name = "PanelMenu";
            PanelMenu.Size = new Size(175, 749);
            PanelMenu.TabIndex = 5;
            // 
            // BtnQuitter
            // 
            BtnQuitter.FlatStyle = FlatStyle.Flat;
            BtnQuitter.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnQuitter.ForeColor = Color.White;
            BtnQuitter.ImageAlign = ContentAlignment.BottomCenter;
            BtnQuitter.Location = new Point(1, 134);
            BtnQuitter.Name = "BtnQuitter";
            BtnQuitter.Size = new Size(170, 45);
            BtnQuitter.TabIndex = 10;
            BtnQuitter.Text = "Quitter";
            BtnQuitter.UseVisualStyleBackColor = true;
            BtnQuitter.Click += BtnQuitter_Click;
            // 
            // BtnSeDeconnecter
            // 
            BtnSeDeconnecter.FlatStyle = FlatStyle.Flat;
            BtnSeDeconnecter.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnSeDeconnecter.ForeColor = Color.White;
            BtnSeDeconnecter.ImageAlign = ContentAlignment.BottomCenter;
            BtnSeDeconnecter.Location = new Point(3, 89);
            BtnSeDeconnecter.Name = "BtnSeDeconnecter";
            BtnSeDeconnecter.Size = new Size(170, 45);
            BtnSeDeconnecter.TabIndex = 9;
            BtnSeDeconnecter.Text = "Se déconnecter";
            BtnSeDeconnecter.UseVisualStyleBackColor = true;
            BtnSeDeconnecter.Click += BtnSeDeconnecter_Click;
            // 
            // BtnLocataire
            // 
            BtnLocataire.FlatStyle = FlatStyle.Flat;
            BtnLocataire.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnLocataire.ForeColor = Color.White;
            BtnLocataire.ImageAlign = ContentAlignment.BottomCenter;
            BtnLocataire.Location = new Point(3, 3);
            BtnLocataire.Name = "BtnLocataire";
            BtnLocataire.Size = new Size(170, 45);
            BtnLocataire.TabIndex = 3;
            BtnLocataire.Text = "Locataire";
            BtnLocataire.UseVisualStyleBackColor = true;
            BtnLocataire.Click += BtnLocataire_Click;
            // 
            // FrmDossierLocatif
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1370, 749);
            Controls.Add(lblBatiment);
            Controls.Add(groupBox1);
            Controls.Add(PanelMenu);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmDossierLocatif";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmDossierLocatif";
            WindowState = FormWindowState.Maximized;
            Load += FrmDossierLocatif_Load;
            ((System.ComponentModel.ISupportInitialize)DGVDosssier).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            PanelMenu.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnModifier;
        private Button BtnSupprimer;
        private DataGridView DGVDosssier;
        private ComboBox ComboIDLOc;
        private Button BtnEnregistrer;
        private ComboBox CodeNote;
        private ComboBox ComboMatricule;
        private Label lblFonction;
        private Label lblGrade;
        private Label lblAdresseAgent;
        private Label lblSexeAgent;
        private TextBox TxtNature;
        private TextBox TxtLibelle;
        private TextBox TxtCodeDossier;
        private Label lblPrenomAgent;
        private Label lblPostnomAgent;
        private Label lblNomAgent;
        private Label lblBatiment;
        private Label lblMatricule;
        private PictureBox pictureBox1;
        private Button BtnCompteCourant;
        private GroupBox groupBox1;
        private Panel PanelMenu;
        private ComboBox ComboCodeContrat;
        private Button BtnLocataire;
        private Button BtnQuitter;
        private Button BtnSeDeconnecter;
        private DateTimePicker DateDossier;
    }
}