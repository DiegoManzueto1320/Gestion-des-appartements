namespace GESTAPP
{
    partial class FrmMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenu));
            PanelMenu = new Panel();
            pictureBox1 = new PictureBox();
            BtnCompteCourant = new Button();
            BtnFrais = new Button();
            BtnBatiment = new Button();
            BtnAppartement = new Button();
            BtnCmptecourant = new Button();
            BtnLocataire = new Button();
            BtnDemande = new Button();
            BtnDossier = new Button();
            BtnGrade = new Button();
            BtnFonction = new Button();
            BtnOccuperAppartement = new Button();
            BtnNotedeRemise = new Button();
            label1 = new Label();
            BtnContrat = new Button();
            PanelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // PanelMenu
            // 
            PanelMenu.Controls.Add(pictureBox1);
            PanelMenu.Controls.Add(BtnCompteCourant);
            PanelMenu.Controls.Add(BtnFrais);
            PanelMenu.Dock = DockStyle.Left;
            PanelMenu.Location = new Point(0, 0);
            PanelMenu.Name = "PanelMenu";
            PanelMenu.Size = new Size(175, 749);
            PanelMenu.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 100);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(170, 646);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // BtnCompteCourant
            // 
            BtnCompteCourant.FlatStyle = FlatStyle.Flat;
            BtnCompteCourant.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnCompteCourant.ForeColor = Color.White;
            BtnCompteCourant.ImageAlign = ContentAlignment.BottomCenter;
            BtnCompteCourant.Location = new Point(3, 51);
            BtnCompteCourant.Name = "BtnCompteCourant";
            BtnCompteCourant.Size = new Size(170, 45);
            BtnCompteCourant.TabIndex = 6;
            BtnCompteCourant.Text = "Quitter";
            BtnCompteCourant.UseVisualStyleBackColor = true;
            BtnCompteCourant.Click += BtnCompteCourant_Click;
            // 
            // BtnFrais
            // 
            BtnFrais.FlatStyle = FlatStyle.Flat;
            BtnFrais.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnFrais.ForeColor = Color.White;
            BtnFrais.ImageAlign = ContentAlignment.BottomCenter;
            BtnFrais.Location = new Point(2, 4);
            BtnFrais.Name = "BtnFrais";
            BtnFrais.Size = new Size(170, 45);
            BtnFrais.TabIndex = 5;
            BtnFrais.Text = "Se décoonnecter";
            BtnFrais.UseVisualStyleBackColor = true;
            BtnFrais.Click += BtnFrais_Click;
            // 
            // BtnBatiment
            // 
            BtnBatiment.Image = (Image)resources.GetObject("BtnBatiment.Image");
            BtnBatiment.ImageAlign = ContentAlignment.TopLeft;
            BtnBatiment.Location = new Point(176, 78);
            BtnBatiment.Name = "BtnBatiment";
            BtnBatiment.Size = new Size(467, 86);
            BtnBatiment.TabIndex = 2;
            BtnBatiment.Text = "BATIMENT ";
            BtnBatiment.TextAlign = ContentAlignment.MiddleRight;
            BtnBatiment.UseVisualStyleBackColor = true;
            BtnBatiment.Click += BtnBatiment_Click_1;
            // 
            // BtnAppartement
            // 
            BtnAppartement.Image = (Image)resources.GetObject("BtnAppartement.Image");
            BtnAppartement.ImageAlign = ContentAlignment.MiddleLeft;
            BtnAppartement.Location = new Point(722, 78);
            BtnAppartement.Name = "BtnAppartement";
            BtnAppartement.Size = new Size(467, 86);
            BtnAppartement.TabIndex = 3;
            BtnAppartement.Text = "APPARTEMENT";
            BtnAppartement.TextAlign = ContentAlignment.MiddleRight;
            BtnAppartement.UseVisualStyleBackColor = true;
            BtnAppartement.Click += BtnAppartement_Click_1;
            // 
            // BtnCmptecourant
            // 
            BtnCmptecourant.Image = (Image)resources.GetObject("BtnCmptecourant.Image");
            BtnCmptecourant.ImageAlign = ContentAlignment.MiddleLeft;
            BtnCmptecourant.Location = new Point(722, 176);
            BtnCmptecourant.Name = "BtnCmptecourant";
            BtnCmptecourant.Size = new Size(467, 86);
            BtnCmptecourant.TabIndex = 5;
            BtnCmptecourant.Text = "COMPTE COURANT";
            BtnCmptecourant.TextAlign = ContentAlignment.MiddleRight;
            BtnCmptecourant.UseVisualStyleBackColor = true;
            BtnCmptecourant.Click += BtnCmptecourant_Click;
            // 
            // BtnLocataire
            // 
            BtnLocataire.Image = (Image)resources.GetObject("BtnLocataire.Image");
            BtnLocataire.ImageAlign = ContentAlignment.MiddleLeft;
            BtnLocataire.Location = new Point(176, 176);
            BtnLocataire.Name = "BtnLocataire";
            BtnLocataire.Size = new Size(467, 86);
            BtnLocataire.TabIndex = 4;
            BtnLocataire.Text = "LOCATAIRE";
            BtnLocataire.TextAlign = ContentAlignment.MiddleRight;
            BtnLocataire.UseVisualStyleBackColor = true;
            BtnLocataire.Click += BtnLocataire_Click_1;
            // 
            // BtnDemande
            // 
            BtnDemande.Image = (Image)resources.GetObject("BtnDemande.Image");
            BtnDemande.ImageAlign = ContentAlignment.MiddleLeft;
            BtnDemande.Location = new Point(722, 285);
            BtnDemande.Name = "BtnDemande";
            BtnDemande.Size = new Size(467, 86);
            BtnDemande.TabIndex = 7;
            BtnDemande.Text = "DEMANDE DE LOCATION";
            BtnDemande.TextAlign = ContentAlignment.MiddleRight;
            BtnDemande.UseVisualStyleBackColor = true;
            BtnDemande.Click += BtnDemande_Click;
            // 
            // BtnDossier
            // 
            BtnDossier.Image = (Image)resources.GetObject("BtnDossier.Image");
            BtnDossier.ImageAlign = ContentAlignment.MiddleLeft;
            BtnDossier.Location = new Point(176, 285);
            BtnDossier.Name = "BtnDossier";
            BtnDossier.Size = new Size(467, 86);
            BtnDossier.TabIndex = 6;
            BtnDossier.Text = "DOSSIER LOCATIF";
            BtnDossier.TextAlign = ContentAlignment.MiddleRight;
            BtnDossier.UseVisualStyleBackColor = true;
            BtnDossier.Click += BtnDossier_Click;
            // 
            // BtnGrade
            // 
            BtnGrade.Image = (Image)resources.GetObject("BtnGrade.Image");
            BtnGrade.ImageAlign = ContentAlignment.MiddleLeft;
            BtnGrade.Location = new Point(722, 399);
            BtnGrade.Name = "BtnGrade";
            BtnGrade.Size = new Size(467, 86);
            BtnGrade.TabIndex = 9;
            BtnGrade.Text = "GRADE";
            BtnGrade.TextAlign = ContentAlignment.MiddleRight;
            BtnGrade.UseVisualStyleBackColor = true;
            BtnGrade.Click += BtnGrade_Click;
            // 
            // BtnFonction
            // 
            BtnFonction.Image = (Image)resources.GetObject("BtnFonction.Image");
            BtnFonction.ImageAlign = ContentAlignment.MiddleLeft;
            BtnFonction.Location = new Point(176, 502);
            BtnFonction.Name = "BtnFonction";
            BtnFonction.Size = new Size(467, 86);
            BtnFonction.TabIndex = 8;
            BtnFonction.Text = "FONCTION";
            BtnFonction.TextAlign = ContentAlignment.MiddleRight;
            BtnFonction.UseVisualStyleBackColor = true;
            BtnFonction.Click += BtnFonction_Click;
            // 
            // BtnOccuperAppartement
            // 
            BtnOccuperAppartement.Image = (Image)resources.GetObject("BtnOccuperAppartement.Image");
            BtnOccuperAppartement.ImageAlign = ContentAlignment.TopLeft;
            BtnOccuperAppartement.Location = new Point(722, 502);
            BtnOccuperAppartement.Name = "BtnOccuperAppartement";
            BtnOccuperAppartement.Size = new Size(467, 86);
            BtnOccuperAppartement.TabIndex = 11;
            BtnOccuperAppartement.Text = "OCCUPER APPARTEMENT";
            BtnOccuperAppartement.TextAlign = ContentAlignment.MiddleRight;
            BtnOccuperAppartement.UseVisualStyleBackColor = true;
            BtnOccuperAppartement.Click += BtnOccuperAppartement_Click;
            // 
            // BtnNotedeRemise
            // 
            BtnNotedeRemise.Image = (Image)resources.GetObject("BtnNotedeRemise.Image");
            BtnNotedeRemise.ImageAlign = ContentAlignment.MiddleLeft;
            BtnNotedeRemise.Location = new Point(176, 609);
            BtnNotedeRemise.Name = "BtnNotedeRemise";
            BtnNotedeRemise.Size = new Size(467, 86);
            BtnNotedeRemise.TabIndex = 10;
            BtnNotedeRemise.Text = "NOTE DE REMISE";
            BtnNotedeRemise.TextAlign = ContentAlignment.MiddleRight;
            BtnNotedeRemise.UseVisualStyleBackColor = true;
            BtnNotedeRemise.Click += BtnNotedeRemise_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(510, 25);
            label1.Name = "label1";
            label1.Size = new Size(304, 39);
            label1.TabIndex = 12;
            label1.Text = "GESTION DU SYSTEME ";
            // 
            // BtnContrat
            // 
            BtnContrat.Image = (Image)resources.GetObject("BtnContrat.Image");
            BtnContrat.ImageAlign = ContentAlignment.MiddleLeft;
            BtnContrat.Location = new Point(176, 399);
            BtnContrat.Name = "BtnContrat";
            BtnContrat.Size = new Size(467, 86);
            BtnContrat.TabIndex = 13;
            BtnContrat.Text = "CONTRAT DE BAIL";
            BtnContrat.TextAlign = ContentAlignment.MiddleRight;
            BtnContrat.UseVisualStyleBackColor = true;
            BtnContrat.Click += BtnContrat_Click;
            // 
            // FrmMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1370, 749);
            Controls.Add(BtnContrat);
            Controls.Add(label1);
            Controls.Add(BtnOccuperAppartement);
            Controls.Add(BtnNotedeRemise);
            Controls.Add(BtnGrade);
            Controls.Add(BtnFonction);
            Controls.Add(BtnDemande);
            Controls.Add(BtnDossier);
            Controls.Add(BtnCmptecourant);
            Controls.Add(BtnLocataire);
            Controls.Add(BtnAppartement);
            Controls.Add(BtnBatiment);
            Controls.Add(PanelMenu);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmMenu";
            WindowState = FormWindowState.Maximized;
            Load += FrmMenu_Load;
            PanelMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel PanelMenu;
        private Button BtnCompteCourant;
        private Button BtnFrais;
        private PictureBox pictureBox1;
        private Button BtnBatiment;
        private Button BtnAppartement;
        private Button BtnCmptecourant;
        private Button BtnLocataire;
        private Button BtnDemande;
        private Button BtnDossier;
        private Button BtnGrade;
        private Button BtnFonction;
        private Button BtnOccuperAppartement;
        private Button BtnNotedeRemise;
        private Label label1;
        private Button BtnContrat;
    }
}