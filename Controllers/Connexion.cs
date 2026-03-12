using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GESTAPP.Outils  //remplacer le xxxxx avec le nom de votre projet
{
    public class ConMysql
    {

        // Déclaration de la connexion MySQL
        public MySqlConnection con = new MySqlConnection();


        public string ConnectionString = "Server=localhost; database= bddgestapp; user id=root; password='';";


        // Méthode pour établir la connexion
        public void connex()
        {
            try
            {
                // Chaîne de connexion à la base de données MySQL
                con.ConnectionString = "Server=localhost; database= bddgestapp; user id=root; password='';";
                con.Open();  // Ouvrir la connexion
            }
            catch (Exception ex)
            {
                // Afficher une erreur si la connexion échoue
                MessageBox.Show(ex.Message);
            }
        }

        // Méthode pour fermer la connexion
        public void deconnex()
        {
            con.Close();
        }

        // Déclaration de la méthode Enregistrer (avec MySQL)
        public MySqlCommand cmd = new MySqlCommand();

        // Méthode pour exécuter la requête d'enregistrement
        public void requete_E(string str)
        {
            try
            {
                // Établir la connexion à la base de données
                this.connex();

                // Configurer la commande MySQL
                cmd.CommandText = str;
                cmd.Connection = this.con;

                // Exécuter la requête
                cmd.ExecuteNonQuery();

                // Fermer la connexion après exécution de la requête
                this.deconnex();

                // Afficher un message de succès
                MessageBox.Show("Enregistrement effectué avec succès", "Réussite!!!", MessageBoxButtons.OK);
            }
            catch (Exception)
            {
                // Afficher un message d'erreur si la requête échoue
                MessageBox.Show("La tentative d'enregistrement a échoué", "Erreur!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void requete_Ebis(string str)
        {
            try
            {

                this.connex();
                cmd.CommandText = str;
                cmd.Connection = this.con;
                cmd.ExecuteNonQuery();
                this.deconnex();

            }
            catch (Exception)
            {
                MessageBox.Show("la tentative d'enregistrement a echouée", "Erreur", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
                this.deconnex();
            }
        }



        // Declaration de la methode Modification
        public void requete_M(string str)
        {
            try
            {
                this.connex();
                cmd.CommandText = str;
                cmd.Connection = this.con;
                cmd.ExecuteNonQuery();
                this.deconnex();
                MessageBox.Show("Modification effectuée avec succès", "Réussite!!!", MessageBoxButtons.OK);
            }
            catch (Exception)
            {
                MessageBox.Show("la tentative d'modification a echouée", "erreur!!!", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            }
        }
        // Declaration du bouton Suppression
        public void requete_S(string str)
        {
            this.deconnex();
            try
            {
                DialogResult zResult = MessageBox.Show("voulez-vous vraiment supprimer cet enregistrement de la base de données?", "suppression des données", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                if (zResult == DialogResult.Yes)
                {
                    this.connex();
                    cmd.CommandText = str;
                    cmd.Connection = this.con;
                    cmd.ExecuteNonQuery();
                    this.deconnex();
                    MessageBox.Show("Suppression effectuée avec succès", "Réussite!!!",
                    MessageBoxButtons.OK);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("la tentative d'Suppression a echouée", "erreur!!!", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            }
        }

        // Declaration du bouton Suppression
        public void suppression(string str)
        {

            try
            {
                DialogResult zResult = MessageBox.Show("voulez-vous vraiment supprimer cet enregistrement de la base de données?", "suppression des données", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                if (zResult == DialogResult.Yes)
                {

                    using (MySqlConnection connection = new MySqlConnection(ConnectionString))
                    {
                        this.connex();
                        cmd.CommandText = str;
                        cmd.Connection = this.con;
                        cmd.ExecuteNonQuery();
                        this.deconnex();
                        MessageBox.Show("Suppression effectuée avec succès", "Réussite!!!",
                        MessageBoxButtons.OK);
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("la tentative d'Suppression a echouée", "erreur!!!", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            }
        }

        //Declaration du bouton recherche
        public MySqlDataReader? dr;
        public void requete_R(string str)
        {
            try
            {
                this.connex();
                cmd.CommandText = str;
                cmd.Connection = this.con;
                dr = cmd.ExecuteReader();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }







        // Declaration de la methode Modification discrette
        public void mod(string str)
        {
            try
            {
                this.connex();
                cmd.CommandText = str;
                cmd.Connection = this.con;
                cmd.ExecuteNonQuery();
                this.deconnex();

            }
            catch (Exception)
            {

            }
        }


        // Declaration de validation facture
        public void ValideFac(string str)
        {
            try
            {
                this.connex();
                cmd.CommandText = str;
                cmd.Connection = this.con;
                cmd.ExecuteNonQuery();
                this.deconnex();
                //MessageBox.Show("Facture enregistrée avec succès", "Réussite!!!", MessageBoxButtons.OK);
            }
            catch (Exception)
            {
                MessageBox.Show("la tentative a echouée", "erreur!!!", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            }
        }





        // Suppression directe sans demander oui ou non
        public void suppri(string str)
        {
            try
            {

                this.connex();
                cmd.CommandText = str;
                cmd.Connection = this.con;
                cmd.ExecuteNonQuery();
                this.deconnex();
                MessageBox.Show("Suppression effectuée avec succès", "Réussite!!!",
                MessageBoxButtons.OK);

            }
            catch (Exception)
            {
                MessageBox.Show("la tentative d'Suppression a echouée", "erreur!!!", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            }
        }



        //Chargement du datagrid view
        public DataSet DS = new DataSet();
        public void chargerDGV(String str, DataGridView dv)
        {
            try
            {
                DS.Clear();
                //dv.Rows.Clear();
                this.connex();
                MySqlDataAdapter oda = new MySqlDataAdapter(str, this.con);
                oda.Fill(DS, str);
                this.deconnex();
                dv.DataSource = DS.Tables[str];
                dv.Refresh();
                dv.ReadOnly = true;

                //configuration esthetique
                DataGridViewCellStyle entete = new DataGridViewCellStyle();

                entete.Font = new System.Drawing.Font("Arial", 14, System.Drawing.FontStyle.Bold);
                dv.ColumnHeadersDefaultCellStyle = entete;
                dv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dv.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        //Chargement du datagrid view avec peti titre
        public DataSet DSS = new DataSet();
        public void chargerDGVbis(String str, DataGridView dv)
        {
            try
            {
                DSS.Clear();
                //dv.Rows.Clear();
                this.connex();
                MySqlDataAdapter oda = new MySqlDataAdapter(str, this.con);
                oda.Fill(DSS, str);
                this.deconnex();
                dv.DataSource = DSS.Tables[str];
                dv.Refresh();
                dv.ReadOnly = true;

                //configuration esthetique
                DataGridViewCellStyle entete = new DataGridViewCellStyle();

                entete.Font = new System.Drawing.Font("Arial", 10, System.Drawing.FontStyle.Bold);
                dv.ColumnHeadersDefaultCellStyle = entete;

                dv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dv.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

                // corps
                dv.DefaultCellStyle.Font = new System.Drawing.Font("Arial", 9);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Recherche et chargement d'un enregistrement de la table, contenue dans une BDD, à un tableau string
        public string[] tabText = new string[200];
        public DataSet DS1 = new DataSet();
        public DataSet DS2 = new DataSet();
        //Le parametre de type datagridView doit etre un objet qui ne sera pas visible à l'utilisateur
        public void Charge_Ligne_A_TabText(string Requete, DataGridView DGV, params TextBox[] zone)
        {
            try
            {
                DS2.Clear();
                this.connex();
                MySqlDataAdapter oda = new MySqlDataAdapter(Requete, this.con);
                oda.Fill(DS2, Requete);
                this.deconnex();
                DGV.DataSource = DS2.Tables[Requete];
                DataGridViewRow ligne = DGV.Rows[0];
                DGV.Visible = false;

                // string[] tabDGV = new string[ligne.Cells.Count];
                for (int i = 0; i < ligne.Cells.Count; i++)
                {
                    tabText[i] = ligne.Cells[i].Value.ToString();
                    zone[i].Text = ligne.Cells[i].Value.ToString();
                }
                DS2.Clear();
            }
            catch (Exception)
            {

            }
            this.deconnex();
        }



        //Surcharge de la methode précédante
        public void Charge_Ligne_A_TabText(string Nomtable, string champ1, string champ2, TextBox zoneCle, DataGridView DGV, params TextBox[] zone)
        {
            try
            {
                DS2.Clear();
                string Requete = "Select " + champ1 + " from " + Nomtable + " where " + champ2 + " ='" + zoneCle.Text + "' ";
                this.connex();
                MySqlDataAdapter oda = new MySqlDataAdapter(Requete, this.con);
                oda.Fill(DS2, Requete);
                this.deconnex();
                DGV.DataSource = DS2.Tables[Requete];
                DataGridViewRow ligne = DGV.Rows[0];
                DGV.Visible = false;



                // string[] tabDGV = new string[ligne.Cells.Count];
                for (int i = 0; i < ligne.Cells.Count; i++)
                {

                    zone[i].Text = ligne.Cells[i].Value.ToString();
                }
                DGV.ClearSelection();
                DS2.Clear();
            }
            catch (Exception)
            {

            }
            this.deconnex();
        }


        //Surcharge de la methode précédante
        public void ExtraireChamp(string Nomtable, string champRech, string champCle, string zoneCle, DataGridView DGV, TextBox zone)
        {
            try
            {
                DS2.Clear();
                string Requete = "Select " + champRech + " from " + Nomtable + " where " + champCle + " ='" + zoneCle + "' ";
                this.connex();
                MySqlDataAdapter oda = new MySqlDataAdapter(Requete, this.con);
                oda.Fill(DS2, Requete);
                this.deconnex();
                DGV.DataSource = DS2.Tables[Requete];
                DataGridViewRow ligne = DGV.Rows[0];
                DGV.Visible = false;

                zone.Text = ligne.Cells[0].Value.ToString();

                DS2.Clear();
            }
            catch (Exception)
            {

            }
            this.deconnex();
        }


        //Surcharge de la methode précédante avec un label
        public void ExtraireChamp(string Requete, DataGridView DGV, Label zone)
        {
            try
            {
                DS2.Clear();

                this.connex();
                MySqlDataAdapter oda = new MySqlDataAdapter(Requete, this.con);
                oda.Fill(DS2, Requete);
                this.deconnex();
                DGV.DataSource = DS2.Tables[Requete];
                DataGridViewRow ligne = DGV.Rows[0];
                DGV.Visible = false;

                zone.Text = ligne.Cells[0].Value.ToString();

                DS2.Clear();
            }
            catch (Exception)
            {

            }
            this.deconnex();
        }

        //Surcharge de la methode précédante avec une chaine
        public string ExtraireChampTexte(string Requete, DataGridView DGV)
        {
            try
            {
                DS2.Clear();

                this.connex();
                MySqlDataAdapter oda = new MySqlDataAdapter(Requete, this.con);
                oda.Fill(DS2, Requete);
                this.deconnex();
                DGV.DataSource = DS2.Tables[Requete];
                DataGridViewRow ligne = DGV.Rows[0];
                DGV.Visible = false;

                return ligne.Cells[0].Value.ToString();

            }
            catch (Exception)
            {
                this.deconnex();
                return "erreur";
            }

        }


        //Verifier si une clé d'un textBox ou un index existe ou pas dans une table
        public bool SiCleExiste(string Nomtable, string champ, TextBox zoneCle)
        {
            bool R = false;
            try
            {
                string str = "Select " + champ + " from " + Nomtable + " where " + champ + " ='" + zoneCle.Text + "' ";
                this.connex();
                cmd.CommandText = str;
                cmd.Connection = this.con;
                dr = cmd.ExecuteReader();
                if (dr.Read())
                { R = true; }
                else { R = false; }
                dr.Close();
                this.deconnex();
            }
            catch (Exception)
            {

            }
            this.deconnex();
            return R;

        }


        //Verifier si une clé d'un ComboBox ou un index existe ou pas dans une table (Methode surcharchée)
        public bool SiCleExiste(string Nomtable, string champ, ComboBox zoneCle)
        {
            bool R = false;
            try
            {
                string str = "Select " + champ + " from " + Nomtable + " where " + champ + " ='" + zoneCle.Text + "' ";
                this.connex();
                cmd.CommandText = str;
                cmd.Connection = this.con;
                dr = cmd.ExecuteReader();
                if (dr.Read())
                { R = true; }
                else { R = false; }
                dr.Close();
                this.deconnex();
            }
            catch (Exception)
            {

            }
            this.deconnex();
            return R;
        }



        //Charge comboBox avec les Clé etrangere
        public void ChargeCleEtrangere(string Nomtable, string champ, DataGridView DGV, ComboBox zoneCle)
        {

            try
            {
                DS1.Clear();
                zoneCle.Items.Clear();
                zoneCle.Text = "";
                string Requete = "Select " + champ + " from " + Nomtable;
                this.connex();
                MySqlDataAdapter oda = new MySqlDataAdapter(Requete, this.con);
                oda.Fill(DS2, Requete);
                this.deconnex();
                DGV.DataSource = DS2.Tables[Requete];
                int compt = DGV.RowCount;
                DataGridViewRow ligne;
                DGV.Visible = false;

                for (int j = 0; j <= compt; j++)
                {
                    ligne = DGV.Rows[j];
                    zoneCle.Items.Add(ligne.Cells[0].Value.ToString());
                }
                DS1.Clear();
            }
            catch (Exception)
            {

            }
            this.deconnex();

        }

        //ChargeListBoxReq
        public void ChargeListBoxReq(string Requete, DataGridView DGV, ListBox list)
        {
            try
            {
                list.Items.Clear();
                DS2.Clear();
                this.connex();
                MySqlDataAdapter oda = new MySqlDataAdapter(Requete, this.con);
                oda.Fill(DS2, Requete);
                this.deconnex();
                DGV.DataSource = DS2.Tables[Requete];
                int compt = DGV.RowCount;
                DataGridViewRow ligne;
                DGV.Visible = false;
                string ll = "";
                for (int j = 0; j <= compt; j++)
                {
                    ligne = DGV.Rows[j];
                    for (int i = 0; i < ligne.Cells.Count; i++)
                    {
                        tabText[i] = ligne.Cells[i].Value.ToString();
                        ll = ll + "  " + tabText[i];
                    }
                    list.Items.Add(ll.ToString());
                    ll = "";
                }
                DS2.Clear();
            }
            catch (Exception)
            {

            }
            this.deconnex();
        }





        //Foction auto completion à partir d'un DGV
        public void GererAutocompletion(DataGridView dgv, TextBox tb, ListBox lb)
        {
            if (dgv == null || tb == null || lb == null)
            {
                return; // Gérer les cas où les contrôles sont null
            }

            string entree = tb.Text;
            List<string> suggestions = Autocompleter1(dgv, entree);

            lb.Visible = true;
            lb.Items.Clear();
            lb.Items.AddRange(suggestions.ToArray());
        }

        public List<string> Autocompleter1(DataGridView dgv, string input)
        {
            if (dgv == null || dgv.Rows.Count == 0 || string.IsNullOrEmpty(input))
            {
                return new List<string>();
            }

            input = input.ToLower();

            List<string> suggestions = new List<string>();

            foreach (DataGridViewRow row in dgv.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.Value != null)
                    {
                        string cellValue = cell.Value.ToString().ToLower();
                        if (cellValue.StartsWith(input))
                        {
                            suggestions.Add(cellValue);
                        }
                    }
                }
            }

            return suggestions;
        }

        public bool Authentifier(string nomUtilisateur, string motDePasse)
        {
            bool estAuthentifie = false;
            string requete = "SELECT COUNT(*) FROM utilisateur WHERE NomUtilisateur = @nom AND Mot_de_Passe = @mdp";

            try
            {
                this.connex();
                using (MySqlCommand cmd = new MySqlCommand(requete, this.con))
                {
                    cmd.Parameters.AddWithValue("@nom", nomUtilisateur);
                    cmd.Parameters.AddWithValue("@mdp", motDePasse);

                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                    estAuthentifie = count > 0;
                }
                this.deconnex();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur d'authentification : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.deconnex();
            }

            return estAuthentifie;
        }
    }
}
