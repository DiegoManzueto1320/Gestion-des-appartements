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
    public partial class FrmChargéCompeCourant : Form
    {
        public FrmChargéCompeCourant()
        {
            InitializeComponent();
            //Couleur pour le formulaire
            this.BackColor = Color.FromArgb(199, 221, 245);
            //Couleur pour le panel
            PanelMenu.BackColor = Color.FromArgb(45, 62, 80);
            PanelMenu.Height = 200;
            //Mise en forme pour les bouttons
            MiseEnForme.AppliquerBoutonFormulaire(BtnDossierLocatif);
            MiseEnForme.AppliquerBoutonFormulaire(BtnGrstionCompte);
            MiseEnForme.AppliquerBoutonFormulaire(BtnTousPayement);
            MiseEnForme.AppliquerBoutonMenu(BtnGestionLocataire);
            MiseEnForme.AppliquerButtonQuitter(BtnQuitter);
            MiseEnForme.AppliquerBoutonMenu(BtnSeDeconnecter);
        }

        private void BtnGrstionCompte_Click(object sender, EventArgs e)
        {
            FrmCompteCourant frmCompteCourant = new FrmCompteCourant();
            frmCompteCourant.ShowDialog();
        }

        private void BtnTousPayement_Click(object sender, EventArgs e)
        {
            FrmListePayements frmListePayements = new FrmListePayements();
            frmListePayements.ShowDialog();
        }

        private void BtnGestionLocataire_Click(object sender, EventArgs e)
        {
            FrmLocataire FL = new FrmLocataire();
            FL.ShowDialog();
        }

        private void BtnSeDeconnecter_Click(object sender, EventArgs e)
        {
            FrmConnexion FC = new FrmConnexion();
            this.Hide();
            FC.ShowDialog();

        }

        private void BtnQuitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnDossierLocatif_Click(object sender, EventArgs e)
        {
            FrmDossierLocatif FD = new FrmDossierLocatif();
            FD.ShowDialog();
        }
    }
}
