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
    public partial class FrmFrais : Form
    {
        public FrmFrais()
        {
            InitializeComponent();
            MiseFormeFormulaire.AppliquerForm(this);
            MiseEnForme.AppliquerPanelMenu(PanelMenu);
            //Mise en forme pour les bouttons
            MiseEnForme.AppliquerButtonQuitter(BtnFFRais);
            MiseEnForme.AppliquerBoutonMenu(BtnPayements);
            MiseEnForme.AppliquerBoutonMenu(BtnSedeconnecter);
            MiseEnForme.AppliquerBoutonMenu(BtnFFRais);
            //Mise en forme pour les textBox
            MiseEnForme.AppliquerTextBox(TxtCodeFrais);
            MiseEnForme.AppliquerTextBox(TxtMontant);
            //Mise en forme pour les comboBox
            MiseEnForme.AppliquerComboBox(ComboFrais);
            //Datagrid
            MiseEnForme.ConfigurerDataGridView(DGVFrais);
            // boutton formulaire
            groupBox1.BackColor = Color.FromArgb(102, 154, 204);
            MiseEnForme.AppliquerEnregitrer(BtnEnregistrer);
            MiseEnForme.AppliquerModifier(BtnModiifier);
            MiseEnForme.AppliquerSupprimer(BtnSupprimer);
        }

        private void BtnFFRais_Click(object sender, EventArgs e)
        {
            FrmFrais fen = new FrmFrais();
            fen.ShowDialog();
        }

        private void BtnPayements_Click(object sender, EventArgs e)
        {
            FrmListePayements frmListePayements = new FrmListePayements();
            frmListePayements.ShowDialog();
        }

        private void BtnSedeconnecter_Click(object sender, EventArgs e)
        {
            FrmConnexion fen = new FrmConnexion();
            this.Hide();
            fen.ShowDialog();
        }

        private void BtnFrais_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FrmFrais_Load(object sender, EventArgs e)
        {
            Basique.cx.chargerDGV("Select * from frais ", DGVFrais);

        }
        void Nettoyage()
        {
            TxtCodeFrais.Clear();
            TxtMontant.Clear();
            ComboFrais.SelectedIndex = -1;
            TxtCodeFrais.Focus();
            Basique.cx.chargerDGV("Select * from frais ", DGVFrais);
        }
        private void BtnEnregistrer_Click(object sender, EventArgs e)
        {
            if (TxtCodeFrais.Text == "" || TxtMontant.Text == "" || ComboFrais.Text == "")
            {
                Basique.ChampVide();
            }
            else
            {
                Basique.cx.requete_E("insert into frais values ('" + TxtCodeFrais.Text + "', '" + ComboFrais.Text + "','" + TxtMontant.Text + "' )");
                Nettoyage();
            }

        }

        private void BtnModiifier_Click(object sender, EventArgs e)
        {
            Basique.cx.requete_M(
                "update frais set Nom_Frais = '" + 
                ComboFrais.Text + "', Montant_Frais = '" + 
                TxtMontant.Text + "' where Code_Frais = '" + 
                TxtCodeFrais.Text + "'");
            Nettoyage();
        }

        private void BtnSupprimer_Click(object sender, EventArgs e)
        {
            Basique.cx.requete_S("delete from frais where Code_Frais = '" + TxtCodeFrais.Text + "'");
        }

        private void TxtCodeFrais_TextChanged(object sender, EventArgs e)
        {
            Basique.cx.chargerDGV("Select * from frais where Code_Frais like '" + TxtCodeFrais.Text + "%' ", DGVFrais);
        }
    }
}
