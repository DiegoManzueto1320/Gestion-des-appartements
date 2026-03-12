namespace GESTAPP
{
    partial class FrmListeAppartement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmListeAppartement));
            pictureBox1 = new PictureBox();
            PanelMenu = new Panel();
            lblBatiment = new Label();
            DVGListeAppartement = new DataGridView();
            label1 = new Label();
            txtRecherche = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            PanelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DVGListeAppartement).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Bottom;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 313);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(186, 436);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // PanelMenu
            // 
            PanelMenu.Controls.Add(pictureBox1);
            PanelMenu.Dock = DockStyle.Left;
            PanelMenu.Location = new Point(0, 0);
            PanelMenu.Name = "PanelMenu";
            PanelMenu.Size = new Size(186, 749);
            PanelMenu.TabIndex = 15;
            // 
            // lblBatiment
            // 
            lblBatiment.AutoSize = true;
            lblBatiment.FlatStyle = FlatStyle.Flat;
            lblBatiment.Font = new Font("Times New Roman", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBatiment.ForeColor = Color.White;
            lblBatiment.Location = new Point(424, 19);
            lblBatiment.Name = "lblBatiment";
            lblBatiment.Size = new Size(427, 36);
            lblBatiment.TabIndex = 17;
            lblBatiment.Text = "Liste de tous les appartements";
            lblBatiment.TextAlign = ContentAlignment.TopCenter;
            // 
            // DVGListeAppartement
            // 
            DVGListeAppartement.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DVGListeAppartement.Dock = DockStyle.Bottom;
            DVGListeAppartement.Location = new Point(186, 72);
            DVGListeAppartement.Name = "DVGListeAppartement";
            DVGListeAppartement.Size = new Size(1074, 677);
            DVGListeAppartement.TabIndex = 32;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(961, 19);
            label1.Name = "label1";
            label1.Size = new Size(133, 21);
            label1.TabIndex = 40;
            label1.Text = "Rechercher par : ";
            // 
            // txtRecherche
            // 
            txtRecherche.Location = new Point(961, 43);
            txtRecherche.Name = "txtRecherche";
            txtRecherche.Size = new Size(288, 23);
            txtRecherche.TabIndex = 39;
            txtRecherche.TextChanged += txtRecherche_TextChanged;
            // 
            // FrmListeAppartement
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1260, 749);
            Controls.Add(label1);
            Controls.Add(txtRecherche);
            Controls.Add(DVGListeAppartement);
            Controls.Add(lblBatiment);
            Controls.Add(PanelMenu);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "FrmListeAppartement";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmListeAppartement";
            WindowState = FormWindowState.Maximized;
            Load += FrmListeAppartement_Load_1;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            PanelMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DVGListeAppartement).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pictureBox1;
        private Panel PanelMenu;
        private Label lblBatiment;
        private DataGridView DVGListeAppartement;
        private Label label1;
        private TextBox txtRecherche;
    }
}