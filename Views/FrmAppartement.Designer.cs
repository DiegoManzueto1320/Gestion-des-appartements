namespace GESTAPP
{
    partial class FrmAppartement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAppartement));
            PanelMenu = new Panel();
            pictureBox1 = new PictureBox();
            BtnCompteCourant = new Button();
            BtnFrais = new Button();
            BtnLocataire = new Button();
            BtnAppartement = new Button();
            BtnBatiment = new Button();
            groupBox1 = new GroupBox();
            TxtNomApp = new TextBox();
            label3 = new Label();
            ComboIDLOc = new ComboBox();
            label2 = new Label();
            DGVAppartement = new DataGridView();
            BtnSupprimer = new Button();
            ComboPiece = new ComboBox();
            label1 = new Label();
            BtnModifier = new Button();
            ComboStatut = new ComboBox();
            ComboCodeBat = new ComboBox();
            LblStatut = new Label();
            TxtPrix = new TextBox();
            TxtDetail = new TextBox();
            TxtNumero = new TextBox();
            BtnEnregistrer = new Button();
            LblPrix = new Label();
            LblCodebat = new Label();
            LblDetails = new Label();
            LblNum = new Label();
            BtnListeAppart = new Button();
            lblBatiment = new Label();
            PanelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DGVAppartement).BeginInit();
            SuspendLayout();
            // 
            // PanelMenu
            // 
            PanelMenu.Controls.Add(pictureBox1);
            PanelMenu.Controls.Add(BtnCompteCourant);
            PanelMenu.Controls.Add(BtnFrais);
            PanelMenu.Controls.Add(BtnLocataire);
            PanelMenu.Controls.Add(BtnAppartement);
            PanelMenu.Controls.Add(BtnBatiment);
            PanelMenu.Dock = DockStyle.Left;
            PanelMenu.Location = new Point(0, 0);
            PanelMenu.Name = "PanelMenu";
            PanelMenu.Size = new Size(186, 749);
            PanelMenu.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(2, 239);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(181, 507);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // BtnCompteCourant
            // 
            BtnCompteCourant.FlatStyle = FlatStyle.Flat;
            BtnCompteCourant.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnCompteCourant.ForeColor = Color.White;
            BtnCompteCourant.ImageAlign = ContentAlignment.BottomCenter;
            BtnCompteCourant.Location = new Point(0, 188);
            BtnCompteCourant.Name = "BtnCompteCourant";
            BtnCompteCourant.Size = new Size(183, 45);
            BtnCompteCourant.TabIndex = 6;
            BtnCompteCourant.Text = "Compte Courant";
            BtnCompteCourant.UseVisualStyleBackColor = true;
            BtnCompteCourant.Click += BtnCompteCourant_Click;
            // 
            // BtnFrais
            // 
            BtnFrais.FlatStyle = FlatStyle.Flat;
            BtnFrais.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnFrais.ForeColor = Color.White;
            BtnFrais.ImageAlign = ContentAlignment.BottomCenter;
            BtnFrais.Location = new Point(2, 142);
            BtnFrais.Name = "BtnFrais";
            BtnFrais.Size = new Size(181, 45);
            BtnFrais.TabIndex = 5;
            BtnFrais.Text = "Frais";
            BtnFrais.UseVisualStyleBackColor = true;
            // 
            // BtnLocataire
            // 
            BtnLocataire.FlatStyle = FlatStyle.Flat;
            BtnLocataire.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnLocataire.ForeColor = Color.White;
            BtnLocataire.ImageAlign = ContentAlignment.BottomCenter;
            BtnLocataire.Location = new Point(0, 98);
            BtnLocataire.Name = "BtnLocataire";
            BtnLocataire.Size = new Size(183, 45);
            BtnLocataire.TabIndex = 3;
            BtnLocataire.Text = "Locataire";
            BtnLocataire.UseVisualStyleBackColor = true;
            BtnLocataire.Click += BtnLocataire_Click_1;
            // 
            // BtnAppartement
            // 
            BtnAppartement.FlatStyle = FlatStyle.Flat;
            BtnAppartement.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnAppartement.ForeColor = Color.White;
            BtnAppartement.ImageAlign = ContentAlignment.BottomCenter;
            BtnAppartement.Location = new Point(3, 53);
            BtnAppartement.Name = "BtnAppartement";
            BtnAppartement.Size = new Size(180, 45);
            BtnAppartement.TabIndex = 2;
            BtnAppartement.Text = "Appartement";
            BtnAppartement.UseVisualStyleBackColor = true;
            BtnAppartement.Click += BtnAppartement_Click;
            // 
            // BtnBatiment
            // 
            BtnBatiment.FlatStyle = FlatStyle.Flat;
            BtnBatiment.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnBatiment.ForeColor = Color.White;
            BtnBatiment.ImageAlign = ContentAlignment.BottomCenter;
            BtnBatiment.Location = new Point(3, 8);
            BtnBatiment.Name = "BtnBatiment";
            BtnBatiment.Size = new Size(180, 45);
            BtnBatiment.TabIndex = 1;
            BtnBatiment.Text = "Batiment";
            BtnBatiment.UseVisualStyleBackColor = true;
            BtnBatiment.Click += BtnBatiment_Click_1;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(TxtNomApp);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(ComboIDLOc);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(DGVAppartement);
            groupBox1.Controls.Add(BtnSupprimer);
            groupBox1.Controls.Add(ComboPiece);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(BtnModifier);
            groupBox1.Controls.Add(ComboStatut);
            groupBox1.Controls.Add(ComboCodeBat);
            groupBox1.Controls.Add(LblStatut);
            groupBox1.Controls.Add(TxtPrix);
            groupBox1.Controls.Add(TxtDetail);
            groupBox1.Controls.Add(TxtNumero);
            groupBox1.Controls.Add(BtnEnregistrer);
            groupBox1.Controls.Add(LblPrix);
            groupBox1.Controls.Add(LblCodebat);
            groupBox1.Controls.Add(LblDetails);
            groupBox1.Controls.Add(LblNum);
            groupBox1.Dock = DockStyle.Bottom;
            groupBox1.Location = new Point(186, 67);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1184, 682);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            // 
            // TxtNomApp
            // 
            TxtNomApp.Font = new Font("Roboto", 12F);
            TxtNomApp.Location = new Point(8, 114);
            TxtNomApp.Multiline = true;
            TxtNomApp.Name = "TxtNomApp";
            TxtNomApp.Size = new Size(304, 35);
            TxtNomApp.TabIndex = 37;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Roboto", 12F);
            label3.Location = new Point(10, 92);
            label3.Name = "label3";
            label3.Size = new Size(55, 19);
            label3.TabIndex = 36;
            label3.Text = "Nom : ";
            // 
            // ComboIDLOc
            // 
            ComboIDLOc.FormattingEnabled = true;
            ComboIDLOc.Location = new Point(350, 184);
            ComboIDLOc.Name = "ComboIDLOc";
            ComboIDLOc.Size = new Size(304, 23);
            ComboIDLOc.TabIndex = 35;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Roboto", 12F);
            label2.Location = new Point(350, 162);
            label2.Name = "label2";
            label2.Size = new Size(101, 19);
            label2.TabIndex = 34;
            label2.Text = "ID locataire : ";
            // 
            // DGVAppartement
            // 
            DGVAppartement.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGVAppartement.Dock = DockStyle.Bottom;
            DGVAppartement.Location = new Point(3, 394);
            DGVAppartement.Name = "DGVAppartement";
            DGVAppartement.Size = new Size(1178, 285);
            DGVAppartement.TabIndex = 33;
            // 
            // BtnSupprimer
            // 
            BtnSupprimer.Location = new Point(934, 75);
            BtnSupprimer.Name = "BtnSupprimer";
            BtnSupprimer.Size = new Size(149, 37);
            BtnSupprimer.TabIndex = 16;
            BtnSupprimer.Text = "Supprimer";
            BtnSupprimer.UseVisualStyleBackColor = true;
            BtnSupprimer.Click += BtnSupprimer_Click;
            // 
            // ComboPiece
            // 
            ComboPiece.FormattingEnabled = true;
            ComboPiece.Items.AddRange(new object[] { "1 pièce", "2 pièces ", "3 pièces ou plus" });
            ComboPiece.Location = new Point(350, 69);
            ComboPiece.Name = "ComboPiece";
            ComboPiece.Size = new Size(304, 23);
            ComboPiece.TabIndex = 15;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Roboto", 12F);
            label1.Location = new Point(350, 47);
            label1.Name = "label1";
            label1.Size = new Size(155, 19);
            label1.TabIndex = 14;
            label1.Text = "Nombre des pièces : ";
            // 
            // BtnModifier
            // 
            BtnModifier.Location = new Point(746, 75);
            BtnModifier.Name = "BtnModifier";
            BtnModifier.Size = new Size(178, 37);
            BtnModifier.TabIndex = 13;
            BtnModifier.Text = "Modifier";
            BtnModifier.UseVisualStyleBackColor = true;
            BtnModifier.Click += BtnModifier_Click;
            // 
            // ComboStatut
            // 
            ComboStatut.FormattingEnabled = true;
            ComboStatut.Items.AddRange(new object[] { "Occuper", "Libre", "En maintenance" });
            ComboStatut.Location = new Point(10, 365);
            ComboStatut.Name = "ComboStatut";
            ComboStatut.Size = new Size(304, 23);
            ComboStatut.TabIndex = 12;
            // 
            // ComboCodeBat
            // 
            ComboCodeBat.FormattingEnabled = true;
            ComboCodeBat.Location = new Point(350, 123);
            ComboCodeBat.Name = "ComboCodeBat";
            ComboCodeBat.Size = new Size(304, 23);
            ComboCodeBat.TabIndex = 11;
            // 
            // LblStatut
            // 
            LblStatut.AutoSize = true;
            LblStatut.Font = new Font("Roboto", 12F);
            LblStatut.Location = new Point(10, 343);
            LblStatut.Name = "LblStatut";
            LblStatut.Size = new Size(64, 19);
            LblStatut.TabIndex = 10;
            LblStatut.Text = "Statut : ";
            // 
            // TxtPrix
            // 
            TxtPrix.Font = new Font("Roboto", 12F);
            TxtPrix.Location = new Point(8, 181);
            TxtPrix.Multiline = true;
            TxtPrix.Name = "TxtPrix";
            TxtPrix.Size = new Size(304, 35);
            TxtPrix.TabIndex = 9;
            // 
            // TxtDetail
            // 
            TxtDetail.Font = new Font("Roboto", 12F);
            TxtDetail.Location = new Point(10, 241);
            TxtDetail.Multiline = true;
            TxtDetail.Name = "TxtDetail";
            TxtDetail.Size = new Size(429, 97);
            TxtDetail.TabIndex = 7;
            // 
            // TxtNumero
            // 
            TxtNumero.Font = new Font("Roboto", 12F);
            TxtNumero.Location = new Point(8, 47);
            TxtNumero.Multiline = true;
            TxtNumero.Name = "TxtNumero";
            TxtNumero.Size = new Size(304, 35);
            TxtNumero.TabIndex = 6;
            TxtNumero.TextChanged += TxtNumero_TextChanged;
            // 
            // BtnEnregistrer
            // 
            BtnEnregistrer.Location = new Point(746, 32);
            BtnEnregistrer.Name = "BtnEnregistrer";
            BtnEnregistrer.Size = new Size(337, 37);
            BtnEnregistrer.TabIndex = 3;
            BtnEnregistrer.Text = "Enregistrer";
            BtnEnregistrer.UseVisualStyleBackColor = true;
            BtnEnregistrer.Click += BtnEnregistrer_Click;
            // 
            // LblPrix
            // 
            LblPrix.AutoSize = true;
            LblPrix.Font = new Font("Roboto", 12F);
            LblPrix.Location = new Point(8, 156);
            LblPrix.Name = "LblPrix";
            LblPrix.Size = new Size(170, 19);
            LblPrix.TabIndex = 5;
            LblPrix.Text = "Prix de l'appartement : ";
            // 
            // LblCodebat
            // 
            LblCodebat.AutoSize = true;
            LblCodebat.Font = new Font("Roboto", 12F);
            LblCodebat.Location = new Point(350, 101);
            LblCodebat.Name = "LblCodebat";
            LblCodebat.Size = new Size(125, 19);
            LblCodebat.TabIndex = 4;
            LblCodebat.Text = "Code Batiment : ";
            // 
            // LblDetails
            // 
            LblDetails.AutoSize = true;
            LblDetails.Font = new Font("Roboto", 12F);
            LblDetails.Location = new Point(8, 219);
            LblDetails.Name = "LblDetails";
            LblDetails.Size = new Size(70, 19);
            LblDetails.TabIndex = 3;
            LblDetails.Text = "Détails : ";
            // 
            // LblNum
            // 
            LblNum.AutoSize = true;
            LblNum.Font = new Font("Roboto", 12F);
            LblNum.Location = new Point(8, 25);
            LblNum.Name = "LblNum";
            LblNum.Size = new Size(77, 19);
            LblNum.TabIndex = 2;
            LblNum.Text = "Numéro : ";
            // 
            // BtnListeAppart
            // 
            BtnListeAppart.Location = new Point(1021, 13);
            BtnListeAppart.Name = "BtnListeAppart";
            BtnListeAppart.Size = new Size(337, 37);
            BtnListeAppart.TabIndex = 13;
            BtnListeAppart.Text = "Liste des appartements";
            BtnListeAppart.UseVisualStyleBackColor = true;
            BtnListeAppart.Click += BtnListeAppart_Click;
            // 
            // lblBatiment
            // 
            lblBatiment.AutoSize = true;
            lblBatiment.FlatStyle = FlatStyle.Flat;
            lblBatiment.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBatiment.ForeColor = Color.White;
            lblBatiment.Location = new Point(536, 29);
            lblBatiment.Name = "lblBatiment";
            lblBatiment.Size = new Size(168, 24);
            lblBatiment.TabIndex = 14;
            lblBatiment.Text = "APPARTEMENT";
            lblBatiment.TextAlign = ContentAlignment.TopCenter;
            // 
            // FrmAppartement
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1370, 749);
            Controls.Add(lblBatiment);
            Controls.Add(BtnListeAppart);
            Controls.Add(groupBox1);
            Controls.Add(PanelMenu);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmAppartement";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmAppartement";
            WindowState = FormWindowState.Maximized;
            Load += FrmAppartement_Load;
            PanelMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DGVAppartement).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel PanelMenu;
        private Button BtnCompteCourant;
        private Button BtnFrais;
        private Button BtnLocataire;
        private Button BtnAppartement;
        private Button BtnBatiment;
        private PictureBox pictureBox1;
        private GroupBox groupBox1;
        private Label LblStatut;
        private TextBox TxtPrix;
        private TextBox TxtDetail;
        private TextBox TxtNumero;
        private Button BtnEnregistrer;
        private Label LblPrix;
        private Label LblCodebat;
        private Label LblDetails;
        private Label LblNum;
        private ComboBox ComboStatut;
        private ComboBox ComboCodeBat;
        private Button BtnModifier;
        private Button BtnListeAppart;
        private Label lblBatiment;
        private ComboBox ComboPiece;
        private Label label1;
        private Button BtnSupprimer;
        private DataGridView DGVAppartement;
        private ComboBox ComboIDLOc;
        private Label label2;
        private TextBox TxtNomApp;
        private Label label3;
    }
}