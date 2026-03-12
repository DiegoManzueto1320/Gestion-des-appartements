namespace GESTAPP.Views
{
    partial class FrmFonction
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmFonction));
            BtnModifier = new Button();
            TxtLibelle = new TextBox();
            BtnEnregistrer = new Button();
            lblCode = new Label();
            PanelMenu = new Panel();
            BtnFonction = new Button();
            pictureBox1 = new PictureBox();
            BtnQuitter = new Button();
            BtnSeDeconnecter = new Button();
            BtnAgent = new Button();
            BtnUtilisateur = new Button();
            BtnSupprimer = new Button();
            lblBatiment = new Label();
            groupBox1 = new GroupBox();
            TxtFonction = new TextBox();
            lblLibelle = new Label();
            panel1 = new Panel();
            PanelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // BtnModifier
            // 
            BtnModifier.Location = new Point(538, 157);
            BtnModifier.Name = "BtnModifier";
            BtnModifier.Size = new Size(229, 37);
            BtnModifier.TabIndex = 11;
            BtnModifier.Text = "Modifer";
            BtnModifier.UseVisualStyleBackColor = true;
            BtnModifier.Click += BtnModifier_Click;
            // 
            // TxtLibelle
            // 
            TxtLibelle.Font = new Font("Roboto", 12F);
            TxtLibelle.Location = new Point(414, 69);
            TxtLibelle.Multiline = true;
            TxtLibelle.Name = "TxtLibelle";
            TxtLibelle.Size = new Size(353, 35);
            TxtLibelle.TabIndex = 7;
            // 
            // BtnEnregistrer
            // 
            BtnEnregistrer.Location = new Point(479, 110);
            BtnEnregistrer.Name = "BtnEnregistrer";
            BtnEnregistrer.Size = new Size(229, 37);
            BtnEnregistrer.TabIndex = 3;
            BtnEnregistrer.Text = "Enregistrer";
            BtnEnregistrer.UseVisualStyleBackColor = true;
            BtnEnregistrer.Click += BtnEnregistrer_Click;
            // 
            // lblCode
            // 
            lblCode.AutoSize = true;
            lblCode.Font = new Font("Roboto", 12F);
            lblCode.Location = new Point(183, 23);
            lblCode.Name = "lblCode";
            lblCode.Size = new Size(57, 19);
            lblCode.TabIndex = 2;
            lblCode.Text = "Code : ";
            // 
            // PanelMenu
            // 
            PanelMenu.Controls.Add(BtnFonction);
            PanelMenu.Controls.Add(pictureBox1);
            PanelMenu.Controls.Add(BtnQuitter);
            PanelMenu.Controls.Add(BtnSeDeconnecter);
            PanelMenu.Controls.Add(BtnAgent);
            PanelMenu.Controls.Add(BtnUtilisateur);
            PanelMenu.Dock = DockStyle.Left;
            PanelMenu.Location = new Point(0, 0);
            PanelMenu.Name = "PanelMenu";
            PanelMenu.Size = new Size(176, 450);
            PanelMenu.TabIndex = 7;
            // 
            // BtnFonction
            // 
            BtnFonction.BackColor = Color.Transparent;
            BtnFonction.FlatStyle = FlatStyle.Flat;
            BtnFonction.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnFonction.ForeColor = Color.Transparent;
            BtnFonction.ImageAlign = ContentAlignment.BottomCenter;
            BtnFonction.Location = new Point(3, 92);
            BtnFonction.Name = "BtnFonction";
            BtnFonction.Size = new Size(170, 45);
            BtnFonction.TabIndex = 12;
            BtnFonction.Text = "Grade";
            BtnFonction.UseVisualStyleBackColor = false;
            BtnFonction.Click += BtnFonction_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(1, 233);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(170, 214);
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
            BtnQuitter.Location = new Point(1, 182);
            BtnQuitter.Name = "BtnQuitter";
            BtnQuitter.Size = new Size(170, 45);
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
            BtnSeDeconnecter.Location = new Point(3, 137);
            BtnSeDeconnecter.Name = "BtnSeDeconnecter";
            BtnSeDeconnecter.Size = new Size(170, 45);
            BtnSeDeconnecter.TabIndex = 5;
            BtnSeDeconnecter.Text = "Se déconnecter";
            BtnSeDeconnecter.UseVisualStyleBackColor = false;
            BtnSeDeconnecter.Click += BtnSeDeconnecter_Click;
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
            BtnAgent.Click += BtnAgent_Click;
            // 
            // BtnUtilisateur
            // 
            BtnUtilisateur.BackColor = Color.Transparent;
            BtnUtilisateur.FlatStyle = FlatStyle.Flat;
            BtnUtilisateur.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnUtilisateur.ForeColor = Color.Transparent;
            BtnUtilisateur.ImageAlign = ContentAlignment.BottomCenter;
            BtnUtilisateur.Location = new Point(2, 47);
            BtnUtilisateur.Name = "BtnUtilisateur";
            BtnUtilisateur.Size = new Size(170, 45);
            BtnUtilisateur.TabIndex = 1;
            BtnUtilisateur.Text = "Utilisateurs";
            BtnUtilisateur.UseVisualStyleBackColor = false;
            BtnUtilisateur.Click += BtnUtilisateur_Click;
            // 
            // BtnSupprimer
            // 
            BtnSupprimer.Location = new Point(303, 157);
            BtnSupprimer.Name = "BtnSupprimer";
            BtnSupprimer.Size = new Size(229, 37);
            BtnSupprimer.TabIndex = 12;
            BtnSupprimer.Text = "Supprimer";
            BtnSupprimer.UseVisualStyleBackColor = true;
            BtnSupprimer.Click += BtnSupprimer_Click;
            // 
            // lblBatiment
            // 
            lblBatiment.AutoSize = true;
            lblBatiment.FlatStyle = FlatStyle.Flat;
            lblBatiment.Font = new Font("Roboto", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBatiment.ForeColor = Color.White;
            lblBatiment.Location = new Point(505, 38);
            lblBatiment.Name = "lblBatiment";
            lblBatiment.Size = new Size(149, 33);
            lblBatiment.TabIndex = 1;
            lblBatiment.Text = "FONCTION";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(BtnSupprimer);
            groupBox1.Controls.Add(BtnModifier);
            groupBox1.Controls.Add(TxtLibelle);
            groupBox1.Controls.Add(TxtFonction);
            groupBox1.Controls.Add(BtnEnregistrer);
            groupBox1.Controls.Add(lblLibelle);
            groupBox1.Controls.Add(lblCode);
            groupBox1.Dock = DockStyle.Bottom;
            groupBox1.Location = new Point(0, 92);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1106, 358);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // TxtFonction
            // 
            TxtFonction.Font = new Font("Roboto", 12F);
            TxtFonction.Location = new Point(414, 17);
            TxtFonction.Multiline = true;
            TxtFonction.Name = "TxtFonction";
            TxtFonction.Size = new Size(353, 35);
            TxtFonction.TabIndex = 6;
            TxtFonction.TextChanged += TxtFonction_TextChanged;
            // 
            // lblLibelle
            // 
            lblLibelle.AutoSize = true;
            lblLibelle.Font = new Font("Roboto", 12F);
            lblLibelle.Location = new Point(182, 82);
            lblLibelle.Name = "lblLibelle";
            lblLibelle.Size = new Size(67, 19);
            lblLibelle.TabIndex = 3;
            lblLibelle.Text = "Libellé : ";
            // 
            // panel1
            // 
            panel1.BackColor = Color.WhiteSmoke;
            panel1.Controls.Add(lblBatiment);
            panel1.Controls.Add(groupBox1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1106, 450);
            panel1.TabIndex = 8;
            // 
            // FrmFonction
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1106, 450);
            Controls.Add(PanelMenu);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmFonction";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmFonction";
            PanelMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button BtnModifier;
        private TextBox TxtLibelle;
        private Button BtnEnregistrer;
        private Label lblCode;
        private Panel PanelMenu;
        private Button BtnFonction;
        private PictureBox pictureBox1;
        private Button BtnQuitter;
        private Button BtnSeDeconnecter;
        private Button BtnAgent;
        private Button BtnUtilisateur;
        private Button BtnSupprimer;
        private Label lblBatiment;
        private GroupBox groupBox1;
        private TextBox TxtFonction;
        private Label lblLibelle;
        private Panel panel1;
    }
}