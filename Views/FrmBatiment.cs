using GESTAPP.Outils;
using GESTAPP.Views;
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

namespace GESTAPP
{
    public partial class FrmBatiment : Form
    {
        private void Nettoyage()
        {
            TxtCode.Text = "";
            TXTAdresse.Text = "";
            TxtLibelle.Text = "";
            TXTNombreUnite.Text = "";
        }

        public FrmBatiment()
        {
            InitializeComponent();
            MiseFormeFormulaire.CouleursDGV(DVGBatiment);
        }
        public void MiseForme()
        {

            //Couleur pour le formulaire 
            this.BackColor = Color.FromArgb(199, 221, 245);
            //Couleur pour le panel
            PanelMenu.Height = 200;
            panel1.BackColor = Color.White;

            //Mise en forme pour les bouttons
            //Agent
            PanelMenu.BackColor = Color.FromArgb(102, 154, 204);
        
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
            //Bouton formulaire
            MiseEnForme.AppliquerEnregitrer(BtnEnregistrer);
            MiseEnForme.AppliquerModifier(BtnNouveau);
            MiseEnForme.AppliquerSupprimer(BtnSupprimer);
            //Textbox code
            MiseEnForme.AppliquerTextBox(TxtCode);
            //Textbox adresse
            MiseEnForme.AppliquerTextBox(TXTAdresse);
            MiseEnForme.AppliquerTextBox(TxtLibelle);
            MiseEnForme.AppliquerTextBox(TXTNombreUnite);
            MiseEnForme.ConfigurerDataGridView(DVGBatiment);
        }
        private void Batiment_Load(object sender, EventArgs e)
        {
            MiseForme();
            Basique.cx.chargerDGV("Select * from batiment ", DVGBatiment);

        }
        private void BtnBatiment_Click(object sender, EventArgs e)
        {

        }

        private void BtnAppartement_Click(object sender, EventArgs e)
        {
            FrmAppartement A = new FrmAppartement();
            A.ShowDialog();
        }


        private void BtnBatiment_Click_1(object sender, EventArgs e)
        {
            FrmBatiment B = new FrmBatiment();
            B.ShowDialog();
        }

        private void BtnAppartement_Click_1(object sender, EventArgs e)
        {
            FrmAppartement B = new FrmAppartement();
            B.ShowDialog();
        }

        private void BtnLocataire_Click_1(object sender, EventArgs e)
        {
            FrmLocataire L = new FrmLocataire();
            L.ShowDialog();
        }

        private void BtnAgent_Click_1(object sender, EventArgs e)
        {

            FrmAgent A = new FrmAgent();
            A.ShowDialog();
        }

        private void BtnEnregistrer_Click(object sender, EventArgs e)
        {


            if (TxtCode.Text == "" || TxtLibelle.Text == "" || TXTAdresse.Text == "" || TXTNombreUnite.Text == "")
            {
                MessageBox.Show("Veuillez remplir tous les champs.", "Champs Incomplets", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                Basique.cx.requete_E(
                    "insert into batiment values ('" +
                    TxtCode.Text + "', '" +
                    TxtLibelle.Text + "', '" +
                    TXTAdresse.Text + "', '" +
                    TXTNombreUnite.Text + "')"
                );
                Nettoyage();
            }

        }
         

        private void BtnNouveau_Click(object sender, EventArgs e)
        {
            Basique.cx.requete_M(
                "update batiment set Nom_Bat = '" +TxtLibelle.Text + 
                "', Adresse_Bat = '" +TXTAdresse.Text +
                "', NombreAppartement_Bat = '" + TXTNombreUnite.Text + "' where Code_Bat = '" +
                TxtCode.Text + "'");
            Nettoyage();
        }

        private void BtnSupprimer_Click(object sender, EventArgs e)
        {
            Basique.cx.requete_S("delete from batiment where Code_Bat = '" + TxtCode.Text + "'");
            Nettoyage();
        }

        private void TxtCode_TextChanged(object sender, EventArgs e)
        {
            Basique.cx.chargerDGV("Select * from batiment where Code_Bat like '" + TxtCode.Text + "%' ", DVGBatiment);
        }

        private void BtnCompteCourant_Click(object sender, EventArgs e)
        {
           
        }
    }
}
