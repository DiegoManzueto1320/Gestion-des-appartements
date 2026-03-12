using iTextSharp.text.pdf.security;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace GESTAPP
{
    public static class MiseEnForme
    {
        // 🎨 Mise en forme globale d’un formulaire
        public static void AppliquerForm(Form form)
        {
            form.BackColor = Color.FromArgb(199, 221, 245);
        }

        // 🎨 Mise en forme pour un Panel Menu
        public static void AppliquerPanelMenu(Panel panel)
        {
            panel.BackColor = Color.FromArgb(45, 62, 80);
        }

        // 🎨 Mise en forme des boutons du menu
        public static void AppliquerBoutonMenu(Button btn)
        {
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.ForeColor = Color.White;
            btn.TextAlign = ContentAlignment.MiddleLeft;
            btn.Padding = new Padding(10, 0, 0, 0);
            btn.Font = new Font("Roboto", 12, FontStyle.Bold);
            btn.BackColor = Color.Transparent; // Laisse la couleur du panel
        }
        public static void AppliquerButtonQuitter(Button btn)
        {
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.ForeColor = Color.White;
            btn.TextAlign = ContentAlignment.MiddleLeft;
            btn.Padding = new Padding(10, 0, 0, 0);
            btn.Font = new Font("Roboto", 12, FontStyle.Bold);
            btn.BackColor = Color.Transparent; // Laisse la couleur du panel
            btn.BackColor = Color.FromArgb(231, 76, 60); // Rouge
            btn.Cursor = Cursors.Hand;
        }

        // 🎨 Mise en forme des boutons d’un formulaire
        public static void AppliquerBoutonFormulaire(Button btn)
        {
            btn.FlatStyle = FlatStyle.Flat;
            btn.BackColor = Color.FromArgb(66, 133, 244);
            btn.ForeColor = Color.White;
            btn.TextAlign = ContentAlignment.MiddleCenter;
            btn.Padding = new Padding(10, 0, 0, 0);
            btn.Font = new Font("Times New Roman", 12, FontStyle.Bold);
        }
        public static void AppliquerEnregitrer(Button btn)
        {
            // Paramètres communs
            Font font = new Font("Segoe UI", 11, FontStyle.Bold);
            Size size = new Size(150, 45);

            // Bouton Enregistrer
            btn.BackColor = Color.FromArgb(46, 204, 113); // Vert
            btn.ForeColor = Color.White;
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.Font = font;
            btn.Size = size;
            btn.Cursor = Cursors.Hand;

        }
        public static void AppliquerMenuPrincipal(Button btn)
        {
            Font font = new Font("Segoe UI", 18, FontStyle.Bold);
            // ButtonMenu Principal
            btn.BackColor = Color.FromArgb(46, 204, 113); // Bleu
            btn.ForeColor = Color.White ;
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.Font = font;
            btn.Cursor = Cursors.Hand;
        }
        
        public static void AppliquerModifier(Button btn)
        {
            Font font = new Font("Segoe UI", 11, FontStyle.Bold);
            Size size = new Size(150, 45);
            // Bouton Modifier
            btn.Text = "Modifier";
            btn.BackColor = Color.FromArgb(52, 152, 219); // Bleu
            btn.ForeColor = Color.White;
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.Font = font;
            btn.Size = size;
            btn.Cursor = Cursors.Hand;
        }
        public static void AppliquerSupprimer(Button btn)
        {
            Font font = new Font("Segoe UI", 11, FontStyle.Bold);
            Size size = new Size(150, 45);
            // Bouton Supprimer
            btn.Text = "Supprimer";
            btn.BackColor = Color.FromArgb(231, 76, 60); // Rouge
            btn.ForeColor = Color.White;
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.Font = font;
            btn.Size = size;
            btn.Cursor = Cursors.Hand;
        }
        // 🎨 Mise en forme des TextBox
        public static void AppliquerTextBox(TextBox txt)
        {
            txt.BackColor = Color.White;
            txt.ForeColor = Color.Black;
            txt.Font = new Font("Roboto", 12, FontStyle.Bold);
        }


        // 🎨 Mise en forme des ComboBox
        public static void AppliquerComboBox(ComboBox combo)
        {
            combo.BackColor = Color.Blue;
            combo.ForeColor = Color.LightYellow;
            combo.Font = new Font("Roboto", 12, FontStyle.Bold);
            combo.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        public static void ConfigurerDataGridView(DataGridView dgv)
        {
            // Taille et ajustement
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;

            // Couleurs générales
            dgv.BackgroundColor = Color.White;
            dgv.BorderStyle = BorderStyle.None;
            dgv.GridColor = Color.LightGray;

            // En-tête des colonnes
            dgv.EnableHeadersVisualStyles = false; // important pour appliquer les styles
            dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(0, 122, 204); // bleu foncé
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dgv.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv.ColumnHeadersHeight = 40;

            // Style des cellules
            dgv.DefaultCellStyle.BackColor = Color.White;
            dgv.DefaultCellStyle.ForeColor = Color.Black;
            dgv.DefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Regular);
            dgv.DefaultCellStyle.SelectionBackColor = Color.FromArgb(0, 153, 255); // bleu clair
            dgv.DefaultCellStyle.SelectionForeColor = Color.White;
            dgv.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            // Alternance de couleur des lignes
            dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(240, 240, 240); // gris clair

            // Taille des lignes
            dgv.RowTemplate.Height = 35;

            // Sélection
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.MultiSelect = false;

            // Mode édition
            dgv.ReadOnly = true; // lecture seule (modifiable selon ton besoin)
            dgv.AllowUserToAddRows = false;
            dgv.AllowUserToDeleteRows = false;
            dgv.AllowUserToResizeRows = false;

            // Bordures
            dgv.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgv.RowHeadersVisible = false; // cacher la première colonne d’index
        }

    }
}
