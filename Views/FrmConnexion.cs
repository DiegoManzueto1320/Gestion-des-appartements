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

namespace GESTAPP
{
    public partial class FrmConnexion : Form
    {
        public FrmConnexion()
        {
            InitializeComponent();
            //Couleur pour le formulaire 
            this.BackColor = Color.FromArgb(199, 221, 245);
            //couleurs bouttons
            panel1.BackColor = Color.FromArgb(102, 154, 204);
            panel2.BackColor = Color.FromArgb(102, 154, 204);
            BtnConnexion.FlatStyle = FlatStyle.Flat;
            BtnConnexion.ForeColor = Color.FromArgb(102, 154, 204);
            BtnQuitter.FlatStyle = FlatStyle.Flat;
            BtnQuitter.ForeColor = Color.Red;
            // ===== TextBox pour le nom d’utilisateur =====

            TxtNomUser.Width = 250;                     // Largeur
            TxtNomUser.Height = 35;                     // Hauteur
            TxtNomUser.Font = new Font("Segoe UI", 12); // Police moderne et lisible
            TxtNomUser.ForeColor = Color.Black;         // Couleur du texte
            TxtNomUser.BackColor = Color.White;         // Couleur de fond
            TxtNomUser.MaxLength = 50;                  // Nombre max de caractères
            TxtNomUser.Multiline = false;               // Une seule ligne
            TxtNomUser.BorderStyle = BorderStyle.FixedSingle;
            TxtNomUser.TextAlign = HorizontalAlignment.Left;

            // ===== TextBox pour le mot de passe =====

            TxtMotdePasse.Width = 250;
            TxtMotdePasse.Height = 35;
            TxtMotdePasse.Font = new Font("Segoe UI", 12);
            TxtMotdePasse.ForeColor = Color.Black;
            TxtMotdePasse.BackColor = Color.White;
            TxtMotdePasse.MaxLength = 20;                   // Limite du mot de passe
            TxtMotdePasse.Multiline = false;
            TxtMotdePasse.PlaceholderText = "Mot de passe"; // Texte indicatif
            TxtMotdePasse.BorderStyle = BorderStyle.FixedSingle;
            TxtMotdePasse.TextAlign = HorizontalAlignment.Left;

            //buttons
            MiseEnForme.AppliquerEnregitrer(BtnConnexion);
            MiseEnForme.AppliquerButtonQuitter(BtnQuitter);

        }
        private void nettoyer ()
        {
            TxtMotdePasse.Text ="";
            TxtNomUser.Text = "";
            TxtNomUser.Focus();
        }

        private void BtnConnexion_Click(object sender, EventArgs e)
        {
            if (TxtNomUser.Text == "" || TxtMotdePasse.Text == "")
            {
                MessageBox.Show(" Veillez remplir les champs de saisie ");
                return;
            }
            Basique connexion = new Basique();
            string categorie = connexion.AuthentifierEtObtenirCategorie(TxtNomUser.Text.Trim(), TxtMotdePasse.Text);
           

            if (!string.IsNullOrEmpty(categorie))
            {
                MessageBox.Show("Bienvenue" +" "+ categorie+ " !");
                
                this.Hide();

                if (categorie.Equals("caissier", StringComparison.OrdinalIgnoreCase))
                {
                    FrmCaissier frm = new FrmCaissier();
                    nettoyer();
                    frm.ShowDialog();
                }
                if (categorie.Equals("Inspecteur de logement", StringComparison.OrdinalIgnoreCase))
                {
                    FrmInspecteurAppartement frm = new FrmInspecteurAppartement();
                    frm.ShowDialog();
                    nettoyer();

                    this.Hide();

                }
                else if (categorie.Equals("Chargé de logement", StringComparison.OrdinalIgnoreCase))
                {
                    FrmMenuChargeLogement frm = new FrmMenuChargeLogement();
                    frm.ShowDialog();
                    nettoyer();

                    this.Hide();

                }
                else if (categorie.Equals("Chargé de compte courant", StringComparison.OrdinalIgnoreCase))
                {
                    FrmChargéCompeCourant frm = new FrmChargéCompeCourant();
                    frm.ShowDialog();
                    nettoyer();

                    this.Hide();

                }
                else if (categorie.Equals("Administrateur", StringComparison.OrdinalIgnoreCase))
                {
                    FrmMenu_Admin frm = new FrmMenu_Admin();
                    frm.ShowDialog();
                    nettoyer();

                    this.Hide();

                }
                else
                {
                    MessageBox.Show("Catégorie non reconnue.");
                    nettoyer();

                    this.Show();
                }
            }
            else
            {
                MessageBox.Show("Nom d'utilisateur ou mot de passe incorrect.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnNettoyer_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FrmConnexion_Load(object sender, EventArgs e)
        {

        }
    }
}
