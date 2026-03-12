using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;
using GESTAPP.Views;
using MySql.Data.MySqlClient;
namespace GESTAPP.Outils

{

    class Basique
    {

        public static  ConTraitment cx = new ConTraitment();
        public static string Catego = "";

        

        //Declaration du forme invisible
        public static frmInvisible invi = new frmInvisible();

        public static string categorie = "";
        public static string utilisateur = "";
        public static string action = "";
        public static string matri = "";
        public static DateTime heure()
        { return DateTime.Now; }

      



        //Nettoyage
        public static void net(int x, params TextBox[] zone)
        {
            try
            {
                // nettoyage en boucle
                for (int i = 0; i < x; i++)
                {
                    zone[i].Clear();
                    zone[0].Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        //NB : pour que cette methode marche, la table UTILISATEUR doit avoir les champs NomUti, MotDePasse, Categorie et agent
        public static void AjoutUser(TextBox user, TextBox mot, TextBox cat, ComboBox agent)
        {
            ConTraitment conB = new ConTraitment();
            try
            {
                if (VerifZone(user))
                {
                    MessageBox.Show("Zone de l'utilisateur vide", "Erreur!!!", MessageBoxButtons.OK);
                    user.Focus();
                }

                else
                {
                    if (conB.SiCleExiste("UTILISATEUR", "NomUtil", user) || conB.SiCleExiste("UTILISATEUR", "agent", agent))
                    {
                        MessageBox.Show("cet agent possede deja un compte utilisateur ou bien ce nom de compte existe deja", "Erreur!!!", MessageBoxButtons.OK);
                        user.Focus();
                    }
                    else
                    {
                        conB.requete_E("insert into UTILISATEUR values ('" + user.Text + "', '" + mot.Text + "','" + cat.Text + "','" + agent.Text + "') ");
                        user.Clear();
                        mot.Clear();
                        cat.Clear();
                        agent.Text = "";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Méthode pour rechercher un locataire dans un compte courant
public static void RechercherParLocataire(string idLoc, DataGridView dgv)
{
    string conString = "Server=localhost; database=bddgestapp; user id=root; password='';";
    string query = "SELECT Num_Compte, Motif, Mois_Paye, Date_Paye, Montant_Loyer, Montant_Paye, SoldeLoyer,Type_Paiement, Référence_paiement, Matricule_Agent, ID_Loc " +
                   "FROM compte_courant WHERE ID_Loc = @idLoc";

    using (MySql.Data.MySqlClient.MySqlConnection con = new MySql.Data.MySqlClient.MySqlConnection(conString))
    using (MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(query, con))
    {
        cmd.Parameters.AddWithValue("@ID_Loc", idLoc);

        try
        {
            con.Open();
            MySql.Data.MySqlClient.MySqlDataAdapter da = new MySql.Data.MySqlClient.MySqlDataAdapter(cmd);
            System.Data.DataTable dt = new System.Data.DataTable();
            da.Fill(dt);

            dgv.DataSource = dt;
        }
        catch (Exception ex)
        {
            MessageBox.Show("Erreur : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}

        //Méthode pour calculer le solde du locatire 
        public static double SoldeLocataire(string idloc)
        {
            double solde = 0, totalPaye = 0, totalLoyer = 0;
            //Calcul du total payé
            ConTraitment conB = new ConTraitment();
            conB.chargerDGV("Select SUM(Montant_Paye) as Montant_Paye from compte_courant where ID_Loc = '" + idloc + "'", Basique.invi.DataGV);
            if (Basique.invi.DataGV.Rows[0].Cells["Montant_Paye"].Value != DBNull.Value)
            {
                totalPaye = Convert.ToDouble(Basique.invi.DataGV.Rows[0].Cells["Montant_Paye"].Value);
            }
            else
            {
                totalPaye = 0;
            }
            //Calcul du total loyer
            conB.chargerDGV("Select SUM(Montant_Loyer) as Montant_Loyer from compte_courant where ID_Loc = '" + idloc + "'", Basique.invi.DataGV);
            if (Basique.invi.DataGV.Rows[0].Cells["Montant_Loyer"].Value != DBNull.Value)
            {
                totalLoyer = Convert.ToDouble(Basique.invi.DataGV.Rows[0].Cells["Montant_Loyer"].Value);
            }
            else
            {
                totalLoyer = 0;
            }
            //Calcul du solde
            solde = totalPaye - totalLoyer;
            return solde;
        }



     

        public static bool VerifZone(TextBox txt)
        {
            bool verif;

            //verifie la zone si vide
            if (txt.TextLength == 0)
            {
                verif = true;
                txt.Focus();
            }
            else
            {
                verif = false;

            }

            return verif;
        }


        public static bool VerifZone(TextBox txt, string x)
        {
            bool verif;

            //verifie la zone s'il y a un caractere special
            if (txt.Text.IndexOf("&") != -1 || txt.Text.IndexOf("%") != -1 || txt.Text.IndexOf(",") != -1 || txt.Text.IndexOf(".") != -1 || txt.Text.IndexOf("|") != -1 || txt.Text.IndexOf("/") != -1 || txt.Text.IndexOf("\\") != -1 || txt.Text.IndexOf(">") != -1 || txt.Text.IndexOf("<") != -1 || txt.Text.IndexOf("=") != -1 || txt.Text.IndexOf("!") != -1 || txt.Text.IndexOf("*") != -1 || txt.Text.IndexOf("$") != -1 || txt.Text.IndexOf("{") != -1 || txt.Text.IndexOf("[") != -1 || txt.Text.IndexOf(";") != -1 || txt.Text.IndexOf("?") != -1 || txt.Text.IndexOf("(") != -1 || txt.Text.IndexOf("\"") != -1 || txt.Text.IndexOf("'") != -1)
            {
                verif = false;
                MessageBox.Show("Caractères spéciaux interdits dans cette zone de texte : & | / \\ * + - . ? etc...", "Caractère interdit!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt.Focus();
            }
            else
            {
                verif = true;
            }

            return verif;
        }


        public static bool VerifZone(TextBox txt, int x)
        {
            bool verif = false;

            double x1 = -1.6341;
            //verifie la zone numerique
            try
            {
                x1 = Convert.ToInt32(txt.Text);

            }
            catch (Exception)
            {
                MessageBox.Show("La valeur saisie n'est pas numerique", "Erreur type", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt.Clear();
                txt.Focus();
            }

            if (x1 != (-1.6341))
            {
                verif = true;
            }


            return verif;
        }


        // Methode imbriquée verif zone vide et excluant les caracteres speciaux = methode imbriquée 
        public static bool VerifZoneCar(TextBox txtR)
        {
            bool verif = false;
            if (Basique.VerifZone(txtR, "") || Basique.VerifZone(txtR))
            {
                verif = true;
            }
            else
            {
                verif = false;
            }


            return verif;
        }

        //verif zone numerique = methode imbrique
        public static bool VerifZoneNum(TextBox txtR)
        {
            bool verif = false;
            if (Basique.VerifZone(txtR, 1))
            {
                verif = true;
            }
            else
            {
                verif = false;
            }


            return verif;
        }


        // fonction convertisseur monnaie
        public static double Cmonnaie(TextBox txt)
        {

            double val = 0;
            //verifie la zone s'il y a un caractere special
            if (double.TryParse(txt.Text, out val))
            {

            }
            else
            {
                MessageBox.Show("La valeur saisie n'est pas monnetaire", "Erreur type données", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            return val;
        }




        //Procedure verification si zone monetaire et efacement automatique des interdits
        public static void Monnaie(TextBox txt)
        {

            double val;
            //verifie la zone s'il y a un caractere special
            if (double.TryParse(txt.Text, out val))
            {

            }
            else
            {
                string t = txt.Text;
                if (t.Length == 0) { txt.Text = ""; }

                else if (t.Length > 0)
                {
                    t = t.Substring(0, t.Length - 1);
                    txt.Text = t;
                    txt.SelectionStart = txt.Text.Length;
                    txt.SelectionLength = 0;
                    MessageBox.Show("La valeur saisie n'est pas numerique", "Erreur type données", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt.Clear();
                }
            }
        }

        //Procedure verification si zone entier et efacement automatique des interdits
        public static void Entier(TextBox txt)
        {

            int val;
            //verifie la zone s'il y a un caractere special
            if (int.TryParse(txt.Text, out val))
            {

            }
            else
            {
                string t = txt.Text;
                if (t.Length > 0)
                {
                    t = t.Substring(0, t.Length - 1);
                    txt.Text = t;
                    txt.SelectionStart = txt.Text.Length;
                    txt.SelectionLength = 0;
                    MessageBox.Show("La valeur saisie n'est pas numerique", "Erreur type données", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        //Message de champs vide
        public static void ChampVide()
        {
            MessageBox.Show("Veuillez Remplir tous les champs importants SVP!!! ", "Erreur!!! champs vides", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }


        //Message de champs vide
        public static void AccesRefuse()
        {
            MessageBox.Show("Vous n'etes pas autorisé à acceder à cette information", "Accès refusé!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        //Blocage frais
        public static string nomBDD = "BDKF1";




        //generateur des ID unique
        public static int tailleID = 10;
        public static string Cp(int length)
        {
            if (length <= 0 || length > 32)
            {
                throw new ArgumentOutOfRangeException("Taille", "La longueur doit être comprise entre 1 et 32.");
            }

            Guid guid = Guid.NewGuid();
            string guidString = guid.ToString("N");
            string uniqueId = guidString.Substring(0, length);

            return uniqueId;
        }

        //generateur des ID unique
        public static void clefacile(TextBox x)
        {
            Random r = new Random();
            int nbre = r.Next(65, 91);
            int nbre1 = r.Next(65, 91);
            char l1 = Convert.ToChar(nbre);
            char l2 = Convert.ToChar(nbre1);

            int digit1 = r.Next(15);
            int digit2 = r.Next(10);
            int digit3 = r.Next(10);


            x.Text = Convert.ToString(l1) + Convert.ToString(l2) + digit1.ToString() + digit2.ToString() + digit3.ToString();
        }

        //generateur des ID unique
        public static string clefacile_chaine()
        {
            Random r = new Random();
            int nbre = r.Next(65, 91);
            int nbre1 = r.Next(65, 91);
            char l1 = Convert.ToChar(nbre);
            char l2 = Convert.ToChar(nbre1);

            int digit1 = r.Next(15);
            int digit2 = r.Next(10);
            int digit3 = r.Next(10);


            return Convert.ToString(l1) + Convert.ToString(l2) + digit1.ToString() + digit2.ToString() + digit3.ToString();
        }

        //generateur des ID unique avec verification dans la base de données, pour la facture
        public static void clefacile(string Nomtable, string champ, TextBox x)
        {

            Random r = new Random();
            int nbre = r.Next(65, 91);
            int nbre1 = r.Next(65, 91);
            char l1 = Convert.ToChar(nbre);
            char l2 = Convert.ToChar(nbre1);

            int digit1 = r.Next(15);
            int digit2 = r.Next(10);
            int digit3 = r.Next(10);


            x.Text = Convert.ToString(l1) + Convert.ToString(l2) + digit1.ToString() + digit2.ToString() + digit3.ToString();

            if (cx.SiCleExiste(Nomtable, champ, x) == true)
            {
                clefacile(x);
            };

        }

        //Variables d'aide à Etat d'impression
        public static string paramPrint, tcode, tmatri, ttel, tcli, tdate, tnet;


        //Variable de reserve
        public static string v1, vcli = "";

        //Nom BDD
        public static string nomBase = "BDKF1";

        public static bool VerifDt()
        {
            DateTime j = DateTime.Today;
            string Jour = j.ToString();
            String FDATE = j.ToString("dd/MM/yyyy");

            bool veri = false;

            switch (FDATE)
            {
                case "31/01/2025":
                    veri = true;
                    break;
                case "28/02/2025":
                    veri = true;
                    break;
                case "31/03/2025":
                    veri = true;
                    break;
                case "30/04/2025":
                    veri = true;
                    break;
                case "31/05/2025":
                    veri = true;
                    break;
                case "30/06/2025":
                    veri = true;
                    break;
                case "31/07/2025":
                    veri = true;
                    break;
                case "31/08/2025":
                    veri = true;
                    break;
                case "30/09/2025":
                    veri = true;
                    break;
                case "31/10/2025":
                    veri = true;
                    break;
                case "30/11/2025":
                    veri = true;
                    break;
                case "31/12/2025":
                    veri = true;
                    break;

            }

            return veri;
        }



        //fonction de conversion de date franco à anglo

        // Fonction pour convertir la date du format DD/MM/YY au format YY/MM/DD
        public static string ConvertToAngloFormat(string dateFrancophone)
        {

            // Diviser la date en jour, mois et année (au format DD/MM/YY)
            string[] dateParts = dateFrancophone.Split('/');

            // Récupérer le jour, le mois et l'année
            string day = dateParts[0];
            string month = dateParts[1];
            string year = dateParts[2];

            // Retourner la date au format Anglo-Saxon (YY/MM/DD)
            return year + "/" + month + "/" + day;
        }


        public static void AppliquerCouleurs(Label label, string couleur1RVB, string couleur2RVB)
        {

            // Séparer la chaîne en valeurs R, G, B BackColor
            string[] valeurs = couleur1RVB.Split(';');

            // Convertir chaque valeur en entier
            int r = int.Parse(valeurs[0]);
            int g = int.Parse(valeurs[1]);
            int b = int.Parse(valeurs[2]);

            // Séparer la chaîne en valeurs R, G, B Forecolore
            string[] valeurs1 = couleur2RVB.Split(';');

            // Convertir chaque valeur en entier
            int r1 = int.Parse(valeurs1[0]);
            int g1 = int.Parse(valeurs1[1]);
            int b1 = int.Parse(valeurs1[2]);

            // Appliquer les couleurs au label
            label.BackColor = System.Drawing.Color.FromArgb(r, g, b);
            label.ForeColor = System.Drawing.Color.FromArgb(r1, g1, b1);
        }


        public static void CouleursBouton(Button btn, string couleur1RVB, string couleur2RVB)
        {

            // Séparer la chaîne en valeurs R, G, B BackColor
            string[] valeurs = couleur1RVB.Split(';');

            // Convertir chaque valeur en entier
            int r = int.Parse(valeurs[0]);
            int g = int.Parse(valeurs[1]);
            int b = int.Parse(valeurs[2]);

            // Séparer la chaîne en valeurs R, G, B Forecolore
            string[] valeurs1 = couleur2RVB.Split(';');

            // Convertir chaque valeur en entier
            int r1 = int.Parse(valeurs1[0]);
            int g1 = int.Parse(valeurs1[1]);
            int b1 = int.Parse(valeurs1[2]);

            // Appliquer les couleurs au label
            btn.BackColor = System.Drawing.Color.FromArgb(r, g, b);
            btn.ForeColor = System.Drawing.Color.FromArgb(r1, g1, b1);
        }

        public static void CouleursBoutons(string couleur1RVB, string couleur2RVB, params Button[] boutons)
        {
            // Séparer la chaîne en valeurs R, G, B pour le BackColor
            string[] valeurs = couleur1RVB.Split(';');

            // Convertir chaque valeur en entier pour le BackColor
            int r = int.Parse(valeurs[0]);
            int g = int.Parse(valeurs[1]);
            int b = int.Parse(valeurs[2]);

            // Séparer la chaîne en valeurs R, G, B pour le ForeColor
            string[] valeurs1 = couleur2RVB.Split(';');

            // Convertir chaque valeur en entier pour le ForeColor
            int r1 = int.Parse(valeurs1[0]);
            int g1 = int.Parse(valeurs1[1]);
            int b1 = int.Parse(valeurs1[2]);

            // Appliquer les couleurs à chaque bouton passé en paramètre
            foreach (var btn in boutons)
            {
                btn.BackColor = System.Drawing.Color.FromArgb(r, g, b);
                btn.ForeColor = System.Drawing.Color.FromArgb(r1, g1, b1);
            }
        }



        public static void CouleursLab(Label lab, string couleur1RVB, string couleur2RVB)
        {

            // Séparer la chaîne en valeurs R, G, B BackColor
            string[] valeurs = couleur1RVB.Split(';');

            // Convertir chaque valeur en entier
            int r = int.Parse(valeurs[0]);
            int g = int.Parse(valeurs[1]);
            int b = int.Parse(valeurs[2]);

            // Séparer la chaîne en valeurs R, G, B Forecolore
            string[] valeurs1 = couleur2RVB.Split(';');

            // Convertir chaque valeur en entier
            int r1 = int.Parse(valeurs1[0]);
            int g1 = int.Parse(valeurs1[1]);
            int b1 = int.Parse(valeurs1[2]);

            // Appliquer les couleurs au label
            lab.BackColor = System.Drawing.Color.FromArgb(r, g, b);
            lab.ForeColor = System.Drawing.Color.FromArgb(r1, g1, b1);
        }

        public static void CouleursLabels(string couleur1RVB, string couleur2RVB, params Label[] lab)
        {
            // Séparer la chaîne en valeurs R, G, B pour le BackColor
            string[] valeurs = couleur1RVB.Split(';');

            // Convertir chaque valeur en entier pour le BackColor
            int r = int.Parse(valeurs[0]);
            int g = int.Parse(valeurs[1]);
            int b = int.Parse(valeurs[2]);

            // Séparer la chaîne en valeurs R, G, B pour le ForeColor
            string[] valeurs1 = couleur2RVB.Split(';');

            // Convertir chaque valeur en entier pour le ForeColor
            int r1 = int.Parse(valeurs1[0]);
            int g1 = int.Parse(valeurs1[1]);
            int b1 = int.Parse(valeurs1[2]);

            // Appliquer les couleurs à chaque bouton passé en paramètre
            foreach (var lbl in lab)
            {
                lbl.BackColor = System.Drawing.Color.FromArgb(r, g, b);
                lbl.ForeColor = System.Drawing.Color.FromArgb(r1, g1, b1);
            }
        }

        public static void CouleursPan(Panel panel, string couleur1RVB, string couleur2RVB)
        {

            // Séparer la chaîne en valeurs R, G, B BackColor
            string[] valeurs = couleur1RVB.Split(';');

            // Convertir chaque valeur en entier
            int r = int.Parse(valeurs[0]);
            int g = int.Parse(valeurs[1]);
            int b = int.Parse(valeurs[2]);

            // Séparer la chaîne en valeurs R, G, B Forecolore
            string[] valeurs1 = couleur2RVB.Split(';');

            // Convertir chaque valeur en entier
            int r1 = int.Parse(valeurs1[0]);
            int g1 = int.Parse(valeurs1[1]);
            int b1 = int.Parse(valeurs1[2]);

            // Appliquer les couleurs au label
            panel.BackColor = System.Drawing.Color.FromArgb(r, g, b);
            panel.ForeColor = System.Drawing.Color.FromArgb(r1, g1, b1);
        }


        public static void CouleursGroupBox(GroupBox panel, string couleur1RVB, string couleur2RVB)
        {

            // Séparer la chaîne en valeurs R, G, B BackColor
            string[] valeurs = couleur1RVB.Split(';');

            // Convertir chaque valeur en entier
            int r = int.Parse(valeurs[0]);
            int g = int.Parse(valeurs[1]);
            int b = int.Parse(valeurs[2]);

            // Séparer la chaîne en valeurs R, G, B Forecolore
            string[] valeurs1 = couleur2RVB.Split(';');

            // Convertir chaque valeur en entier
            int r1 = int.Parse(valeurs1[0]);
            int g1 = int.Parse(valeurs1[1]);
            int b1 = int.Parse(valeurs1[2]);

            // Appliquer les couleurs au label
            panel.BackColor = System.Drawing.Color.FromArgb(r, g, b);
            panel.ForeColor = System.Drawing.Color.FromArgb(r1, g1, b1);
        }


        public static void CouleursRichtxt(RichTextBox panel, string couleur1RVB, string couleur2RVB)
        {

            // Séparer la chaîne en valeurs R, G, B BackColor
            string[] valeurs = couleur1RVB.Split(';');

            // Convertir chaque valeur en entier
            int r = int.Parse(valeurs[0]);
            int g = int.Parse(valeurs[1]);
            int b = int.Parse(valeurs[2]);

            // Séparer la chaîne en valeurs R, G, B Forecolore
            string[] valeurs1 = couleur2RVB.Split(';');

            // Convertir chaque valeur en entier
            int r1 = int.Parse(valeurs1[0]);
            int g1 = int.Parse(valeurs1[1]);
            int b1 = int.Parse(valeurs1[2]);

            // Appliquer les couleurs au label
            panel.BackColor = System.Drawing.Color.FromArgb(r, g, b);
            panel.ForeColor = System.Drawing.Color.FromArgb(r1, g1, b1);
        }


        public static void CouleursDGV(DataGridView DGV, string couleur1RVB, string couleur2RVB)
        {

            // Séparer la chaîne en valeurs R, G, B BackColor
            string[] valeurs = couleur1RVB.Split(';');

            // Convertir chaque valeur en entier
            int r = int.Parse(valeurs[0]);
            int g = int.Parse(valeurs[1]);
            int b = int.Parse(valeurs[2]);

            // Séparer la chaîne en valeurs R, G, B Forecolore
            string[] valeurs1 = couleur2RVB.Split(';');

            // Convertir chaque valeur en entier
            int r1 = int.Parse(valeurs1[0]);
            int g1 = int.Parse(valeurs1[1]);
            int b1 = int.Parse(valeurs1[2]);


            foreach (DataGridViewRow row in DGV.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    cell.Style.BackColor = System.Drawing.Color.FromArgb(r, g, b); // Arrière-plan blanc pour chaque cellule  
                    cell.Style.ForeColor = System.Drawing.Color.FromArgb(r1, g1, b1); // Couleur de texte noir pour chaque cellule  
                }
            }


            // Appliquer les couleurs au label
            DGV.BackgroundColor = System.Drawing.Color.FromArgb(r, g, b);
            DGV.BackColor = System.Drawing.Color.FromArgb(r, g, b);
            DGV.ForeColor = System.Drawing.Color.FromArgb(r1, g1, b1);

            DGV.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(r1, g1, b1); // Vous pouvez également choisir n'importe quelle autre couleur  
            DGV.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(r, g, b); // Couleur de texte noir pour l'en-tête  

        }


        public static void CouleursForm(Form frm, string couleur1RVB, string couleur2RVB)
        {

            // Séparer la chaîne en valeurs R, G, B BackColor
            string[] valeurs = couleur1RVB.Split(';');

            // Convertir chaque valeur en entier
            int r = int.Parse(valeurs[0]);
            int g = int.Parse(valeurs[1]);
            int b = int.Parse(valeurs[2]);

            // Séparer la chaîne en valeurs R, G, B Forecolore
            string[] valeurs1 = couleur2RVB.Split(';');

            // Convertir chaque valeur en entier
            int r1 = int.Parse(valeurs1[0]);
            int g1 = int.Parse(valeurs1[1]);
            int b1 = int.Parse(valeurs1[2]);

            // Appliquer les couleurs au label
            frm.BackColor = System.Drawing.Color.FromArgb(r, g, b);
            frm.ForeColor = System.Drawing.Color.FromArgb(r1, g1, b1);
        }
       
        public string AuthentifierEtObtenirCategorie(string nomUtilisateur, string motDePasse)
        {

            string categorie = null;
            using (var connexion = new MySqlConnection("Server=localhost; database= bddgestapp; user id=root; password='';"))
            {

                connexion.Open();
                string requete = "SELECT categorie FROM utilisateur WHERE NomUtilisateur = @nom AND Mot_de_Passe = @mdp";
                using (var cmd = new MySqlCommand(requete, connexion))
                {
                    cmd.Parameters.AddWithValue("@nom", nomUtilisateur);
                    cmd.Parameters.AddWithValue("@mdp", motDePasse);
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            categorie = reader["categorie"].ToString();
                        }
                    }
                }
                return categorie; // null si non trouvé

            }
        }
        //Méthode pour supprimer utilisateur avec validation
        public static bool SupprimerUtilisateur(string nomUtilisateur)
        {
            ConTraitment conB = new ConTraitment();
            // Vérification du champ vide
            if (string.IsNullOrWhiteSpace(nomUtilisateur))
            {
                MessageBox.Show("Veuillez entrer le nom d'utilisateur à supprimer.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            // Suppression dans la base de données
            using (var con = new MySqlConnection("Server=localhost; database=bddgestapp; user id=root; password=''; Allow Zero Datetime=True; Convert Zero Datetime=True;"))
            {
                con.Open();
                var cmd = new MySqlCommand("DELETE FROM utilisateur WHERE NomUtilisateur = @nom", con);
                cmd.Parameters.AddWithValue("@nom", nomUtilisateur);
                int rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected == 0)
                {
                    MessageBox.Show("Aucun utilisateur trouvé avec ce nom d'utilisateur.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            return true;
        }
        //Méthode pour modifer utilisateur avec validation
        public static bool ModifierUtilisateur(string nomUtilisateur, string motDePasse, string agent, string categorie)
        {
            ConTraitment conB = new ConTraitment();
            // Vérification des champs vides
            if (string.IsNullOrWhiteSpace(nomUtilisateur) || string.IsNullOrWhiteSpace(motDePasse) || string.IsNullOrWhiteSpace(agent) ||
                string.IsNullOrWhiteSpace(categorie))
            {
                MessageBox.Show("Veuillez remplir tous les champs.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            

            // Insertion dans la base de données
            using (var con = new MySqlConnection("Server=localhost; database=bddgestapp; user id=root; password=''; Allow Zero Datetime=True; Convert Zero Datetime=True;"))
            {
                con.Open();
                var cmd = new MySqlCommand("UPDATE utilisateur SET Mot_de_Passe = @mdp, Matricule_Ag = @mat, categorie = @cat WHERE NomUtilisateur = @nom", con);
                cmd.Parameters.AddWithValue("@nom", nomUtilisateur);
                cmd.Parameters.AddWithValue("@mdp", motDePasse);
                cmd.Parameters.AddWithValue("@mat", agent);
                cmd.Parameters.AddWithValue("@cat", categorie);
                int rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected == 0)
                {
                    MessageBox.Show("Aucun utilisateur trouvé avec ce nom d'utilisateur.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            return true;
        }
        // Méthode pour ajouter un utilisateur avec validation
        public static bool AjouterUtilisateur(string nomUtilisateur, string motDePasse, string agent, string categorie)
            {
                ConTraitment conB = new ConTraitment();

                // Vérification des champs vides
                if (string.IsNullOrWhiteSpace(nomUtilisateur) || string.IsNullOrWhiteSpace(motDePasse)|| string.IsNullOrWhiteSpace(agent) ||
                    string.IsNullOrWhiteSpace(categorie))
            {
                    MessageBox.Show("Veuillez remplir tous les champs.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                // Vérification si le nom d'utilisateur ou l'agent existe déjà
                TextBox tbUser = new TextBox { Text = nomUtilisateur };
                ComboBox cbAgent = new ComboBox { Text = agent };
                if (conB.SiCleExiste("utilisateur", "NomUtilisateur", tbUser) || conB.SiCleExiste("utilisateur", "Matricule_Ag", cbAgent))
                {
                    MessageBox.Show("Cet agent possède déjà un compte utilisateur ou ce nom de compte existe déjà.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                // Insertion dans la base de données
                using (var con = new MySqlConnection("Server=localhost; database=bddgestapp; user id=root; password=''; Allow Zero Datetime=True; Convert Zero Datetime=True;"))
{
    con.Open();
    var cmd = new MySqlCommand("INSERT INTO utilisateur (NomUtilisateur, Mot_de_Passe, Matricule_Ag, categorie) VALUES (@nom, @mdp, @mat, @cat)", con);
    cmd.Parameters.AddWithValue("@nom", nomUtilisateur);
    cmd.Parameters.AddWithValue("@mdp", motDePasse);
    cmd.Parameters.AddWithValue("@mat", agent);
    cmd.Parameters.AddWithValue("@cat", categorie);
    cmd.ExecuteNonQuery();
}

                return true;
            }


    }
}
