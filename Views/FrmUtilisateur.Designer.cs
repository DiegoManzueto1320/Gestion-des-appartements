namespace GESTAPP
{
    partial class FrmUtilisateur
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUtilisateur));
            TxtMotDepasse = new TextBox();
            TxtNom = new TextBox();
            BtnEnregistrer = new Button();
            lblAdresse = new Label();
            lblCode = new Label();
            lblBatiment = new Label();
            groupBox1 = new GroupBox();
            BtnSupprimer = new Button();
            BtnModifier = new Button();
            ComboRole = new ComboBox();
            label1 = new Label();
            ComboMatricule = new ComboBox();
            lblLibelle = new Label();
            panel1 = new Panel();
            BtnAgent = new Button();
            PanelMenu = new Panel();
            pictureBox1 = new PictureBox();
            BtnQuitter = new Button();
            BtnSeDeconnecter = new Button();
            BtnUtilisateur = new Button();
            groupBox1.SuspendLayout();
            panel1.SuspendLayout();
            PanelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // TxtMotDepasse
            // 
            TxtMotDepasse.Font = new Font("Roboto", 12F);
            TxtMotDepasse.Location = new Point(245, 95);
            TxtMotDepasse.Multiline = true;
            TxtMotDepasse.Name = "TxtMotDepasse";
            TxtMotDepasse.Size = new Size(353, 35);
            TxtMotDepasse.TabIndex = 7;
            // 
            // TxtNom
            // 
            TxtNom.Font = new Font("Roboto", 12F);
            TxtNom.Location = new Point(245, 43);
            TxtNom.Multiline = true;
            TxtNom.Name = "TxtNom";
            TxtNom.Size = new Size(353, 35);
            TxtNom.TabIndex = 6;
            // 
            // BtnEnregistrer
            // 
            BtnEnregistrer.Location = new Point(14, 225);
            BtnEnregistrer.Name = "BtnEnregistrer";
            BtnEnregistrer.Size = new Size(229, 37);
            BtnEnregistrer.TabIndex = 3;
            BtnEnregistrer.Text = "Enregistrer";
            BtnEnregistrer.UseVisualStyleBackColor = true;
            BtnEnregistrer.Click += BtnEnregistrer_Click;
            // 
            // lblAdresse
            // 
            lblAdresse.AutoSize = true;
            lblAdresse.Font = new Font("Roboto", 12F);
            lblAdresse.Location = new Point(14, 153);
            lblAdresse.Name = "lblAdresse";
            lblAdresse.Size = new Size(131, 19);
            lblAdresse.TabIndex = 4;
            lblAdresse.Text = "Matricule agent : ";
            // 
            // lblCode
            // 
            lblCode.AutoSize = true;
            lblCode.Font = new Font("Roboto", 12F);
            lblCode.Location = new Point(14, 49);
            lblCode.Name = "lblCode";
            lblCode.Size = new Size(130, 19);
            lblCode.TabIndex = 2;
            lblCode.Text = "Nom Utilisateur : ";
            // 
            // lblBatiment
            // 
            lblBatiment.AutoSize = true;
            lblBatiment.FlatStyle = FlatStyle.Flat;
            lblBatiment.Font = new Font("Roboto", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBatiment.ForeColor = Color.White;
            lblBatiment.Location = new Point(170, 38);
            lblBatiment.Name = "lblBatiment";
            lblBatiment.Size = new Size(375, 33);
            lblBatiment.TabIndex = 1;
            lblBatiment.Text = "GESTION DES UTILISATEURS";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(BtnSupprimer);
            groupBox1.Controls.Add(BtnModifier);
            groupBox1.Controls.Add(ComboRole);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(ComboMatricule);
            groupBox1.Controls.Add(TxtMotDepasse);
            groupBox1.Controls.Add(TxtNom);
            groupBox1.Controls.Add(BtnEnregistrer);
            groupBox1.Controls.Add(lblAdresse);
            groupBox1.Controls.Add(lblLibelle);
            groupBox1.Controls.Add(lblCode);
            groupBox1.Dock = DockStyle.Bottom;
            groupBox1.Location = new Point(0, 86);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(723, 274);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // BtnSupprimer
            // 
            BtnSupprimer.Location = new Point(488, 225);
            BtnSupprimer.Name = "BtnSupprimer";
            BtnSupprimer.Size = new Size(229, 37);
            BtnSupprimer.TabIndex = 12;
            BtnSupprimer.Text = "Supprimer";
            BtnSupprimer.UseVisualStyleBackColor = true;
            BtnSupprimer.Click += BtnSupprimer_Click;
            // 
            // BtnModifier
            // 
            BtnModifier.Location = new Point(249, 225);
            BtnModifier.Name = "BtnModifier";
            BtnModifier.Size = new Size(229, 37);
            BtnModifier.TabIndex = 11;
            BtnModifier.Text = "Modifer";
            BtnModifier.UseVisualStyleBackColor = true;
            BtnModifier.Click += BtnModifier_Click;
            // 
            // ComboRole
            // 
            ComboRole.FormattingEnabled = true;
            ComboRole.Items.AddRange(new object[] { "Chargé de logement", "Inspecteur d'appartement", "Caissier", "Chargé de compte courant", "Administrateur" });
            ComboRole.Location = new Point(245, 188);
            ComboRole.Name = "ComboRole";
            ComboRole.Size = new Size(263, 23);
            ComboRole.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Roboto", 12F);
            label1.Location = new Point(14, 192);
            label1.Name = "label1";
            label1.Size = new Size(52, 19);
            label1.TabIndex = 9;
            label1.Text = "Rôle : ";
            // 
            // ComboMatricule
            // 
            ComboMatricule.FormattingEnabled = true;
            ComboMatricule.Location = new Point(245, 149);
            ComboMatricule.Name = "ComboMatricule";
            ComboMatricule.Size = new Size(263, 23);
            ComboMatricule.TabIndex = 8;
            // 
            // lblLibelle
            // 
            lblLibelle.AutoSize = true;
            lblLibelle.Font = new Font("Roboto", 12F);
            lblLibelle.Location = new Point(13, 108);
            lblLibelle.Name = "lblLibelle";
            lblLibelle.Size = new Size(116, 19);
            lblLibelle.TabIndex = 3;
            lblLibelle.Text = "Mot de passe : ";
            // 
            // panel1
            // 
            panel1.BackColor = Color.WhiteSmoke;
            panel1.Controls.Add(lblBatiment);
            panel1.Controls.Add(groupBox1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(175, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(723, 360);
            panel1.TabIndex = 4;
            // 
            // BtnAgent
            // 
            BtnAgent.BackColor = Color.Transparent;
            BtnAgent.FlatStyle = FlatStyle.Flat;
            BtnAgent.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnAgent.ForeColor = Color.Transparent;
            BtnAgent.ImageAlign = ContentAlignment.BottomCenter;
            BtnAgent.Location = new Point(3, 3);
            BtnAgent.Name = "BtnAgent";
            BtnAgent.Size = new Size(170, 45);
            BtnAgent.TabIndex = 4;
            BtnAgent.Text = "Agent";
            BtnAgent.UseVisualStyleBackColor = false;
            BtnAgent.Click += BtnAgent_Click_1;
            // 
            // PanelMenu
            // 
            PanelMenu.Controls.Add(pictureBox1);
            PanelMenu.Controls.Add(BtnQuitter);
            PanelMenu.Controls.Add(BtnSeDeconnecter);
            PanelMenu.Controls.Add(BtnAgent);
            PanelMenu.Controls.Add(BtnUtilisateur);
            PanelMenu.Dock = DockStyle.Left;
            PanelMenu.Location = new Point(0, 0);
            PanelMenu.Name = "PanelMenu";
            PanelMenu.Size = new Size(175, 360);
            PanelMenu.TabIndex = 3;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(1, 190);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(170, 155);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // BtnQuitter
            // 
            BtnQuitter.BackColor = Color.Transparent;
            BtnQuitter.FlatStyle = FlatStyle.Flat;
            BtnQuitter.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnQuitter.ForeColor = Color.Transparent;
            BtnQuitter.ImageAlign = ContentAlignment.BottomCenter;
            BtnQuitter.Location = new Point(2, 139);
            BtnQuitter.Name = "BtnQuitter";
            BtnQuitter.Size = new Size(170, 45);
            BtnQuitter.TabIndex = 6;
            BtnQuitter.Text = "Quitter";
            BtnQuitter.UseVisualStyleBackColor = false;
            BtnQuitter.Click += BtnQuitter_Click_1;
            // 
            // BtnSeDeconnecter
            // 
            BtnSeDeconnecter.BackColor = Color.Transparent;
            BtnSeDeconnecter.FlatStyle = FlatStyle.Flat;
            BtnSeDeconnecter.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnSeDeconnecter.ForeColor = Color.Transparent;
            BtnSeDeconnecter.ImageAlign = ContentAlignment.BottomCenter;
            BtnSeDeconnecter.Location = new Point(2, 94);
            BtnSeDeconnecter.Name = "BtnSeDeconnecter";
            BtnSeDeconnecter.Size = new Size(170, 45);
            BtnSeDeconnecter.TabIndex = 5;
            BtnSeDeconnecter.Text = "Se déconnecter";
            BtnSeDeconnecter.UseVisualStyleBackColor = false;
            BtnSeDeconnecter.Click += BtnSeDeconnecter_Click;
            // 
            // BtnUtilisateur
            // 
            BtnUtilisateur.BackColor = Color.Transparent;
            BtnUtilisateur.FlatStyle = FlatStyle.Flat;
            BtnUtilisateur.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnUtilisateur.ForeColor = Color.Transparent;
            BtnUtilisateur.ImageAlign = ContentAlignment.BottomCenter;
            BtnUtilisateur.Location = new Point(2, 49);
            BtnUtilisateur.Name = "BtnUtilisateur";
            BtnUtilisateur.Size = new Size(170, 45);
            BtnUtilisateur.TabIndex = 1;
            BtnUtilisateur.Text = "Utilisateurs";
            BtnUtilisateur.UseVisualStyleBackColor = false;
            BtnUtilisateur.Click += BtnUtilisateur_Click_1;
            // 
            // FrmUtilisateur
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(898, 360);
            Controls.Add(panel1);
            Controls.Add(PanelMenu);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmUtilisateur";
            StartPosition = FormStartPosition.CenterScreen;
            Load += FrmUtilisateur_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            PanelMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private TextBox TxtMotDepasse;
        private TextBox TxtNom;
        private Button BtnEnregistrer;
        private Label lblAdresse;
        private Label lblCode;
        private Label lblBatiment;
        private GroupBox groupBox1;
        private Label lblLibelle;
        private Panel panel1;
        private Button BtnAgent;
        private Panel PanelMenu;
        private Button BtnUtilisateur;
        private ComboBox ComboMatricule;
        private Button BtnQuitter;
        private Button BtnSeDeconnecter;
        private PictureBox pictureBox1;
        private ComboBox ComboRole;
        private Label label1;
        private Button BtnSupprimer;
        private Button BtnModifier;
    }
}