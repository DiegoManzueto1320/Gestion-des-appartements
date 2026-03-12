namespace GESTAPP.Views
{
    partial class FrmListeDemandeLocation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmListeDemandeLocation));
            pictureBox1 = new PictureBox();
            DGVListeDemande = new DataGridView();
            lblBatiment = new Label();
            PanelMenu = new Panel();
            BtnActualiser = new Button();
            txtRecherche = new TextBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DGVListeDemande).BeginInit();
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
            // DGVListeDemande
            // 
            DGVListeDemande.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGVListeDemande.Dock = DockStyle.Bottom;
            DGVListeDemande.Location = new Point(186, 123);
            DGVListeDemande.Name = "DGVListeDemande";
            DGVListeDemande.Size = new Size(1118, 626);
            DGVListeDemande.TabIndex = 35;
            // 
            // lblBatiment
            // 
            lblBatiment.AutoSize = true;
            lblBatiment.FlatStyle = FlatStyle.Flat;
            lblBatiment.Font = new Font("Times New Roman", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBatiment.ForeColor = Color.White;
            lblBatiment.Location = new Point(433, 9);
            lblBatiment.Name = "lblBatiment";
            lblBatiment.Size = new Size(400, 36);
            lblBatiment.TabIndex = 34;
            lblBatiment.Text = "Liste de toutes les demandes";
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
            // BtnActualiser
            // 
            BtnActualiser.Location = new Point(980, 62);
            BtnActualiser.Name = "BtnActualiser";
            BtnActualiser.Size = new Size(237, 37);
            BtnActualiser.TabIndex = 36;
            BtnActualiser.Text = "Actualiser";
            BtnActualiser.UseVisualStyleBackColor = true;
            BtnActualiser.Click += BtnActualiser_Click;
            // 
            // txtRecherche
            // 
            txtRecherche.Location = new Point(1004, 13);
            txtRecherche.Name = "txtRecherche";
            txtRecherche.Size = new Size(288, 23);
            txtRecherche.TabIndex = 37;
            txtRecherche.TextChanged += txtRecherche_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(865, 15);
            label1.Name = "label1";
            label1.Size = new Size(133, 21);
            label1.TabIndex = 38;
            label1.Text = "Rechercher par : ";
            // 
            // FrmListeDemandeLocation
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1304, 749);
            Controls.Add(label1);
            Controls.Add(txtRecherche);
            Controls.Add(BtnActualiser);
            Controls.Add(DGVListeDemande);
            Controls.Add(lblBatiment);
            Controls.Add(PanelMenu);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmListeDemandeLocation";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmListeDemandeLocation";
            WindowState = FormWindowState.Maximized;
            Load += FrmListeDemandeLocation_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)DGVListeDemande).EndInit();
            PanelMenu.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private DataGridView DGVListeDemande;
        private Label lblBatiment;
        private Panel PanelMenu;
        private Button BtnActualiser;
        private TextBox txtRecherche;
        private Label label1;
    }
}