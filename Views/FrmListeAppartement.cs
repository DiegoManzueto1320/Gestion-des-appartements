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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace GESTAPP
{
    public partial class FrmListeAppartement : Form
    {
        MySqlConnection conn = new MySqlConnection("server=localhost; database=bddgestapp; uid=root; pwd=;");
        MySqlDataAdapter adapter;
        DataTable dt;

        public FrmListeAppartement()
        {
            InitializeComponent();

        }
        public void MiseForme()
        {
            //Couleur pour le formulaire 
            this.BackColor = Color.FromArgb(199, 221, 245);
            //Couleur pour le panel
            PanelMenu.BackColor = Color.FromArgb(45, 62, 80);
            PanelMenu.Height = 200;
            //Datagrid
            MiseFormeFormulaire.CouleursDGV(DVGListeAppartement);

        }

        private void FrmListeAppartement_Load(object sender, EventArgs e)
        {

        }

        private void FrmListeAppartement_Load_1(object sender, EventArgs e)
        {
            MiseForme();
            Basique.cx.chargerDGV("SELECT * FROM appartement", DVGListeAppartement);

        }
      

        private void txtRecherche_TextChanged(object sender, EventArgs e)
        {
            Basique.cx.chargerDGV("Select * from appartement where Num_App like '" + txtRecherche.Text + "%' ", DVGListeAppartement);


        }
    }
}
