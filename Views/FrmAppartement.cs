using GESTAPP.Outils;
using GESTAPP.Views;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.CompilerServices.RuntimeHelpers;

namespace GESTAPP
{
    public partial class FrmAppartement : Form
    {
        public FrmAppartement()
        {
            InitializeComponent();
        }
        public void MiseForme()
        {
            //Couleur pour le formulaire 
            this.BackColor = Color.FromArgb(199, 221, 245);
            //Couleur pour le panel
            PanelMenu.Height = 200;
            MiseEnForme.ConfigurerDataGridView(DGVAppartement);
            //Mise en forme pour les bouttons

            //Batiment
            PanelMenu.BackColor = Color.FromArgb(45, 62, 80);
            BtnBatiment.FlatStyle = FlatStyle.Flat;
            BtnBatiment.FlatAppearance.BorderSize = 0;
            BtnBatiment.ForeColor = Color.White;
            BtnBatiment.TextAlign = ContentAlignment.MiddleLeft;
            BtnBatiment.Padding = new Padding(10, 0, 0, 0);
            BtnBatiment.Height = 40;
            BtnBatiment.Width = 200;
            BtnBatiment.Font = new Font("Roboto", 12, FontStyle.Bold);

            //Liste 
            BtnSupprimer.BackColor = Color.FromArgb(66, 133, 244);
            BtnSupprimer.ForeColor = Color.White;
            BtnSupprimer.TextAlign = ContentAlignment.MiddleCenter;
            BtnSupprimer.Padding = new Padding(10, 0, 0, 0);
            BtnSupprimer.Font = new Font("Times New Roman", 12, FontStyle.Bold);
            //Locataire
            PanelMenu.BackColor = Color.FromArgb(45, 62, 80);
            BtnLocataire.FlatStyle = FlatStyle.Flat;
            BtnLocataire.FlatAppearance.BorderSize = 0;
            BtnLocataire.ForeColor = Color.White;
            BtnLocataire.TextAlign = ContentAlignment.MiddleLeft;
            BtnLocataire.Padding = new Padding(10, 0, 0, 0);
            BtnLocataire.Height = 40;
            BtnLocataire.Width = 200;
            BtnLocataire.Font = new Font("Roboto", 12, FontStyle.Bold);
            //Appartement
            PanelMenu.BackColor = Color.FromArgb(45, 62, 80);
            BtnAppartement.FlatStyle = FlatStyle.Flat;
            BtnAppartement.FlatAppearance.BorderSize = 0;
            BtnAppartement.ForeColor = Color.White;
            BtnAppartement.TextAlign = ContentAlignment.MiddleLeft;
            BtnAppartement.Padding = new Padding(10, 0, 0, 0);
            BtnAppartement.Height = 40;
            BtnAppartement.Width = 200;
            BtnAppartement.Font = new Font("Roboto", 12, FontStyle.Bold);
            //Frais
            PanelMenu.BackColor = Color.FromArgb(45, 62, 80);
            BtnFrais.FlatStyle = FlatStyle.Flat;
            BtnFrais.FlatAppearance.BorderSize = 0;
            BtnFrais.ForeColor = Color.White;
            BtnFrais.TextAlign = ContentAlignment.MiddleLeft;
            BtnFrais.Padding = new Padding(10, 0, 0, 0);
            BtnFrais.Height = 40;
            BtnFrais.Width = 200;
            BtnFrais.Font = new Font("Roboto", 12, FontStyle.Bold);
            //CompteCourant
            PanelMenu.BackColor = Color.FromArgb(45, 62, 80);
            BtnCompteCourant.FlatStyle = FlatStyle.Flat;
            BtnCompteCourant.FlatAppearance.BorderSize = 0;
            BtnCompteCourant.ForeColor = Color.White;
            BtnCompteCourant.TextAlign = ContentAlignment.MiddleLeft;
            BtnCompteCourant.Padding = new Padding(10, 0, 0, 0);
            BtnCompteCourant.Height = 40;
            BtnCompteCourant.Width = 200;
            BtnCompteCourant.Font = new Font("Roboto", 12, FontStyle.Bold);
            //textBOX
            MiseEnForme.AppliquerTextBox(TxtDetail);
            MiseEnForme.AppliquerTextBox(TxtNumero);
            MiseEnForme.AppliquerTextBox(TxtPrix);
            MiseEnForme.AppliquerTextBox(TxtNomApp);
            //ComboBox
            MiseEnForme.AppliquerComboBox(ComboIDLOc);
            MiseEnForme.AppliquerComboBox(ComboCodeBat);
            MiseEnForme.AppliquerComboBox(ComboPiece);
            MiseEnForme.AppliquerComboBox(ComboStatut);
            //buttons
            MiseEnForme.AppliquerEnregitrer(BtnEnregistrer);
            MiseEnForme.AppliquerModifier(BtnModifier);
            MiseEnForme.AppliquerSupprimer(BtnSupprimer);
        }
        private void BtnAppartement_Click(object sender, EventArgs e)
        {
            FrmAppartement fA = new FrmAppartement();
            fA.ShowDialog();
            this.Hide();
        }

