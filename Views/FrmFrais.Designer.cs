namespace GESTAPP.Views
{
    partial class FrmFrais
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmFrais));
            groupBox1 = new GroupBox();
            ComboFrais = new ComboBox();
            DGVFrais = new DataGridView();
            BtnModiifier = new Button();
            BtnSupprimer = new Button();
            TxtMontant = new TextBox();
            TxtCodeFrais = new TextBox();
            BtnEnregistrer = new Button();
            lblPostnomAgent = new Label();
            lblNomAgent = new Label();
            lblMatricule = new Label();
            PanelMenu = new Panel();
            pictureBox1 = new PictureBox();
            BtnFrais = new Button();
            BtnSedeconnecter = new Button();
            BtnFFRais = new Button();
            BtnPayements = new Button();
            lblBatiment = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DGVFrais).BeginInit();
            PanelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(ComboFrais);
            groupBox1.Controls.Add(DGVFrais);
            groupBox1.Controls.Add(BtnModiifier);
            groupBox1.Controls.Add(BtnSupprimer);
            groupBox1.Controls.Add(TxtMontant);
            groupBox1.Controls.Add(TxtCodeFrais);
            groupBox1.Controls.Add(BtnEnregistrer);
            groupBox1.Controls.Add(lblPostnomAgent);
            groupBox1.Controls.Add(lblNomAgent);
            groupBox1.Controls.Add(lblMatricule);
            groupBox1.Dock = DockStyle.Bottom;
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(196, 69);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(702, 511);
            groupBox1.TabIndex = 14;
            groupBox1.TabStop = false;
            // 
            // ComboFrais
            // 
            ComboFrais.FormattingEnabled = true;
            ComboFrais.Items.AddRange(new object[] { "Garantie", "Loyer", "Courant", "Eau" });
            ComboFrais.Location = new Point(14, 96);
            ComboFrais.Name = "ComboFrais";
            ComboFrais.Size = new Size(270, 23);
            ComboFrais.TabIndex = 32;
            // 
            // DGVFrais
            // 
            DGVFrais.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGVFrais.Dock = DockStyle.Bottom;
            DGVFrais.Location = new Point(3, 184);
            DGVFrais.Name = "DGVFrais";
            DGVFrais.Size = new Size(696, 324);
            DGVFrais.TabIndex = 31;
            // 
            // BtnModiifier
            // 
            BtnModiifier.Location = new Point(462, 95);
            BtnModiifier.Name = "BtnModiifier";
            BtnModiifier.Size = new Size(237, 37);
            BtnModiifier.TabIndex = 17;
            BtnModiifier.Text = "Modifier";
            BtnModiifier.UseVisualStyleBackColor = true;
            BtnModiifier.Click += BtnModiifier_Click;
            // 
            // BtnSupprimer
            // 
            BtnSupprimer.Location = new Point(462, 143);
            BtnSupprimer.Name = "BtnSupprimer";
            BtnSupprimer.Size = new Size(237, 37);
            BtnSupprimer.TabIndex = 16;
            BtnSupprimer.Text = "Supprimer";
            BtnSupprimer.UseVisualStyleBackColor = true;
            BtnSupprimer.Click += BtnSupprimer_Click;
            // 
            // TxtMontant
            // 
            TxtMontant.Font = new Font("Roboto", 12F);
            TxtMontant.Location = new Point(14, 148);
            TxtMontant.Multiline = true;
            TxtMontant.Name = "TxtMontant";
            TxtMontant.Size = new Size(277, 30);
            TxtMontant.TabIndex = 8;
            // 
            // TxtCodeFrais
            // 
            TxtCodeFrais.Font = new Font("Roboto", 12F);
            TxtCodeFrais.Location = new Point(11, 38);
            TxtCodeFrais.Multiline = true;
            TxtCodeFrais.Name = "TxtCodeFrais";
            TxtCodeFrais.Size = new Size(273, 30);
            TxtCodeFrais.TabIndex = 6;
            TxtCodeFrais.TextChanged += TxtCodeFrais_TextChanged;
            // 
            // BtnEnregistrer
            // 
            BtnEnregistrer.Location = new Point(462, 43);
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
            lblPostnomAgent.Location = new Point(11, 126);
            lblPostnomAgent.Name = "lblPostnomAgent";
            lblPostnomAgent.Size = new Size(81, 19);
            lblPostnomAgent.TabIndex = 4;
            lblPostnomAgent.Text = "Montant : ";
            // 
            // lblNomAgent
            // 
            lblNomAgent.AutoSize = true;
            lblNomAgent.Font = new Font("Roboto", 12F);
            lblNomAgent.ForeColor = Color.White;
            lblNomAgent.Location = new Point(11, 71);
            lblNomAgent.Name = "lblNomAgent";
            lblNomAgent.Size = new Size(67, 19);
            lblNomAgent.TabIndex = 3;
            lblNomAgent.Text = "Libelle : ";
            // 
            // lblMatricule
            // 
            lblMatricule.AutoSize = true;
            lblMatricule.Font = new Font("Roboto", 12F);
            lblMatricule.ForeColor = Color.White;
            lblMatricule.Location = new Point(11, 16);
            lblMatricule.Name = "lblMatricule";
            lblMatricule.Size = new Size(57, 19);
            lblMatricule.TabIndex = 2;
            lblMatricule.Text = "Code : ";
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
            PanelMenu.Size = new Size(196, 580);
            PanelMenu.TabIndex = 13;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 189);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(186, 391);
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
            BtnFrais.Location = new Point(2, 138);
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
            BtnSedeconnecter.Location = new Point(2, 92);
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
            BtnFFRais.Location = new Point(6, 2);
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
            BtnPayements.Location = new Point(2, 46);
            BtnPayements.Name = "BtnPayements";
            BtnPayements.Size = new Size(190, 45);
            BtnPayements.TabIndex = 1;
            BtnPayements.Text = "Tous les payements";
            BtnPayements.UseVisualStyleBackColor = true;
            BtnPayements.Click += BtnPayements_Click;
            // 
            // lblBatiment
            // 
            lblBatiment.AutoSize = true;
            lblBatiment.FlatStyle = FlatStyle.Flat;
            lblBatiment.Font = new Font("Roboto", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBatiment.Location = new Point(530, 16);
            lblBatiment.Name = "lblBatiment";
            lblBatiment.Size = new Size(68, 23);
            lblBatiment.TabIndex = 15;
            lblBatiment.Text = "FRAIS ";
            // 
            // FrmFrais
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(898, 580);
            Controls.Add(groupBox1);
            Controls.Add(PanelMenu);
            Controls.Add(lblBatiment);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmFrais";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmFrais";
            Load += FrmFrais_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DGVFrais).EndInit();
            PanelMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private ComboBox ComboFrais;
        private DataGridView DGVFrais;
        private Button BtnModiifier;
        private Button BtnSupprimer;
        private TextBox TxtMontant;
        private TextBox TxtCodeFrais;
        private Button BtnEnregistrer;
        private Label lblPostnomAgent;
        private Label lblNomAgent;
        private Label lblMatricule;
        private Panel PanelMenu;
        private PictureBox pictureBox1;
        private Button BtnFrais;
        private Button BtnSedeconnecter;
        private Button BtnFFRais;
        private Button BtnPayements;
        private Label lblBatiment;
    }
}