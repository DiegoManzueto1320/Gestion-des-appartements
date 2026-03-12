namespace GESTAPP.Views
{
    partial class FrmContratBail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmContratBail));
            BtnModifier = new Button();
            BtnSupprimer = new Button();
            DGVContrat = new DataGridView();
            ComboLoc = new ComboBox();
            BtnEnregistrer = new Button();
            ComboMatriculeAgent = new ComboBox();
            lblGrade = new Label();
            lblSexeAgent = new Label();
            TxtDetails = new TextBox();
            TxtLibelle = new TextBox();
            groupBox1 = new GroupBox();
            DateContrat = new DateTimePicker();
            TxtNum = new TextBox();
            lblPrenomAgent = new Label();
            lblPostnomAgent = new Label();
            lblNomAgent = new Label();
            lblMatricule = new Label();
            pictureBox1 = new PictureBox();
            BtnAppartement = new Button();
            lblBatiment = new Label();
            PanelMenu = new Panel();
            BtnQuitter = new Button();
            BtnSedeconnecter = new Button();
            BtnCompteCourant = new Button();
            BtnImprimer = new Button();
            ((System.ComponentModel.ISupportInitialize)DGVContrat).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            PanelMenu.SuspendLayout();
            SuspendLayout();
            // 
            // BtnModifier
            // 
            BtnModifier.Location = new Point(803, 13);
            BtnModifier.Name = "BtnModifier";
            BtnModifier.Size = new Size(237, 37);
            BtnModifier.TabIndex = 33;
            BtnModifier.Text = "Modifier";
            BtnModifier.UseVisualStyleBackColor = true;
            BtnModifier.Click += BtnModifier_Click;
            // 
            // BtnSupprimer
            // 
            BtnSupprimer.Location = new Point(803, 56);
            BtnSupprimer.Name = "BtnSupprimer";
            BtnSupprimer.Size = new Size(237, 37);
            BtnSupprimer.TabIndex = 19;
            BtnSupprimer.Text = "Supprimer";
            BtnSupprimer.UseVisualStyleBackColor = true;
            BtnSupprimer.Click += BtnSupprimer_Click;
            // 
            // DGVContrat
            // 
            DGVContrat.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGVContrat.Dock = DockStyle.Bottom;
            DGVContrat.Location = new Point(3, 295);
            DGVContrat.Name = "DGVContrat";
            DGVContrat.Size = new Size(1189, 398);
            DGVContrat.TabIndex = 32;
            // 
            // ComboLoc
            // 
            ComboLoc.FormattingEnabled = true;
            ComboLoc.Items.AddRange(new object[] { "Masculin", "Feminin" });
            ComboLoc.Location = new Point(391, 149);
            ComboLoc.Name = "ComboLoc";
            ComboLoc.Size = new Size(263, 23);
            ComboLoc.TabIndex = 9;
            // 
            // BtnEnregistrer
            // 
            BtnEnregistrer.Location = new Point(493, 13);
            BtnEnregistrer.Name = "BtnEnregistrer";
            BtnEnregistrer.Size = new Size(304, 37);
            BtnEnregistrer.TabIndex = 18;
            BtnEnregistrer.Text = "Enregistrer";
            BtnEnregistrer.UseVisualStyleBackColor = true;
            BtnEnregistrer.Click += BtnEnregistrer_Click;
            // 
            // ComboMatriculeAgent
            // 
            ComboMatriculeAgent.FormattingEnabled = true;
            ComboMatriculeAgent.Location = new Point(391, 194);
            ComboMatriculeAgent.Name = "ComboMatriculeAgent";
            ComboMatriculeAgent.Size = new Size(263, 23);
            ComboMatriculeAgent.TabIndex = 10;
            // 
            // lblGrade
            // 
            lblGrade.AutoSize = true;
            lblGrade.Font = new Font("Roboto", 12F);
            lblGrade.Location = new Point(391, 172);
            lblGrade.Name = "lblGrade";
            lblGrade.Size = new Size(131, 19);
            lblGrade.TabIndex = 12;
            lblGrade.Text = "Matricule agent : ";
            // 
            // lblSexeAgent
            // 
            lblSexeAgent.AutoSize = true;
            lblSexeAgent.Font = new Font("Roboto", 12F);
            lblSexeAgent.Location = new Point(391, 124);
            lblSexeAgent.Name = "lblSexeAgent";
            lblSexeAgent.Size = new Size(101, 19);
            lblSexeAgent.TabIndex = 10;
            lblSexeAgent.Text = "ID locataire : ";
            // 
            // TxtDetails
            // 
            TxtDetails.Font = new Font("Roboto", 12F);
            TxtDetails.Location = new Point(11, 141);
            TxtDetails.Multiline = true;
            TxtDetails.Name = "TxtDetails";
            TxtDetails.Size = new Size(353, 148);
            TxtDetails.TabIndex = 9;
            // 
            // TxtLibelle
            // 
            TxtLibelle.Font = new Font("Roboto", 12F);
            TxtLibelle.Location = new Point(11, 86);
            TxtLibelle.Multiline = true;
            TxtLibelle.Name = "TxtLibelle";
            TxtLibelle.Size = new Size(353, 30);
            TxtLibelle.TabIndex = 7;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(DateContrat);
            groupBox1.Controls.Add(BtnModifier);
            groupBox1.Controls.Add(BtnSupprimer);
            groupBox1.Controls.Add(DGVContrat);
            groupBox1.Controls.Add(ComboLoc);
            groupBox1.Controls.Add(BtnEnregistrer);
            groupBox1.Controls.Add(ComboMatriculeAgent);
            groupBox1.Controls.Add(lblGrade);
            groupBox1.Controls.Add(lblSexeAgent);
            groupBox1.Controls.Add(TxtDetails);
            groupBox1.Controls.Add(TxtLibelle);
            groupBox1.Controls.Add(TxtNum);
            groupBox1.Controls.Add(lblPrenomAgent);
            groupBox1.Controls.Add(lblPostnomAgent);
            groupBox1.Controls.Add(lblNomAgent);
            groupBox1.Controls.Add(lblMatricule);
            groupBox1.Dock = DockStyle.Bottom;
            groupBox1.Location = new Point(175, 53);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1195, 696);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            // 
            // DateContrat
            // 
            DateContrat.CalendarFont = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DateContrat.Format = DateTimePickerFormat.Short;
            DateContrat.Location = new Point(391, 86);
            DateContrat.Name = "DateContrat";
            DateContrat.Size = new Size(212, 23);
            DateContrat.TabIndex = 36;
            // 
            // TxtNum
            // 
            TxtNum.Font = new Font("Roboto", 12F);
            TxtNum.Location = new Point(92, 16);
            TxtNum.Multiline = true;
            TxtNum.Name = "TxtNum";
            TxtNum.Size = new Size(353, 30);
            TxtNum.TabIndex = 6;
            TxtNum.TextChanged += TxtNum_TextChanged;
            // 
            // lblPrenomAgent
            // 
            lblPrenomAgent.AutoSize = true;
            lblPrenomAgent.Font = new Font("Roboto", 12F);
            lblPrenomAgent.Location = new Point(11, 119);
            lblPrenomAgent.Name = "lblPrenomAgent";
            lblPrenomAgent.Size = new Size(141, 19);
            lblPrenomAgent.TabIndex = 5;
            lblPrenomAgent.Text = "Détails du contat : ";
            // 
            // lblPostnomAgent
            // 
            lblPostnomAgent.AutoSize = true;
            lblPostnomAgent.Font = new Font("Roboto", 12F);
            lblPostnomAgent.Location = new Point(391, 64);
            lblPostnomAgent.Name = "lblPostnomAgent";
            lblPostnomAgent.Size = new Size(220, 19);
            lblPostnomAgent.TabIndex = 4;
            lblPostnomAgent.Text = "Date de la crétion du contrat : ";
            // 
            // lblNomAgent
            // 
            lblNomAgent.AutoSize = true;
            lblNomAgent.Font = new Font("Roboto", 12F);
            lblNomAgent.Location = new Point(11, 59);
            lblNomAgent.Name = "lblNomAgent";
            lblNomAgent.Size = new Size(67, 19);
            lblNomAgent.TabIndex = 3;
            lblNomAgent.Text = "Libellé : ";
            // 
            // lblMatricule
            // 
            lblMatricule.AutoSize = true;
            lblMatricule.Font = new Font("Roboto", 12F);
            lblMatricule.Location = new Point(9, 19);
            lblMatricule.Name = "lblMatricule";
            lblMatricule.Size = new Size(77, 19);
            lblMatricule.TabIndex = 2;
            lblMatricule.Text = "Numero : ";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-1, 182);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(170, 564);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // BtnAppartement
            // 
            BtnAppartement.FlatStyle = FlatStyle.Flat;
            BtnAppartement.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnAppartement.ForeColor = Color.White;
            BtnAppartement.ImageAlign = ContentAlignment.BottomCenter;
            BtnAppartement.Location = new Point(2, 3);
            BtnAppartement.Name = "BtnAppartement";
            BtnAppartement.Size = new Size(170, 45);
            BtnAppartement.TabIndex = 2;
            BtnAppartement.Text = "Batiment";
            BtnAppartement.UseVisualStyleBackColor = true;
            BtnAppartement.Click += BtnAppartement_Click;
            // 
            // lblBatiment
            // 
            lblBatiment.AutoSize = true;
            lblBatiment.FlatStyle = FlatStyle.Flat;
            lblBatiment.Font = new Font("Roboto", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBatiment.Location = new Point(599, 18);
            lblBatiment.Name = "lblBatiment";
            lblBatiment.Size = new Size(169, 23);
            lblBatiment.TabIndex = 7;
            lblBatiment.Text = "CONTRAT DE BAIL";
            // 
            // PanelMenu
            // 
            PanelMenu.Controls.Add(BtnQuitter);
            PanelMenu.Controls.Add(BtnSedeconnecter);
            PanelMenu.Controls.Add(pictureBox1);
            PanelMenu.Controls.Add(BtnCompteCourant);
            PanelMenu.Controls.Add(BtnAppartement);
            PanelMenu.Dock = DockStyle.Left;
            PanelMenu.Location = new Point(0, 0);
            PanelMenu.Name = "PanelMenu";
            PanelMenu.Size = new Size(175, 749);
            PanelMenu.TabIndex = 5;
            // 
            // BtnQuitter
            // 
            BtnQuitter.FlatStyle = FlatStyle.Flat;
            BtnQuitter.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnQuitter.ForeColor = Color.White;
            BtnQuitter.ImageAlign = ContentAlignment.BottomCenter;
            BtnQuitter.Location = new Point(2, 131);
            BtnQuitter.Name = "BtnQuitter";
            BtnQuitter.Size = new Size(170, 45);
            BtnQuitter.TabIndex = 10;
            BtnQuitter.Text = "Quitter";
            BtnQuitter.UseVisualStyleBackColor = true;
            BtnQuitter.Click += BtnQuitter_Click;
            // 
            // BtnSedeconnecter
            // 
            BtnSedeconnecter.FlatStyle = FlatStyle.Flat;
            BtnSedeconnecter.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnSedeconnecter.ForeColor = Color.White;
            BtnSedeconnecter.ImageAlign = ContentAlignment.BottomCenter;
            BtnSedeconnecter.Location = new Point(2, 86);
            BtnSedeconnecter.Name = "BtnSedeconnecter";
            BtnSedeconnecter.Size = new Size(170, 45);
            BtnSedeconnecter.TabIndex = 9;
            BtnSedeconnecter.Text = "Se déconnceter";
            BtnSedeconnecter.UseVisualStyleBackColor = true;
            BtnSedeconnecter.Click += BtnSedeconnecter_Click;
            // 
            // BtnCompteCourant
            // 
            BtnCompteCourant.FlatStyle = FlatStyle.Flat;
            BtnCompteCourant.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnCompteCourant.ForeColor = Color.White;
            BtnCompteCourant.ImageAlign = ContentAlignment.BottomCenter;
            BtnCompteCourant.Location = new Point(2, 48);
            BtnCompteCourant.Name = "BtnCompteCourant";
            BtnCompteCourant.Size = new Size(170, 45);
            BtnCompteCourant.TabIndex = 6;
            BtnCompteCourant.Text = "Appartement";
            BtnCompteCourant.UseVisualStyleBackColor = true;
            BtnCompteCourant.Click += BtnCompteCourant_Click;
            // 
            // BtnImprimer
            // 
            BtnImprimer.Location = new Point(978, 8);
            BtnImprimer.Name = "BtnImprimer";
            BtnImprimer.Size = new Size(356, 37);
            BtnImprimer.TabIndex = 13;
            BtnImprimer.Text = "Imprimer";
            BtnImprimer.UseVisualStyleBackColor = true;
            BtnImprimer.Click += BtnImprimer_Click;
            // 
            // FrmContratBail
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1370, 749);
            Controls.Add(BtnImprimer);
            Controls.Add(groupBox1);
            Controls.Add(lblBatiment);
            Controls.Add(PanelMenu);
            Name = "FrmContratBail";
            Text = "FrmContratBail";
            Load += FrmContratBail_Load;
            ((System.ComponentModel.ISupportInitialize)DGVContrat).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            PanelMenu.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnModifier;
        private Button BtnSupprimer;
        private DataGridView DGVContrat;
        private ComboBox ComboLoc;
        private Button BtnEnregistrer;
        private ComboBox ComboMatriculeAgent;
        private Label lblGrade;
        private Label lblSexeAgent;
        private TextBox TxtDetails;
        private TextBox TxtLibelle;
        private GroupBox groupBox1;
        private TextBox TxtNum;
        private Label lblPrenomAgent;
        private Label lblPostnomAgent;
        private Label lblNomAgent;
        private Label lblMatricule;
        private PictureBox pictureBox1;
        private Button BtnAppartement;
        private Label lblBatiment;
        private Panel PanelMenu;
        private Button BtnCompteCourant;
        private Button BtnQuitter;
        private Button BtnSedeconnecter;
        private DateTimePicker DateContrat;
        private Button BtnImprimer;
    }
}