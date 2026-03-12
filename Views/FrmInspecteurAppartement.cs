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
    public partial class FrmInspecteurAppartement : Form
    {
        public FrmInspecteurAppartement()
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
            MiseEnForme.AppliquerBoutonFormulaire(BtnEtablirNote);

        }

        private void BtnEtablirNote_Click(object sender, EventArgs e)
        {
            FrmNotedeRemise FN = new FrmNotedeRemise();
            FN.ShowDialog();
        }

        private void BtnSeDeconnecter_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmConnexion FN = new FrmConnexion();
            FN.ShowDialog();
        }

        private void BtnQuitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnAppartementOccupe_Click(object sender, EventArgs e)
        {
            FrmListePayements p = new FrmListePayements();
            p.ShowDialog();
        }
    }
}
