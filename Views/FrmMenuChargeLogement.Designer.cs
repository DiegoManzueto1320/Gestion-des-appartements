namespace GESTAPP
{
    partial class FrmMenuChargeLogement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenuChargeLogement));
            pictureBox1 = new PictureBox();
            PanelMenu = new Panel();
            BtnQuitter = new Button();
            BtnSeDeconnecter = new Button();
            BtnGestionDemande = new Button();
            panel1 = new Panel();
            label1 = new Label();
            groupBox1 = new GroupBox();
            BtnDisponniblite = new Button();
            BtnVerifierDemande = new Button();
            BtnFormulaire = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            PanelMenu.SuspendLayout();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(1, 145);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(326, 200);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // PanelMenu
            // 
            PanelMenu.Controls.Add(pictureBox1);
            PanelMenu.Controls.Add(BtnQuitter);
            PanelMenu.Controls.Add(BtnSeDeconnecter);
            PanelMenu.Controls.Add(BtnGestionDemande);
            PanelMenu.Dock = DockStyle.Left;
            PanelMenu.Location = new Point(0, 0);
            PanelMenu.Name = "PanelMenu";
            PanelMenu.Size = new Size(331, 349);
            PanelMenu.TabIndex = 5;
            // 
            // BtnQuitter
            // 
            BtnQuitter.BackColor = Color.Transparent;
            BtnQuitter.FlatStyle = FlatStyle.Flat;
            BtnQuitter.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnQuitter.ForeColor = Color.Transparent;
            BtnQuitter.ImageAlign = ContentAlignment.BottomCenter;
            BtnQuitter.Location = new Point(2, 91);
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
            BtnSeDeconnecter.Location = new Point(1, 46);
            BtnSeDeconnecter.Name = "BtnSeDeconnecter";
            BtnSeDeconnecter.Size = new Size(326, 45);
            BtnSeDeconnecter.TabIndex = 5;
            BtnSeDeconnecter.Text = "Se déconnecter";
            BtnSeDeconnecter.UseVisualStyleBackColor = false;
            BtnSeDeconnecter.Click += BtnSeDeconnecter_Click;
            // 
            // BtnGestionDemande
            // 
            BtnGestionDemande.BackColor = Color.Transparent;
            BtnGestionDemande.FlatStyle = FlatStyle.Flat;
            BtnGestionDemande.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnGestionDemande.ForeColor = Color.Transparent;
            BtnGestionDemande.ImageAlign = ContentAlignment.BottomCenter;
            BtnGestionDemande.Location = new Point(3, 3);
            BtnGestionDemande.Name = "BtnGestionDemande";
            BtnGestionDemande.Size = new Size(325, 45);
            BtnGestionDemande.TabIndex = 4;
            BtnGestionDemande.Text = "Gestion des demandes de location";
            BtnGestionDemande.UseVisualStyleBackColor = false;
            BtnGestionDemande.Click += BtnAgent_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.WhiteSmoke;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(groupBox1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1015, 349);
            panel1.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Roboto", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(581, 34);
            label1.Name = "label1";
            label1.Size = new Size(216, 23);
            label1.TabIndex = 3;
            label1.Text = "CHARGE DE LOGEMENT";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(BtnDisponniblite);
            groupBox1.Controls.Add(BtnVerifierDemande);
            groupBox1.Controls.Add(BtnFormulaire);
            groupBox1.Dock = DockStyle.Bottom;
            groupBox1.Location = new Point(0, 70);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1015, 279);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // BtnDisponniblite
            // 
            BtnDisponniblite.Location = new Point(337, 165);
            BtnDisponniblite.Name = "BtnDisponniblite";
            BtnDisponniblite.Size = new Size(666, 62);
            BtnDisponniblite.TabIndex = 4;
            BtnDisponniblite.Text = "Verifier la disponnibilité des appartements";
            BtnDisponniblite.UseVisualStyleBackColor = true;
            BtnDisponniblite.Click += BtnDisponniblite_Click;
            // 
            // BtnVerifierDemande
            // 
            BtnVerifierDemande.Location = new Point(337, 22);
            BtnVerifierDemande.Name = "BtnVerifierDemande";
            BtnVerifierDemande.Size = new Size(666, 69);
            BtnVerifierDemande.TabIndex = 3;
            BtnVerifierDemande.Text = "Verifier les demandes";
            BtnVerifierDemande.UseVisualStyleBackColor = true;
            BtnVerifierDemande.Click += BtnEnregistrer_Click;
            // 
            // BtnFormulaire
            // 
            BtnFormulaire.Location = new Point(337, 97);
            BtnFormulaire.Name = "BtnFormulaire";
            BtnFormulaire.Size = new Size(666, 62);
            BtnFormulaire.TabIndex = 2;
            BtnFormulaire.Text = "Formulaire de demande de location";
            BtnFormulaire.UseVisualStyleBackColor = true;
            BtnFormulaire.Click += BtnNouveau_Click;
            // 
            // FrmMenuChargeLogement
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1015, 349);
            Controls.Add(PanelMenu);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmMenuChargeLogement";
            StartPosition = FormStartPosition.CenterScreen;
            Load += FrmMenuChargeLogement_Load_1;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            PanelMenu.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Panel PanelMenu;
        private Button BtnQuitter;
        private Button BtnSeDeconnecter;
        private Button BtnGestionDemande;
        private Panel panel1;
        private Button BtnFormulaire;
        private GroupBox groupBox1;
        private Button BtnVerifierDemande;
        private Label label1;
        private Button BtnDisponniblite;
    }
}