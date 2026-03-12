namespace GESTAPP
{
    partial class FrmConnexion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConnexion));
            label1 = new Label();
            label2 = new Label();
            panel1 = new Panel();
            Image_connexion = new PictureBox();
            panel2 = new Panel();
            TxtMotdePasse = new TextBox();
            TxtNomUser = new TextBox();
            BtnConnexion = new Button();
            BtnQuitter = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Image_connexion).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.FlatStyle = FlatStyle.Popup;
            label1.Font = new Font("Sylfaen", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(3, 41);
            label1.Name = "label1";
            label1.Size = new Size(205, 31);
            label1.TabIndex = 0;
            label1.Text = "Nom utilisateur : ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.FlatStyle = FlatStyle.Popup;
            label2.Font = new Font("Sylfaen", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(3, 85);
            label2.Name = "label2";
            label2.Size = new Size(178, 31);
            label2.TabIndex = 1;
            label2.Text = "Mot de passe : ";
            // 
            // panel1
            // 
            panel1.Controls.Add(Image_connexion);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(276, 207);
            panel1.TabIndex = 2;
            // 
            // Image_connexion
            // 
            Image_connexion.Dock = DockStyle.Top;
            Image_connexion.Image = (Image)resources.GetObject("Image_connexion.Image");
            Image_connexion.Location = new Point(0, 0);
            Image_connexion.Name = "Image_connexion";
            Image_connexion.Size = new Size(276, 205);
            Image_connexion.SizeMode = PictureBoxSizeMode.StretchImage;
            Image_connexion.TabIndex = 3;
            Image_connexion.TabStop = false;
            // 
            // panel2
            // 
            panel2.Controls.Add(TxtMotdePasse);
            panel2.Controls.Add(TxtNomUser);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(276, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(502, 144);
            panel2.TabIndex = 3;
            // 
            // TxtMotdePasse
            // 
            TxtMotdePasse.Location = new Point(214, 92);
            TxtMotdePasse.Name = "TxtMotdePasse";
            TxtMotdePasse.PasswordChar = '◉';
            TxtMotdePasse.Size = new Size(277, 23);
            TxtMotdePasse.TabIndex = 2;
            TxtMotdePasse.UseSystemPasswordChar = true;
            // 
            // TxtNomUser
            // 
            TxtNomUser.Location = new Point(214, 48);
            TxtNomUser.Name = "TxtNomUser";
            TxtNomUser.Size = new Size(277, 23);
            TxtNomUser.TabIndex = 1;
            // 
            // BtnConnexion
            // 
            BtnConnexion.Font = new Font("Roboto", 9.75F);
            BtnConnexion.Location = new Point(279, 150);
            BtnConnexion.Name = "BtnConnexion";
            BtnConnexion.Size = new Size(205, 45);
            BtnConnexion.TabIndex = 3;
            BtnConnexion.Text = "Se connecter";
            BtnConnexion.UseVisualStyleBackColor = true;
            BtnConnexion.Click += BtnConnexion_Click;
            // 
            // BtnQuitter
            // 
            BtnQuitter.Font = new Font("Roboto", 9.75F);
            BtnQuitter.Location = new Point(578, 150);
            BtnQuitter.Name = "BtnQuitter";
            BtnQuitter.Size = new Size(192, 45);
            BtnQuitter.TabIndex = 4;
            BtnQuitter.Text = "Quitter";
            BtnQuitter.UseVisualStyleBackColor = true;
            BtnQuitter.Click += BtnNettoyer_Click;
            // 
            // FrmConnexion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(778, 207);
            Controls.Add(BtnQuitter);
            Controls.Add(BtnConnexion);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("Roboto", 9.75F);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmConnexion";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmConnexion";
            Load += FrmConnexion_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)Image_connexion).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
        private Panel panel1;
        private PictureBox Image_connexion;
        private Panel panel2;
        private Button BtnConnexion;
        private TextBox TxtMotdePasse;
        private TextBox TxtNomUser;
        private Button BtnQuitter;
    }
}