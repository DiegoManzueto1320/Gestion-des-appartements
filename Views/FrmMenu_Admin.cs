using GESTAPP.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GESTAPP
{
    public partial class FrmMenu_Admin : Form
    {

        public FrmMenu_Admin()
        {

            InitializeComponent();
            {

            }

        }
        public void MiseAjour()
        {
            // ===== Style de base pour tous les boutons =====
            this.BackColor = Color.FromArgb(199, 221, 245); // Couleur de fond du formulaire
            //ButtonGeestionUsers
            BtnGestionUser.Width = 150;                               // Largeur
            BtnGestionUser.Height = 45;                               // Hauteur
            BtnGestionUser.Size = new Size(492, 74);
            BtnGestionUser.Font = new Font("Segoe UI", 11, FontStyle.Bold); // Police moderne et lisible
            BtnGestionUser.ForeColor = Color.White;                   // Couleur du texte
            BtnGestionUser.BackColor = Color.FromArgb(51, 102, 204);  // Couleur bleue personnalisée
            BtnGestionUser.FlatStyle = FlatStyle.Flat;                // Style plat moderne
            BtnGestionUser.FlatAppearance.BorderSize = 0;             // Pas de bordure
            BtnGestionUser.Cursor = Cursors.Hand;                     // Curseur "main" au survol
            //ButtonGestionsysteme
            BtnGestionSystem.Width = 150;                               // Largeur
            BtnGestionSystem.Height = 45;                               // Hauteur
            BtnGestionSystem.Size = new Size(492, 74);
            BtnGestionSystem.Font = new Font("Segoe UI", 11, FontStyle.Bold); // Police moderne et lisible
            BtnGestionSystem.ForeColor = Color.White;                   // Couleur du texte
            BtnGestionSystem.BackColor = Color.FromArgb(51, 102, 204);  // Couleur bleue personnalisée
            BtnGestionSystem.FlatStyle = FlatStyle.Flat;                // Style plat moderne
            BtnGestionSystem.FlatAppearance.BorderSize = 0;             // Pas de bordure
            BtnGestionSystem.Cursor = Cursors.Hand;                     // Curseur "main" au survol
            //ButtonGestion BtnSeDeconnecter
            BtnSeDeconnecter.Width = 150;                               // Largeur
            BtnSeDeconnecter.Height = 45;                               // Hauteur
            BtnSeDeconnecter.Size = new Size(492, 74);
            BtnSeDeconnecter.Font = new Font("Segoe UI", 11, FontStyle.Bold); // Police moderne et lisible
            BtnSeDeconnecter.ForeColor = Color.White;                   // Couleur du texte
            BtnSeDeconnecter.BackColor = Color.FromArgb(51, 102, 204);  // Couleur bleue personnalisée
            BtnSeDeconnecter.FlatStyle = FlatStyle.Flat;                // Style plat moderne
            BtnSeDeconnecter.FlatAppearance.BorderSize = 0;             // Pas de bordure
            BtnSeDeconnecter.Cursor = Cursors.Hand;                     // Curseur "main" au survol
            //button Quitter
            BtnQuitter.Width = 150;                               // Largeur
            BtnQuitter.Height = 45;                               // Hauteur
            BtnQuitter.Size = new Size(492, 74);
            BtnQuitter.Font = new Font("Segoe UI", 11, FontStyle.Bold); // Police moderne et lisible
            BtnQuitter.ForeColor = Color.White;                   // Couleur du texte
            BtnQuitter.BackColor = Color.FromArgb(255, 0, 0); // Rouge pur
            BtnQuitter.FlatStyle = FlatStyle.Flat;                // Style plat moderne
            BtnQuitter.FlatAppearance.BorderSize = 0;             // Pas de bordure
            BtnQuitter.Cursor = Cursors.Hand;                     // Curseur "main" au survol
            //Button apropos
            BtnPropos.Width = 150;                               // Largeur
            BtnPropos.Height = 45;                               // Hauteur
            BtnPropos.Size = new Size(492, 74);
            BtnPropos.Font = new Font("Segoe UI", 11, FontStyle.Bold); // Police moderne et lisible
            BtnPropos.ForeColor = Color.White;                   // Couleur du texte
            BtnPropos.BackColor = Color.FromArgb(51, 102, 204);  // Couleur bleue personnalisée
            BtnPropos.FlatStyle = FlatStyle.Flat;                // Style plat moderne
            BtnPropos.FlatAppearance.BorderSize = 0;             // Pas de bordure
            BtnPropos.Cursor = Cursors.Hand;                     // Curseur "main" au survol


        }
        private void FrmMenu_Admin_Load(object sender, EventArgs e)
        {
            MiseAjour();
        }

        private void BtnGestionUser_Click(object sender, EventArgs e)
        {
            FrmUtilisateur fen = new FrmUtilisateur();
            fen.ShowDialog();

        }

        private void BtnQuitter_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void BtnSeDeconnecter_Click(object sender, EventArgs e)
        {
            FrmConnexion fen = new FrmConnexion();
            this.Hide();
            fen.ShowDialog();
        }

        private void BtnGestionSystem_Click(object sender, EventArgs e)
        {
            FrmMenu fen = new FrmMenu();
            fen.ShowDialog();
        }

        private void BtnPropos_Click(object sender, EventArgs e)
        {
            FrmApropos fAa = new FrmApropos();
            fAa.ShowDialog();
        }
    }
}
