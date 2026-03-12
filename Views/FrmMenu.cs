using GESTAPP.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GESTAPP
{

    public partial class FrmMenu : Form
    {

        public FrmMenu()

        {
            InitializeComponent();
            //Mise en forme du formulaire
            this.BackColor = Color.White;
            label1.BackColor = Color.Green;
            MiseEnForme.AppliquerPanelMenu(PanelMenu);
            //Mise en forme des boutons
            MiseEnForme.AppliquerBoutonMenu(BtnFrais);
            MiseEnForme.AppliquerButtonQuitter(BtnCompteCourant);
            MiseEnForme.AppliquerMenuPrincipal(BtnBatiment);
            MiseEnForme.AppliquerMenuPrincipal(BtnAppartement);
            MiseEnForme.AppliquerMenuPrincipal(BtnLocataire);
            MiseEnForme.AppliquerMenuPrincipal(BtnGrade);
            MiseEnForme.AppliquerMenuPrincipal(BtnNotedeRemise);
            MiseEnForme.AppliquerMenuPrincipal(BtnContrat);
            MiseEnForme.AppliquerMenuPrincipal(BtnDemande);
            MiseEnForme.AppliquerMenuPrincipal(BtnCmptecourant);
            MiseEnForme.AppliquerMenuPrincipal(BtnOccuperAppartement);
            MiseEnForme.AppliquerMenuPrincipal(BtnDossier);
            MiseEnForme.AppliquerMenuPrincipal(BtnFonction);


        }


        private void BtnBatiment_Click(object sender, EventArgs e)
        {

            FrmBatiment B = new FrmBatiment();
            B.Show();
            this.Hide();
        }

        private void FrmMenu_Load(object sender, EventArgs e)
        {

        }

        private void BtnAppartement_Click(object sender, EventArgs e)
        {

            FrmAppartement fA = new FrmAppartement();
            fA.ShowDialog();
            this.Hide();
        }

        private void BtnLocataire_Click(object sender, EventArgs e)
        {
            FrmLocataire fL = new FrmLocataire();
            fL.ShowDialog();
            this.Hide();
        }

        private void BtnAgent_Click(object sender, EventArgs e)
        {
            FrmAgent fA = new FrmAgent();
            fA.ShowDialog();
            this.Hide();

        }

        private void BtnBatiment_Click_1(object sender, EventArgs e)
        {
            FrmBatiment frm = new FrmBatiment();
            frm.ShowDialog();
        }

        private void BtnLocataire_Click_1(object sender, EventArgs e)
        {
            FrmLocataire fL = new FrmLocataire();
            fL.ShowDialog();
        }

        private void BtnAppartement_Click_1(object sender, EventArgs e)
        {
            FrmAppartement fA = new FrmAppartement();
            fA.ShowDialog();
        }

        private void BtnCmptecourant_Click(object sender, EventArgs e)
        {
            FrmChargéCompeCourant frm = new FrmChargéCompeCourant();
            frm.ShowDialog();
        }

        private void BtnDossier_Click(object sender, EventArgs e)
        {
            FrmDossierLocatif frm = new FrmDossierLocatif();
            frm.ShowDialog();
        }

        private void BtnDemande_Click(object sender, EventArgs e)
        {
            FrmDemandeLocation frm = new FrmDemandeLocation();
            frm.ShowDialog();
        }

        private void BtnGrade_Click(object sender, EventArgs e)
        {
            FrmGrade FG = new FrmGrade();
            FG.ShowDialog();
        }

        private void BtnContrat_Click(object sender, EventArgs e)
        {
            FrmContratBail FC = new FrmContratBail();
            FC.ShowDialog();
        }

        private void BtnFonction_Click(object sender, EventArgs e)
        {
            FrmFonction FF = new FrmFonction();
            FF.ShowDialog();
        }

        private void BtnOccuperAppartement_Click(object sender, EventArgs e)
        {
            FrmOccuperAppartemeent F0 = new FrmOccuperAppartemeent();
            F0.ShowDialog();
        }

        private void BtnNotedeRemise_Click(object sender, EventArgs e)
        {
            FrmNotedeRemise fn = new FrmNotedeRemise();
            fn.ShowDialog();
        }

        private void BtnFrais_Click(object sender, EventArgs e)
        {
            FrmConnexion F0 = new FrmConnexion();
            this.Hide();
            F0.ShowDialog();
        }

        private void BtnCompteCourant_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }


}

