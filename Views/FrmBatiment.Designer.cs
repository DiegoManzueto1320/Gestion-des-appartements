namespace GESTAPP
{
    partial class FrmBatiment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBatiment));
            PanelMenu = new Panel();
            pictureBox1 = new PictureBox();
            BtnCompteCourant = new Button();
            BtnFrais = new Button();
            BtnLocataire = new Button();
            BtnAppartement = new Button();
            BtnBatiment = new Button();
            panel1 = new Panel();
            BtnSupprimer = new Button();
            BtnNouveau = new Button();
            lblBatiment = new Label();
            groupBox1 = new GroupBox();
            DVGBatiment = new DataGridView();
            TXTNombreUnite = new TextBox();
            TXTAdresse = new TextBox();
            TxtLibelle = new TextBox();
            TxtCode = new TextBox();
            lblNombreUnite = new Label();
            lblAdresse = new Label();
            lblLibelle = new Label();
            lblCode = new Label();
            BtnEnregistrer = new Button();
            PanelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DVGBatiment).BeginInit();
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
            PanelMenu.Size = new Size(175, 553);
            PanelMenu.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(5, 243);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(170, 304);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // BtnCompteCourant
            // 
            BtnCompteCourant.BackColor = Color.Transparent;
            BtnCompteCourant.FlatStyle = FlatStyle.Flat;
            BtnCompteCourant.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnCompteCourant.ForeColor = Color.Transparent;
            BtnCompteCourant.ImageAlign = ContentAlignment.BottomCenter;
            BtnCompteCourant.Location = new Point(5, 186);
            BtnCompteCourant.Name = "BtnCompteCourant";
            BtnCompteCourant.Size = new Size(170, 45);
            BtnCompteCourant.TabIndex = 6;
            BtnCompteCourant.Text = "Compte Courant";
            BtnCompteCourant.UseVisualStyleBackColor = false;
            BtnCompteCourant.Click += BtnCompteCourant_Click;
            // 
            // BtnFrais
            // 
            BtnFrais.BackColor = Color.Transparent;
            BtnFrais.FlatStyle = FlatStyle.Flat;
            BtnFrais.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnFrais.ForeColor = Color.Transparent;
            BtnFrais.ImageAlign = ContentAlignment.BottomCenter;
            BtnFrais.Location = new Point(3, 141);
            BtnFrais.Name = "BtnFrais";
            BtnFrais.Size = new Size(170, 45);
            BtnFrais.TabIndex = 5;
            BtnFrais.Text = "Frais";
            BtnFrais.UseVisualStyleBackColor = false;
            // 
            // BtnLocataire
            // 
            BtnLocataire.BackColor = Color.Transparent;
            BtnLocataire.FlatStyle = FlatStyle.Flat;
            BtnLocataire.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnLocataire.ForeColor = Color.Transparent;
            BtnLocataire.ImageAlign = ContentAlignment.BottomCenter;
            BtnLocataire.Location = new Point(2, 98);
            BtnLocataire.Name = "BtnLocataire";
            BtnLocataire.Size = new Size(170, 45);
            BtnLocataire.TabIndex = 3;
            BtnLocataire.Text = "Locataire";
            BtnLocataire.UseVisualStyleBackColor = false;
            BtnLocataire.Click += BtnLocataire_Click_1;
            // 
            // BtnAppartement
            // 
            BtnAppartement.BackColor = Color.Transparent;
            BtnAppartement.FlatStyle = FlatStyle.Flat;
            BtnAppartement.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnAppartement.ForeColor = Color.Transparent;
            BtnAppartement.ImageAlign = ContentAlignment.BottomCenter;
            BtnAppartement.Location = new Point(3, 53);
            BtnAppartement.Name = "BtnAppartement";
            BtnAppartement.Size = new Size(170, 45);
            BtnAppartement.TabIndex = 2;
            BtnAppartement.Text = "Appartement";
            BtnAppartement.UseVisualStyleBackColor = false;
            BtnAppartement.Click += BtnAppartement_Click_1;
            // 
            // BtnBatiment
            // 
            BtnBatiment.BackColor = Color.Transparent;
            BtnBatiment.FlatStyle = FlatStyle.Flat;
            BtnBatiment.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnBatiment.ForeColor = Color.Transparent;
            BtnBatiment.ImageAlign = ContentAlignment.BottomCenter;
            BtnBatiment.Location = new Point(3, 8);
            BtnBatiment.Name = "BtnBatiment";
            BtnBatiment.Size = new Size(170, 45);
            BtnBatiment.TabIndex = 1;
            BtnBatiment.Text = "Batiment";
            BtnBatiment.UseVisualStyleBackColor = false;
            BtnBatiment.Click += BtnBatiment_Click_1;
            // 
            // panel1
            // 
            panel1.BackColor = Color.WhiteSmoke;
            panel1.Controls.Add(BtnSupprimer);
            panel1.Controls.Add(BtnNouveau);
            panel1.Controls.Add(lblBatiment);
            panel1.Controls.Add(groupBox1);
            panel1.Controls.Add(BtnEnregistrer);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(175, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(809, 553);
            panel1.TabIndex = 2;
            // 
            // BtnSupprimer
            // 
            BtnSupprimer.Location = new Point(441, 98);
            BtnSupprimer.Name = "BtnSupprimer";
            BtnSupprimer.Size = new Size(356, 37);
            BtnSupprimer.TabIndex = 4;
            BtnSupprimer.Text = "Supprimer";
            BtnSupprimer.UseVisualStyleBackColor = true;
            BtnSupprimer.Click += BtnSupprimer_Click;
            // 
            // BtnNouveau
            // 
            BtnNouveau.Location = new Point(441, 10);
            BtnNouveau.Name = "BtnNouveau";
            BtnNouveau.Size = new Size(356, 37);
            BtnNouveau.TabIndex = 2;
            BtnNouveau.Text = "Modifier";
            BtnNouveau.UseVisualStyleBackColor = true;
            BtnNouveau.Click += BtnNouveau_Click;
            // 
            // lblBatiment
            // 
            lblBatiment.AutoSize = true;
            lblBatiment.FlatStyle = FlatStyle.Flat;
            lblBatiment.Font = new Font("Roboto", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBatiment.Location = new Point(111, 30);
            lblBatiment.Name = "lblBatiment";
            lblBatiment.Size = new Size(105, 23);
            lblBatiment.TabIndex = 1;
            lblBatiment.Text = "BATIMENT";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(DVGBatiment);
            groupBox1.Controls.Add(TXTNombreUnite);
            groupBox1.Controls.Add(TXTAdresse);
            groupBox1.Controls.Add(TxtLibelle);
            groupBox1.Controls.Add(TxtCode);
            groupBox1.Controls.Add(lblNombreUnite);
            groupBox1.Controls.Add(lblAdresse);
            groupBox1.Controls.Add(lblLibelle);
            groupBox1.Controls.Add(lblCode);
            groupBox1.Dock = DockStyle.Bottom;
            groupBox1.Location = new Point(0, 141);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(809, 412);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // DVGBatiment
            // 
            DVGBatiment.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DVGBatiment.Dock = DockStyle.Bottom;
            DVGBatiment.Location = new Point(3, 151);
            DVGBatiment.Name = "DVGBatiment";
            DVGBatiment.Size = new Size(803, 258);
            DVGBatiment.TabIndex = 32;
            // 
            // TXTNombreUnite
            // 
            TXTNombreUnite.Font = new Font("Roboto", 12F);
            TXTNombreUnite.Location = new Point(383, 112);
            TXTNombreUnite.Multiline = true;
            TXTNombreUnite.Name = "TXTNombreUnite";
            TXTNombreUnite.Size = new Size(353, 35);
            TXTNombreUnite.TabIndex = 9;
            // 
            // TXTAdresse
            // 
            TXTAdresse.Font = new Font("Roboto", 12F);
            TXTAdresse.Location = new Point(15, 110);
            TXTAdresse.Multiline = true;
            TXTAdresse.Name = "TXTAdresse";
            TXTAdresse.Size = new Size(353, 35);
            TXTAdresse.TabIndex = 8;
            // 
            // TxtLibelle
            // 
            TxtLibelle.Font = new Font("Roboto", 12F);
            TxtLibelle.Location = new Point(383, 41);
            TxtLibelle.Multiline = true;
            TxtLibelle.Name = "TxtLibelle";
            TxtLibelle.Size = new Size(353, 35);
            TxtLibelle.TabIndex = 7;
            // 
            // TxtCode
            // 
            TxtCode.Font = new Font("Roboto", 12F);
            TxtCode.Location = new Point(15, 41);
            TxtCode.Multiline = true;
            TxtCode.Name = "TxtCode";
            TxtCode.Size = new Size(353, 35);
            TxtCode.TabIndex = 6;
            TxtCode.TextChanged += TxtCode_TextChanged;
            // 
            // lblNombreUnite
            // 
            lblNombreUnite.AutoSize = true;
            lblNombreUnite.Font = new Font("Roboto", 12F);
            lblNombreUnite.Location = new Point(392, 90);
            lblNombreUnite.Name = "lblNombreUnite";
            lblNombreUnite.Size = new Size(191, 19);
            lblNombreUnite.TabIndex = 5;
            lblNombreUnite.Text = "Nombre d'appartements : ";
            // 
            // lblAdresse
            // 
            lblAdresse.AutoSize = true;
            lblAdresse.Font = new Font("Roboto", 12F);
            lblAdresse.Location = new Point(15, 79);
            lblAdresse.Name = "lblAdresse";
            lblAdresse.Size = new Size(77, 19);
            lblAdresse.TabIndex = 4;
            lblAdresse.Text = "Adresse : ";
            // 
            // lblLibelle
            // 
            lblLibelle.AutoSize = true;
            lblLibelle.Font = new Font("Roboto", 12F);
            lblLibelle.Location = new Point(392, 19);
            lblLibelle.Name = "lblLibelle";
            lblLibelle.Size = new Size(71, 19);
            lblLibelle.TabIndex = 3;
            lblLibelle.Text = "Libelllé : ";
            // 
            // lblCode
            // 
            lblCode.AutoSize = true;
            lblCode.Font = new Font("Roboto", 12F);
            lblCode.Location = new Point(15, 19);
            lblCode.Name = "lblCode";
            lblCode.Size = new Size(57, 19);
            lblCode.TabIndex = 2;
            lblCode.Text = "Code : ";
            // 
            // BtnEnregistrer
            // 
            BtnEnregistrer.Location = new Point(441, 55);
            BtnEnregistrer.Name = "BtnEnregistrer";
            BtnEnregistrer.Size = new Size(356, 37);
            BtnEnregistrer.TabIndex = 3;
            BtnEnregistrer.Text = "Enregistrer";
            BtnEnregistrer.UseVisualStyleBackColor = true;
            BtnEnregistrer.Click += BtnEnregistrer_Click;
            // 
            // FrmBatiment
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(984, 553);
            Controls.Add(panel1);
            Controls.Add(PanelMenu);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmBatiment";
            StartPosition = FormStartPosition.CenterScreen;
            Load += Batiment_Load;
            PanelMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DVGBatiment).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel PanelMenu;
        private Button BtnCompteCourant;
        private Button BtnFrais;
        private Button BtnLocataire;
        private Button BtnAppartement;
        private Button BtnBatiment;
        private Panel panel1;
        private Label lblBatiment;
        private GroupBox groupBox1;
        private Label lblNombreUnite;
        private Label lblAdresse;
        private Label lblLibelle;
        private Label lblCode;
        private Button BtnNouveau;
        private TextBox TXTNombreUnite;
        private TextBox TXTAdresse;
        private TextBox TxtLibelle;
        private TextBox TxtCode;
        private Button BtnEnregistrer;
        private PictureBox pictureBox1;
        private DataGridView DVGBatiment;
        private Button BtnSupprimer;
    }
}