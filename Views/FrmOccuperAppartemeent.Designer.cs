namespace GESTAPP
{
    partial class FrmOccuperAppartemeent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmOccuperAppartemeent));
            DGVLocataire = new DataGridView();
            ComboStatut = new ComboBox();
            DateOccupation = new DateTimePicker();
            ComboMatricule = new ComboBox();
            label5 = new Label();
            TxtNombre = new TextBox();
            label1 = new Label();
            label4 = new Label();
            BtnModiifier = new Button();
            BtnSupprimer = new Button();
            lblGrade = new Label();
            BtnEnregistrer = new Button();
            lblMatricule = new Label();
            lblBatiment = new Label();
            pictureBox1 = new PictureBox();
            BtnCederLogement = new Button();
            BtnComptcourant = new Button();
            BtnOccuperAppartement = new Button();
            BtnDoossierLocatif = new Button();
            BtnFrais = new Button();
            BtnLocataire = new Button();
            BtnAppartement = new Button();
            BtnBatiment = new Button();
            groupBox1 = new GroupBox();
            ComboDossier = new ComboBox();
            label6 = new Label();
            ComboCodeAppart = new ComboBox();
            ComboIDLoc = new ComboBox();
            label3 = new Label();
            PanelMenu = new Panel();
            ((System.ComponentModel.ISupportInitialize)DGVLocataire).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            PanelMenu.SuspendLayout();
            SuspendLayout();
            // 
            // DGVLocataire
            // 
            DGVLocataire.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGVLocataire.Dock = DockStyle.Bottom;
            DGVLocataire.Location = new Point(3, 258);
            DGVLocataire.Name = "DGVLocataire";
            DGVLocataire.Size = new Size(982, 435);
            DGVLocataire.TabIndex = 31;
            // 
            // ComboStatut
            // 
            ComboStatut.FormattingEnabled = true;
            ComboStatut.Items.AddRange(new object[] { "Occuper", "Libre ", "En maintenace" });
            ComboStatut.Location = new Point(300, 99);
            ComboStatut.Name = "ComboStatut";
            ComboStatut.Size = new Size(243, 23);
            ComboStatut.TabIndex = 30;
            // 
            // DateOccupation
            // 
            DateOccupation.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DateOccupation.Format = DateTimePickerFormat.Short;
            DateOccupation.Location = new Point(16, 164);
            DateOccupation.Name = "DateOccupation";
            DateOccupation.Size = new Size(274, 27);
            DateOccupation.TabIndex = 28;
            // 
            // ComboMatricule
            // 
            ComboMatricule.FormattingEnabled = true;
            ComboMatricule.Location = new Point(16, 229);
            ComboMatricule.Name = "ComboMatricule";
            ComboMatricule.Size = new Size(353, 23);
            ComboMatricule.TabIndex = 26;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Roboto", 12F);
            label5.ForeColor = Color.White;
            label5.Location = new Point(16, 207);
            label5.Name = "label5";
            label5.Size = new Size(131, 19);
            label5.TabIndex = 27;
            label5.Text = "Matricule agent : ";
            // 
            // TxtNombre
            // 
            TxtNombre.Font = new Font("Roboto", 12F);
            TxtNombre.Location = new Point(16, 96);
            TxtNombre.Multiline = true;
            TxtNombre.Name = "TxtNombre";
            TxtNombre.Size = new Size(268, 30);
            TxtNombre.TabIndex = 25;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Roboto", 12F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(14, 74);
            label1.Name = "label1";
            label1.Size = new Size(201, 19);
            label1.TabIndex = 21;
            label1.Text = "Nombre de personne logé : ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Roboto", 12F);
            label4.ForeColor = Color.White;
            label4.Location = new Point(300, 71);
            label4.Name = "label4";
            label4.Size = new Size(68, 19);
            label4.TabIndex = 18;
            label4.Text = "Statiut : ";
            // 
            // BtnModiifier
            // 
            BtnModiifier.Location = new Point(703, 79);
            BtnModiifier.Name = "BtnModiifier";
            BtnModiifier.Size = new Size(237, 37);
            BtnModiifier.TabIndex = 17;
            BtnModiifier.Text = "Modifier";
            BtnModiifier.UseVisualStyleBackColor = true;
            // 
            // BtnSupprimer
            // 
            BtnSupprimer.Location = new Point(703, 127);
            BtnSupprimer.Name = "BtnSupprimer";
            BtnSupprimer.Size = new Size(237, 37);
            BtnSupprimer.TabIndex = 16;
            BtnSupprimer.Text = "Supprimer";
            BtnSupprimer.UseVisualStyleBackColor = true;
            // 
            // lblGrade
            // 
            lblGrade.AutoSize = true;
            lblGrade.Font = new Font("Roboto", 12F);
            lblGrade.ForeColor = Color.White;
            lblGrade.Location = new Point(16, 135);
            lblGrade.Name = "lblGrade";
            lblGrade.Size = new Size(149, 19);
            lblGrade.TabIndex = 12;
            lblGrade.Text = "Date d'occupation : ";
            // 
            // BtnEnregistrer
            // 
            BtnEnregistrer.Location = new Point(703, 27);
            BtnEnregistrer.Name = "BtnEnregistrer";
            BtnEnregistrer.Size = new Size(237, 37);
            BtnEnregistrer.TabIndex = 3;
            BtnEnregistrer.Text = "Enregistrer";
            BtnEnregistrer.UseVisualStyleBackColor = true;
            BtnEnregistrer.Click += BtnEnregistrer_Click;
            // 
            // lblMatricule
            // 
            lblMatricule.AutoSize = true;
            lblMatricule.Font = new Font("Roboto", 12F);
            lblMatricule.ForeColor = Color.White;
            lblMatricule.Location = new Point(11, 19);
            lblMatricule.Name = "lblMatricule";
            lblMatricule.RightToLeft = RightToLeft.No;
            lblMatricule.Size = new Size(101, 19);
            lblMatricule.TabIndex = 2;
            lblMatricule.Text = "ID locataire : ";
            // 
            // lblBatiment
            // 
            lblBatiment.AutoSize = true;
            lblBatiment.FlatStyle = FlatStyle.Flat;
            lblBatiment.Font = new Font("Roboto", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBatiment.Location = new Point(533, 16);
            lblBatiment.Name = "lblBatiment";
            lblBatiment.Size = new Size(267, 23);
            lblBatiment.TabIndex = 10;
            lblBatiment.Text = "Occupation des appartements";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(4, 377);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(170, 364);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // BtnCederLogement
            // 
            BtnCederLogement.FlatStyle = FlatStyle.Flat;
            BtnCederLogement.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnCederLogement.ForeColor = Color.White;
            BtnCederLogement.ImageAlign = ContentAlignment.BottomCenter;
            BtnCederLogement.Location = new Point(2, 326);
            BtnCederLogement.Name = "BtnCederLogement";
            BtnCederLogement.Size = new Size(190, 45);
            BtnCederLogement.TabIndex = 9;
            BtnCederLogement.Text = "Céder Appartement";
            BtnCederLogement.UseVisualStyleBackColor = true;
            // 
            // BtnComptcourant
            // 
            BtnComptcourant.FlatStyle = FlatStyle.Flat;
            BtnComptcourant.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnComptcourant.ForeColor = Color.White;
            BtnComptcourant.ImageAlign = ContentAlignment.BottomCenter;
            BtnComptcourant.Location = new Point(0, 234);
            BtnComptcourant.Name = "BtnComptcourant";
            BtnComptcourant.Size = new Size(190, 45);
            BtnComptcourant.TabIndex = 8;
            BtnComptcourant.Text = "Compte Courant";
            BtnComptcourant.UseVisualStyleBackColor = true;
            // 
            // BtnOccuperAppartement
            // 
            BtnOccuperAppartement.FlatStyle = FlatStyle.Flat;
            BtnOccuperAppartement.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnOccuperAppartement.ForeColor = Color.White;
            BtnOccuperAppartement.ImageAlign = ContentAlignment.BottomCenter;
            BtnOccuperAppartement.Location = new Point(0, 279);
            BtnOccuperAppartement.Name = "BtnOccuperAppartement";
            BtnOccuperAppartement.Size = new Size(190, 45);
            BtnOccuperAppartement.TabIndex = 7;
            BtnOccuperAppartement.Text = "Occuper Appartement";
            BtnOccuperAppartement.UseVisualStyleBackColor = true;
            // 
            // BtnDoossierLocatif
            // 
            BtnDoossierLocatif.FlatStyle = FlatStyle.Flat;
            BtnDoossierLocatif.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnDoossierLocatif.ForeColor = Color.White;
            BtnDoossierLocatif.ImageAlign = ContentAlignment.BottomCenter;
            BtnDoossierLocatif.Location = new Point(0, 189);
            BtnDoossierLocatif.Name = "BtnDoossierLocatif";
            BtnDoossierLocatif.Size = new Size(190, 45);
            BtnDoossierLocatif.TabIndex = 6;
            BtnDoossierLocatif.Text = "Dossier locatif";
            BtnDoossierLocatif.UseVisualStyleBackColor = true;
            // 
            // BtnFrais
            // 
            BtnFrais.FlatStyle = FlatStyle.Flat;
            BtnFrais.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnFrais.ForeColor = Color.White;
            BtnFrais.ImageAlign = ContentAlignment.BottomCenter;
            BtnFrais.Location = new Point(2, 144);
            BtnFrais.Name = "BtnFrais";
            BtnFrais.Size = new Size(190, 45);
            BtnFrais.TabIndex = 5;
            BtnFrais.Text = "Payement des frais";
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
            BtnLocataire.Size = new Size(190, 45);
            BtnLocataire.TabIndex = 3;
            BtnLocataire.Text = "Locataire";
            BtnLocataire.UseVisualStyleBackColor = true;
            // 
            // BtnAppartement
            // 
            BtnAppartement.FlatStyle = FlatStyle.Flat;
            BtnAppartement.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnAppartement.ForeColor = Color.White;
            BtnAppartement.ImageAlign = ContentAlignment.BottomCenter;
            BtnAppartement.Location = new Point(3, 53);
            BtnAppartement.Name = "BtnAppartement";
            BtnAppartement.Size = new Size(190, 45);
            BtnAppartement.TabIndex = 2;
            BtnAppartement.Text = "Appartement";
            BtnAppartement.UseVisualStyleBackColor = true;
            // 
            // BtnBatiment
            // 
            BtnBatiment.FlatStyle = FlatStyle.Flat;
            BtnBatiment.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnBatiment.ForeColor = Color.White;
            BtnBatiment.ImageAlign = ContentAlignment.BottomCenter;
            BtnBatiment.Location = new Point(3, 6);
            BtnBatiment.Name = "BtnBatiment";
            BtnBatiment.Size = new Size(190, 45);
            BtnBatiment.TabIndex = 1;
            BtnBatiment.Text = "Batiment";
            BtnBatiment.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(ComboDossier);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(ComboCodeAppart);
            groupBox1.Controls.Add(ComboIDLoc);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(DGVLocataire);
            groupBox1.Controls.Add(ComboStatut);
            groupBox1.Controls.Add(DateOccupation);
            groupBox1.Controls.Add(ComboMatricule);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(TxtNombre);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(BtnModiifier);
            groupBox1.Controls.Add(BtnSupprimer);
            groupBox1.Controls.Add(lblGrade);
            groupBox1.Controls.Add(BtnEnregistrer);
            groupBox1.Controls.Add(lblMatricule);
            groupBox1.Dock = DockStyle.Bottom;
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(196, 53);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(988, 696);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            // 
            // ComboDossier
            // 
            ComboDossier.FormattingEnabled = true;
            ComboDossier.Items.AddRange(new object[] { "Marié", "Cellibataire", "Divorcé", "Veuf", "Veuve" });
            ComboDossier.Location = new Point(300, 158);
            ComboDossier.Name = "ComboDossier";
            ComboDossier.Size = new Size(243, 23);
            ComboDossier.TabIndex = 37;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Roboto", 12F);
            label6.ForeColor = Color.White;
            label6.Location = new Point(300, 130);
            label6.Name = "label6";
            label6.Size = new Size(112, 19);
            label6.TabIndex = 36;
            label6.Text = "Code dossier : ";
            // 
            // ComboCodeAppart
            // 
            ComboCodeAppart.FormattingEnabled = true;
            ComboCodeAppart.Items.AddRange(new object[] { "Marié", "Cellibataire", "Divorcé", "Veuf", "Veuve" });
            ComboCodeAppart.Location = new Point(300, 41);
            ComboCodeAppart.Name = "ComboCodeAppart";
            ComboCodeAppart.Size = new Size(243, 23);
            ComboCodeAppart.TabIndex = 35;
            // 
            // ComboIDLoc
            // 
            ComboIDLoc.FormattingEnabled = true;
            ComboIDLoc.Items.AddRange(new object[] { "Marié", "Cellibataire", "Divorcé", "Veuf", "Veuve" });
            ComboIDLoc.Location = new Point(16, 41);
            ComboIDLoc.Name = "ComboIDLoc";
            ComboIDLoc.Size = new Size(268, 23);
            ComboIDLoc.TabIndex = 34;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Roboto", 12F);
            label3.ForeColor = Color.White;
            label3.Location = new Point(300, 13);
            label3.Name = "label3";
            label3.Size = new Size(179, 19);
            label3.TabIndex = 32;
            label3.Text = "Code de l'appartement : ";
            // 
            // PanelMenu
            // 
            PanelMenu.Controls.Add(pictureBox1);
            PanelMenu.Controls.Add(BtnCederLogement);
            PanelMenu.Controls.Add(BtnComptcourant);
            PanelMenu.Controls.Add(BtnOccuperAppartement);
            PanelMenu.Controls.Add(BtnDoossierLocatif);
            PanelMenu.Controls.Add(BtnFrais);
            PanelMenu.Controls.Add(BtnLocataire);
            PanelMenu.Controls.Add(BtnAppartement);
            PanelMenu.Controls.Add(BtnBatiment);
            PanelMenu.Dock = DockStyle.Left;
            PanelMenu.Location = new Point(0, 0);
            PanelMenu.Name = "PanelMenu";
            PanelMenu.Size = new Size(196, 749);
            PanelMenu.TabIndex = 8;
            // 
            // FrmOccuperAppartemeent
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1184, 749);
            Controls.Add(lblBatiment);
            Controls.Add(groupBox1);
            Controls.Add(PanelMenu);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmOccuperAppartemeent";
            Text = "FrmOccuperAppartemeent";
            WindowState = FormWindowState.Maximized;
            Load += FrmOccuperAppartemeent_Load;
            ((System.ComponentModel.ISupportInitialize)DGVLocataire).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            PanelMenu.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView DGVLocataire;
        private ComboBox ComboStatut;
        private DateTimePicker DateOccupation;
        private ComboBox ComboMatricule;
        private Label label5;
        private TextBox TxtNombre;
        private Label label1;
        private Label label4;
        private Button BtnModiifier;
        private Button BtnSupprimer;
        private Label lblGrade;
        private Button BtnEnregistrer;
        private Label lblMatricule;
        private Label lblBatiment;
        private PictureBox pictureBox1;
        private Button BtnCederLogement;
        private Button BtnComptcourant;
        private Button BtnOccuperAppartement;
        private Button BtnDoossierLocatif;
        private Button BtnFrais;
        private Button BtnLocataire;
        private Button BtnAppartement;
        private Button BtnBatiment;
        private GroupBox groupBox1;
        private Panel PanelMenu;
        private Label label3;
        private ComboBox ComboIDLoc;
        private ComboBox ComboCodeAppart;
        private ComboBox ComboDossier;
        private Label label6;
    }
}