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
    public partial class FrmApropos : Form
    {
        public FrmApropos()
        {
            InitializeComponent();
        }

        private void FrmApropos_Load(object sender, EventArgs e)
        {
            // Infos de l'application
            lblAppName.Text = "GESTAPP – Gestion des Appartements";
            lblVersion.Text = "Version : 1.0 (Septembre 2025)";
            lblCompany.Text = "Développé par : MATONDO MANZUETO Diego";
            lblCopyright.Text = "© 2025 Direction de Gestion Immobilière";
            txtDescription.Text =
                 "Ce logiciel a été conçu pour automatiser et optimiser la gestion immobilière.\r\n\r\n" +
                 "Fonctionnalités principales :\r\n" +
                 "• Gestion des utilisateurs et des accès\r\n" +
                 "• Gestion du système et paramétrages\r\n" +
                 "• Suivi des opérations immobilières\r\n" +
                 "• Sécurité et traçabilité des actions\r\n\r\n" +
                 "Support technique : support@dgi.cd\r\n" +
                 "Téléphone : (+243) 844 543 523";

        }
            

        private void BtnOk_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
