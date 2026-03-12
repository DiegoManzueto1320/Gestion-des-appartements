using System;
using System.Drawing;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace GESTAPP.Outils
{
   
        public static class MiseFormeFormulaire
        {
        // 🎨 Mise en forme globale d’un formulaire
        public static void AppliquerForm(Form form)
        {
            form.BackColor = Color.WhiteSmoke;
            form.StartPosition = FormStartPosition.CenterScreen;


        }
        public static void AppliquerLabels(Label label)
        {
            label.Font = new Font("Segoe UI", 14, FontStyle.Bold);
            label.ForeColor = Color.FromArgb(22, 46, 93);
            label.AutoSize = true;
            label.Location = new Point(200, 20);
        }
        public static void AppliquerGroupebox(System.Windows.Forms.GroupBox groupBox)
        {
            groupBox.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            groupBox.ForeColor = Color.FromArgb(22, 46, 93);
            groupBox.BackColor = Color.FromArgb(235, 243, 252);
        }

        public static void AppliquerCheckbox(System.Windows.Forms.CheckBox checkBox)
        {
            checkBox.Font = new Font("Segoe UI", 10, FontStyle.Regular);
            checkBox.ForeColor = Color.FromArgb(22, 46, 93);
            checkBox.BackColor = Color.FromArgb(235, 243, 252);
        }

        public static void CouleursDGV(DataGridView dgv)
        {
            dgv.BackgroundColor = System.Drawing.Color.FromArgb(102, 154, 204);
            dgv.ForeColor = System.Drawing.Color.FromArgb(22, 46, 93);

            dgv.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(102, 154, 204); // Vous pouvez également choisir n'importe quelle autre couleur  
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255); // Couleur de texte noir pour l'en-tête  
            dgv.EnableHeadersVisualStyles = false; // important pour appliquer les styles
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 7, FontStyle.Bold);
            dgv.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv.ColumnHeadersHeight = 40;
            dgv.DefaultCellStyle.BackColor = Color.White;
            dgv.DefaultCellStyle.ForeColor = Color.Black;
            dgv.DefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Regular);
            dgv.DefaultCellStyle.SelectionForeColor = Color.White;
            dgv.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgv.RowTemplate.Height = 35;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.MultiSelect = false;
        }




    }
}
