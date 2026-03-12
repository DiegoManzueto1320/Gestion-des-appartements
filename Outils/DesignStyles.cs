using System;
using System.Drawing;
using System.Windows.Forms;

namespace GESTAPP.Outils
{
    /// <summary>
    /// Classe centralisée pour appliquer un design cohérent à tous les formulaires
    /// Utilise une palette de couleurs et polices standardisées
    /// </summary>
    public static class DesignStyles
    {
        // ==================== COULEURS ====================
        
        public static class Couleurs
        {
            /// <summary>Fond principal des formulaires - Gris clair</summary>
            public static readonly Color FOND_PRINCIPAL = Color.FromArgb(240, 245, 250);
            
            /// <summary>Menu latéral - Bleu profond</summary>
            public static readonly Color MENU = Color.FromArgb(41, 57, 86);
            
            /// <summary>Texte foncé - Gris foncé lisible</summary>
            public static readonly Color TEXTE_FONCE = Color.FromArgb(44, 62, 80);
            
            /// <summary>Blanc pur</summary>
            public static readonly Color BLANC = Color.White;
            
            /// <summary>Gris léger pour alternance</summary>
            public static readonly Color GRIS_CLAIR = Color.FromArgb(245, 245, 245);
            
            /// <summary>Bleu clair pour sélection</summary>
            public static readonly Color BLEU_SELECTION = Color.FromArgb(173, 216, 230);
            
            // Palette de boutons menu
            public static readonly Color BTN_BATIMENT = Color.FromArgb(52, 152, 219);      // Bleu
            public static readonly Color BTN_APPARTEMENT = Color.FromArgb(46, 204, 113);   // Vert
            public static readonly Color BTN_LOCATAIRE = Color.FromArgb(155, 89, 182);     // Violet
            public static readonly Color BTN_AGENT = Color.FromArgb(230, 126, 34);         // Orange
            public static readonly Color BTN_FRAIS = Color.FromArgb(52, 73, 94);           // Gris foncé
            public static readonly Color BTN_COMPTE = Color.FromArgb(44, 62, 80);          // Bleu très foncé
            public static readonly Color BTN_FONCTION = Color.FromArgb(155, 89, 182);      // Violet
            public static readonly Color BTN_GRADE = Color.FromArgb(230, 126, 34);         // Orange
            public static readonly Color BTN_UTILISATEUR = Color.FromArgb(52, 152, 219);   // Bleu
            
            // Palette boutons d'action
            public static readonly Color BTN_ENREGISTRER = Color.FromArgb(46, 204, 113);   // Vert succès
            public static readonly Color BTN_MODIFIER = Color.FromArgb(52, 152, 219);      // Bleu édition
            public static readonly Color BTN_SUPPRIMER = Color.FromArgb(231, 76, 60);      // Rouge danger
            public static readonly Color BTN_ANNULER = Color.FromArgb(189, 195, 199);      // Gris neutre
        }
        
        // ==================== POLICES ====================
        
        public static class Polices
        {
            /// <summary>Police pour les titres principaux</summary>
            public static readonly Font TITRE = new Font("Segoe UI", 16, FontStyle.Bold);
            
            /// <summary>Police pour les labels/titres de groupe</summary>
            public static readonly Font LABEL = new Font("Segoe UI", 12, FontStyle.Regular);
            
            /// <summary>Police standard pour le contenu</summary>
            public static readonly Font NORMAL = new Font("Segoe UI", 11, FontStyle.Regular);
            
            /// <summary>Police pour les boutons</summary>
            public static readonly Font BOUTON = new Font("Segoe UI", 11, FontStyle.Bold);
            
            /// <summary>Police pour les boutons du menu</summary>
            public static readonly Font MENU_BTN = new Font("Segoe UI", 10, FontStyle.Bold);
            
            /// <summary>Police pour les en-têtes de DataGrid</summary>
            public static readonly Font ENTETE_DATAGRID = new Font("Segoe UI", 10, FontStyle.Bold);
        }
        
        // ==================== MÉTHODES PRINCIPALES ====================
        
        /// <summary>Applique le style standard à un formulaire</summary>
        public static void AppliquerFormulaire(Form frm)
        {
            frm.BackColor = Couleurs.FOND_PRINCIPAL;
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.Font = Polices.NORMAL;
        }
        
        /// <summary>Applique le style au panel de menu latéral</summary>
        public static void AppliquerMenuLateral(Panel pnl)
        {
            pnl.BackColor = Couleurs.MENU;
            pnl.Dock = DockStyle.Left;
        }
        
        /// <summary>Applique le style à un bouton du menu avec couleur spécifique</summary>
        public static void AppliquerBoutonMenuAvecCouleur(Button btn, Color couleur, string texte = "")
        {
            btn.BackColor = couleur;
            btn.ForeColor = Couleurs.BLANC;
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.Font = Polices.MENU_BTN;
            btn.Cursor = Cursors.Hand;
            btn.Height = 45;
            
            if (!string.IsNullOrEmpty(texte))
                btn.Text = texte;
            
            // Ajout des effets de survol
            btn.MouseEnter += (s, e) => btn.BackColor = AugmenterBrillance(couleur, 20);
            btn.MouseLeave += (s, e) => btn.BackColor = couleur;
        }
        
