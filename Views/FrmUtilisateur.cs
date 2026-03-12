using GESTAPP.Outils;
using GESTAPP.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GESTAPP
{
    public partial class FrmUtilisateur : Form
    {
        public void MiseForme()
        {
            //Mise en forme formulaire
            MiseEnForme.AppliquerForm(this);
            MiseFormeFormulaire.AppliquerGroupebox(groupBox1);
            //Mise en forme panel
            MiseEnForme.AppliquerPanelMenu(panel1);
            //Mise en forme pour les bouttons
            MiseEnForme.AppliquerBoutonMenu(BtnAgent);
            MiseEnForme.AppliquerBoutonMenu(BtnUtilisateur);
            MiseEnForme.AppliquerButtonQuitter(BtnQuitter);
            MiseEnForme.AppliquerBoutonMenu(BtnSeDeconnecter);
            MiseEnForme.AppliquerEnregitrer(BtnEnregistrer);
            MiseEnForme.AppliquerSupprimer(BtnSupprimer);
            MiseEnForme.AppliquerModifier(BtnModifier);
            //Mise en forme pour les textBox
            MiseEnForme.AppliquerTextBox(TxtNom);
            MiseEnForme.AppliquerTextBox(TxtMotDepasse);
            //Mise en forme pour les comboBox
            MiseEnForme.AppliquerComboBox(ComboMatricule);
            MiseEnForme.AppliquerComboBox(ComboRole);


        }

        public FrmUtilisateur()
        {
            InitializeComponent();
            //Couleur pour le formulaire 
            MiseEnForme.AppliquerForm(this);
            //Couleur pour le panel
            MiseEnForme.AppliquerPanelMenu(PanelMenu);
            PanelMenu.Height = 200;
        }


        private void BtnUtilisateur_Click(object sender, EventArgs e)
        {

        }

        private void BtnAgent_Click(object sender, EventArgs e)
        {


        }

        private void BtnAgent_Click_1(object sender, EventArgs e)
        {
            FrmAgent f = new FrmAgent();
            f.ShowDialog();
        }

        private void BtnUtilisateur_Click_1(object sender, EventArgs e)
        {
            FrmUtilisateur f = new FrmUtilisateur();
            this.Hide();
            f.ShowDialog();

        }

        private void FrmUtilisateur_Load(object sender, EventArgs e)
        {
            MiseForme();
            Basique.cx.ChargeCleEtrangere("agent", "Matricule_Ag", Basique.invi.DataGV, ComboMatricule);

        }

        private void BtnQuitter_Click(object sender, EventArgs e)
        {

        }

        private void BtnQuitter_Click_1(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void BtnSeDeconnecter_Click(object sender, EventArgs e)
        {
            FrmConnexion f = new FrmConnexion();
            this.Hide();
            f.ShowDialog();

        }
        private void NettoyerChamps()
        {
            TxtNom.Clear();
            TxtMotDepasse.Clear();
            ComboRole.SelectedIndex = -1;
            ComboMatricule.SelectedIndex = -1;
            ComboMatricule.Text = "";
            TxtNom.Focus();
        }
        private void BtnEnregistrer_Click(object sender, EventArgs e)
        {
            string nomUtilisateur = TxtNom.Text.Trim();
            string motDePasse = TxtMotDepasse.Text.Trim();
            string agent = ComboMatricule.Text.Trim();
            string categorie = ComboRole.Text.Trim();

            if (string.IsNullOrWhiteSpace(nomUtilisateur) ||
                string.IsNullOrWhiteSpace(motDePasse) ||
                string.IsNullOrWhiteSpace(agent) ||
                string.IsNullOrWhiteSpace(categorie))
            {
                MessageBox.Show("Veuillez remplir tous les champs.", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                bool resultat = GESTAPP.Outils.Basique.AjouterUtilisateur(nomUtilisateur, motDePasse, agent, categorie);

                if (resultat)
                {
                    MessageBox.Show("Utilisateur ajouté avec succès.", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    NettoyerChamps();
                }
                else
                {
                    MessageBox.Show("Échec de l'ajout de l'utilisateur.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    NettoyerChamps();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur inattendue : {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnModifier_Click(object sender, EventArgs e)
        {
            string nomUtilisateur = TxtNom.Text.Trim();
            string motDePasse = TxtMotDepasse.Text.Trim();
            string agent = ComboMatricule.Text.Trim();
            string categorie = ComboRole.Text.Trim();

            if (string.IsNullOrWhiteSpace(nomUtilisateur) ||
                string.IsNullOrWhiteSpace(motDePasse) ||
                string.IsNullOrWhiteSpace(agent) ||
                string.IsNullOrWhiteSpace(categorie))
            {
                MessageBox.Show("Veuillez remplir tous les champs.", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                bool resultat = GESTAPP.Outils.Basique.ModifierUtilisateur(nomUtilisateur, motDePasse, agent, categorie);
                if (resultat)
                {
                    MessageBox.Show("Utilisateur modifié avec succès.", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    NettoyerChamps();
                }
                else
                {
                    MessageBox.Show("Échec de la modification de l'utilisateur.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    NettoyerChamps();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur inattendue : {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnSupprimer_Click(object sender, EventArgs e)
        {
            string nomUtilisateur = TxtNom.Text.Trim();
            if (string.IsNullOrWhiteSpace(nomUtilisateur))
            {
                MessageBox.Show("Veuillez entrer le nom d'utilisateur à supprimer.", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var confirmation = MessageBox.Show($"Êtes-vous sûr de vouloir supprimer l'utilisateur '{nomUtilisateur}' ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirmation == DialogResult.No)
                return;
            try
            {
                bool resultat = GESTAPP.Outils.Basique.SupprimerUtilisateur(nomUtilisateur);
                if (resultat)
                {
                    MessageBox.Show("Utilisateur supprimé avec succès.", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    NettoyerChamps();
                }
                else
                {
                    MessageBox.Show("Échec de la suppression de l'utilisateur.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    NettoyerChamps();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur inattendue : {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
















