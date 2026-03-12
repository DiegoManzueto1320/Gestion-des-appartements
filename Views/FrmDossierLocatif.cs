using GESTAPP.Outils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GESTAPP.Views
{
    public partial class FrmDossierLocatif : Form
    {
        private GestionService service; // Déclaration du champ service

        public FrmDossierLocatif()
        {
            InitializeComponent();
            service = new GestionService(); // Initialisation du champ service
            //Mise en forme du formulaire 
            MiseEnForme.AppliquerForm(this);
            MiseEnForme.AppliquerPanelMenu(PanelMenu);
            MiseFormeFormulaire.AppliquerGroupebox(groupBox1);
            MiseEnForme.ConfigurerDataGridView(DGVDosssier);
            //Mise en forme des bouttons
            MiseEnForme.AppliquerBoutonMenu(BtnCompteCourant);
            MiseEnForme.AppliquerBoutonMenu(BtnLocataire);
            MiseEnForme.AppliquerBoutonMenu(BtnSeDeconnecter);
            MiseEnForme.AppliquerButtonQuitter(BtnQuitter);
            MiseEnForme.AppliquerEnregitrer(BtnEnregistrer);
            MiseEnForme.AppliquerModifier(BtnModifier);
            MiseEnForme.AppliquerSupprimer(BtnSupprimer);
            //Mise en forme pour les textbox
            MiseEnForme.AppliquerTextBox(TxtCodeDossier);
            MiseEnForme.AppliquerTextBox(TxtLibelle);
            MiseEnForme.AppliquerTextBox(TxtNature);
            //Mise en forme Combo
            MiseEnForme.AppliquerComboBox(ComboCodeContrat);
            MiseEnForme.AppliquerComboBox(ComboIDLOc);
            MiseEnForme.AppliquerComboBox(ComboMatricule);
            MiseEnForme.AppliquerComboBox(CodeNote);







        }

        private void SomeMethod()
        {
            // Changer l’état d’un dossier
            service.ChangerEtatDossier(123, "Validé");

            // Récupérer l’état d’un dossier
            string etat = service.GetEtatDossier(123);

            // Ajouter une notification
            service.AjouterNotification("Nouveau dossier créé", "Gestionnaire");

            // Récupérer les notifications pour le rôle "Administrateur"
            List<string> notifs = service.GetNotifications("Administrateur");

            // Marquer une notification comme lue
            service.MarquerCommeLue(5);
        }

        private void BtnCompteCourant_Click(object sender, EventArgs e)
        {
            FrmCompteCourant FC = new FrmCompteCourant();
            FC.ShowDialog();
        }
        private void Nettoyage()
        {
            TxtCodeDossier.Text = "";
            TxtLibelle.Text = "";
            TxtNature.Text = "";
            ComboCodeContrat.Text = "";
            ComboMatricule.Text = "";
            ComboIDLOc.Text = "";
            CodeNote.Text = "";
            DateDossier.Value = DateTime.Now;
            Basique.cx.chargerDGV("Select * from dossierlocatif", DGVDosssier);
            TxtCodeDossier.Focus();

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

        private void BtnEnregistrer_Click(object sender, EventArgs e)
        {
            if (TxtCodeDossier.Text == "" || TxtLibelle.Text == "" || TxtNature.Text == "" || ComboCodeContrat.Text == "" || CodeNote.Text == "" || ComboIDLOc.Text == "" || ComboMatricule.Text == "")
            {
                MessageBox.Show("Veuillez remplir tous les champs.", "Champs Incomplets", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                Basique.cx.requete_E(
                    "insert into dossierlocatif values ('" +
                    TxtCodeDossier.Text + "', '" +
                    TxtLibelle.Text + "', '" +
                    TxtNature.Text + "', '" +
                    DateDossier.Value.Date.ToString("yyyy-MM-dd") + "', '" +
                    ComboIDLOc.Text + "', '" +
                    ComboCodeContrat.Text + "', '" +
                    CodeNote.Text + "', '" +
                    ComboMatricule.Text + "')"
                );
                Nettoyage();
            }


        }

        private void FrmDossierLocatif_Load(object sender, EventArgs e)
        {
            Basique.cx.chargerDGV("Select * from dossierlocatif", DGVDosssier);
            Basique.cx.ChargeCleEtrangere("locataire", "ID_Loc", Basique.invi.DataGV, ComboIDLOc);
            Basique.cx.ChargeCleEtrangere("contrat_de_bail", "Num_Con", Basique.invi.DataGV, ComboCodeContrat);
            Basique.cx.ChargeCleEtrangere("note_de_remise", "Code_Note", Basique.invi.DataGV, CodeNote);
            Basique.cx.ChargeCleEtrangere("agent", "Matricule_Ag", Basique.invi.DataGV, ComboMatricule);
        }

        private void BtnModifier_Click(object sender, EventArgs e)
        {
            Basique.cx.requete_M(
               "update dossierlocatif set " +
               "Libelle_Dos = '" + TxtLibelle.Text +
               "', Nature_Dos = '" + TxtNature.Text +
               "', Date__Dos = '" + DateDossier.Value.Date.ToString("yyyy-MM-dd") +
               "', ID_Loc = '" + ComboIDLOc.Text +
               "', Code_Con  = '" + ComboCodeContrat.Text +
               "', Code_Note = '" + CodeNote.Text +
               "', Maricule_Ag = '" + ComboMatricule.Text +
               "' where Code_Dos = '" + TxtCodeDossier.Text + "'"
           );
            Nettoyage();
        }

        private void BtnSupprimer_Click(object sender, EventArgs e)
        {
            Basique.cx.requete_S("delete from dossierlocatif where Code_Dos  = '" + TxtCodeDossier.Text + "'");
            Nettoyage();

        }

        private void TxtCodeDossier_TextChanged(object sender, EventArgs e)
        {
            Basique.cx.chargerDGV("Select * from dossierlocatif where Code_Dos  like '" + TxtCodeDossier.Text + "%' ", DGVDosssier);

        }

        private void BtnLocataire_Click(object sender, EventArgs e)
        {
            FrmLocataire FL = new FrmLocataire();
            FL.ShowDialog();
        }
    }
}
