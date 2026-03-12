namespace GESTAPP.Views
{
    partial class frmInvisible
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
            DataGV = new DataGridView();
            T1 = new TextBox();
            T2 = new TextBox();
            DataGV1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)DataGV).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DataGV1).BeginInit();
            SuspendLayout();
            // 
            // DataGV
            // 
            DataGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGV.Location = new Point(383, 180);
            DataGV.Name = "DataGV";
            DataGV.Size = new Size(240, 150);
            DataGV.TabIndex = 0;
            // 
            // T1
            // 
            T1.Location = new Point(382, 366);
            T1.Name = "T1";
            T1.Size = new Size(100, 23);
            T1.TabIndex = 1;
            // 
            // T2
            // 
            T2.Location = new Point(523, 366);
            T2.Name = "T2";
            T2.Size = new Size(100, 23);
            T2.TabIndex = 2;
            // 
            // DataGV1
            // 
            DataGV1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGV1.Location = new Point(656, 180);
            DataGV1.Name = "DataGV1";
            DataGV1.Size = new Size(240, 150);
            DataGV1.TabIndex = 3;
            // 
            // frmInvisible
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1014, 450);
            Controls.Add(DataGV1);
            Controls.Add(T2);
            Controls.Add(T1);
            Controls.Add(DataGV);
            Name = "frmInvisible";
            Text = "frmInvisible";
            ((System.ComponentModel.ISupportInitialize)DataGV).EndInit();
            ((System.ComponentModel.ISupportInitialize)DataGV1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox T1;
        private TextBox T2;
        private DataGridView DataGV1;
        public DataGridView DataGV;
    }
}