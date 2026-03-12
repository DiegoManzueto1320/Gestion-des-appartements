namespace GESTAPP.Views
{
    partial class FrmGrade
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGrade));
            pictureBox1 = new PictureBox();
            BtnQuitter = new Button();
            PanelMenu = new Panel();
            BtnUtilisateur = new Button();
            BtnFonction = new Button();
            BtnSeDeconnecter = new Button();
            BtnAgent = new Button();
            panel1 = new Panel();
            lblBatiment = new Label();
            groupBox1 = new GroupBox();
            BtnSupprimer = new Button();
            BtnModifier = new Button();
            TxtLibelleGrade = new TextBox();
            TxtCodeGrande = new TextBox();
            BtnEnregistrer = new Button();
            lblLibelle = new Label();
            lblCode = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            PanelMenu.SuspendLayout();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
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
            // PanelMenu
            // 
            PanelMenu.Controls.Add(BtnUtilisateur);
            PanelMenu.Controls.Add(BtnFonction);
            PanelMenu.Controls.Add(pictureBox1);
            PanelMenu.Controls.Add(BtnQuitter);
            PanelMenu.Controls.Add(BtnSeDeconnecter);
            PanelMenu.Controls.Add(BtnAgent);
            PanelMenu.Dock = DockStyle.Left;
            PanelMenu.Location = new Point(0, 0);
            PanelMenu.Name = "PanelMenu";
            PanelMenu.Size = new Size(176, 450);
            PanelMenu.TabIndex = 5;
            // 
            // BtnUtilisateur
            // 
            BtnUtilisateur.BackColor = Color.Transparent;
            BtnUtilisateur.FlatStyle = FlatStyle.Flat;
            BtnUtilisateur.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnUtilisateur.ForeColor = Color.Transparent;
            BtnUtilisateur.ImageAlign = ContentAlignment.BottomCenter;
            BtnUtilisateur.Location = new Point(3, 46);
            BtnUtilisateur.Name = "BtnUtilisateur";
            BtnUtilisateur.Size = new Size(170, 45);
            BtnUtilisateur.TabIndex = 13;
            BtnUtilisateur.Text = "Utlisateur";
            BtnUtilisateur.UseVisualStyleBackColor = false;
            BtnUtilisateur.Click += BtnUtilisateur_Click;
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
            BtnFonction.Text = "Fonction";
            BtnFonction.UseVisualStyleBackColor = false;
            BtnFonction.Click += BtnFonction_Click;
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
            // 
            // panel1
            // 
            panel1.BackColor = Color.WhiteSmoke;
            panel1.Controls.Add(lblBatiment);
            panel1.Controls.Add(groupBox1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1009, 450);
            panel1.TabIndex = 6;
            // 
            // lblBatiment
            // 
            lblBatiment.AutoSize = true;
            lblBatiment.FlatStyle = FlatStyle.Flat;
            lblBatiment.Font = new Font("Roboto", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBatiment.ForeColor = Color.White;
            lblBatiment.Location = new Point(514, 15);
            lblBatiment.Name = "lblBatiment";
            lblBatiment.Size = new Size(87, 33);
            lblBatiment.TabIndex = 1;
            lblBatiment.Text = "Grade";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(BtnSupprimer);
            groupBox1.Controls.Add(BtnModifier);
            groupBox1.Controls.Add(TxtLibelleGrade);
            groupBox1.Controls.Add(TxtCodeGrande);
            groupBox1.Controls.Add(BtnEnregistrer);
            groupBox1.Controls.Add(lblLibelle);
            groupBox1.Controls.Add(lblCode);
            groupBox1.Dock = DockStyle.Bottom;
            groupBox1.Location = new Point(0, 92);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1009, 358);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
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
            // TxtLibelleGrade
            // 
            TxtLibelleGrade.Font = new Font("Roboto", 12F);
            TxtLibelleGrade.Location = new Point(414, 69);
            TxtLibelleGrade.Multiline = true;
            TxtLibelleGrade.Name = "TxtLibelleGrade";
            TxtLibelleGrade.Size = new Size(353, 35);
            TxtLibelleGrade.TabIndex = 7;
            // 
            // TxtCodeGrande
            // 
            TxtCodeGrande.Font = new Font("Roboto", 12F);
            TxtCodeGrande.Location = new Point(414, 17);
            TxtCodeGrande.Multiline = true;
            TxtCodeGrande.Name = "TxtCodeGrande";
            TxtCodeGrande.Size = new Size(353, 35);
            TxtCodeGrande.TabIndex = 6;
            TxtCodeGrande.TextChanged += TxtCodeGrande_TextChanged;
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
            // FrmGrade
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1009, 450);
            Controls.Add(PanelMenu);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmGrade";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmGrade";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            PanelMenu.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Button BtnQuitter;
        private Panel PanelMenu;
        private Button BtnSeDeconnecter;
        private Button BtnAgent;
        private Panel panel1;
        private Label lblBatiment;
        private GroupBox groupBox1;
        private Button BtnSupprimer;
        private Button BtnModifier;
        private TextBox TxtLibelleGrade;
        private TextBox TxtCodeGrande;
        private Button BtnEnregistrer;
        private Label lblLibelle;
        private Label lblCode;
        private Button BtnFonction;
        private Button BtnUtilisateur;
    }
}