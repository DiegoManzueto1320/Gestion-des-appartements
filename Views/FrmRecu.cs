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
    public partial class FrmRecu : Form
    {
        public FrmRecu()
        {
            InitializeComponent();
            // Appliquer style général
            MiseEnForme.AppliquerForm(this);

            // Panel
            MiseEnForme.AppliquerPanelMenu(PanelMenu);
            groupBox1.BackColor = Color.FromArgb(102, 154, 204);
            //ButtonMenu
            MiseEnForme.AppliquerBoutonMenu(BtnFFRais);
            MiseEnForme.AppliquerBoutonMenu(BtnPayements);
            MiseEnForme.AppliquerBoutonMenu(BtnSedeconnecter);
            //ButtonQuitter
            MiseEnForme.AppliquerButtonQuitter(BtnFrais);
            //ButtonFormulaire
            MiseEnForme.AppliquerBoutonFormulaire(BtnEnregistrer);
            MiseEnForme.AppliquerEnregitrer(BtnEnregistrer);
            MiseEnForme.AppliquerModifier(BtnModiifier);
            MiseEnForme.AppliquerSupprimer(BtnSupprimer);
            MiseEnForme.AppliquerBoutonFormulaire(BtnImprimer);

            //Textbox
            MiseEnForme.AppliquerTextBox(TxtCodeRecu);
            MiseEnForme.AppliquerTextBox(TxtLibelleRecu);
            //Combobox
            MiseEnForme.AppliquerComboBox(ComboFrais);
            MiseEnForme.AppliquerComboBox(ComboMatricule);
            MiseEnForme.AppliquerComboBox(ComboIDloc);
            MiseEnForme.AppliquerComboBox(ComboMontant);
            MiseEnForme.AppliquerComboBox(CombooModePaiement);

            //Datagrid
            MiseEnForme.ConfigurerDataGridView(DGVRecu);

        }

        private void BtnPayements_Click(object sender, EventArgs e)
        {
            FrmListePayements listePayements = new FrmListePayements();
            listePayements.ShowDialog();
        }

        private void BtnFFRais_Click(object sender, EventArgs e)
        {
            FrmFrais frais = new FrmFrais();
            frais.ShowDialog();
        }

        private void BtnSedeconnecter_Click(object sender, EventArgs e)
        {
            FrmConnexion frmConnexion = new FrmConnexion();
            this.Hide();
            frmConnexion.ShowDialog();
        }

        private void BtnFrais_Click(object sender, EventArgs e)
        {
            FrmCaissier frmCaissier = new FrmCaissier();
            frmCaissier.ShowDialog();
        }

        private void FrmRecu_Load(object sender, EventArgs e)
        {
            Basique.cx.chargerDGV("Select * from recu", DGVRecu);
            Basique.cx.ChargeCleEtrangere("locataire", "ID_Loc", Basique.invi.DataGV, ComboIDloc);
            Basique.cx.ChargeCleEtrangere("agent", "Matricule_Ag", Basique.invi.DataGV, ComboMatricule);
            Basique.cx.ChargeCleEtrangere("frais", "Code_Frais", Basique.invi.DataGV, ComboFrais);
            Basique.cx.ChargeCleEtrangere("frais", "Montant_Frais", Basique.invi.DataGV, ComboMontant);



        }
        private void Nettoyage()
        {
            TxtCodeRecu.Clear();
            TxtLibelleRecu.Clear();
            ComboFrais.SelectedIndex = -1;
            ComboIDloc.SelectedIndex = -1;
            ComboMontant.SelectedIndex = -1;
            ComboMatricule.SelectedIndex = -1;
            DateRec.Value = DateTime.Now;
            Basique.cx.chargerDGV("Select * from recu", DGVRecu);
            TxtCodeRecu.Focus();
        }

        private void BtnEnregistrer_Click(object sender, EventArgs e)
        {
            if (TxtCodeRecu.Text == "" || TxtLibelleRecu.Text == "" || ComboMontant.Text == "" || ComboFrais.Text == "" || ComboIDloc.Text == "" || ComboMatricule.Text == "")
            {
                MessageBox.Show("Veuillez remplir tous les champs.", "Champs Incomplets", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                Basique.cx.requete_E(
                    "insert into recu (" +
                    "Code_Rec, Libelle_Rec, Code_Frais, Montant_Frais, Date_Rec, Moyen_Paiement, ID_Loc, Matricule_Ag" +
                    ") values ('" +
                    TxtCodeRecu.Text + "', '" +
                    TxtLibelleRecu.Text + "', '" +
                    ComboFrais.Text + "', '" +
                    ComboMontant.Text + "', '" +
                    DateRec.Value.Date.ToString("yyyy-MM-dd") + "', '" +
                    CombooModePaiement.Text + "', '" +
                    ComboIDloc.Text + "', '" +
                    ComboMatricule.Text + "')"
                );
                Nettoyage();
            }
        }

        private void BtnModiifier_Click(object sender, EventArgs e)
        {
            Basique.cx.requete_M(
               "update recu set " +
               "Libelle_Rec = '" + TxtLibelleRecu.Text +
               "', Code_Frais = '" + ComboFrais.Text +
               "', Montant_Frais = '" + ComboMontant.Text +
               "', Date_Rec = '" + DateRec.Value.Date.ToString("yyyy-MM-dd") +
               "', Moyen_Paiement = '" + CombooModePaiement.Text +
               "', ID_Loc = '" + ComboIDloc.Text +
               "', Matricule_Ag = '" + ComboMatricule.Text +
               "' where Code_Rec = '" + TxtCodeRecu.Text + "'"
           );
            Nettoyage();
        }

        private void BtnSupprimer_Click(object sender, EventArgs e)
        {
            Basique.cx.requete_S("delete from recu where Code_Rec   = '" + TxtCodeRecu.Text + "'");
            Nettoyage();
        }

        private void TxtCodeRecu_TextChanged(object sender, EventArgs e)
        {
            Basique.cx.chargerDGV("Select * from recu where Code_Rec like '" + TxtCodeRecu.Text + "%' ", DGVRecu);

        }

        private void BtnImprimer_Click(object sender, EventArgs e)
        {
            try
            {
                // --- Vérification simple ---
                if (TxtCodeRecu.Text == "" || TxtLibelleRecu.Text == "" || ComboFrais.Text == "" || ComboIDloc.Text == "" || ComboMatricule.Text == "")
                {
                    MessageBox.Show("Veuillez remplir tous les champs de saisie ", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                 GnerationPDF.GenererRecu(
                    numeroRecu: TxtCodeRecu.Text,
                    motif: TxtLibelleRecu.Text,
                    codeFrais: ComboFrais.Text,
                    datePaiement: DateTime.Now.ToString("dd/MM/yyyy"),
                    idLocataire: ComboIDloc.Text,
                    matriculeAgent: ComboMatricule.Text,
                    montant: ComboMontant.Text,
                    moyenPaiement: CombooModePaiement.Text );

                MessageBox.Show("Reçu généré avec succès !", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)

            {
                MessageBox.Show("Erreur lors de la génération du reçu : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }   


            if (TxtCodeRecu.Text == "" || TxtLibelleRecu.Text == "" || ComboMontant.Text == "" || ComboFrais.Text == "" || ComboIDloc.Text == "" || ComboMatricule.Text == "")
            {
                MessageBox.Show("Veuillez remplir tous les champs.", "Champs Incomplets", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                Basique.cx.requete_E(
                    "insert into recu (" +
                    "Code_Rec, Libelle_Rec, Code_Frais, Montant_Frais, Date_Rec,Moyen_Paiement, ID_Loc, Matricule_Ag" +
                    ") values ('" +
                    TxtCodeRecu.Text + "', '" +
                    TxtLibelleRecu.Text + "', '" +
                    ComboFrais.Text + "', '" +
                    ComboMontant.Text + "', '" +
                    DateRec.Value.Date.ToString("yyyy-MM-dd") + "', '" +
                    CombooModePaiement.Text + "', '" +
                    ComboIDloc.Text + "', '" +
                    ComboMatricule.Text + "')"
                );
                Nettoyage();
            }
        }
    }
    }

