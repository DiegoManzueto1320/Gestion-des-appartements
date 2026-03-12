namespace GESTAPP
{
    partial class FrmLocataire
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLocataire));
            PanelMenu = new Panel();
            pictureBox1 = new PictureBox();
            BtnCederLogement = new Button();
            BtnComptcourant = new Button();
            BtnOccuperAppartement = new Button();
            BtnDoossierLocatif = new Button();
            BtnLocataire = new Button();
            lblBatiment = new Label();
            groupBox1 = new GroupBox();
            DGVLocataire = new DataGridView();
            ComboEtat = new ComboBox();
            TxtAge = new TextBox();
            DateNaissanceLoc = new DateTimePicker();
            ComboMatricule = new ComboBox();
            label5 = new Label();
            TxtTelephone = new TextBox();
            TxtEmail = new TextBox();
            TxtProfession = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            BtnModiifier = new Button();
            BtnSupprimer = new Button();
            ComboSexeLoc = new ComboBox();
            TxtLieuNaissanceLoc = new TextBox();
            lblFonction = new Label();
            lblGrade = new Label();
            lblAdresseAgent = new Label();
            lblSexeAgent = new Label();
            TxtPrenomLoc = new TextBox();
            TxtPostnomLoc = new TextBox();
            TxtNomLoc = new TextBox();
            TxtIDLoc = new TextBox();
            BtnEnregistrer = new Button();
            lblPrenomAgent = new Label();
            lblPostnomAgent = new Label();
            lblNomAgent = new Label();
            lblMatricule = new Label();
            PanelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DGVLocataire).BeginInit();
            SuspendLayout();
            // 
            // PanelMenu
            // 
            PanelMenu.Controls.Add(pictureBox1);
            PanelMenu.Controls.Add(BtnCederLogement);
            PanelMenu.Controls.Add(BtnComptcourant);
            PanelMenu.Controls.Add(BtnOccuperAppartement);
            PanelMenu.Controls.Add(BtnDoossierLocatif);
            PanelMenu.Controls.Add(BtnLocataire);
            PanelMenu.Dock = DockStyle.Left;
            PanelMenu.Location = new Point(0, 0);
            PanelMenu.Name = "PanelMenu";
            PanelMenu.Size = new Size(196, 749);
            PanelMenu.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(4, 225);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(186, 516);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // BtnCederLogement
            // 
            BtnCederLogement.FlatStyle = FlatStyle.Flat;
            BtnCederLogement.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnCederLogement.ForeColor = Color.White;
            BtnCederLogement.ImageAlign = ContentAlignment.BottomCenter;
            BtnCederLogement.Location = new Point(4, 180);
            BtnCederLogement.Name = "BtnCederLogement";
            BtnCederLogement.Size = new Size(190, 45);
            BtnCederLogement.TabIndex = 9;
            BtnCederLogement.Text = "Céder Appartement";
            BtnCederLogement.UseVisualStyleBackColor = true;
            // 
            // BtnComptcourant
            // 
            BtnComptcourant.FlatStyle = FlatStyle.Flat;
            BtnComptcourant.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnComptcourant.ForeColor = Color.White;
            BtnComptcourant.ImageAlign = ContentAlignment.BottomCenter;
            BtnComptcourant.Location = new Point(3, 91);
            BtnComptcourant.Name = "BtnComptcourant";
            BtnComptcourant.Size = new Size(190, 45);
            BtnComptcourant.TabIndex = 8;
            BtnComptcourant.Text = "Compte Courant";
            BtnComptcourant.UseVisualStyleBackColor = true;
            BtnComptcourant.Click += BtnComptcourant_Click;
            // 
            // BtnOccuperAppartement
            // 
            BtnOccuperAppartement.FlatStyle = FlatStyle.Flat;
            BtnOccuperAppartement.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnOccuperAppartement.ForeColor = Color.White;
            BtnOccuperAppartement.ImageAlign = ContentAlignment.BottomCenter;
            BtnOccuperAppartement.Location = new Point(3, 134);
            BtnOccuperAppartement.Name = "BtnOccuperAppartement";
            BtnOccuperAppartement.Size = new Size(190, 45);
            BtnOccuperAppartement.TabIndex = 7;
            BtnOccuperAppartement.Text = "Occuper Appartement";
            BtnOccuperAppartement.UseVisualStyleBackColor = true;
            BtnOccuperAppartement.Click += BtnOccuperAppartement_Click;
            // 
            // BtnDoossierLocatif
            // 
            BtnDoossierLocatif.FlatStyle = FlatStyle.Flat;
            BtnDoossierLocatif.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnDoossierLocatif.ForeColor = Color.White;
            BtnDoossierLocatif.ImageAlign = ContentAlignment.BottomCenter;
            BtnDoossierLocatif.Location = new Point(3, 47);
            BtnDoossierLocatif.Name = "BtnDoossierLocatif";
            BtnDoossierLocatif.Size = new Size(190, 45);
            BtnDoossierLocatif.TabIndex = 6;
            BtnDoossierLocatif.Text = "Dossier locatif";
            BtnDoossierLocatif.UseVisualStyleBackColor = true;
            BtnDoossierLocatif.Click += BtnDoossierLocatif_Click;
            // 
            // BtnLocataire
            // 
            BtnLocataire.FlatStyle = FlatStyle.Flat;
            BtnLocataire.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnLocataire.ForeColor = Color.White;
            BtnLocataire.ImageAlign = ContentAlignment.BottomCenter;
            BtnLocataire.Location = new Point(3, 3);
            BtnLocataire.Name = "BtnLocataire";
            BtnLocataire.Size = new Size(190, 45);
            BtnLocataire.TabIndex = 3;
            BtnLocataire.Text = "Locataire";
            BtnLocataire.UseVisualStyleBackColor = true;
            BtnLocataire.Click += BtnLocataire_Click_1;
            // 
            // lblBatiment
            // 
            lblBatiment.AutoSize = true;
            lblBatiment.FlatStyle = FlatStyle.Flat;
            lblBatiment.Font = new Font("Roboto", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBatiment.Location = new Point(660, 25);
            lblBatiment.Name = "lblBatiment";
            lblBatiment.Size = new Size(109, 23);
            lblBatiment.TabIndex = 7;
            lblBatiment.Text = "LOCATAIRE";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(DGVLocataire);
            groupBox1.Controls.Add(ComboEtat);
            groupBox1.Controls.Add(TxtAge);
            groupBox1.Controls.Add(DateNaissanceLoc);
            groupBox1.Controls.Add(ComboMatricule);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(TxtTelephone);
            groupBox1.Controls.Add(TxtEmail);
            groupBox1.Controls.Add(TxtProfession);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(BtnModiifier);
            groupBox1.Controls.Add(BtnSupprimer);
            groupBox1.Controls.Add(ComboSexeLoc);
            groupBox1.Controls.Add(TxtLieuNaissanceLoc);
            groupBox1.Controls.Add(lblFonction);
            groupBox1.Controls.Add(lblGrade);
            groupBox1.Controls.Add(lblAdresseAgent);
            groupBox1.Controls.Add(lblSexeAgent);
            groupBox1.Controls.Add(TxtPrenomLoc);
            groupBox1.Controls.Add(TxtPostnomLoc);
            groupBox1.Controls.Add(TxtNomLoc);
            groupBox1.Controls.Add(TxtIDLoc);
            groupBox1.Controls.Add(BtnEnregistrer);
            groupBox1.Controls.Add(lblPrenomAgent);
            groupBox1.Controls.Add(lblPostnomAgent);
            groupBox1.Controls.Add(lblNomAgent);
            groupBox1.Controls.Add(lblMatricule);
            groupBox1.Dock = DockStyle.Bottom;
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(196, 53);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1057, 696);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            // 
            // DGVLocataire
            // 
            DGVLocataire.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGVLocataire.Dock = DockStyle.Bottom;
            DGVLocataire.Location = new Point(3, 392);
            DGVLocataire.Name = "DGVLocataire";
            DGVLocataire.Size = new Size(1051, 301);
            DGVLocataire.TabIndex = 31;
            DGVLocataire.CellContentClick += DGVLocataire_CellContentClick;
            // 
            // ComboEtat
            // 
            ComboEtat.FormattingEnabled = true;
            ComboEtat.Items.AddRange(new object[] { "Marié", "Cellibataire", "Divorcé", "Veuf", "Veuve" });
            ComboEtat.Location = new Point(499, 219);
            ComboEtat.Name = "ComboEtat";
            ComboEtat.Size = new Size(243, 23);
            ComboEtat.TabIndex = 30;
            // 
            // TxtAge
            // 
            TxtAge.Font = new Font("Roboto", 12F);
            TxtAge.Location = new Point(68, 232);
            TxtAge.Multiline = true;
            TxtAge.Name = "TxtAge";
            TxtAge.Size = new Size(220, 30);
            TxtAge.TabIndex = 29;
            // 
            // DateNaissanceLoc
            // 
            DateNaissanceLoc.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DateNaissanceLoc.Format = DateTimePickerFormat.Short;
            DateNaissanceLoc.Location = new Point(405, 172);
            DateNaissanceLoc.Name = "DateNaissanceLoc";
            DateNaissanceLoc.Size = new Size(274, 27);
            DateNaissanceLoc.TabIndex = 28;
            // 
            // ComboMatricule
            // 
            ComboMatricule.FormattingEnabled = true;
            ComboMatricule.Location = new Point(405, 356);
            ComboMatricule.Name = "ComboMatricule";
            ComboMatricule.Size = new Size(353, 23);
            ComboMatricule.TabIndex = 26;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Roboto", 12F);
            label5.ForeColor = Color.White;
            label5.Location = new Point(405, 334);
            label5.Name = "label5";
            label5.Size = new Size(131, 19);
            label5.TabIndex = 27;
            label5.Text = "Matricule agent : ";
            // 
            // TxtTelephone
            // 
            TxtTelephone.Font = new Font("Roboto", 12F);
            TxtTelephone.Location = new Point(405, 288);
            TxtTelephone.Multiline = true;
            TxtTelephone.Name = "TxtTelephone";
            TxtTelephone.Size = new Size(353, 30);
            TxtTelephone.TabIndex = 25;
            // 
            // TxtEmail
            // 
            TxtEmail.Font = new Font("Roboto", 12F);
            TxtEmail.Location = new Point(14, 356);
            TxtEmail.Multiline = true;
            TxtEmail.Name = "TxtEmail";
            TxtEmail.Size = new Size(353, 30);
            TxtEmail.TabIndex = 24;
            // 
            // TxtProfession
            // 
            TxtProfession.Font = new Font("Roboto", 12F);
            TxtProfession.Location = new Point(14, 288);
            TxtProfession.Multiline = true;
            TxtProfession.Name = "TxtProfession";
            TxtProfession.Size = new Size(350, 30);
            TxtProfession.TabIndex = 23;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Roboto", 12F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(403, 266);
            label1.Name = "label1";
            label1.Size = new Size(94, 19);
            label1.TabIndex = 21;
            label1.Text = "Télephone : ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Roboto", 12F);
            label2.ForeColor = Color.White;
            label2.Location = new Point(14, 334);
            label2.Name = "label2";
            label2.Size = new Size(61, 19);
            label2.TabIndex = 20;
            label2.Text = "Email : ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Roboto", 12F);
            label3.ForeColor = Color.White;
            label3.Location = new Point(11, 266);
            label3.Name = "label3";
            label3.Size = new Size(97, 19);
            label3.TabIndex = 19;
            label3.Text = "Profession : ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Roboto", 12F);
            label4.ForeColor = Color.White;
            label4.Location = new Point(401, 223);
            label4.Name = "label4";
            label4.Size = new Size(81, 19);
            label4.TabIndex = 18;
            label4.Text = "Etat-civil : ";
            // 
            // BtnModiifier
            // 
            BtnModiifier.Location = new Point(808, 74);
            BtnModiifier.Name = "BtnModiifier";
            BtnModiifier.Size = new Size(237, 37);
            BtnModiifier.TabIndex = 17;
            BtnModiifier.Text = "Modifier";
            BtnModiifier.UseVisualStyleBackColor = true;
            BtnModiifier.Click += BtnModiifier_Click;
            // 
            // BtnSupprimer
            // 
            BtnSupprimer.Location = new Point(808, 122);
            BtnSupprimer.Name = "BtnSupprimer";
            BtnSupprimer.Size = new Size(237, 37);
            BtnSupprimer.TabIndex = 16;
            BtnSupprimer.Text = "Supprimer";
            BtnSupprimer.UseVisualStyleBackColor = true;
            BtnSupprimer.Click += BtnSupprimer_Click;
            // 
            // ComboSexeLoc
            // 
            ComboSexeLoc.FormattingEnabled = true;
            ComboSexeLoc.Items.AddRange(new object[] { "Masculin", "Feminin" });
            ComboSexeLoc.Location = new Point(68, 136);
            ComboSexeLoc.Name = "ComboSexeLoc";
            ComboSexeLoc.Size = new Size(216, 23);
            ComboSexeLoc.TabIndex = 9;
            // 
            // TxtLieuNaissanceLoc
            // 
            TxtLieuNaissanceLoc.Font = new Font("Roboto", 12F);
            TxtLieuNaissanceLoc.Location = new Point(14, 196);
            TxtLieuNaissanceLoc.Multiline = true;
            TxtLieuNaissanceLoc.Name = "TxtLieuNaissanceLoc";
            TxtLieuNaissanceLoc.Size = new Size(353, 30);
            TxtLieuNaissanceLoc.TabIndex = 15;
            // 
            // lblFonction
            // 
            lblFonction.AutoSize = true;
            lblFonction.Font = new Font("Roboto", 12F);
            lblFonction.ForeColor = Color.White;
            lblFonction.Location = new Point(11, 236);
            lblFonction.Name = "lblFonction";
            lblFonction.Size = new Size(48, 19);
            lblFonction.TabIndex = 13;
            lblFonction.Text = "Age : ";
            // 
            // lblGrade
            // 
            lblGrade.AutoSize = true;
            lblGrade.Font = new Font("Roboto", 12F);
            lblGrade.ForeColor = Color.White;
            lblGrade.Location = new Point(405, 143);
            lblGrade.Name = "lblGrade";
            lblGrade.Size = new Size(151, 19);
            lblGrade.TabIndex = 12;
            lblGrade.Text = "Date de naissance : ";
            // 
            // lblAdresseAgent
            // 
            lblAdresseAgent.AutoSize = true;
            lblAdresseAgent.Font = new Font("Roboto", 12F);
            lblAdresseAgent.ForeColor = Color.White;
            lblAdresseAgent.Location = new Point(10, 174);
            lblAdresseAgent.Name = "lblAdresseAgent";
            lblAdresseAgent.Size = new Size(148, 19);
            lblAdresseAgent.TabIndex = 11;
            lblAdresseAgent.Text = "Lieu de naissance : ";
            // 
            // lblSexeAgent
            // 
            lblSexeAgent.AutoSize = true;
            lblSexeAgent.Font = new Font("Roboto", 12F);
            lblSexeAgent.ForeColor = Color.White;
            lblSexeAgent.Location = new Point(11, 140);
            lblSexeAgent.Name = "lblSexeAgent";
            lblSexeAgent.Size = new Size(51, 19);
            lblSexeAgent.TabIndex = 10;
            lblSexeAgent.Text = "Sexe :";
            // 
            // TxtPrenomLoc
            // 
            TxtPrenomLoc.Font = new Font("Roboto", 12F);
            TxtPrenomLoc.Location = new Point(401, 96);
            TxtPrenomLoc.Multiline = true;
            TxtPrenomLoc.Name = "TxtPrenomLoc";
            TxtPrenomLoc.Size = new Size(341, 30);
            TxtPrenomLoc.TabIndex = 9;
            // 
            // TxtPostnomLoc
            // 
            TxtPostnomLoc.Font = new Font("Roboto", 12F);
            TxtPostnomLoc.Location = new Point(11, 96);
            TxtPostnomLoc.Multiline = true;
            TxtPostnomLoc.Name = "TxtPostnomLoc";
            TxtPostnomLoc.Size = new Size(277, 30);
            TxtPostnomLoc.TabIndex = 8;
            // 
            // TxtNomLoc
            // 
            TxtNomLoc.Font = new Font("Roboto", 12F);
            TxtNomLoc.Location = new Point(402, 35);
            TxtNomLoc.Multiline = true;
            TxtNomLoc.Name = "TxtNomLoc";
            TxtNomLoc.Size = new Size(341, 30);
            TxtNomLoc.TabIndex = 7;
            // 
            // TxtIDLoc
            // 
            TxtIDLoc.Font = new Font("Roboto", 12F);
            TxtIDLoc.Location = new Point(11, 38);
            TxtIDLoc.Multiline = true;
            TxtIDLoc.Name = "TxtIDLoc";
            TxtIDLoc.Size = new Size(273, 30);
            TxtIDLoc.TabIndex = 6;
            TxtIDLoc.TextChanged += TxtIDLoc_TextChanged;
            // 
            // BtnEnregistrer
            // 
            BtnEnregistrer.Location = new Point(808, 22);
            BtnEnregistrer.Name = "BtnEnregistrer";
            BtnEnregistrer.Size = new Size(237, 37);
            BtnEnregistrer.TabIndex = 3;
            BtnEnregistrer.Text = "Enregistrer";
            BtnEnregistrer.UseVisualStyleBackColor = true;
            BtnEnregistrer.Click += BtnEnregistrer_Click;
            // 
            // lblPrenomAgent
            // 
            lblPrenomAgent.AutoSize = true;
            lblPrenomAgent.Font = new Font("Roboto", 12F);
            lblPrenomAgent.ForeColor = Color.White;
            lblPrenomAgent.Location = new Point(405, 74);
            lblPrenomAgent.Name = "lblPrenomAgent";
            lblPrenomAgent.Size = new Size(76, 19);
            lblPrenomAgent.TabIndex = 5;
            lblPrenomAgent.Text = "Prénom : ";
            // 
            // lblPostnomAgent
            // 
            lblPostnomAgent.AutoSize = true;
            lblPostnomAgent.Font = new Font("Roboto", 12F);
            lblPostnomAgent.ForeColor = Color.White;
            lblPostnomAgent.Location = new Point(8, 74);
            lblPostnomAgent.Name = "lblPostnomAgent";
            lblPostnomAgent.Size = new Size(85, 19);
            lblPostnomAgent.TabIndex = 4;
            lblPostnomAgent.Text = "Postnom : ";
            // 
            // lblNomAgent
            // 
            lblNomAgent.AutoSize = true;
            lblNomAgent.Font = new Font("Roboto", 12F);
            lblNomAgent.ForeColor = Color.White;
            lblNomAgent.Location = new Point(402, 13);
            lblNomAgent.Name = "lblNomAgent";
            lblNomAgent.Size = new Size(55, 19);
            lblNomAgent.TabIndex = 3;
            lblNomAgent.Text = "Nom : ";
            // 
            // lblMatricule
            // 
            lblMatricule.AutoSize = true;
            lblMatricule.Font = new Font("Roboto", 12F);
            lblMatricule.ForeColor = Color.White;
            lblMatricule.Location = new Point(11, 19);
            lblMatricule.Name = "lblMatricule";
            lblMatricule.Size = new Size(36, 19);
            lblMatricule.TabIndex = 2;
            lblMatricule.Text = "ID : ";
            // 
            // FrmLocataire
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1253, 749);
            Controls.Add(lblBatiment);
            Controls.Add(groupBox1);
            Controls.Add(PanelMenu);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmLocataire";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmLocataire";
            WindowState = FormWindowState.Maximized;
            Load += FrmLocataire_Load;
            PanelMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DGVLocataire).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel PanelMenu;
        private Button BtnDoossierLocatif;
        private Button BtnLocataire;
        private Button BtnCederLogement;
        private Button BtnComptcourant;
        private Button BtnOccuperAppartement;
        private PictureBox pictureBox1;
        private Label lblBatiment;
        private GroupBox groupBox1;
        private Button BtnModiifier;
        private Button BtnSupprimer;
        private ComboBox ComboSexeLoc;
        private TextBox TxtLieuNaissanceLoc;
        private Label lblFonction;
        private Label lblAdresseAgent;
        private Label lblSexeAgent;
        private TextBox TxtPrenomLoc;
        private TextBox TxtPostnomLoc;
        private TextBox TxtNomLoc;
        private TextBox TxtIDLoc;
        private Button BtnEnregistrer;
        private Label lblPrenomAgent;
        private Label lblPostnomAgent;
        private Label lblNomAgent;
        private Label lblMatricule;
        private TextBox TxtTelephone;
        private TextBox TxtEmail;
        private TextBox TxtProfession;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label lblGrade;
        private TextBox TxtAge;
        private DateTimePicker DateNaissanceLoc;
        private ComboBox ComboMatricule;
        private Label label5;
        private ComboBox ComboEtat;
        private DataGridView DGVLocataire;
    }
}