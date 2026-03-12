using GESTAPP.Outils;
using GESTAPP.Views;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.CompilerServices.RuntimeHelpers;

namespace GESTAPP
{
    public partial class FrmAgent : Form
    {
        public void MiseForme()
        {
            //Couleur pour le formulaire - Gradient professionnel
            this.BackColor = Color.FromArgb(240, 245, 250);
            
            //Couleur pour le panel menu - Bleu profond
            PanelMenu.Height = 250;
            PanelMenu.BackColor = Color.FromArgb(41, 57, 86);
            
            //Mise en forme du DataGridView
            MiseEnForme.ConfigurerDataGridView(DGVAgent);
            DGVAgent.BackgroundColor = Color.White;
            DGVAgent.DefaultCellStyle.Font = new Font("Segoe UI", 10);

            //Mise en forme des boutons du menu avec couleurs distinctes
            StyleBoutonMenu(BtnBatiment, Color.FromArgb(52, 152, 219));      // Bleu
            StyleBoutonMenu(BtnAppartement, Color.FromArgb(46, 204, 113));   // Vert
            StyleBoutonMenu(BtnLocataire, Color.FromArgb(155, 89, 182));     // Violet
            StyleBoutonMenu(BtnAgent, Color.FromArgb(230, 126, 34));         // Orange
            StyleBoutonMenu(BtnFrais, Color.FromArgb(52, 73, 94));           // Gris foncé
            StyleBoutonMenu(BtnCompteCourant, Color.FromArgb(44, 62, 80));   // Bleu très foncé

            //Mise en forme pour les boutons d'action
            StyleBoutonAction(BtnEnregistrer, Color.FromArgb(46, 204, 113), "✓ Enregistrer");
            StyleBoutonAction(BtnModifier, Color.FromArgb(52, 152, 219), "✎ Modifier");
            StyleBoutonAction(BtnSupprimer, Color.FromArgb(231, 76, 60), "✕ Supprimer");
            
            //Mise en forme pour les textBox
            StyleTextBox(TxtMatriculeAgent);
            StyleTextBox(TxtNomAgent);
            StyleTextBox(TxtPostnomA);
            StyleTextBox(TxtPrenomA);
            StyleTextBox(TxtAdresse);
            
            //Mise en forme pour les comboBox
            StyleComboBox(ComboSexe);
            StyleComboBox(ComboGrade);
            StyleComboBox(ComboFonction);
            
            //Style du GroupBox
            groupBox1.ForeColor = Color.FromArgb(52, 73, 94);
            groupBox1.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            groupBox1.BackColor = Color.FromArgb(250, 250, 250);
        }

        /// <summary>Style personnalisé pour les boutons du menu</summary>
        private void StyleBoutonMenu(Button btn, Color couleur)
        {
            btn.BackColor = couleur;
            btn.ForeColor = Color.White;
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            btn.Cursor = Cursors.Hand;
            btn.Height = 45;
            btn.MouseEnter += (s, e) => btn.BackColor = AugmenterBrillance(couleur, 20);
            btn.MouseLeave += (s, e) => btn.BackColor = couleur;
        }

        /// <summary>Style personnalisé pour les boutons d'action</summary>
        private void StyleBoutonAction(Button btn, Color couleur, string texte)
        {
            btn.BackColor = couleur;
            btn.ForeColor = Color.White;
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.Font = new Font("Segoe UI", 11, FontStyle.Bold);
            btn.Cursor = Cursors.Hand;
            btn.Text = texte;
            btn.Height = 40;
            btn.MouseEnter += (s, e) => btn.BackColor = AugmenterBrillance(couleur, 25);
            btn.MouseLeave += (s, e) => btn.BackColor = couleur;
        }

        /// <summary>Style personnalisé pour les TextBox</summary>
        private void StyleTextBox(TextBox txt)
        {
            txt.BackColor = Color.White;
            txt.ForeColor = Color.FromArgb(44, 62, 80);
            txt.Font = new Font("Segoe UI", 11);
            txt.BorderStyle = BorderStyle.FixedSingle;
        }

        /// <summary>Style personnalisé pour les ComboBox</summary>
        private void StyleComboBox(ComboBox combo)
        {
            combo.BackColor = Color.White;
            combo.ForeColor = Color.FromArgb(44, 62, 80);
            combo.Font = new Font("Segoe UI", 11);
            combo.FlatStyle = FlatStyle.Flat;
        }

        /// <summary>Augmenter la brillance d'une couleur</summary>
        private Color AugmenterBrillance(Color couleur, int pourcentage)
        {
            int r = Math.Min(255, couleur.R + pourcentage);
            int g = Math.Min(255, couleur.G + pourcentage);
            int b = Math.Min(255, couleur.B + pourcentage);
            return Color.FromArgb(r, g, b);
        }
        public FrmAgent()
        {
            InitializeComponent();
        }

        private void FrmAgent_Load(object sender, EventArgs e)
        {
            MiseForme();
            Basique.cx.ChargeCleEtrangere("grade", "Code_Grade", Basique.invi.DataGV, ComboGrade);
            Basique.cx.ChargeCleEtrangere("fonction", "Code_Fonction", Basique.invi.DataGV, ComboFonction);
            Basique.cx.chargerDGV("Select * from agent ", DGVAgent);
        }

        private void BtnBatiment_Click(object sender, EventArgs e)
        {
            FrmBatiment B = new FrmBatiment();
            B.ShowDialog();
        }

        private void BtnAppartement_Click(object sender, EventArgs e)
        {
            FrmAppartement A = new FrmAppartement();
            A.ShowDialog();
        }