        /// <summary>Applique le style à un bouton d'action (Enregistrer, Modifier, Supprimer)</summary>
        public static void AppliquerBoutonAction(Button btn, Color couleur, string texte = "")
        {
            btn.BackColor = couleur;
            btn.ForeColor = Couleurs.BLANC;
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.Font = Polices.BOUTON;
            btn.Cursor = Cursors.Hand;
            btn.Height = 40;
            
            if (!string.IsNullOrEmpty(texte))
                btn.Text = texte;
            
            // Effets de survol plus prononcés
            btn.MouseEnter += (s, e) => btn.BackColor = AugmenterBrillance(couleur, 25);
            btn.MouseLeave += (s, e) => btn.BackColor = couleur;
        }
        
        /// <summary>Applique le style à une TextBox</summary>
        public static void AppliquerTextBox(TextBox txt)
        {
            txt.BackColor = Couleurs.BLANC;
            txt.ForeColor = Couleurs.TEXTE_FONCE;
            txt.Font = Polices.NORMAL;
            txt.BorderStyle = BorderStyle.FixedSingle;
        }
        
        /// <summary>Applique le style à une ComboBox</summary>
        public static void AppliquerComboBox(ComboBox combo)
        {
            combo.BackColor = Couleurs.BLANC;
            combo.ForeColor = Couleurs.TEXTE_FONCE;
            combo.Font = Polices.NORMAL;
            combo.FlatStyle = FlatStyle.Flat;
        }
        
        /// <summary>Applique le style à un Label</summary>
        public static void AppliquerLabel(Label lbl, bool isTitre = false)
        {
            lbl.ForeColor = Couleurs.TEXTE_FONCE;
            lbl.Font = isTitre ? Polices.TITRE : Polices.LABEL;
            lbl.AutoSize = true;
        }
        
        /// <summary>Applique le style professionnel à un DataGridView</summary>
        public static void AppliquerDataGridView(DataGridView dgv)
        {
            dgv.BackgroundColor = Couleurs.BLANC;
            dgv.BorderStyle = BorderStyle.None;
            dgv.GridColor = Color.LightGray;
            
            // Configuration de l'en-tête
            dgv.EnableHeadersVisualStyles = false;
            dgv.ColumnHeadersDefaultCellStyle.BackColor = Couleurs.BTN_MODIFIER;
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = Couleurs.BLANC;
            dgv.ColumnHeadersDefaultCellStyle.Font = Polices.ENTETE_DATAGRID;
            dgv.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv.ColumnHeadersHeight = 40;
            
            // Configuration des cellules
            dgv.DefaultCellStyle.BackColor = Couleurs.BLANC;
            dgv.DefaultCellStyle.ForeColor = Couleurs.TEXTE_FONCE;
            dgv.DefaultCellStyle.Font = Polices.NORMAL;
            dgv.DefaultCellStyle.SelectionBackColor = Couleurs.BLEU_SELECTION;
            dgv.DefaultCellStyle.SelectionForeColor = Couleurs.TEXTE_FONCE;
            dgv.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            
            // Alternance de couleurs pour meilleure lisibilité
            dgv.AlternatingRowsDefaultCellStyle.BackColor = Couleurs.GRIS_CLAIR;
            
            // Configuration générale
            dgv.RowTemplate.Height = 35;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.MultiSelect = false;
            dgv.ReadOnly = true;
            dgv.AllowUserToAddRows = false;
            dgv.AllowUserToDeleteRows = false;
            dgv.AllowUserToResizeRows = false;
            dgv.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgv.RowHeadersVisible = false;
            
            // Auto-sizing
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        
        /// <summary>Applique le style à un GroupBox</summary>
        public static void AppliquerGroupBox(GroupBox grp)
        {
            grp.ForeColor = Couleurs.TEXTE_FONCE;
            grp.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            grp.BackColor = Color.FromArgb(250, 250, 250);
        }
        
        /// <summary>Applique le style à un Panel</summary>
        public static void AppliquerPanel(Panel pnl)
        {
            pnl.BackColor = Color.FromArgb(250, 250, 250);
            pnl.BorderStyle = BorderStyle.FixedSingle;
        }
        
        // ==================== MÉTHODES UTILITAIRES ====================
        
        /// <summary>Augmente la brillance d'une couleur pour les hover effects</summary>
        public static Color AugmenterBrillance(Color couleur, int pourcentage)
        {
            int r = Math.Min(255, couleur.R + pourcentage);
            int g = Math.Min(255, couleur.G + pourcentage);
            int b = Math.Min(255, couleur.B + pourcentage);
            return Color.FromArgb(r, g, b);
        }
        
        /// <summary>Réduit la brillance d'une couleur (pour effet inverse)</summary>
        public static Color RediureBrillance(Color couleur, int pourcentage)
        {
            int r = Math.Max(0, couleur.R - pourcentage);
            int g = Math.Max(0, couleur.G - pourcentage);
            int b = Math.Max(0, couleur.B - pourcentage);
            return Color.FromArgb(r, g, b);
        }
        
        /// <summary>Applique les styles à plusieurs TextBox simultanément</summary>
        public static void AppliquerTextBoxMultiple(params TextBox[] textBoxes)
        {
            foreach (TextBox txt in textBoxes)
                AppliquerTextBox(txt);
        }
        
        /// <summary>Applique les styles à plusieurs ComboBox simultanément</summary>
        public static void AppliquerComboBoxMultiple(params ComboBox[] combos)
        {
            foreach (ComboBox cmb in combos)
                AppliquerComboBox(cmb);
        }
        
        /// <summary>Applique les styles à plusieurs Labels simultanément</summary>
        public static void AppliquerLabelMultiple(bool isTitre = false, params Label[] labels)
        {
            foreach (Label lbl in labels)
                AppliquerLabel(lbl, isTitre);
        }
    }
}
