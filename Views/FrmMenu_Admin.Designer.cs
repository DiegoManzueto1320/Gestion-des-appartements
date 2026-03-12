namespace GESTAPP
{
    partial class FrmMenu_Admin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenu_Admin));
            BtnGestionUser = new Button();
            BtnGestionSystem = new Button();
            BtnPropos = new Button();
            BtnSeDeconnecter = new Button();
            BtnQuitter = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // BtnGestionUser
            // 
            BtnGestionUser.Image = (Image)resources.GetObject("BtnGestionUser.Image");
            BtnGestionUser.ImageAlign = ContentAlignment.MiddleLeft;
            BtnGestionUser.Location = new Point(385, 12);
            BtnGestionUser.Name = "BtnGestionUser";
            BtnGestionUser.Size = new Size(492, 74);
            BtnGestionUser.TabIndex = 0;
            BtnGestionUser.Text = "Gestion des utilisateurs";
            BtnGestionUser.UseVisualStyleBackColor = true;
            BtnGestionUser.Click += BtnGestionUser_Click;
            // 
            // BtnGestionSystem
            // 
            BtnGestionSystem.Image = (Image)resources.GetObject("BtnGestionSystem.Image");
            BtnGestionSystem.ImageAlign = ContentAlignment.MiddleLeft;
            BtnGestionSystem.Location = new Point(385, 90);
            BtnGestionSystem.Name = "BtnGestionSystem";
            BtnGestionSystem.Size = new Size(489, 74);
            BtnGestionSystem.TabIndex = 1;
            BtnGestionSystem.Text = "Gestion du système";
            BtnGestionSystem.UseVisualStyleBackColor = true;
            BtnGestionSystem.Click += BtnGestionSystem_Click;
            // 
            // BtnPropos
            // 
            BtnPropos.Image = (Image)resources.GetObject("BtnPropos.Image");
            BtnPropos.ImageAlign = ContentAlignment.MiddleLeft;
            BtnPropos.Location = new Point(385, 170);
            BtnPropos.Name = "BtnPropos";
            BtnPropos.Size = new Size(487, 74);
            BtnPropos.TabIndex = 2;
            BtnPropos.Text = "A Propos";
            BtnPropos.UseVisualStyleBackColor = true;
            BtnPropos.Click += BtnPropos_Click;
            // 
            // BtnSeDeconnecter
            // 
            BtnSeDeconnecter.Image = (Image)resources.GetObject("BtnSeDeconnecter.Image");
            BtnSeDeconnecter.ImageAlign = ContentAlignment.MiddleLeft;
            BtnSeDeconnecter.Location = new Point(385, 248);
            BtnSeDeconnecter.Name = "BtnSeDeconnecter";
            BtnSeDeconnecter.Size = new Size(485, 74);
            BtnSeDeconnecter.TabIndex = 3;
            BtnSeDeconnecter.Text = "Se Déconnecter";
            BtnSeDeconnecter.UseVisualStyleBackColor = true;
            BtnSeDeconnecter.Click += BtnSeDeconnecter_Click;
            // 
            // BtnQuitter
            // 
            BtnQuitter.ImageAlign = ContentAlignment.MiddleLeft;
            BtnQuitter.Location = new Point(385, 325);
            BtnQuitter.Name = "BtnQuitter";
            BtnQuitter.Size = new Size(486, 74);
            BtnQuitter.TabIndex = 4;
            BtnQuitter.Text = "Quitter";
            BtnQuitter.UseVisualStyleBackColor = true;
            BtnQuitter.Click += BtnQuitter_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(367, 383);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // FrmMenu_Admin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(879, 407);
            Controls.Add(pictureBox1);
            Controls.Add(BtnQuitter);
            Controls.Add(BtnSeDeconnecter);
            Controls.Add(BtnPropos);
            Controls.Add(BtnGestionSystem);
            Controls.Add(BtnGestionUser);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmMenu_Admin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menu Administrateur";
            Load += FrmMenu_Admin_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button BtnGestionUser;
        private Button BtnGestionSystem;
        private Button BtnPropos;
        private Button BtnSeDeconnecter;
        private Button BtnQuitter;
        private PictureBox pictureBox1;
    }
}