        private void BtnLocataire_Click(object sender, EventArgs e)
        {
            FrmLocataire L = new FrmLocataire();
            L.ShowDialog();
        }

        private void BtnAgent_Click(object sender, EventArgs e)
        {
            FrmAgent A = new FrmAgent();
            A.ShowDialog();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        void Nettoyage()
        {
            TxtAdresse.Clear();
            TxtMatriculeAgent.Clear();
            TxtNomAgent.Clear();
            TxtPostnomA.Clear();
            TxtPrenomA.Clear();
            ComboFonction.Text = "";
            ComboGrade.Text = "";
            ComboSexe.Text = "";

        }
        private void BtnEnregistrer_Click(object sender, EventArgs e)
        {

        }

        private void BtnFrais_Click(object sender, EventArgs e)
        {
            FrmFrais frmFrais = new FrmFrais();
            frmFrais.ShowDialog();
        }

        private void BtnEnregistrer_Click_1(object sender, EventArgs e)
        {
            // Validation des champs
            if (string.IsNullOrWhiteSpace(TxtMatriculeAgent.Text) || 
                string.IsNullOrWhiteSpace(TxtNomAgent.Text) || 
                string.IsNullOrWhiteSpace(TxtPostnomA.Text) || 
                string.IsNullOrWhiteSpace(TxtPrenomA.Text) || 
                string.IsNullOrWhiteSpace(ComboSexe.Text) || 
                string.IsNullOrWhiteSpace(TxtAdresse.Text) || 
                string.IsNullOrWhiteSpace(ComboGrade.Text) || 
                string.IsNullOrWhiteSpace(ComboFonction.Text))
            {
                MessageBox.Show("Veuillez remplir tous les champs.", "Champs Incomplets", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                Basique.cx.requete_E(
                    "insert into agent values ('" +
                    TxtMatriculeAgent.Text.Trim() + "', '" +
                    TxtNomAgent.Text.Trim() + "', '" +
                    TxtPostnomA.Text.Trim() + "', '" +
                    TxtPrenomA.Text.Trim() + "', '" +
                    ComboSexe.Text + "', '" +
                    TxtAdresse.Text.Trim() + "', '" +
                    ComboGrade.Text + "', '" +
                    ComboFonction.Text + "')"
                );
                Basique.cx.chargerDGV("Select * from agent", DGVAgent);
                Nettoyage();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors de l'enregistrement : {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TxtMatriculeAgent_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(TxtMatriculeAgent.Text))
            {
                Basique.cx.chargerDGV("Select * from agent where Matricule_Ag like '" + TxtMatriculeAgent.Text + "%'", DGVAgent);
            }
        }

        private void DGVAgent_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = DGVAgent.Rows[e.RowIndex];
                TxtMatriculeAgent.Text = row.Cells[0].Value?.ToString() ?? "";
                TxtNomAgent.Text = row.Cells[1].Value?.ToString() ?? "";
                TxtPostnomA.Text = row.Cells[2].Value?.ToString() ?? "";
                TxtPrenomA.Text = row.Cells[3].Value?.ToString() ?? "";
                ComboSexe.Text = row.Cells[4].Value?.ToString() ?? "";
                TxtAdresse.Text = row.Cells[5].Value?.ToString() ?? "";
                ComboGrade.Text = row.Cells[6].Value?.ToString() ?? "";
                ComboFonction.Text = row.Cells[7].Value?.ToString() ?? "";
            }
        }

        private void BtnModifier_Click(object sender, EventArgs e)
        {

        }

        private void BtnSupprimer_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TxtMatriculeAgent.Text))
            {
                MessageBox.Show("Veuillez sélectionner un agent à supprimer.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                Basique.cx.requete_S("delete from agent where Matricule_Ag = '" + TxtMatriculeAgent.Text + "'");
                Basique.cx.chargerDGV("Select * from agent", DGVAgent);
                Nettoyage();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors de la suppression : {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnModiifier_Click(object sender, EventArgs e)
        {


        }

        private void BtnModifier_Click_1(object sender, EventArgs e)
        {
            // Validation des champs
            if (string.IsNullOrWhiteSpace(TxtMatriculeAgent.Text))
            {
                MessageBox.Show("Veuillez sélectionner un agent à modifier.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (TxtMatriculeAgent.Text == "" || TxtNomAgent.Text == "" || TxtPostnomA.Text == "" || TxtPrenomA.Text == "" || ComboSexe.Text == "" || TxtAdresse.Text == "" || ComboGrade.Text == "" || ComboFonction.Text == "")
            {
                MessageBox.Show("Veuillez remplir tous les champs.", "Champs Incomplets", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                Basique.cx.requete_M(
                    "update agent set Nom_Ag = '" + TxtNomAgent.Text.Trim() +
                    "', Postnom_Ag = '" + TxtPostnomA.Text.Trim() +
                    "', Prenom_Ag = '" + TxtPrenomA.Text.Trim() +
                    "', Sexe_Ag = '" + ComboSexe.Text +
                    "', Adresse_Ag = '" + TxtAdresse.Text.Trim() +
                    "', Code_Grade = '" + ComboGrade.Text +
                    "', Code_Fonction = '" + ComboFonction.Text +
                    "' where Matricule_Ag = '" + TxtMatriculeAgent.Text + "'");
                Basique.cx.chargerDGV("Select * from agent", DGVAgent);
                Nettoyage();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors de la modification : {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnCompteCourant_Click(object sender, EventArgs e)
        {
            FrmCompteCourant fC = new FrmCompteCourant();
            fC.ShowDialog();
        }
    }
}
    

