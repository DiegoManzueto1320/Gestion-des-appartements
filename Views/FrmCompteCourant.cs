using GESTAPP.Outils;
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
    public partial class FrmCompteCourant : Form
    {
        public FrmCompteCourant()
        {
            InitializeComponent();
            //Formulaire
            MiseEnForme.AppliquerForm(this);
            //Panel
            MiseEnForme.AppliquerPanelMenu(PanelMenu);
            //buttonMenu
            MiseEnForme.AppliquerBoutonMenu(BtnBatiment);
            MiseEnForme.AppliquerBoutonMenu(BtnDossier);
            MiseEnForme.AppliquerBoutonMenu(BtnDeconnecter);
            MiseEnForme.AppliquerButtonQuitter(BtnQuitter);
            //Datagrid
            MiseEnForme.ConfigurerDataGridView(DGVCompte);
            //ButtonFormualaire
            MiseEnForme.AppliquerEnregitrer(BtnEnregistrer);
            MiseEnForme.AppliquerModifier(BtnModifier);
            MiseEnForme.AppliquerSupprimer(BtnSupprimer);
            //TextBox
            MiseEnForme.AppliquerTextBox(TxtNumero);
            MiseEnForme.AppliquerTextBox(TxtMotif);
            MiseEnForme.AppliquerTextBox(TxtMontanntLoyer);
            MiseEnForme.AppliquerTextBox(TxtMontantPaye);
            MiseEnForme.AppliquerTextBox(TxtSolde);
            MiseEnForme.AppliquerTextBox(TxtReference);
            //ComboBox
            MiseEnForme.AppliquerComboBox(ComboMois);
            MiseEnForme.AppliquerComboBox(ComboTypePaiment);
            MiseEnForme.AppliquerComboBox(ComboMatricule);
            MiseEnForme.AppliquerComboBox(ComboIDLOc);
            MiseEnForme.AppliquerComboBox(ComboRechercher);


        }

        private void FrmCompteCourant_Load(object sender, EventArgs e)
        {
            Basique.cx.ChargeCleEtrangere("agent", "Matricule_Ag", Basique.invi.DataGV, ComboMatricule);
            Basique.cx.ChargeCleEtrangere("locataire", "ID_Loc", Basique.invi.DataGV, ComboIDLOc);
            Basique.cx.ChargeCleEtrangere("locataire", "ID_Loc", Basique.invi.DataGV, ComboRechercher);
            Basique.cx.chargerDGV("Select * from compte_courant ", DGVCompte);

            TxtSolde.Text = Basique.SoldeLocataire(ComboIDLOc.Text).ToString();

        }

        private void BtnBatiment_Click(object sender, EventArgs e)
        {
            FrmFrais fF = new FrmFrais();
            fF.ShowDialog();
        }

        private void BtnDossier_Click(object sender, EventArgs e)
        {
            FrmDossierLocatif DS = new FrmDossierLocatif();
            DS.ShowDialog();
        }

        private void BtnDeconnecter_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmConnexion frmConnexion = new FrmConnexion();
            frmConnexion.ShowDialog();
        }
        private void Nettoyage()
        {
            TxtNumero.Text = "";
            TxtMontantPaye.Text = "";
            TxtSolde.Text = "";
            TxtMontanntLoyer.Text = "";
            ComboIDLOc.Text = "";
            ComboMois.Text = "";
            ComboMatricule.Text = "";
            ComboTypePaiment.Text = "";
            TxtMotif.Text = "";
            TxtReference.Text = "";
            TxtNumero.Focus();
            Basique.cx.chargerDGV("Select * from compte_courant ", DGVCompte);
        }
        private void BtnQuitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnEnregistrer_Click(object sender, EventArgs e)
        {
            if (TxtNumero.Text == "" || TxtNumero.Text == "" || TxtMotif.Text == "" || ComboMois.Text == "" || DatePaie.Text == "" || TxtMontanntLoyer.Text == "" || TxtMontantPaye.Text == "" || TxtSolde.Text == "" || ComboTypePaiment.Text == "" || TxtReference.Text == "" || ComboMatricule.Text == "" || ComboIDLOc.Text == "")
            {
                MessageBox.Show("Veuillez remplir tous les champs.", "Champs Incomplets", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                Basique.cx.requete_E(
                    "insert into compte_courant values ('" +
                    TxtNumero.Text + "', '" +
                    TxtMotif.Text + "', '" +
                    ComboMois.Text + "', '" +
                    DatePaie.Value.ToString("yyyy-MM-dd") + "', '" +
                    TxtMontanntLoyer.Text + "', '" +
                    TxtMontantPaye.Text + "', '" +
                    TxtSolde.Text + "', '" +
                    ComboTypePaiment.Text + "', '" +
                    TxtReference.Text + "', '" +
                    ComboMatricule.Text + "', '" +
                    ComboIDLOc.Text + "')"
                );
                Nettoyage();
            }
        }


        private void BtnModifier_Click(object sender, EventArgs e)
        {
            Basique.cx.requete_M(
                "update compte_courant set " +
                "Motif = '" + TxtMotif.Text +
                "', Mois_Paye = '" + ComboMois.Text +
                "', Date_Paye = '" + DatePaie.Value.ToString("yyyy-MM-dd") +
                "', Montant_Loyer = '" + TxtMontanntLoyer.Text +
                "', Montant_Paye = '" + TxtMontantPaye.Text +
                "', SoldeLoyer = '" + TxtSolde.Text +
                "', Type_Paiement = '" + ComboTypePaiment.Text +
                "', Référence_paiement = '" + TxtReference.Text +
                "', Matricule_Ag = '" + ComboMatricule.Text +
                "', ID_Loc = '" + ComboIDLOc.Text +
                "' where Num_Compte = '" + TxtNumero.Text + "'"
            );
            Nettoyage();
        }

        private void BtnSupprimer_Click(object sender, EventArgs e)
        {
            Basique.cx.requete_S("delete from compte_courant where Num_Compte = '" + TxtNumero.Text + "'");
            Nettoyage();

        }

        private void TxtNumero_TextChanged(object sender, EventArgs e)
        {
            Basique.cx.chargerDGV("Select * from compte_courant where Num_Compte like '" + TxtNumero.Text + "%' ", DGVCompte);

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ComboIDLOc_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void DGVCompte_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          
        }

        private void ComboRechercher_SelectedIndexChanged(object sender, EventArgs e)
        {

            double solde = Basique.SoldeLocataire(ComboRechercher.Text);

            if (solde < 0)
            {
                lblSolde.ForeColor = Color.Red;  // 🔴 Dette
                lblSolde.Text = solde + " $ (Dette)";
            }
            else if (solde == 0)
            {
                lblSolde.ForeColor = Color.Green;  // 🟢 En ordre
                lblSolde.Text = "En ordre";
            }
            else
            {
                lblSolde.ForeColor = Color.Orange;  // 🟠 Avance
                lblSolde.Text = Math.Abs(solde) + " $ (Avance)";
            }
            Basique.cx.chargerDGV("Select * from compte_courant where ID_Loc like '" + ComboRechercher.Text + "%' ", DGVCompte);
        }

        private void TxtSolde_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtMontantPaye_TextChanged(object sender, EventArgs e)
        {
            TxtMontantPaye.TextChanged += (s, ev) =>
            {
                if (double.TryParse(TxtMontantPaye.Text, out double montantPaye) && double.TryParse(TxtMontanntLoyer.Text, out double montantLoyer))
                {
                    TxtSolde.Text = (montantPaye - montantLoyer).ToString();
                }
                else
                {
                    TxtSolde.Text = Basique.SoldeLocataire(ComboIDLOc.Text).ToString();

                }
            };
        }

        private void TxtMontanntLoyer_TextChanged(object sender, EventArgs e)
        {
            TxtMontanntLoyer.TextChanged += (s, ev) =>
            {
                if (double.TryParse(TxtMontantPaye.Text, out double montantPaye) && double.TryParse(TxtMontanntLoyer.Text, out double montantLoyer))
                {
                    TxtSolde.Text = (montantPaye - montantLoyer).ToString();
                }
                else
                {
                    TxtSolde.Text = Basique.SoldeLocataire(ComboIDLOc.Text).ToString();
                }
            };
        }
    }
}

