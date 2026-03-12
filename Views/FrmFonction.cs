using GESTAPP.Outils;
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

namespace GESTAPP.Views
{
    public partial class FrmFonction : Form
    {
        public FrmFonction()
        {
            InitializeComponent();
            //Couleur pour le formulaire
            MiseEnForme.AppliquerForm(this);
            MiseFormeFormulaire.AppliquerGroupebox(groupBox1);
            //Couleur pour le panel
            MiseEnForme.AppliquerPanelMenu(PanelMenu);
            MiseEnForme.AppliquerPanelMenu(panel1);
            PanelMenu.Height = 200;
            //Mise en forme pour les bouttons
            MiseEnForme.AppliquerBoutonMenu(BtnAgent);
            MiseEnForme.AppliquerBoutonMenu(BtnFonction);
            MiseEnForme.AppliquerBoutonMenu(BtnUtilisateur);
            MiseEnForme.AppliquerButtonQuitter(BtnQuitter);
            MiseEnForme.AppliquerBoutonMenu(BtnSeDeconnecter);
            MiseEnForme.AppliquerEnregitrer(BtnEnregistrer);
            MiseEnForme.AppliquerSupprimer(BtnSupprimer);
            MiseEnForme.AppliquerModifier(BtnModifier);
            //Mise en forme pour les textBox
            MiseEnForme.AppliquerTextBox(TxtFonction);
            MiseEnForme.AppliquerTextBox(TxtLibelle);



        }
        private void Nettoyage()
        {
            TxtFonction.Clear();
            TxtLibelle.Clear();
            TxtFonction.Focus();
        }

        private void BtnEnregistrer_Click(object sender, EventArgs e)
        {
            if (TxtFonction.Text == "" || TxtLibelle.Text == "")
            {
                MessageBox.Show("Veuillez remplir tous les champs.", "Champs Incomplets", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                Basique.cx.requete_E(
                    "insert into fonction (" +
                    "Code_Fonction, Libelle_Fonction" +
                    ") values ('" +
                    TxtFonction.Text + "', '" +
                    TxtLibelle.Text + "')"
                );
                Nettoyage();
            }
        }

        private void BtnSupprimer_Click(object sender, EventArgs e)
        {
            Basique.cx.requete_S("delete from fonction where Code_Fonction = '" + TxtFonction.Text + "'");
            Nettoyage();
        }

        private void TxtFonction_TextChanged(object sender, EventArgs e)
        {

            string Libelle = null;
            using (var connexion = new MySqlConnection("Server=localhost; database= bddgestapp; user id=root; password='';"))
            {
                connexion.Open();
                string requete = "SELECT Libelle_Fonction FROM fonction WHERE Code_Fonction = @code";
                using (var cmd = new MySqlCommand(requete, connexion))
                {
                    cmd.Parameters.AddWithValue("@code", TxtFonction.Text);
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            Libelle = reader["Libelle_Fonction"].ToString();
                        }
                    }
                }
                TxtLibelle.Text = Libelle;
            }
        }

        private void BtnModifier_Click(object sender, EventArgs e)
        {
            Basique.cx.requete_M(
                "update fonction set Libelle_Fonction = '" + TxtLibelle.Text + "' where Code_Fonction = '" +
                TxtFonction.Text + "'");
            Nettoyage();
        }

        private void BtnAgent_Click(object sender, EventArgs e)
        {
            FrmAgent A = new FrmAgent();
            A.ShowDialog();
        }

        private void BtnUtilisateur_Click(object sender, EventArgs e)
        {
            FrmUtilisateur A = new FrmUtilisateur();
            A.ShowDialog();
        }

        private void BtnFonction_Click(object sender, EventArgs e)
        {

            FrmGrade A = new FrmGrade();
            A.ShowDialog();
        }

        private void BtnSeDeconnecter_Click(object sender, EventArgs e)
        {
            FrmConnexion A = new FrmConnexion();
            this.Hide();
            A.ShowDialog();
        }

        private void BtnQuitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
