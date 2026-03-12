namespace GESTAPP.Views
{
    partial class FrmChargéCompeCourant
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmChargéCompeCourant));
            groupBox1 = new GroupBox();
            BtnTousPayement = new Button();
            BtnGrstionCompte = new Button();
            BtnDossierLocatif = new Button();
            pictureBox1 = new PictureBox();
            PanelMenu = new Panel();
            BtnGestionLocataire = new Button();
            BtnQuitter = new Button();
            BtnSeDeconnecter = new Button();
            panel1 = new Panel();
            label1 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            PanelMenu.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(BtnTousPayement);
            groupBox1.Controls.Add(BtnGrstionCompte);
            groupBox1.Controls.Add(BtnDossierLocatif);
            groupBox1.Dock = DockStyle.Bottom;
            groupBox1.Location = new Point(0, 164);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(983, 266);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // BtnTousPayement
            // 
            BtnTousPayement.Location = new Point(340, 165);
            BtnTousPayement.Name = "BtnTousPayement";
            BtnTousPayement.Size = new Size(640, 62);
            BtnTousPayement.TabIndex = 4;
            BtnTousPayement.Text = "Voir tous les payements";
            BtnTousPayement.UseVisualStyleBackColor = true;
            BtnTousPayement.Click += BtnTousPayement_Click;
            // 
            // BtnGrstionCompte
            // 
            BtnGrstionCompte.Location = new Point(337, 22);
            BtnGrstionCompte.Name = "BtnGrstionCompte";
            BtnGrstionCompte.Size = new Size(640, 69);
            BtnGrstionCompte.TabIndex = 3;
            BtnGrstionCompte.Text = "Gestion de compte courat";
            BtnGrstionCompte.UseVisualStyleBackColor = true;
            BtnGrstionCompte.Click += BtnGrstionCompte_Click;
            // 
            // BtnDossierLocatif
            // 
            BtnDossierLocatif.Location = new Point(337, 97);
            BtnDossierLocatif.Name = "BtnDossierLocatif";
            BtnDossierLocatif.Size = new Size(640, 62);
            BtnDossierLocatif.TabIndex = 2;
            BtnDossierLocatif.Text = "Gestion de dossier locatifs";
            BtnDossierLocatif.UseVisualStyleBackColor = true;
            BtnDossierLocatif.Click += BtnDossierLocatif_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(1, 144);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(326, 280);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // PanelMenu
            // 
            PanelMenu.Controls.Add(BtnGestionLocataire);
            PanelMenu.Controls.Add(pictureBox1);
            PanelMenu.Controls.Add(BtnQuitter);
            PanelMenu.Controls.Add(BtnSeDeconnecter);
            PanelMenu.Dock = DockStyle.Left;
            PanelMenu.Location = new Point(0, 0);
            PanelMenu.Name = "PanelMenu";
            PanelMenu.Size = new Size(331, 430);
            PanelMenu.TabIndex = 9;
            // 
            // BtnGestionLocataire
            // 
            BtnGestionLocataire.BackColor = Color.Transparent;
            BtnGestionLocataire.FlatStyle = FlatStyle.Flat;
            BtnGestionLocataire.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnGestionLocataire.ForeColor = Color.Transparent;
            BtnGestionLocataire.ImageAlign = ContentAlignment.BottomCenter;
            BtnGestionLocataire.Location = new Point(1, 5);
            BtnGestionLocataire.Name = "BtnGestionLocataire";
            BtnGestionLocataire.Size = new Size(326, 45);
            BtnGestionLocataire.TabIndex = 12;
            BtnGestionLocataire.Text = "Gstion des locataires";
            BtnGestionLocataire.UseVisualStyleBackColor = false;
            BtnGestionLocataire.Click += BtnGestionLocataire_Click;
            // 
            // BtnQuitter
            // 
            BtnQuitter.BackColor = Color.Transparent;
            BtnQuitter.FlatStyle = FlatStyle.Flat;
            BtnQuitter.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnQuitter.ForeColor = Color.Transparent;
            BtnQuitter.ImageAlign = ContentAlignment.BottomCenter;
            BtnQuitter.Location = new Point(4, 96);
            BtnQuitter.Name = "BtnQuitter";
            BtnQuitter.Size = new Size(326, 45);
            BtnQuitter.TabIndex = 6;
            BtnQuitter.Text = "Quitter";
            BtnQuitter.UseVisualStyleBackColor = false;
            BtnQuitter.Click += BtnQuitter_Click;
            // 
            // BtnSeDeconnecter
            // 
            BtnSeDeconnecter.BackColor = Color.Transparent;
            BtnSeDeconnecter.FlatStyle = FlatStyle.Flat;
            BtnSeDeconnecter.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnSeDeconnecter.ForeColor = Color.Transparent;
            BtnSeDeconnecter.ImageAlign = ContentAlignment.BottomCenter;
            BtnSeDeconnecter.Location = new Point(3, 50);
            BtnSeDeconnecter.Name = "BtnSeDeconnecter";
            BtnSeDeconnecter.Size = new Size(326, 45);
            BtnSeDeconnecter.TabIndex = 5;
            BtnSeDeconnecter.Text = "Se déconnecter";
            BtnSeDeconnecter.UseVisualStyleBackColor = false;
            BtnSeDeconnecter.Click += BtnSeDeconnecter_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.WhiteSmoke;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(groupBox1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(983, 430);
            panel1.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Roboto", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(531, 96);
            label1.Name = "label1";
            label1.Size = new Size(287, 23);
            label1.TabIndex = 5;
            label1.Text = "CHARGE DE COMPTE COURANT";
            // 
            // FrmChargéCompeCourant
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(983, 430);
            Controls.Add(PanelMenu);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FrmChargéCompeCourant";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmChargéCompeCourant";
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            PanelMenu.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button BtnTousPayement;
        private Button BtnGrstionCompte;
        private Button BtnDossierLocatif;
        private PictureBox pictureBox1;
        private Panel PanelMenu;
        private Button BtnQuitter;
        private Button BtnSeDeconnecter;
        private Panel panel1;
        private Button BtnGestionLocataire;
        private Label label1;
    }
}