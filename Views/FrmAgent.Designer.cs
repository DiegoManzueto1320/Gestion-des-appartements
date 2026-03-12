namespace GESTAPP
{
    partial class FrmAgent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAgent));
            PanelMenu = new Panel();
            pictureBox1 = new PictureBox();
            BtnCompteCourant = new Button();
            BtnFrais = new Button();
            BtnAgent = new Button();
            BtnLocataire = new Button();
            BtnAppartement = new Button();
            BtnBatiment = new Button();
            TxtPrenomA = new TextBox();
            TxtPostnomA = new TextBox();
            TxtNomAgent = new TextBox();
            TxtMatriculeAgent = new TextBox();
            lblPrenomAgent = new Label();
            lblPostnomAgent = new Label();
            lblNomAgent = new Label();
            lblMatricule = new Label();
            lblBatiment = new Label();
            groupBox1 = new GroupBox();
            BtnModifier = new Button();
            BtnSupprimer = new Button();
            DGVAgent = new DataGridView();
            ComboSexe = new ComboBox();
            BtnEnregistrer = new Button();
            ComboGrade = new ComboBox();
            ComboFonction = new ComboBox();
            TxtAdresse = new TextBox();
            lblFonction = new Label();
            lblGrade = new Label();
            lblAdresseAgent = new Label();
            lblSexeAgent = new Label();
            PanelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DGVAgent).BeginInit();
            SuspendLayout();
            // 
            // PanelMenu
            // 
            PanelMenu.Controls.Add(pictureBox1);
            PanelMenu.Controls.Add(BtnCompteCourant);
            PanelMenu.Controls.Add(BtnFrais);
            PanelMenu.Controls.Add(BtnAgent);
            PanelMenu.Controls.Add(BtnLocataire);
            PanelMenu.Controls.Add(BtnAppartement);
            PanelMenu.Controls.Add(BtnBatiment);
            PanelMenu.Dock = DockStyle.Left;
            PanelMenu.Location = new Point(0, 0);
            PanelMenu.Name = "PanelMenu";
            PanelMenu.Size = new Size(175, 749);
            PanelMenu.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-1, 280);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(170, 466);
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
            BtnCompteCourant.Location = new Point(0, 234);
            BtnCompteCourant.Name = "BtnCompteCourant";
            BtnCompteCourant.Size = new Size(170, 45);
            BtnCompteCourant.TabIndex = 6;
            BtnCompteCourant.Text = "Compte Courant";
            BtnCompteCourant.UseVisualStyleBackColor = true;
            BtnCompteCourant.Click += BtnCompteCourant_Click;
            // 
            // BtnFrais
            // 
            BtnFrais.FlatStyle = FlatStyle.Flat;
            BtnFrais.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnFrais.ForeColor = Color.White;
            BtnFrais.ImageAlign = ContentAlignment.BottomCenter;
            BtnFrais.Location = new Point(2, 189);
            BtnFrais.Name = "BtnFrais";
            BtnFrais.Size = new Size(170, 45);
            BtnFrais.TabIndex = 5;
            BtnFrais.Text = "Frais";
            BtnFrais.UseVisualStyleBackColor = true;
            BtnFrais.Click += BtnFrais_Click;
            // 
            // BtnAgent
            // 
            BtnAgent.FlatStyle = FlatStyle.Flat;
            BtnAgent.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnAgent.ForeColor = Color.White;
            BtnAgent.ImageAlign = ContentAlignment.BottomCenter;
            BtnAgent.Location = new Point(0, 143);
            BtnAgent.Name = "BtnAgent";
            BtnAgent.Size = new Size(170, 45);
            BtnAgent.TabIndex = 4;
            BtnAgent.Text = "Agent";
            BtnAgent.UseVisualStyleBackColor = true;
            BtnAgent.Click += BtnAgent_Click;
            // 
            // BtnLocataire
            // 
            BtnLocataire.FlatStyle = FlatStyle.Flat;
            BtnLocataire.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnLocataire.ForeColor = Color.White;
            BtnLocataire.ImageAlign = ContentAlignment.BottomCenter;
            BtnLocataire.Location = new Point(0, 98);
            BtnLocataire.Name = "BtnLocataire";
            BtnLocataire.Size = new Size(170, 45);
            BtnLocataire.TabIndex = 3;
            BtnLocataire.Text = "Locataire";
            BtnLocataire.UseVisualStyleBackColor = true;
            BtnLocataire.Click += BtnLocataire_Click;
            // 
            // BtnAppartement
            // 
            BtnAppartement.FlatStyle = FlatStyle.Flat;
            BtnAppartement.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnAppartement.ForeColor = Color.White;
            BtnAppartement.ImageAlign = ContentAlignment.BottomCenter;
            BtnAppartement.Location = new Point(3, 53);
            BtnAppartement.Name = "BtnAppartement";
            BtnAppartement.Size = new Size(170, 45);
            BtnAppartement.TabIndex = 2;
            BtnAppartement.Text = "Appartement";
            BtnAppartement.UseVisualStyleBackColor = true;
            BtnAppartement.Click += BtnAppartement_Click;
            // 
            // BtnBatiment
            // 
            BtnBatiment.FlatStyle = FlatStyle.Flat;
            BtnBatiment.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnBatiment.ForeColor = Color.White;
            BtnBatiment.ImageAlign = ContentAlignment.BottomCenter;
            BtnBatiment.Location = new Point(3, 8);
            BtnBatiment.Name = "BtnBatiment";
            BtnBatiment.Size = new Size(170, 45);
            BtnBatiment.TabIndex = 1;
            BtnBatiment.Text = "Batiment";
            BtnBatiment.UseVisualStyleBackColor = true;
            BtnBatiment.Click += BtnBatiment_Click;
            // 
            // TxtPrenomA
            // 
            TxtPrenomA.Font = new Font("Roboto", 12F);
            TxtPrenomA.Location = new Point(11, 141);
            TxtPrenomA.Multiline = true;
            TxtPrenomA.Name = "TxtPrenomA";
            TxtPrenomA.Size = new Size(353, 30);
            TxtPrenomA.TabIndex = 9;
            // 
            // TxtPostnomA
            // 
            TxtPostnomA.Font = new Font("Roboto", 12F);
            TxtPostnomA.Location = new Point(391, 91);
            TxtPostnomA.Multiline = true;
            TxtPostnomA.Name = "TxtPostnomA";
            TxtPostnomA.Size = new Size(353, 30);
            TxtPostnomA.TabIndex = 8;
            // 
            // TxtNomAgent
            // 
            TxtNomAgent.Font = new Font("Roboto", 12F);
            TxtNomAgent.Location = new Point(11, 86);
            TxtNomAgent.Multiline = true;
            TxtNomAgent.Name = "TxtNomAgent";
            TxtNomAgent.Size = new Size(353, 30);
            TxtNomAgent.TabIndex = 7;
            // 
            // TxtMatriculeAgent
            // 
            TxtMatriculeAgent.Font = new Font("Roboto", 12F);
            TxtMatriculeAgent.Location = new Point(104, 16);
            TxtMatriculeAgent.Multiline = true;
            TxtMatriculeAgent.Name = "TxtMatriculeAgent";
            TxtMatriculeAgent.Size = new Size(353, 30);
            TxtMatriculeAgent.TabIndex = 6;
            TxtMatriculeAgent.TextChanged += TxtMatriculeAgent_TextChanged;
            // 
            // lblPrenomAgent
            // 
            lblPrenomAgent.AutoSize = true;
            lblPrenomAgent.Font = new Font("Roboto", 12F);
            lblPrenomAgent.Location = new Point(11, 119);
            lblPrenomAgent.Name = "lblPrenomAgent";
            lblPrenomAgent.Size = new Size(76, 19);
            lblPrenomAgent.TabIndex = 5;
            lblPrenomAgent.Text = "Prénom : ";
            // 
            // lblPostnomAgent
            // 
            lblPostnomAgent.AutoSize = true;
            lblPostnomAgent.Font = new Font("Roboto", 12F);
            lblPostnomAgent.Location = new Point(391, 59);
            lblPostnomAgent.Name = "lblPostnomAgent";
            lblPostnomAgent.Size = new Size(85, 19);
            lblPostnomAgent.TabIndex = 4;
            lblPostnomAgent.Text = "Postnom : ";
            // 
            // lblNomAgent
            // 
            lblNomAgent.AutoSize = true;
            lblNomAgent.Font = new Font("Roboto", 12F);
            lblNomAgent.Location = new Point(11, 59);
            lblNomAgent.Name = "lblNomAgent";
            lblNomAgent.Size = new Size(55, 19);
            lblNomAgent.TabIndex = 3;
            lblNomAgent.Text = "Nom : ";
            // 
            // lblMatricule
            // 
            lblMatricule.AutoSize = true;
            lblMatricule.Font = new Font("Roboto", 12F);
            lblMatricule.Location = new Point(9, 19);
            lblMatricule.Name = "lblMatricule";
            lblMatricule.Size = new Size(87, 19);
            lblMatricule.TabIndex = 2;
            lblMatricule.Text = "Matricule : ";
            // 
            // lblBatiment
            // 
            lblBatiment.AutoSize = true;
            lblBatiment.FlatStyle = FlatStyle.Flat;
            lblBatiment.Font = new Font("Segoe UI", 16, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBatiment.ForeColor = Color.FromArgb(41, 57, 86);
            lblBatiment.Location = new Point(609, 9);
            lblBatiment.Name = "lblBatiment";
            lblBatiment.Size = new Size(120, 30);
            lblBatiment.TabIndex = 4;
            lblBatiment.Text = "👥 AGENT";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(BtnModifier);
            groupBox1.Controls.Add(BtnSupprimer);
            groupBox1.Controls.Add(DGVAgent);
            groupBox1.Controls.Add(ComboSexe);
            groupBox1.Controls.Add(BtnEnregistrer);
            groupBox1.Controls.Add(ComboGrade);
            groupBox1.Controls.Add(ComboFonction);
            groupBox1.Controls.Add(TxtAdresse);
            groupBox1.Controls.Add(lblFonction);
            groupBox1.Controls.Add(lblGrade);
            groupBox1.Controls.Add(lblAdresseAgent);
            groupBox1.Controls.Add(lblSexeAgent);
            groupBox1.Controls.Add(TxtPrenomA);
            groupBox1.Controls.Add(TxtPostnomA);
            groupBox1.Controls.Add(TxtNomAgent);
            groupBox1.Controls.Add(TxtMatriculeAgent);
            groupBox1.Controls.Add(lblPrenomAgent);
            groupBox1.Controls.Add(lblPostnomAgent);
            groupBox1.Controls.Add(lblNomAgent);
            groupBox1.Controls.Add(lblMatricule);
            groupBox1.Dock = DockStyle.Bottom;
            groupBox1.Location = new Point(175, 44);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1176, 705);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            // 
            // BtnModifier
            // 
            BtnModifier.Location = new Point(803, 13);
            BtnModifier.Name = "BtnModifier";
            BtnModifier.Size = new Size(237, 40);
            BtnModifier.TabIndex = 33;
            BtnModifier.Text = "✎ Modifier";
            BtnModifier.UseVisualStyleBackColor = false;
            BtnModifier.Font = new Font("Segoe UI", 11, FontStyle.Bold);
            BtnModifier.Click += BtnModifier_Click_1;
            // 
            // BtnSupprimer
            // 
            BtnSupprimer.Location = new Point(803, 56);
            BtnSupprimer.Name = "BtnSupprimer";
            BtnSupprimer.Size = new Size(237, 40);
            BtnSupprimer.TabIndex = 19;
            BtnSupprimer.Text = "✕ Supprimer";
            BtnSupprimer.UseVisualStyleBackColor = false;
            BtnSupprimer.Font = new Font("Segoe UI", 11, FontStyle.Bold);
            BtnSupprimer.Click += BtnSupprimer_Click;
            // 
            // DGVAgent
            // 
            DGVAgent.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGVAgent.Dock = DockStyle.Bottom;
            DGVAgent.Location = new Point(3, 304);
            DGVAgent.Name = "DGVAgent";
            DGVAgent.Size = new Size(1170, 398);
            DGVAgent.TabIndex = 32;
            DGVAgent.CellClick += DGVAgent_CellClick;
            // 
            // ComboSexe
            // 
            ComboSexe.FormattingEnabled = true;
            ComboSexe.Items.AddRange(new object[] { "Masculin", "Feminin" });
            ComboSexe.Location = new Point(391, 149);
            ComboSexe.Name = "ComboSexe";
            ComboSexe.Size = new Size(263, 23);
            ComboSexe.TabIndex = 9;
            // 
            // BtnEnregistrer
            // 
            BtnEnregistrer.Location = new Point(493, 13);
            BtnEnregistrer.Name = "BtnEnregistrer";
            BtnEnregistrer.Size = new Size(304, 40);
            BtnEnregistrer.TabIndex = 18;
            BtnEnregistrer.Text = "✓ Enregistrer";
            BtnEnregistrer.UseVisualStyleBackColor = false;
            BtnEnregistrer.Font = new Font("Segoe UI", 11, FontStyle.Bold);
            BtnEnregistrer.Click += BtnEnregistrer_Click_1;
            // 
            // ComboGrade
            // 
            ComboGrade.FormattingEnabled = true;
            ComboGrade.Location = new Point(11, 275);
            ComboGrade.Name = "ComboGrade";
            ComboGrade.Size = new Size(263, 23);
            ComboGrade.TabIndex = 10;
            // 
            // ComboFonction
            // 
            ComboFonction.FormattingEnabled = true;
            ComboFonction.Location = new Point(304, 275);
            ComboFonction.Name = "ComboFonction";
            ComboFonction.Size = new Size(263, 23);
            ComboFonction.TabIndex = 11;
            // 
            // TxtAdresse
            // 
            TxtAdresse.Font = new Font("Roboto", 12F);
            TxtAdresse.Location = new Point(11, 211);
            TxtAdresse.Multiline = true;
            TxtAdresse.Name = "TxtAdresse";
            TxtAdresse.Size = new Size(643, 30);
            TxtAdresse.TabIndex = 15;
            // 
            // lblFonction
            // 
            lblFonction.AutoSize = true;
            lblFonction.Font = new Font("Roboto", 12F);
            lblFonction.Location = new Point(304, 253);
            lblFonction.Name = "lblFonction";
            lblFonction.Size = new Size(83, 19);
            lblFonction.TabIndex = 13;
            lblFonction.Text = "Fonction : ";
            // 
            // lblGrade
            // 
            lblGrade.AutoSize = true;
            lblGrade.Font = new Font("Roboto", 12F);
            lblGrade.Location = new Point(11, 253);
            lblGrade.Name = "lblGrade";
            lblGrade.Size = new Size(63, 19);
            lblGrade.TabIndex = 12;
            lblGrade.Text = "Grade : ";
            // 
            // lblAdresseAgent
            // 
            lblAdresseAgent.AutoSize = true;
            lblAdresseAgent.Font = new Font("Roboto", 12F);
            lblAdresseAgent.Location = new Point(11, 183);
            lblAdresseAgent.Name = "lblAdresseAgent";
            lblAdresseAgent.Size = new Size(77, 19);
            lblAdresseAgent.TabIndex = 11;
            lblAdresseAgent.Text = "Adresse : ";
            // 
            // lblSexeAgent
            // 
            lblSexeAgent.AutoSize = true;
            lblSexeAgent.Font = new Font("Roboto", 12F);
            lblSexeAgent.Location = new Point(391, 124);
            lblSexeAgent.Name = "lblSexeAgent";
            lblSexeAgent.Size = new Size(51, 19);
            lblSexeAgent.TabIndex = 10;
            lblSexeAgent.Text = "Sexe :";
            // 
            // FrmAgent
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1351, 749);
            Controls.Add(lblBatiment);
            Controls.Add(groupBox1);
            Controls.Add(PanelMenu);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmAgent";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmAgent";
            Load += FrmAgent_Load;
            PanelMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DGVAgent).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel PanelMenu;
        private Button BtnCompteCourant;
        private Button BtnFrais;
        private Button BtnAgent;
        private Button BtnLocataire;
        private Button BtnAppartement;
        private Button BtnBatiment;
        private TextBox TxtPrenomA;
        private TextBox TxtPostnomA;
        private TextBox TxtNomAgent;
        private TextBox TxtMatriculeAgent;
        private Label lblPrenomAgent;
        private Label lblPostnomAgent;
        private Label lblNomAgent;
        private Label lblMatricule;
        private Label lblBatiment;
        private GroupBox groupBox1;
        private TextBox TxtAdresse;
        private Label lblFonction;
        private Label lblGrade;
        private Label lblAdresseAgent;
        private Label lblSexeAgent;
        private ComboBox ComboSexe;
        private ComboBox ComboGrade;
        private ComboBox ComboFonction;
        private PictureBox pictureBox1;
        private Button BtnSupprimer;
        private Button BtnEnregistrer;
        private DataGridView DGVAgent;
        private Button BtnModifier;
    }
}