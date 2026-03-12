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
using static System.Runtime.CompilerServices.RuntimeHelpers;

namespace GESTAPP.Views
{
    public partial class FrmGrade : Form
    {

        public FrmGrade()
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
            MiseEnForme.AppliquerTextBox(TxtCodeGrande);
            MiseEnForme.AppliquerTextBox(TxtLibelleGrade);
        }
        public void Nettoyage()
        {
            TxtCodeGrande.Clear();
            TxtLibelleGrade.Clear();
            TxtCodeGrande.Focus();
        }

        private void BtnEnregistrer_Click(object sender, EventArgs e)
        {
            if (TxtCodeGrande.Text == "" || TxtLibelleGrade.Text == "")
            {
                MessageBox.Show("Veuillez remplir tous les champs.", "Champs Incomplets", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                Basique.cx.requete_E(
                    "insert into grade (" +
                    "Code_Grade, Libelle_Grade" +
                    ") values ('" +
                    TxtCodeGrande.Text + "', '" +
                    TxtLibelleGrade.Text + "')"
                );
                Nettoyage();
            }

        }

        private void BtnModifier_Click(object sender, EventArgs e)
        {
            Basique.cx.requete_M(
                "update grade set Libelle_Grade = '" + TxtLibelleGrade.Text + "' where Code_Grade = '" +
                TxtCodeGrande.Text + "'");
            Nettoyage();
        }

        private void BtnSupprimer_Click(object sender, EventArgs e)
        {
            Basique.cx.requete_S("delete from grade where Code_Grade = '" + TxtCodeGrande.Text + "'");
            Nettoyage();
        }

        private void TxtCodeGrande_TextChanged(object sender, EventArgs e)
        {
            string Libelle = null;
            using (var connexion = new MySqlConnection("Server=localhost; database= bddgestapp; user id=root; password='';"))
            {
                connexion.Open();
                string requete = "SELECT Libelle_Grade FROM grade WHERE Code_Grade = @code";
                using (var cmd = new MySqlCommand(requete, connexion))
                {
                    cmd.Parameters.AddWithValue("@code", TxtCodeGrande.Text);
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            Libelle = reader["Libelle_Grade"].ToString();
                        }
                    }
                }
            }
            TxtLibelleGrade.Text = Libelle;
        }

        private void BtnFonction_Click(object sender, EventArgs e)
        {
            FrmFonction FF = new FrmFonction();
            FF.ShowDialog();
        }

        private void BtnUtilisateur_Click(object sender, EventArgs e)
        {
            FrmUtilisateur FF = new FrmUtilisateur();
            FF.ShowDialog();
        }

        private void BtnAgent_Click(object sender, EventArgs e)
        {

        }

        private void BtnSeDeconnecter_Click(object sender, EventArgs e)
        {
            FrmConnexion c = new FrmConnexion();
            this.Hide();
            c.ShowDialog();
        }

        private void BtnQuitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}



