namespace GESTAPP.Views
{
    partial class FrmInspecteurAppartement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmInspecteurAppartement));
            pictureBox1 = new PictureBox();
            PanelMenu = new Panel();
            BtnQuitter = new Button();
            BtnSeDeconnecter = new Button();
            panel1 = new Panel();
            label1 = new Label();
            groupBox1 = new GroupBox();
            BtnEtablirNote = new Button();
            BtnAppartementOccupe = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            PanelMenu.SuspendLayout();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(1, 100);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(326, 245);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // PanelMenu
            // 
            PanelMenu.Controls.Add(pictureBox1);
            PanelMenu.Controls.Add(BtnQuitter);
            PanelMenu.Controls.Add(BtnSeDeconnecter);
            PanelMenu.Dock = DockStyle.Left;
            PanelMenu.Location = new Point(0, 0);
            PanelMenu.Name = "PanelMenu";
            PanelMenu.Size = new Size(331, 450);
            PanelMenu.TabIndex = 9;
            // 
            // BtnQuitter
            // 
            BtnQuitter.BackColor = Color.Transparent;
            BtnQuitter.FlatStyle = FlatStyle.Flat;
            BtnQuitter.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnQuitter.ForeColor = Color.Transparent;
            BtnQuitter.ImageAlign = ContentAlignment.BottomCenter;
            BtnQuitter.Location = new Point(2, 49);
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
            BtnSeDeconnecter.Location = new Point(1, 4);
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
            panel1.Size = new Size(1003, 450);
            panel1.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Roboto", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(543, 71);
            label1.Name = "label1";
            label1.Size = new Size(279, 23);
            label1.TabIndex = 3;
            label1.Text = "INSPECTEUR D'APPARTEMENT";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(BtnEtablirNote);
            groupBox1.Controls.Add(BtnAppartementOccupe);
            groupBox1.Dock = DockStyle.Bottom;
            groupBox1.Location = new Point(0, 184);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1003, 266);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // BtnEtablirNote
            // 
            BtnEtablirNote.Location = new Point(340, 56);
            BtnEtablirNote.Name = "BtnEtablirNote";
            BtnEtablirNote.Size = new Size(640, 69);
            BtnEtablirNote.TabIndex = 3;
            BtnEtablirNote.Text = "Etablir note de remise de clé";
            BtnEtablirNote.UseVisualStyleBackColor = true;
            BtnEtablirNote.Click += BtnEtablirNote_Click;
            // 
            // BtnAppartementOccupe
            // 
            BtnAppartementOccupe.Location = new Point(340, 149);
            BtnAppartementOccupe.Name = "BtnAppartementOccupe";
            BtnAppartementOccupe.Size = new Size(640, 62);
            BtnAppartementOccupe.TabIndex = 2;
            BtnAppartementOccupe.Text = "Voir tous les appartements";
            BtnAppartementOccupe.UseVisualStyleBackColor = true;
            BtnAppartementOccupe.Click += BtnAppartementOccupe_Click;
            // 
            // FrmInspecteurAppartement
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1003, 450);
            Controls.Add(PanelMenu);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmInspecteurAppartement";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmInspecteurAppartement";
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
        private Panel panel1;
        private Label label1;
        private GroupBox groupBox1;
        private Button BtnEtablirNote;
        private Button BtnAppartementOccupe;
    }
}