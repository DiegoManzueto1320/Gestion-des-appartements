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

namespace GESTAPP.Views
{
    public partial class FrmNotedeRemise : Form
    {
        public FrmNotedeRemise()
        {
            InitializeComponent();
            //Mise en forme formulaire
            MiseEnForme.AppliquerForm(this);
            // Panel
            MiseEnForme.AppliquerPanelMenu(PanelMenu);
            MiseFormeFormulaire.AppliquerGroupebox(groupBox1);
            groupBox1.BackColor = Color.FromArgb(102, 154, 204);
            //ButtonMenu
            MiseEnForme.AppliquerBoutonMenu(BtnSedeconncter);
            MiseEnForme.AppliquerButtonQuitter(BtnQuitter);
            //ButtonFormulaire
            MiseEnForme.AppliquerEnregitrer(BtnEnregistrer);
            MiseEnForme.AppliquerModifier(BtnModifier);
            MiseEnForme.AppliquerSupprimer(BtnSupprimer);
            MiseEnForme.AppliquerBoutonFormulaire(BtnImprimer);

            //Textbox
            MiseEnForme.AppliquerTextBox(TxtCode);
            MiseEnForme.AppliquerTextBox(TxtArticle);
            MiseEnForme.AppliquerTextBox(TxtCode);
            //Combobox
            MiseEnForme.AppliquerComboBox(ComboIDLoc);
            MiseEnForme.AppliquerComboBox(ComboNumAppartement);
            MiseEnForme.AppliquerComboBox(ComboMatriculeAgent);
            //Datagrid
            MiseEnForme.ConfigurerDataGridView(DGVNote);
        }

        private void TxtPostnomA_TextChanged(object sender, EventArgs e)
        {

        }
        private void Nettoyage()
        {
            TxtArticle.Clear();
            TxtCode.Clear();
            TxtxLibelle.Clear();
            ComboIDLoc.SelectedIndex = -1;
            ComboMatriculeAgent.SelectedIndex = -1;
            ComboNumAppartement.SelectedIndex = -1;
            DateNote.Value = DateTime.Now;
            Basique.cx.chargerDGV("Select * from note_de_remise", DGVNote);
            TxtCode.Focus();
        }
        private void FrmNotedeRemise_Load(object sender, EventArgs e)
        {
            Basique.cx.chargerDGV("Select * from note_de_remise", DGVNote);
            Basique.cx.ChargeCleEtrangere("appartement", "Num_App", Basique.invi.DataGV, ComboNumAppartement);
            Basique.cx.ChargeCleEtrangere("locataire", "Id_Loc ", Basique.invi.DataGV, ComboIDLoc);
            Basique.cx.ChargeCleEtrangere("agent", "Matricule_Ag", Basique.invi.DataGV, ComboMatriculeAgent);
        }

        private void BtnEnregistrer_Click(object sender, EventArgs e)
        {
            if (TxtCode.Text == "" || TxtArticle.Text == "" || TxtxLibelle.Text == "" || ComboIDLoc.Text == "" || ComboNumAppartement.Text == "" || ComboMatriculeAgent.Text == "")
            {
                MessageBox.Show("Veuillez remplir tous les champs.", "Champs Incomplets", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                Basique.cx.requete_E(
                    "insert into note_de_remise (" +
                    "Code_Note , Libelle_Note, Article_Note, Date_Note, Num_App , Id_Loc, Matricule_Ag" +
                    ") values ('" +
                    TxtCode.Text + "', '" +
                    TxtxLibelle.Text + "', '" +
                    TxtArticle.Text + "', '" +
                    DateNote.Value.Date.ToString("yyyy-MM-dd") + "', '" +
                    ComboNumAppartement.Text + "', '" +
                    ComboIDLoc.Text + "', '" +
                    ComboMatriculeAgent.Text + "')"
                );
                Nettoyage();
            }
        }

        private void BtnModifier_Click(object sender, EventArgs e)
        {
            Basique.cx.requete_M(
               "update note_de_remise set " +
               "Libelle_Note = '" + TxtxLibelle.Text +
               "', Article_Note = '" + TxtArticle.Text +
               "', Date_Note = '" + DateNote.Value.Date.ToString("yyyy-MM-dd") +
               "', Num_App  = '" + ComboNumAppartement.Text +
               "', Id_Loc  = '" + ComboIDLoc.Text +
               "', Matricule_Ag   = '" + ComboMatriculeAgent.Text +
               "' where Code_Note  = '" + TxtCode.Text + "'");

            Nettoyage();
        }

        private void BtnSupprimer_Click(object sender, EventArgs e)
        {
            Basique.cx.requete_S("delete from note_de_remise where Code_Note = '" + TxtCode.Text + "'");
            Nettoyage();
        }

        private void TxtCode_TextChanged(object sender, EventArgs e)
        {
            Basique.cx.chargerDGV("Select * from note_de_remise where Code_Note like '" + TxtCode.Text + "%' ", DGVNote);

        }

        private void BtnImprimer_Click(object sender, EventArgs e)
        {
            try
            {
                // --- Vérification simple ---
                if (TxtCode.Text == "" || TxtArticle.Text == "" || TxtxLibelle.Text == "" || ComboIDLoc.Text == "" || ComboNumAppartement.Text == "" || ComboMatriculeAgent.Text == "")
                {
                    MessageBox.Show("Veuillez remplir tous les champs.", "Champs Incomplets", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                GnerationPDF.GenererNoteRemise(
                   codeNote: TxtCode.Text,
                   motif: TxtxLibelle.Text,
                   article: TxtArticle.Text,
                   dateCreation: DateTime.Now.ToString("dd/MM/yyyy"),
                   numeroAppartement: ComboNumAppartement.Text,
                   idLocataire: ComboIDLoc.Text,
                   matriculeAgent: ComboMatriculeAgent.Text);

                MessageBox.Show("Note de remise générée avec succès !", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)

            {
                MessageBox.Show("Erreur lors de la génération de la note de remise : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (TxtCode.Text == "" || TxtArticle.Text == "" || TxtxLibelle.Text == "" || ComboIDLoc.Text == "" || ComboNumAppartement.Text == "" || ComboMatriculeAgent.Text == "")
            {
                MessageBox.Show("Veuillez remplir tous les champs.", "Champs Incomplets", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                Basique.cx.requete_E(
                    "insert into note_de_remise (" +
                    "Code_Note , Libelle_Note, Article_Note, Date_Note, Num_App , Id_Loc, Matricule_Ag" +
                    ") values ('" +
                    TxtCode.Text + "', '" +
                    TxtxLibelle.Text + "', '" +
                    TxtArticle.Text + "', '" +
                    DateNote.Value.Date.ToString("yyyy-MM-dd") + "', '" +
                    ComboNumAppartement.Text + "', '" +
                    ComboIDLoc.Text + "', '" +
                    ComboMatriculeAgent.Text + "')"
                );
                Nettoyage();
            }
        }

        private void BtnSedeconncter_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            FrmConnexion frmConnexion = new FrmConnexion();
            frmConnexion.ShowDialog();
        }

        private void BtnQuitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
