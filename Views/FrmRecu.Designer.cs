namespace GESTAPP.Views
{
    partial class FrmRecu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRecu));
            DGVRecu = new DataGridView();
            DateRec = new DateTimePicker();
            ComboMatricule = new ComboBox();
            label5 = new Label();
            BtnModiifier = new Button();
            BtnSupprimer = new Button();
            ComboIDloc = new ComboBox();
            lblGrade = new Label();
            lblSexeAgent = new Label();
            TxtLibelleRecu = new TextBox();
            TxtCodeRecu = new TextBox();
            BtnEnregistrer = new Button();
            lblPostnomAgent = new Label();
            lblNomAgent = new Label();
            lblMatricule = new Label();
            BtnImprimer = new Button();
            lblBatiment = new Label();
            pictureBox1 = new PictureBox();
            BtnFrais = new Button();
            BtnSedeconnecter = new Button();
            BtnFFRais = new Button();
            BtnPayements = new Button();
            groupBox1 = new GroupBox();
            CombooModePaiement = new ComboBox();
            label6 = new Label();
            ComboMontant = new ComboBox();
            label1 = new Label();
            ComboFrais = new ComboBox();
            PanelMenu = new Panel();
            ((System.ComponentModel.ISupportInitialize)DGVRecu).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            PanelMenu.SuspendLayout();
            SuspendLayout();
            // 
            // DGVRecu
            // 
            DGVRecu.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGVRecu.Dock = DockStyle.Bottom;
            DGVRecu.Location = new Point(3, 242);
            DGVRecu.Name = "DGVRecu";
            DGVRecu.Size = new Size(1097, 451);
            DGVRecu.TabIndex = 31;
            // 
            // DateRec
            // 
            DateRec.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DateRec.Format = DateTimePickerFormat.Short;
            DateRec.Location = new Point(405, 101);
            DateRec.Name = "DateRec";
            DateRec.Size = new Size(274, 27);
            DateRec.TabIndex = 28;
            // 
            // ComboMatricule
            // 
            ComboMatricule.FormattingEnabled = true;
            ComboMatricule.Location = new Point(405, 209);
            ComboMatricule.Name = "ComboMatricule";
            ComboMatricule.Size = new Size(353, 23);
            ComboMatricule.TabIndex = 26;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Roboto", 12F);
            label5.ForeColor = Color.White;
            label5.Location = new Point(405, 187);
            label5.Name = "label5";
            label5.Size = new Size(131, 19);
            label5.TabIndex = 27;
            label5.Text = "Matricule agent : ";
            // 
            // BtnModiifier
            // 
            BtnModiifier.Location = new Point(839, 93);
            BtnModiifier.Name = "BtnModiifier";
            BtnModiifier.Size = new Size(237, 37);
            BtnModiifier.TabIndex = 17;
            BtnModiifier.Text = "Modifier";
            BtnModiifier.UseVisualStyleBackColor = true;
            BtnModiifier.Click += BtnModiifier_Click;
            // 
            // BtnSupprimer
            // 
            BtnSupprimer.Location = new Point(839, 141);
            BtnSupprimer.Name = "BtnSupprimer";
            BtnSupprimer.Size = new Size(237, 37);
            BtnSupprimer.TabIndex = 16;
            BtnSupprimer.Text = "Supprimer";
            BtnSupprimer.UseVisualStyleBackColor = true;
            BtnSupprimer.Click += BtnSupprimer_Click;
            // 
            // ComboIDloc
            // 
            ComboIDloc.FormattingEnabled = true;
            ComboIDloc.Location = new Point(17, 213);
            ComboIDloc.Name = "ComboIDloc";
            ComboIDloc.Size = new Size(277, 23);
            ComboIDloc.TabIndex = 9;
            // 
            // lblGrade
            // 
            lblGrade.AutoSize = true;
            lblGrade.Font = new Font("Roboto", 12F);
            lblGrade.ForeColor = Color.White;
            lblGrade.Location = new Point(405, 72);
            lblGrade.Name = "lblGrade";
            lblGrade.Size = new Size(145, 19);
            lblGrade.TabIndex = 12;
            lblGrade.Text = "Date de paiement : ";
            // 
            // lblSexeAgent
            // 
            lblSexeAgent.AutoSize = true;
            lblSexeAgent.Font = new Font("Roboto", 12F);
            lblSexeAgent.ForeColor = Color.White;
            lblSexeAgent.Location = new Point(17, 187);
            lblSexeAgent.Name = "lblSexeAgent";
            lblSexeAgent.Size = new Size(105, 19);
            lblSexeAgent.TabIndex = 10;
            lblSexeAgent.Text = "ID  locataire : ";
            // 
            // TxtLibelleRecu
            // 
            TxtLibelleRecu.Font = new Font("Roboto", 12F);
            TxtLibelleRecu.Location = new Point(17, 147);
            TxtLibelleRecu.Multiline = true;
            TxtLibelleRecu.Name = "TxtLibelleRecu";
            TxtLibelleRecu.Size = new Size(277, 30);
            TxtLibelleRecu.TabIndex = 8;
            // 
            // TxtCodeRecu
            // 
            TxtCodeRecu.Font = new Font("Roboto", 12F);
            TxtCodeRecu.Location = new Point(11, 38);
            TxtCodeRecu.Multiline = true;
            TxtCodeRecu.Name = "TxtCodeRecu";
            TxtCodeRecu.Size = new Size(273, 30);
            TxtCodeRecu.TabIndex = 6;
            TxtCodeRecu.TextChanged += TxtCodeRecu_TextChanged;
            // 
            // BtnEnregistrer
            // 
            BtnEnregistrer.Location = new Point(839, 41);
            BtnEnregistrer.Name = "BtnEnregistrer";
            BtnEnregistrer.Size = new Size(237, 37);
            BtnEnregistrer.TabIndex = 3;
            BtnEnregistrer.Text = "Enregistrer";
            BtnEnregistrer.UseVisualStyleBackColor = true;
            BtnEnregistrer.Click += BtnEnregistrer_Click;
            // 
            // lblPostnomAgent
            // 
            lblPostnomAgent.AutoSize = true;
            lblPostnomAgent.Font = new Font("Roboto", 12F);
            lblPostnomAgent.ForeColor = Color.White;
            lblPostnomAgent.Location = new Point(14, 125);
            lblPostnomAgent.Name = "lblPostnomAgent";
            lblPostnomAgent.Size = new Size(97, 19);
            lblPostnomAgent.TabIndex = 4;
            lblPostnomAgent.Text = "Libelle recu :";
            // 
            // lblNomAgent
            // 
            lblNomAgent.AutoSize = true;
            lblNomAgent.Font = new Font("Roboto", 12F);
            lblNomAgent.ForeColor = Color.White;
            lblNomAgent.Location = new Point(402, 13);
            lblNomAgent.Name = "lblNomAgent";
            lblNomAgent.Size = new Size(93, 19);
            lblNomAgent.TabIndex = 3;
            lblNomAgent.Text = "Code frais : ";
            // 
            // lblMatricule
            // 
            lblMatricule.AutoSize = true;
            lblMatricule.Font = new Font("Roboto", 12F);
            lblMatricule.ForeColor = Color.White;
            lblMatricule.Location = new Point(11, 19);
            lblMatricule.Name = "lblMatricule";
            lblMatricule.Size = new Size(91, 19);
            lblMatricule.TabIndex = 2;
            lblMatricule.Text = "Code recu : ";
            // 
            // BtnImprimer
            // 
            BtnImprimer.Location = new Point(916, 6);
            BtnImprimer.Name = "BtnImprimer";
            BtnImprimer.Size = new Size(356, 37);
            BtnImprimer.TabIndex = 12;
            BtnImprimer.Text = "Imprimer";
            BtnImprimer.UseVisualStyleBackColor = true;
            BtnImprimer.Click += BtnImprimer_Click;
            // 
            // lblBatiment
            // 
            lblBatiment.AutoSize = true;
            lblBatiment.FlatStyle = FlatStyle.Flat;
            lblBatiment.Font = new Font("Roboto", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBatiment.Location = new Point(530, 16);
            lblBatiment.Name = "lblBatiment";
            lblBatiment.Size = new Size(58, 23);
            lblBatiment.TabIndex = 11;
            lblBatiment.Text = "RECU";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(4, 194);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(186, 547);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // BtnFrais
            // 
            BtnFrais.FlatStyle = FlatStyle.Flat;
            BtnFrais.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnFrais.ForeColor = Color.White;
            BtnFrais.ImageAlign = ContentAlignment.BottomCenter;
            BtnFrais.Location = new Point(2, 143);
            BtnFrais.Name = "BtnFrais";
            BtnFrais.Size = new Size(190, 45);
            BtnFrais.TabIndex = 5;
            BtnFrais.Text = "Quitter";
            BtnFrais.UseVisualStyleBackColor = true;
            BtnFrais.Click += BtnFrais_Click;
            // 
            // BtnSedeconnecter
            // 
            BtnSedeconnecter.FlatStyle = FlatStyle.Flat;
            BtnSedeconnecter.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnSedeconnecter.ForeColor = Color.White;
            BtnSedeconnecter.ImageAlign = ContentAlignment.BottomCenter;
            BtnSedeconnecter.Location = new Point(0, 97);
            BtnSedeconnecter.Name = "BtnSedeconnecter";
            BtnSedeconnecter.Size = new Size(190, 45);
            BtnSedeconnecter.TabIndex = 3;
            BtnSedeconnecter.Text = "Se déconnecter";
            BtnSedeconnecter.UseVisualStyleBackColor = true;
            BtnSedeconnecter.Click += BtnSedeconnecter_Click;
            // 
            // BtnFFRais
            // 
            BtnFFRais.FlatStyle = FlatStyle.Flat;
            BtnFFRais.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnFFRais.ForeColor = Color.White;
            BtnFFRais.ImageAlign = ContentAlignment.BottomCenter;
            BtnFFRais.Location = new Point(3, 51);
            BtnFFRais.Name = "BtnFFRais";
            BtnFFRais.Size = new Size(190, 45);
            BtnFFRais.TabIndex = 2;
            BtnFFRais.Text = "Frais";
            BtnFFRais.UseVisualStyleBackColor = true;
            BtnFFRais.Click += BtnFFRais_Click;
            // 
            // BtnPayements
            // 
            BtnPayements.FlatStyle = FlatStyle.Flat;
            BtnPayements.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnPayements.ForeColor = Color.White;
            BtnPayements.ImageAlign = ContentAlignment.BottomCenter;
            BtnPayements.Location = new Point(3, 6);
            BtnPayements.Name = "BtnPayements";
            BtnPayements.Size = new Size(190, 45);
            BtnPayements.TabIndex = 1;
            BtnPayements.Text = "Tous les payements";
            BtnPayements.UseVisualStyleBackColor = true;
            BtnPayements.Click += BtnPayements_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(CombooModePaiement);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(ComboMontant);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(ComboFrais);
            groupBox1.Controls.Add(DGVRecu);
            groupBox1.Controls.Add(DateRec);
            groupBox1.Controls.Add(ComboMatricule);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(BtnModiifier);
            groupBox1.Controls.Add(BtnSupprimer);
            groupBox1.Controls.Add(ComboIDloc);
            groupBox1.Controls.Add(lblGrade);
            groupBox1.Controls.Add(lblSexeAgent);
            groupBox1.Controls.Add(TxtLibelleRecu);
            groupBox1.Controls.Add(TxtCodeRecu);
            groupBox1.Controls.Add(BtnEnregistrer);
            groupBox1.Controls.Add(lblPostnomAgent);
            groupBox1.Controls.Add(lblNomAgent);
            groupBox1.Controls.Add(lblMatricule);
            groupBox1.Dock = DockStyle.Bottom;
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(196, 53);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1103, 696);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            // 
            // CombooModePaiement
            // 
            CombooModePaiement.FormattingEnabled = true;
            CombooModePaiement.Items.AddRange(new object[] { "Espèce", "Mobile money", "Virement bancaire" });
            CombooModePaiement.Location = new Point(405, 164);
            CombooModePaiement.Name = "CombooModePaiement";
            CombooModePaiement.Size = new Size(209, 23);
            CombooModePaiement.TabIndex = 49;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Roboto", 12F);
            label6.Location = new Point(405, 136);
            label6.Name = "label6";
            label6.Size = new Size(160, 19);
            label6.TabIndex = 48;
            label6.Text = "Moyen de paiement : ";
            // 
            // ComboMontant
            // 
            ComboMontant.FormattingEnabled = true;
            ComboMontant.Location = new Point(17, 99);
            ComboMontant.Name = "ComboMontant";
            ComboMontant.Size = new Size(267, 23);
            ComboMontant.TabIndex = 34;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Roboto", 12F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(14, 74);
            label1.Name = "label1";
            label1.Size = new Size(117, 19);
            label1.TabIndex = 33;
            label1.Text = "Montant frais : ";
            // 
            // ComboFrais
            // 
            ComboFrais.FormattingEnabled = true;
            ComboFrais.Location = new Point(405, 38);
            ComboFrais.Name = "ComboFrais";
            ComboFrais.Size = new Size(353, 23);
            ComboFrais.TabIndex = 32;
            // 
            // PanelMenu
            // 
            PanelMenu.Controls.Add(pictureBox1);
            PanelMenu.Controls.Add(BtnFrais);
            PanelMenu.Controls.Add(BtnSedeconnecter);
            PanelMenu.Controls.Add(BtnFFRais);
            PanelMenu.Controls.Add(BtnPayements);
            PanelMenu.Dock = DockStyle.Left;
            PanelMenu.Location = new Point(0, 0);
            PanelMenu.Name = "PanelMenu";
            PanelMenu.Size = new Size(196, 749);
            PanelMenu.TabIndex = 9;
            // 
            // FrmRecu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1299, 749);
            Controls.Add(BtnImprimer);
            Controls.Add(lblBatiment);
            Controls.Add(groupBox1);
            Controls.Add(PanelMenu);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmRecu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmRecu";
            WindowState = FormWindowState.Maximized;
            Load += FrmRecu_Load;
            ((System.ComponentModel.ISupportInitialize)DGVRecu).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            PanelMenu.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView DGVRecu;
        private DateTimePicker DateRec;
        private ComboBox ComboMatricule;
        private Label label5;
        private Button BtnModiifier;
        private Button BtnSupprimer;
        private ComboBox ComboIDloc;
        private Label lblGrade;
        private Label lblSexeAgent;
        private TextBox TxtLibelleRecu;
        private TextBox TxtCodeRecu;
        private Button BtnEnregistrer;
        private Label lblPostnomAgent;
        private Label lblNomAgent;
        private Label lblMatricule;
        private Button BtnImprimer;
        private Label lblBatiment;
        private PictureBox pictureBox1;
        private Button BtnFrais;
        private Button BtnSedeconnecter;
        private Button BtnFFRais;
        private Button BtnPayements;
        private GroupBox groupBox1;
        private Panel PanelMenu;
        private ComboBox ComboFrais;
        private ComboBox ComboMontant;
        private Label label1;
        private ComboBox CombooModePaiement;
        private Label label6;
    }
}