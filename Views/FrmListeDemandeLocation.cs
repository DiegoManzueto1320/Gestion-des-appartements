using GESTAPP.Outils;
using iTextSharp.text;
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
    public partial class FrmListeDemandeLocation : Form
    {
        MySqlConnection conn = new MySqlConnection("server=localhost; database=bddgestapp; uid=root; pwd=;");
        MySqlDataAdapter adapter;
        DataTable dt;
#pragma warning disable CS8618 // Un champ non-nullable doit contenir une valeur autre que Null lors de la fermeture du constructeur. Envisagez d’ajouter le modificateur « required » ou de déclarer le champ comme pouvant accepter la valeur Null.
        public FrmListeDemandeLocation()
#pragma warning restore CS8618 // Un champ non-nullable doit contenir une valeur autre que Null lors de la fermeture du constructeur. Envisagez d’ajouter le modificateur « required » ou de déclarer le champ comme pouvant accepter la valeur Null.
        {
            InitializeComponent();
            MiseEnForme.AppliquerForm(this);
            MiseEnForme.AppliquerPanelMenu(PanelMenu);
            MiseFormeFormulaire.CouleursDGV(DGVListeDemande);
            MiseEnForme.AppliquerEnregitrer(BtnActualiser);
        } 

        private void FrmListeDemandeLocation_Load(object sender, EventArgs e)
        {
            ChargerDonnees();
            Basique.cx.chargerDGV("SELECT  id, nom, prenom, email, profession, sexe, telephone, type_demande, localisation, nb_personnes  FROM demande_location", DGVListeDemande);
        }
        private void ChargerDonnees(string filtre = "")
        {
            try
            {
                string query = "SELECT id, nom, prenom, email, profession, sexe, telephone, type_demande, localisation, nb_personnes, date_occupation, date_soumission " +
                               "FROM demande_location";

                // Si on veut filtrer par nom ou autre
                if (!string.IsNullOrEmpty(filtre))
                {
                    query += " WHERE nom LIKE @filtre OR prenom LIKE @filtre OR email LIKE @filtre OR type_demande LIKE @filtre";
                }

                adapter = new MySqlDataAdapter(query, conn);
                if (!string.IsNullOrEmpty(filtre))
                {
                    adapter.SelectCommand.Parameters.AddWithValue("@filtre", "%" + filtre + "%");
                }

                dt = new DataTable();
                adapter.Fill(dt);
                DGVListeDemande.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur : " + ex.Message);
            }
        }
        private void BtnActualiser_Click(object sender, EventArgs e)
        {
            Basique.cx.chargerDGV("SELECT  id, nom, prenom, email, profession, sexe, telephone, type_demande, localisation, nb_personnes,  date_soumission, date_occupation, type_demande FROM demande_location", DGVListeDemande);
        }

        private void txtRecherche_TextChanged(object sender, EventArgs e)
        {
            ChargerDonnees(txtRecherche.Text.Trim());
        }
    }
}
