namespace GESTAPP.Views
{
    partial class FrmNotedeRemise
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmNotedeRemise));
            BtnModifier = new Button();
            BtnSupprimer = new Button();
            DGVNote = new DataGridView();
            ComboMatriculeAgent = new ComboBox();
            BtnEnregistrer = new Button();
            ComboNumAppartement = new ComboBox();
            ComboIDLoc = new ComboBox();
            lblFonction = new Label();
            lblGrade = new Label();
            lblSexeAgent = new Label();
            TxtArticle = new TextBox();
            TxtxLibelle = new TextBox();
            TxtCode = new TextBox();
            lblPrenomAgent = new Label();
            lblPostnomAgent = new Label();
            lblNomAgent = new Label();
            lblBatiment = new Label();
            lblMatricule = new Label();
            pictureBox1 = new PictureBox();
            BtnSedeconncter = new Button();
            groupBox1 = new GroupBox();
            DateNote = new DateTimePicker();
            PanelMenu = new Panel();
            BtnQuitter = new Button();
            BtnImprimer = new Button();
            ((System.ComponentModel.ISupportInitialize)DGVNote).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
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
            // DGVNote
            // 
            DGVNote.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGVNote.Dock = DockStyle.Bottom;
            DGVNote.Location = new Point(3, 284);
            DGVNote.Name = "DGVNote";
            DGVNote.Size = new Size(1065, 418);
            DGVNote.TabIndex = 32;
            // 
            // ComboMatriculeAgent
            // 
            ComboMatriculeAgent.FormattingEnabled = true;
            ComboMatriculeAgent.Items.AddRange(new object[] { "Masculin", "Feminin" });
            ComboMatriculeAgent.Location = new Point(295, 255);
            ComboMatriculeAgent.Name = "ComboMatriculeAgent";
            ComboMatriculeAgent.Size = new Size(263, 23);
            ComboMatriculeAgent.TabIndex = 9;
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
            // ComboNumAppartement
            // 
            ComboNumAppartement.FormattingEnabled = true;
            ComboNumAppartement.Location = new Point(11, 204);
            ComboNumAppartement.Name = "ComboNumAppartement";
            ComboNumAppartement.Size = new Size(263, 23);
            ComboNumAppartement.TabIndex = 10;
            // 
            // ComboIDLoc
            // 
            ComboIDLoc.FormattingEnabled = true;
            ComboIDLoc.Location = new Point(11, 255);
            ComboIDLoc.Name = "ComboIDLoc";
            ComboIDLoc.Size = new Size(263, 23);
            ComboIDLoc.TabIndex = 11;
            // 
            // lblFonction
            // 
            lblFonction.AutoSize = true;
            lblFonction.Font = new Font("Roboto", 12F);
            lblFonction.Location = new Point(11, 233);
            lblFonction.Name = "lblFonction";
            lblFonction.Size = new Size(101, 19);
            lblFonction.TabIndex = 13;
            lblFonction.Text = "ID locataire : ";
            // 
            // lblGrade
            // 
            lblGrade.AutoSize = true;
            lblGrade.Font = new Font("Roboto", 12F);
            lblGrade.Location = new Point(11, 182);
            lblGrade.Name = "lblGrade";
            lblGrade.Size = new Size(187, 19);
            lblGrade.TabIndex = 12;
            lblGrade.Text = "Numero de l'appartement";
            // 
            // lblSexeAgent
            // 
            lblSexeAgent.AutoSize = true;
            lblSexeAgent.Font = new Font("Roboto", 12F);
            lblSexeAgent.Location = new Point(295, 233);
            lblSexeAgent.Name = "lblSexeAgent";
            lblSexeAgent.Size = new Size(131, 19);
            lblSexeAgent.TabIndex = 10;
            lblSexeAgent.Text = "Matricule agent : ";
            // 
            // TxtArticle
            // 
            TxtArticle.Font = new Font("Roboto", 12F);
            TxtArticle.Location = new Point(391, 86);
            TxtArticle.Multiline = true;
            TxtArticle.Name = "TxtArticle";
            TxtArticle.Size = new Size(406, 104);
            TxtArticle.TabIndex = 8;
            TxtArticle.TextChanged += TxtPostnomA_TextChanged;
            // 
            // TxtxLibelle
            // 
            TxtxLibelle.Font = new Font("Roboto", 12F);
            TxtxLibelle.Location = new Point(11, 86);
            TxtxLibelle.Multiline = true;
            TxtxLibelle.Name = "TxtxLibelle";
            TxtxLibelle.Size = new Size(353, 30);
            TxtxLibelle.TabIndex = 7;
            // 
            // TxtCode
            // 
            TxtCode.Font = new Font("Roboto", 12F);
            TxtCode.Location = new Point(80, 16);
            TxtCode.Multiline = true;
            TxtCode.Name = "TxtCode";
            TxtCode.Size = new Size(353, 30);
            TxtCode.TabIndex = 6;
            TxtCode.TextChanged += TxtCode_TextChanged;
            // 
            // lblPrenomAgent
            // 
            lblPrenomAgent.AutoSize = true;
            lblPrenomAgent.Font = new Font("Roboto", 12F);
            lblPrenomAgent.Location = new Point(11, 120);
            lblPrenomAgent.Name = "lblPrenomAgent";
            lblPrenomAgent.Size = new Size(149, 19);
            lblPrenomAgent.TabIndex = 5;
            lblPrenomAgent.Text = "Date de la création: ";
            // 
            // lblPostnomAgent
            // 
            lblPostnomAgent.AutoSize = true;
            lblPostnomAgent.Font = new Font("Roboto", 12F);
            lblPostnomAgent.Location = new Point(391, 59);
            lblPostnomAgent.Name = "lblPostnomAgent";
            lblPostnomAgent.Size = new Size(65, 19);
            lblPostnomAgent.TabIndex = 4;
            lblPostnomAgent.Text = "Article : ";
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
            // lblBatiment
            // 
            lblBatiment.AutoSize = true;
            lblBatiment.FlatStyle = FlatStyle.Flat;
            lblBatiment.Font = new Font("Roboto", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBatiment.Location = new Point(573, 8);
            lblBatiment.Name = "lblBatiment";
            lblBatiment.Size = new Size(160, 23);
            lblBatiment.TabIndex = 7;
            lblBatiment.Text = "NOTE DE REMISE";
            // 
            // lblMatricule
            // 
            lblMatricule.AutoSize = true;
            lblMatricule.Font = new Font("Roboto", 12F);
            lblMatricule.Location = new Point(9, 19);
            lblMatricule.Name = "lblMatricule";
            lblMatricule.Size = new Size(53, 19);
            lblMatricule.TabIndex = 2;
            lblMatricule.Text = "Code :";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-1, 100);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(170, 646);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // BtnSedeconncter
            // 
            BtnSedeconncter.FlatStyle = FlatStyle.Flat;
            BtnSedeconncter.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnSedeconncter.ForeColor = Color.White;
            BtnSedeconncter.ImageAlign = ContentAlignment.BottomCenter;
            BtnSedeconncter.Location = new Point(-1, 3);
            BtnSedeconncter.Name = "BtnSedeconncter";
            BtnSedeconncter.Size = new Size(170, 45);
            BtnSedeconncter.TabIndex = 6;
            BtnSedeconncter.Text = "Se déconnceter";
            BtnSedeconncter.UseVisualStyleBackColor = true;
            BtnSedeconncter.Click += BtnSedeconncter_Click_1;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(DateNote);
            groupBox1.Controls.Add(BtnModifier);
            groupBox1.Controls.Add(BtnSupprimer);
            groupBox1.Controls.Add(DGVNote);
            groupBox1.Controls.Add(ComboMatriculeAgent);
            groupBox1.Controls.Add(BtnEnregistrer);
            groupBox1.Controls.Add(ComboNumAppartement);
            groupBox1.Controls.Add(ComboIDLoc);
            groupBox1.Controls.Add(lblFonction);
            groupBox1.Controls.Add(lblGrade);
            groupBox1.Controls.Add(lblSexeAgent);
            groupBox1.Controls.Add(TxtArticle);
            groupBox1.Controls.Add(TxtxLibelle);
            groupBox1.Controls.Add(TxtCode);
            groupBox1.Controls.Add(lblPrenomAgent);
            groupBox1.Controls.Add(lblPostnomAgent);
            groupBox1.Controls.Add(lblNomAgent);
            groupBox1.Controls.Add(lblMatricule);
            groupBox1.Dock = DockStyle.Bottom;
            groupBox1.Location = new Point(175, 44);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1071, 705);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            // 
            // DateNote
            // 
            DateNote.CalendarFont = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DateNote.Format = DateTimePickerFormat.Short;
            DateNote.Location = new Point(11, 145);
            DateNote.Name = "DateNote";
            DateNote.Size = new Size(212, 23);
            DateNote.TabIndex = 36;
            // 
            // PanelMenu
            // 
            PanelMenu.Controls.Add(BtnQuitter);
            PanelMenu.Controls.Add(pictureBox1);
            PanelMenu.Controls.Add(BtnSedeconncter);
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
            BtnQuitter.Location = new Point(2, 44);
            BtnQuitter.Name = "BtnQuitter";
            BtnQuitter.Size = new Size(170, 45);
            BtnQuitter.TabIndex = 9;
            BtnQuitter.Text = "Quitter";
            BtnQuitter.UseVisualStyleBackColor = true;
            BtnQuitter.Click += BtnQuitter_Click;
            // 
            // BtnImprimer
            // 
            BtnImprimer.Location = new Point(911, 3);
            BtnImprimer.Name = "BtnImprimer";
            BtnImprimer.Size = new Size(304, 37);
            BtnImprimer.TabIndex = 19;
            BtnImprimer.Text = "Imprimer";
            BtnImprimer.UseVisualStyleBackColor = true;
            BtnImprimer.Click += BtnImprimer_Click;
            // 
            // FrmNotedeRemise
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1246, 749);
            Controls.Add(BtnImprimer);
            Controls.Add(lblBatiment);
            Controls.Add(groupBox1);
            Controls.Add(PanelMenu);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmNotedeRemise";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmNotedeRemise";
            WindowState = FormWindowState.Maximized;
            Load += FrmNotedeRemise_Load;
            ((System.ComponentModel.ISupportInitialize)DGVNote).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            PanelMenu.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnModifier;
        private Button BtnSupprimer;
        private DataGridView DGVNote;
        private ComboBox ComboMatriculeAgent;
        private Button BtnEnregistrer;
        private ComboBox ComboNumAppartement;
        private ComboBox ComboIDLoc;
        private Label lblFonction;
        private Label lblGrade;
        private Label lblSexeAgent;
        private TextBox TxtArticle;
        private TextBox TxtxLibelle;
        private TextBox TxtCode;
        private Label lblPrenomAgent;
        private Label lblPostnomAgent;
        private Label lblNomAgent;
        private Label lblBatiment;
        private Label lblMatricule;
        private PictureBox pictureBox1;
        private Button BtnSedeconncter;
        private GroupBox groupBox1;
        private Panel PanelMenu;
        private DateTimePicker DateNote;
        private Button BtnQuitter;
        private Button BtnImprimer;
    }
}