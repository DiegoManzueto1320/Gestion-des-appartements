namespace GESTAPP.Views
{
    partial class FrmListePayements
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmListePayements));
            pictureBox1 = new PictureBox();
            DGVPayement = new DataGridView();
            lblBatiment = new Label();
            PanelMenu = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DGVPayement).BeginInit();
            PanelMenu.SuspendLayout();
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
            // DGVPayement
            // 
            DGVPayement.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGVPayement.Dock = DockStyle.Bottom;
            DGVPayement.Location = new Point(186, 56);
            DGVPayement.Name = "DGVPayement";
            DGVPayement.Size = new Size(1116, 693);
            DGVPayement.TabIndex = 35;
            // 
            // lblBatiment
            // 
            lblBatiment.AutoSize = true;
            lblBatiment.FlatStyle = FlatStyle.Flat;
            lblBatiment.Font = new Font("Times New Roman", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBatiment.ForeColor = Color.White;
            lblBatiment.Location = new Point(436, 17);
            lblBatiment.Name = "lblBatiment";
            lblBatiment.Size = new Size(371, 36);
            lblBatiment.TabIndex = 34;
            lblBatiment.Text = "Liste de tous le payements";
            lblBatiment.TextAlign = ContentAlignment.TopCenter;
            // 
            // PanelMenu
            // 
            PanelMenu.Controls.Add(pictureBox1);
            PanelMenu.Dock = DockStyle.Left;
            PanelMenu.Location = new Point(0, 0);
            PanelMenu.Name = "PanelMenu";
            PanelMenu.Size = new Size(186, 749);
            PanelMenu.TabIndex = 33;
            // 
            // FrmListePayements
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1302, 749);
            Controls.Add(DGVPayement);
            Controls.Add(lblBatiment);
            Controls.Add(PanelMenu);
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "FrmListePayements";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmListePayeùents";
            WindowState = FormWindowState.Maximized;
            Load += FrmListePayements_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)DGVPayement).EndInit();
            PanelMenu.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private DataGridView DGVPayement;
        private Label lblBatiment;
        private Panel PanelMenu;
    }
}