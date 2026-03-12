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
    public partial class FrmMenuChargeLogement : Form
    {

        public FrmMenuChargeLogement()
        {
            InitializeComponent();
            //Formulaire
            MiseEnForme.AppliquerForm(this);
            //Panelmenu
            MiseEnForme.AppliquerPanelMenu(PanelMenu);
            panel1.BackColor = Color.FromArgb(102, 154, 204);
            //ButtonMenu
            MiseEnForme.AppliquerBoutonMenu(BtnSeDeconnecter);
            MiseEnForme.AppliquerBoutonMenu(BtnQuitter);
            MiseEnForme.AppliquerBoutonMenu(BtnGestionDemande);
            //ButtonFormulaire
            MiseEnForme.AppliquerBoutonFormulaire(BtnDisponniblite);
            MiseEnForme.AppliquerBoutonFormulaire(BtnFormulaire);
            MiseEnForme.AppliquerBoutonFormulaire(BtnVerifierDemande);

        }

        private void BtnNouveau_Click(object sender, EventArgs e)
        {
            FrmDemandeLocation frm = new FrmDemandeLocation();
            frm.ShowDialog();
        }

        private void BtnEnregistrer_Click(object sender, EventArgs e)
        {
            FrmListeDemandeLocation frm = new FrmListeDemandeLocation();    
            frm.ShowDialog();
        }

        private void BtnAgent_Click(object sender, EventArgs e)
        {
            FrmMenuChargeLogement frm = new FrmMenuChargeLogement();
            frm.ShowDialog();
        }

        private void FrmMenuChargeLogement_Load(object sender, EventArgs e)
        {
        }

        private void FrmMenuChargeLogement_Load_1(object sender, EventArgs e)
        {

        }

        private void BtnVerifier_Click(object sender, EventArgs e)
        {
            FrmAppartement frm = new FrmAppartement();
            frm.ShowDialog();
        }

        private void BtnSeDeconnecter_Click(object sender, EventArgs e)
        {
            FrmConnexion frm = new FrmConnexion();
            this.Hide();
            frm.ShowDialog();
        }

        private void BtnQuitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnDisponniblite_Click(object sender, EventArgs e)
        {
            FrmListeAppartement frm = new FrmListeAppartement();    
            frm.ShowDialog();
        }
    }
}
