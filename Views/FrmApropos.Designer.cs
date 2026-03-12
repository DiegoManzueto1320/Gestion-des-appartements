using System.util;

namespace GESTAPP.Views
{
    partial class FrmApropos
    {
        private System.ComponentModel.IContainer components = null;
        private PictureBox pictureLogo;
        private Label lblAppName;
        private Label lblVersion;
        private Label lblCompany;
        private Label lblCopyright;
        private TextBox txtDescription;
        private Button btnOk;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmApropos));
            pictureLogo = new PictureBox();
            lblAppName = new Label();
            lblVersion = new Label();
            lblCompany = new Label();
            lblCopyright = new Label();
            txtDescription = new TextBox();
            btnOk = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureLogo).BeginInit();
            SuspendLayout();
            // 
            // pictureLogo
            // 
            pictureLogo.Image = (Image)resources.GetObject("pictureLogo.Image");
            pictureLogo.Location = new Point(180, 15);
            pictureLogo.Name = "pictureLogo";
            pictureLogo.Size = new Size(120, 120);
            pictureLogo.SizeMode = PictureBoxSizeMode.Zoom;
            pictureLogo.TabIndex = 0;
            pictureLogo.TabStop = false;
            // 
            // lblAppName
            // 
            lblAppName.AutoSize = true;
            lblAppName.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblAppName.Location = new Point(50, 150);
            lblAppName.Name = "lblAppName";
            lblAppName.Size = new Size(0, 25);
            lblAppName.TabIndex = 1;
            lblAppName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblVersion
            // 
            lblVersion.AutoSize = true;
            lblVersion.Font = new Font("Segoe UI", 10F);
            lblVersion.Location = new Point(50, 185);
            lblVersion.Name = "lblVersion";
            lblVersion.Size = new Size(0, 19);
            lblVersion.TabIndex = 2;
            lblVersion.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblCompany
            // 
            lblCompany.AutoSize = true;
            lblCompany.Font = new Font("Segoe UI", 9F);
            lblCompany.Location = new Point(50, 210);
            lblCompany.Name = "lblCompany";
            lblCompany.Size = new Size(0, 15);
            lblCompany.TabIndex = 3;
            lblCompany.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblCopyright
            // 
            lblCopyright.AutoSize = true;
            lblCopyright.Font = new Font("Segoe UI", 8F, FontStyle.Italic);
            lblCopyright.Location = new Point(50, 230);
            lblCopyright.Name = "lblCopyright";
            lblCopyright.Size = new Size(0, 13);
            lblCopyright.TabIndex = 4;
            lblCopyright.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(30, 260);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.ReadOnly = true;
            txtDescription.ScrollBars = ScrollBars.Vertical;
            txtDescription.Size = new Size(400, 120);
            txtDescription.TabIndex = 5;
            // 
            // btnOk
            // 
            btnOk.Location = new Point(185, 390);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(100, 30);
            btnOk.TabIndex = 6;
            btnOk.Text = "Fermer";
            btnOk.Click += BtnOk_Click;
            // 
            // FrmApropos
            // 
            ClientSize = new Size(460, 440);
            Controls.Add(pictureLogo);
            Controls.Add(lblAppName);
            Controls.Add(lblVersion);
            Controls.Add(lblCompany);
            Controls.Add(lblCopyright);
            Controls.Add(txtDescription);
            Controls.Add(btnOk);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmApropos";
            StartPosition = FormStartPosition.CenterParent;
            Text = "À propos";
            Load += FrmApropos_Load;
            ((System.ComponentModel.ISupportInitialize)pictureLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
