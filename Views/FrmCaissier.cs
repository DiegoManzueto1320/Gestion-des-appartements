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
    public partial class FrmCaissier : Form
    {
        public FrmCaissier()
        {
            InitializeComponent();
            //Formulaire
            MiseEnForme.AppliquerForm(this);
            //Panel
            MiseEnForme.AppliquerPanelMenu(PanelMenu);
            panel1.BackColor = Color.FromArgb(102, 154, 204);
            groupBox1.BackColor = Color.FromArgb(154, 206, 207);
            //buttonMenu
            MiseEnForme.AppliquerBoutonMenu(BtnSeDeconnecter);
            MiseEnForme.AppliquerButtonQuitter(BtnQuitter);
            //ButtonFormualaire
            MiseEnForme.AppliquerBoutonFormulaire(BtnAppartementOccupe);
            MiseEnForme.AppliquerBoutonFormulaire(BtnTousPayement);
            MiseEnForme.AppliquerBoutonFormulaire(BtnEtablirRecu);

        }

        private void BtnEtablirRecu_Click(object sender, EventArgs e)
        {
            FrmRecu frmRecu = new FrmRecu();
            frmRecu.ShowDialog();
        }

        private void BtnAppartementOccupe_Click(object sender, EventArgs e)
        {
            FrmListeAppartement listeAppartement = new FrmListeAppartement();
            listeAppartement.ShowDialog();
        }

        private void BtnTousPayement_Click(object sender, EventArgs e)
        {
            FrmListePayements listePayements = new FrmListePayements();
            listePayements.ShowDialog();
        }

        private void BtnSeDeconnecter_Click(object sender, EventArgs e)
        {
            FrmConnexion frmConnexion = new FrmConnexion();
            this.Hide();
            frmConnexion.ShowDialog();
        }

        private void BtnQuitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FrmCaissier_Load(object sender, EventArgs e)
        {

        }
    }
}
