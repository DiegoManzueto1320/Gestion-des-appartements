using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GESTAPP.Outils;
namespace GESTAPP
{
    public partial class FrmOccuperAppartemeent : Form
    {
        public FrmOccuperAppartemeent()
        {
            InitializeComponent();
            //Mie en forme formulaire
            MiseEnForme.AppliquerForm(this);
            //Mise en forme panel
            MiseEnForme.AppliquerPanelMenu(PanelMenu);
            //Mise en forme bouton menu
            MiseEnForme.AppliquerBoutonMenu(BtnAppartement);
            MiseEnForme.AppliquerBoutonMenu(BtnBatiment);
            MiseEnForme.AppliquerBoutonMenu(BtnLocataire);
            MiseEnForme.AppliquerBoutonMenu(BtnCederLogement);
            MiseEnForme.AppliquerBoutonMenu(BtnComptcourant);
            MiseEnForme.AppliquerBoutonMenu(BtnDoossierLocatif);
            MiseEnForme.AppliquerBoutonMenu(BtnOccuperAppartement);
            MiseEnForme.AppliquerEnregitrer(BtnEnregistrer);
            MiseEnForme.AppliquerModifier(BtnModiifier);
            MiseEnForme.AppliquerSupprimer(BtnSupprimer);
            //Mise en forme datagrid
            MiseEnForme.ConfigurerDataGridView(DGVLocataire);
            //Mise en forme textBox
            MiseEnForme.AppliquerTextBox(TxtNombre);
            //Mise en forme comboBox
            MiseEnForme.AppliquerComboBox(ComboCodeAppart);
            MiseEnForme.AppliquerComboBox(ComboDossier);
            MiseEnForme.AppliquerComboBox(ComboIDLoc);
            MiseEnForme.AppliquerComboBox(ComboMatricule);
            MiseEnForme.AppliquerComboBox(ComboStatut);



        }
        private void Nettoyage ()
        {
            ComboCodeAppart.Text = "";
            ComboDossier.Text = "";
            ComboIDLoc.Text = "";
            ComboMatricule.Text = "";
            ComboStatut.Text = "";
            TxtNombre.Text = "";
            Basique.cx.chargerDGV("Select * from occuperappartement ", DGVLocataire);

        }
        private void FrmOccuperAppartemeent_Load(object sender, EventArgs e)
        {
            Basique.cx.ChargeCleEtrangere("locataire", "ID_Loc", Basique.invi.DataGV, ComboIDLoc);
            Basique.cx.ChargeCleEtrangere("appartement", "Num_App", Basique.invi.DataGV, ComboCodeAppart);
            Basique.cx.ChargeCleEtrangere("dossierlocatif", "Code_Dos", Basique.invi.DataGV, ComboDossier);
            Basique.cx.ChargeCleEtrangere("agent", "Matricule_Ag", Basique.invi.DataGV, ComboMatricule);
            Basique.cx.chargerDGV("Select * from occuperappartement ", DGVLocataire);


        }

        private void BtnEnregistrer_Click(object sender, EventArgs e)
        {
            if (ComboCodeAppart.Text == "" || ComboDossier.Text == "" || ComboIDLoc.Text == "" || ComboMatricule.Text == "" || ComboStatut.Text == "" || TxtNombre.Text == "")
            {
                MessageBox.Show("Veuillez remplir tous les champs", "Champs incomplets", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                    Basique.cx.requete_E("Insert into occuperappartement(ID_Loc,Num_App ,NombrePeronneLoge,Statut_App,Code_Dos,DateOccupation, Maricule_Ag) values('" 
    + ComboIDLoc.Text + "','" 
    + ComboCodeAppart.Text + "','" 
    + TxtNombre.Text + "','" 
    + ComboStatut.Text + "','" 
    + ComboDossier.Text + "','"
    + DateOccupation.Value.Date.ToString("yyyy-MM-dd") + "', '"
    +ComboMatricule.Text + "')");
                Basique.cx.chargerDGV("Select * from occuperappartement ", DGVLocataire);
                Nettoyage();

            }
        }
    }
}
