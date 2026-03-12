using GESTAPP.Outils;
using GESTAPP.Views;
using iTextSharp.text.pdf.security;
using iTextSharp.text.xml.simpleparser.handler;
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
    public partial class FrmLocataire : Form
    {

        public FrmLocataire()
        {
            InitializeComponent();

            // Appliquer style général
            MiseEnForme.AppliquerForm(this);

            // Panel
            MiseEnForme.AppliquerPanelMenu(PanelMenu);
            groupBox1.BackColor = Color.FromArgb(102, 154, 204);
            // Boutons
            MiseEnForme.AppliquerBoutonMenu(BtnCederLogement);
            MiseEnForme.AppliquerBoutonMenu(BtnLocataire);
            MiseEnForme.AppliquerBoutonMenu(BtnLocataire);
            MiseEnForme.AppliquerBoutonMenu(BtnDoossierLocatif);
            MiseEnForme.AppliquerBoutonMenu(BtnOccuperAppartement);
            MiseEnForme.AppliquerBoutonMenu(BtnComptcourant);
            MiseEnForme.AppliquerEnregitrer(BtnEnregistrer);
            MiseEnForme.AppliquerModifier(BtnModiifier);
            MiseEnForme.AppliquerSupprimer(BtnSupprimer);

            // TextBox
            MiseEnForme.AppliquerTextBox(TxtAge);
            MiseEnForme.AppliquerTextBox(TxtEmail);
            MiseEnForme.AppliquerTextBox(TxtIDLoc);
            MiseEnForme.AppliquerTextBox(TxtLieuNaissanceLoc);
            MiseEnForme.AppliquerTextBox(TxtNomLoc);
            MiseEnForme.AppliquerTextBox(TxtPostnomLoc);
            MiseEnForme.AppliquerTextBox(TxtPrenomLoc);
            MiseEnForme.AppliquerTextBox(TxtProfession);
            MiseEnForme.AppliquerTextBox(TxtTelephone);

            // ComboBox
            MiseEnForme.AppliquerComboBox(ComboMatricule);
            MiseEnForme.AppliquerComboBox(ComboSexeLoc);
            MiseEnForme.AppliquerComboBox(ComboEtat);
            //Datagrid
            MiseEnForme.ConfigurerDataGridView(DGVLocataire);
        }

        private void FrmLocataire_Load(object sender, EventArgs e)
        {
            Basique.cx.ChargeCleEtrangere("agent", "Matricule_Ag", Basique.invi.DataGV, ComboMatricule);
            Basique.cx.chargerDGV("Select * from locataire ", DGVLocataire);
        }
        private void BtnBatiment_Click(object sender, EventArgs e)
        {
            FrmBatiment B = new FrmBatiment();
            B.ShowDialog();
            this.Hide();
        }

        private void BtnAppartement_Click(object sender, EventArgs e)
        {
            FrmAppartement A = new FrmAppartement();
            A.ShowDialog();
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

        private void DGVLocataire_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        //Méthode de  Nettoyage
        private void Nettoyage()
        {
            TxtIDLoc.Clear();
            TxtNomLoc.Clear();
            TxtPostnomLoc.Clear();
            TxtPrenomLoc.Clear();
            ComboSexeLoc.Text = "";
            TxtLieuNaissanceLoc.Clear();
            TxtAge.Clear();
            TxtEmail.Clear();
            TxtTelephone.Clear();
            ComboEtat.Text = "";
            ComboMatricule.Text = "";
            TxtIDLoc.Focus();
        }
        private void BtnEnregistrer_Click(object sender, EventArgs e)
        {

            if (TxtIDLoc.Text == "" || TxtNomLoc.Text == "" || TxtPostnomLoc.Text == "" || TxtPrenomLoc.Text == "" || ComboSexeLoc.Text == "" || TxtLieuNaissanceLoc.Text == "" || TxtAge.Text == "" || TxtEmail.Text == "" || TxtTelephone.Text == "" || ComboEtat.Text == "")
            {
                MessageBox.Show("Veuillez remplir tous les champs.", "Champs Incomplets", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                Basique.cx.requete_E(
                    "insert into locataire (" +
                    "ID_Loc, Nom_Loc, Postnom_Loc, Prenom_Loc, Sexe_Loc, LieuNaissance_Loc, DateNaissance_Loc, Age_Loc, EtatCivil_Loc, Profession_Loc, Email_Loc, Telephone_Loc, Matricule_Ag" +
                    ") values ('" +
                    TxtIDLoc.Text + "', '" +
                    TxtNomLoc.Text + "', '" +
                    TxtPostnomLoc.Text + "', '" +
                    TxtPrenomLoc.Text + "', '" +
                    ComboSexeLoc.Text + "', '" +
                    TxtLieuNaissanceLoc.Text + "', '" +
                    DateNaissanceLoc.Value.Date.ToString("yyyy-MM-dd") + "', '" +
                    TxtAge.Text + "', '" +
                    ComboEtat.Text + "', '" +
                    TxtProfession.Text + "', '" +
                    TxtEmail.Text + "', '" +
                    TxtTelephone.Text + "', '" +
                    ComboMatricule.Text + "')"
                );
                Nettoyage();
            }


        }

        private void BtnModiifier_Click(object sender, EventArgs e)
        {
            Basique.cx.requete_M(
                "update locataire set " +
                "Nom_Loc = '" + TxtNomLoc.Text +
                "', Postnom_Loc = '" + TxtPostnomLoc.Text +
                "', Prenom_Loc = '" + TxtPrenomLoc.Text +
                "', Sexe_Loc = '" + ComboSexeLoc.Text +
                "', LieuNaissance_Loc = '" + TxtLieuNaissanceLoc.Text +
                "', DateNaissance_Loc = '" + DateNaissanceLoc.Value.Date.ToString("yyyy-MM-dd") +
                "', Age_Loc = '" + TxtAge.Text +
                "', EtatCivil_Loc = '" + ComboEtat.Text +
                "', Profession_Loc = '" + TxtProfession.Text +
                ", Email_Loc = '" + TxtEmail.Text +
                "', Telephone_Loc = '" + TxtTelephone.Text +
                "', Matricule_Ag = '" + ComboMatricule.Text +
                "' where ID_Loc = '" + TxtIDLoc.Text + "'"
            );
            Nettoyage();
        }

        private void BtnSupprimer_Click(object sender, EventArgs e)
        {
            Basique.cx.requete_S("delete from locataire where ID_Loc = '" + TxtIDLoc.Text + "'");
            Nettoyage();
        }

        private void TxtIDLoc_TextChanged(object sender, EventArgs e)
        {
            Basique.cx.chargerDGV("Select * from locataire where ID_Loc like '" + TxtIDLoc.Text + "%' ", DGVLocataire);

        }

        private void BtnLocataire_Click_1(object sender, EventArgs e)
        {
            FrmLocataire FL = new FrmLocataire();
            FL.ShowDialog();
        }

        private void BtnDoossierLocatif_Click(object sender, EventArgs e)
        {
            FrmDossierLocatif FD = new FrmDossierLocatif();
            FD.ShowDialog();
        }

        private void BtnComptcourant_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmCompteCourant FC = new FrmCompteCourant();
            FC.ShowDialog();

        }

        private void BtnOccuperAppartement_Click(object sender, EventArgs e)
        {
            FrmOccuperAppartemeent FO = new FrmOccuperAppartemeent();
            FO.ShowDialog();
        }
    }
}
