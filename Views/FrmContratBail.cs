using GESTAPP.Outils;
using iTextSharp.text;
using iTextSharp.text.pdf;
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
    public partial class FrmContratBail : Form
    {
        public FrmContratBail()
        {
            InitializeComponent();
            //Mise en forme formulaire 
            MiseEnForme.AppliquerForm(this);
            MiseEnForme.AppliquerPanelMenu(PanelMenu);
            //Mise en forme des buttons Panel
            MiseEnForme.AppliquerBoutonMenu(BtnAppartement);
            MiseEnForme.AppliquerBoutonMenu(BtnCompteCourant);
            MiseEnForme.AppliquerBoutonMenu(BtnSedeconnecter);
            MiseEnForme.AppliquerButtonQuitter(BtnQuitter);
            //Mise en forme des buttons du formulaire 
            MiseEnForme.AppliquerModifier(BtnModifier);
            MiseEnForme.AppliquerSupprimer(BtnSupprimer);
            MiseEnForme.AppliquerEnregitrer(BtnEnregistrer);
            MiseEnForme.AppliquerBoutonFormulaire(BtnImprimer);
            //Mise en forme  des textboox 
            MiseEnForme.AppliquerTextBox(TxtDetails);
            MiseEnForme.AppliquerTextBox(TxtLibelle);
            MiseEnForme.AppliquerTextBox(TxtNum);
            //Mise en forme des comboboox
            MiseEnForme.AppliquerComboBox(ComboLoc);
            MiseEnForme.AppliquerComboBox(ComboMatriculeAgent);





        }
        private void Nettoyage()
        {
            TxtNum.Clear();
            TxtLibelle.Clear();
            TxtDetails.Clear();
            ComboLoc.SelectedIndex = -1;
            ComboMatriculeAgent.SelectedIndex = -1;
            DateContrat.Value = DateTime.Now;
            Basique.cx.chargerDGV("Select * from contrat_de_bail", DGVContrat);
            TxtNum.Focus();
        }
        private void FrmContratBail_Load(object sender, EventArgs e)
        {
            Basique.cx.chargerDGV("Select * from contrat_de_bail", DGVContrat);
            Basique.cx.ChargeCleEtrangere("locataire", "ID_Loc", Basique.invi.DataGV, ComboLoc);
            Basique.cx.ChargeCleEtrangere("agent", "Matricule_Ag", Basique.invi.DataGV, ComboMatriculeAgent);

        }

        private void BtnEnregistrer_Click(object sender, EventArgs e)
        {
            if (TxtNum.Text == "" || TxtLibelle.Text == "" || TxtDetails.Text == "" || ComboLoc.Text == "" || ComboMatriculeAgent.Text == "")
            {
                MessageBox.Show("Veuillez remplir tous les champs.", "Champs Incomplets", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                Basique.cx.requete_E(
                    "insert into contrat_de_bail (" +
                    "Num_Con , Nom_Con, Details_Con, Date_Con, ID_Loc , Matricule_Ag" +
                    ") values ('" +
                    TxtNum.Text + "', '" +
                    TxtLibelle.Text + "', '" +
                    TxtDetails.Text + "', '" +
                    DateContrat.Value.Date.ToString("yyyy-MM-dd") + "', '" +
                    ComboLoc.Text + "', '" +
                    ComboMatriculeAgent.Text + "')"
                );
                Nettoyage();
            }
        }

        private void BtnModifier_Click(object sender, EventArgs e)
        {

            Basique.cx.requete_M(
               "update contrat_de_bail set " +
               "Nom_Con = '" + TxtLibelle.Text +
               "', Details_Con = '" + TxtDetails.Text +
               "', Date_Con = '" + DateContrat.Value.Date.ToString("yyyy-MM-dd") +
               "', ID_Loc = '" + ComboLoc.Text +
               "', Matricule Ag = '" + ComboMatriculeAgent.Text +
               "' where Num_Con = '" + TxtNum.Text + "'"
           );
            Nettoyage();
        }

        private void BtnSupprimer_Click(object sender, EventArgs e)
        {
            Basique.cx.requete_S("delete from contrat_de_bail where Num_Con  = '" + TxtNum.Text + "'");
            Nettoyage();

        }

        private void TxtNum_TextChanged(object sender, EventArgs e)
        {
            Basique.cx.chargerDGV("Select * from contrat_de_bail where Num_Con  like '" + TxtNum.Text + "%' ", DGVContrat);

        }

        private void BtnAppartement_Click(object sender, EventArgs e)
        {
            FrmBatiment fb = new FrmBatiment();
            fb.ShowDialog();
        }

        private void BtnCompteCourant_Click(object sender, EventArgs e)
        {
            FrmAppartement fb = new FrmAppartement();
            fb.ShowDialog();
        }

        private void BtnSedeconnecter_Click(object sender, EventArgs e)
        {
            FrmConnexion FC = new FrmConnexion();
            this.Hide();
            FC.ShowDialog();
        }

        private void BtnQuitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnImprimer_Click(object sender, EventArgs e)
        {
            try
            {
                // --- Vérification simple ---
                if (TxtNum.Text == "" || TxtLibelle.Text == "" || TxtDetails.Text == "" || ComboLoc.Text == "" || ComboMatriculeAgent.Text == "")
                {
                    MessageBox.Show("Veuillez remplir tous les champs.", "Champs Incomplets", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                GnerationPDF.GenererContratBail(
                   numeroContrat: TxtNum.Text,
                   motif: TxtLibelle.Text,
                   detailsContrat: TxtDetails.Text,
                   dateCreation: DateContrat.Value.Date.ToString("yyyy-MM-dd"),
                   idLocataire: ComboLoc.Text,
                   matriculeAgent: ComboMatriculeAgent.Text);

                MessageBox.Show("Contrat de bail généré avec succès !", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)

            {
                MessageBox.Show("Erreur lors de la génération du contrat de bail : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (TxtNum.Text == "" || TxtLibelle.Text == "" || TxtDetails.Text == "" || ComboLoc.Text == "" || ComboMatriculeAgent.Text == "")
            {
                MessageBox.Show("Veuillez remplir tous les champs.", "Champs Incomplets", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                Basique.cx.requete_E(
                    "insert into contrat_de_bail (" +
                    "Num_Con , Nom_Con, Details_Con, Date_Con, ID_Loc , Matricule_Ag" +
                    ") values ('" +
                    TxtNum.Text + "', '" +
                    TxtLibelle.Text + "', '" +
                    TxtDetails.Text + "', '" +
                    DateContrat.Value.Date.ToString("yyyy-MM-dd") + "', '" +
                    ComboLoc.Text + "', '" +
                    ComboMatriculeAgent.Text + "')"
                );
                Nettoyage();
            }
        }
    }
}