        private void FrmAppartement_Load(object sender, EventArgs e)
        {
            MiseForme();
            Basique.cx.ChargeCleEtrangere("batiment", "Code_Bat", Basique.invi.DataGV, ComboCodeBat);
            Basique.cx.ChargeCleEtrangere("locataire", "ID_Loc", Basique.invi.DataGV, ComboIDLOc);
            Basique.cx.chargerDGV("Select * from appartement ", DGVAppartement);
        }
        private void BtnBatiment_Click(object sender, EventArgs e)
        {
            FrmBatiment B = new FrmBatiment();
            B.ShowDialog();
            this.Hide();
        }

        private void BtnLocataire_Click(object sender, EventArgs e)
        {
            FrmLocataire L = new FrmLocataire();
            L.ShowDialog();
            this.Hide();
        }

        private void BtnAgent_Click(object sender, EventArgs e)
        {
            FrmAgent A = new FrmAgent();
            A.ShowDialog();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void BtnBatiment_Click_1(object sender, EventArgs e)
        {
            FrmBatiment frm = new FrmBatiment();
            this.Hide(); frm.ShowDialog();
        }

        private void BtnLocataire_Click_1(object sender, EventArgs e)
        {
            FrmLocataire frm = new FrmLocataire();
            this.Hide(); frm.ShowDialog();
        }

        private void BtnListeAppart_Click(object sender, EventArgs e)
        {
            FrmListeAppartement frm = new FrmListeAppartement();
            frm.ShowDialog();
        }
        private void nettoyage()
        {
            TxtNumero.Clear();
            TxtDetail.Clear();
            TxtPrix.Clear();
            TxtNomApp.Clear();
            ComboCodeBat.Text = "";
            ComboStatut.Text = "";
            ComboPiece.Text = "";
            ComboIDLOc.Text = "";
            TxtNumero.Focus();
        }
        private void BtnEnregistrer_Click(object sender, EventArgs e)
        {
            if (TxtNumero.Text == "" || TxtDetail.Text == "" || TxtNomApp.Text == "" || TxtPrix.Text == "" || ComboCodeBat.Text == "" || ComboStatut.Text == "" || ComboPiece.Text == "" || ComboIDLOc.Text == "")
            {
                MessageBox.Show("Veuillez remplir tous les champs.", "Champs Incomplets", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                Basique.cx.requete_E(
                    "insert into appartement values ('" +
                    TxtNumero.Text + "', '" +
                    TxtNomApp.Text + "', '" +
                    TxtDetail.Text + "', '" +
                    ComboPiece.Text + "', '" +
                    TxtPrix.Text + "', '" +
                    ComboStatut.Text + "', '" +
                    ComboCodeBat.Text + "', '" +
                    ComboIDLOc.Text + "')"
                );
                nettoyage();
            }
        }

        private void BtnModifier_Click(object sender, EventArgs e)
        {
            Basique.cx.requete_M(
                            "update appartement set Nom_App = '" + TxtNomApp.Text +
                            "', Details_Appart = '" + TxtDetail.Text +
                            "', NombrePiece_App = '" + ComboPiece.Text +
                            "', Montant_App = '" + TxtPrix.Text +
                            "', Statut_App = '" + ComboStatut.Text +
                            "', Code_Batiment = '" + ComboCodeBat.Text +
                            "', ID_Loc = '" + ComboIDLOc.Text +
                            "' where Num_App = '" + TxtNumero.Text + "'");
            nettoyage();
        }

        private void BtnSupprimer_Click(object sender, EventArgs e)
        {
            Basique.cx.requete_S("delete from appartement where Num_App = '" + TxtNumero.Text + "'");
            nettoyage();
        }

        private void TxtNumero_TextChanged(object sender, EventArgs e)
        {
            Basique.cx.chargerDGV("Select * from appartement where Num_App like '" + TxtNumero.Text + "%' ", DGVAppartement);
        }

        private void BtnCompteCourant_Click(object sender, EventArgs e)
        {
            FrmCompteCourant F = new FrmCompteCourant();
            F.ShowDialog();
        }
    }
}
