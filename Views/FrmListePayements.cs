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
    public partial class FrmListePayements : Form
    {
        public FrmListePayements()
        {
            InitializeComponent();
            //Couleur pour le formulaire 
            this.BackColor = Color.FromArgb(199, 221, 245);
            //Couleur pour le panel
            PanelMenu.BackColor = Color.FromArgb(45, 62, 80);
            PanelMenu.Height = 200;
            //Datagrid
            MiseFormeFormulaire.CouleursDGV(DGVPayement);
        }

        private void FrmListePayements_Load(object sender, EventArgs e)
        {

            Basique.cx.chargerDGV("Select * from recu ", DGVPayement);
        }
    }
}
