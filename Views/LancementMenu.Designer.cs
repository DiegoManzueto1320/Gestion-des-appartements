namespace GESTAPP
{
    partial class LancementMenu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LancementMenu));
            panel1 = new Panel();
            LblBienvenue = new Label();
            pictureBox1 = new PictureBox();
            progressBar1 = new ProgressBar();
            timer1 = new System.Windows.Forms.Timer(components);
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(LblBienvenue);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1184, 66);
            panel1.TabIndex = 0;
            // 
            // LblBienvenue
            // 
            LblBienvenue.AutoSize = true;
            LblBienvenue.FlatStyle = FlatStyle.Popup;
            LblBienvenue.Font = new Font("Times New Roman", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblBienvenue.ForeColor = Color.FromArgb(128, 128, 255);
            LblBienvenue.Location = new Point(386, 25);
            LblBienvenue.Name = "LblBienvenue";
            LblBienvenue.Size = new Size(424, 31);
            LblBienvenue.TabIndex = 0;
            LblBienvenue.Text = "GESTION DES APPARTEMENTS";
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Top;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 66);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1184, 554);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // progressBar1
            // 
            progressBar1.Dock = DockStyle.Bottom;
            progressBar1.Location = new Point(0, 613);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(1184, 71);
            progressBar1.Step = 5;
            progressBar1.TabIndex = 3;
            progressBar1.Click += progressBar1_Click;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 1;
            timer1.Tick += timer1_Tick;
            // 
            // LancementMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1184, 684);
            ControlBox = false;
            Controls.Add(progressBar1);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "LancementMenu";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            WindowState = FormWindowState.Maximized;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private ProgressBar progressBar1;
        private System.Windows.Forms.Timer timer1;
        private Label LblBienvenue;
    }
}
