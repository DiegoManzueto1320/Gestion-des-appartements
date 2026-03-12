using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using GESTAPP.Outils;

namespace GESTAPP
{
    public partial class FrmDemandeLocation : Form
    {
        public FrmDemandeLocation()
        {
            InitializeComponent();

            MiseFormeFormulaire.AppliquerForm(this);
            MiseFormeFormulaire.AppliquerLabels(lblFormulaire);
            MiseFormeFormulaire.AppliquerGroupebox(GrouppPiece);
            MiseFormeFormulaire.AppliquerGroupebox(GroupBoxInfoPersonnelle);
            MiseFormeFormulaire.AppliquerGroupebox(GroupEngagementDemandeur);
            MiseFormeFormulaire.AppliquerGroupebox(GroupInfoDemande);
            MiseFormeFormulaire.AppliquerCheckbox(CheckAttestation);
            MiseFormeFormulaire.AppliquerCheckbox(CheckCopiePassport);
            MiseFormeFormulaire.AppliquerCheckbox(CheckFacultatif);
            MiseFormeFormulaire.AppliquerCheckbox(CheckPhotosPassport);
            // Bouton
           MiseEnForme.AppliquerBoutonFormulaire(BtnSooumettre);
        }

        private void BtnSooumettre_Click(object sender, EventArgs e)
        {
            try
            {
                // --- Vérification simple ---
                if (string.IsNullOrWhiteSpace(TxtNom.Text) || string.IsNullOrWhiteSpace(TxtPrenom.Text))
                {
                    MessageBox.Show("Veuillez remplir au minimum Nom et Prénom.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // --- Définition du chemin du PDF ---
                string filePath = Path.Combine(
                    Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),
                    "Demande_Location.pdf"
                );

                // --- Création du document PDF ---
                Document doc = new Document(PageSize.A4, 40, 40, 60, 40);
                PdfWriter.GetInstance(doc, new FileStream(filePath, FileMode.Create));
                doc.Open();

                // --- Police ---
                var fontTitre = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 14);
                var fontSection = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 12);
                var fontTexte = FontFactory.GetFont(FontFactory.HELVETICA, 10);

                // --- Titre ---
                Paragraph titre = new Paragraph("Formulaire de demande de location\n\n", fontTitre);
                titre.Alignment = Element.ALIGN_CENTER;
                doc.Add(titre);

                // ================= SECTION 1 =================
                doc.Add(new Paragraph("1. Informations personnelles du demandeur", fontSection));
                PdfPTable table1 = new PdfPTable(2);
                table1.WidthPercentage = 100;

                table1.AddCell(new Phrase("Nom : " + TxtNom.Text, fontTexte));
                table1.AddCell(new Phrase("Prénom : " + TxtPrenom.Text, fontTexte));
                table1.AddCell(new Phrase("Date de naissance : " + DateInfoNaissance.Value.ToShortDateString(), fontTexte));
                table1.AddCell(new Phrase("Lieu : " + TxtLieuNaissance.Text, fontTexte));
                table1.AddCell(new Phrase("Sexe : " + (RbMasculin.Checked ? "Masculin" : RbFeminin.Checked ? "Féminin" : "Non spécifié"), fontTexte));
                table1.AddCell(new Phrase("Email : " + TxtMail.Text, fontTexte));
                doc.Add(table1);
                doc.Add(new Paragraph("\n"));

                // ================= SECTION 2 =================
                doc.Add(new Paragraph("2. Informations sur la demande", fontSection));
                PdfPTable table2 = new PdfPTable(1);
                table2.WidthPercentage = 100;

                string typeDemande = "";
                if (Controls.ContainsKey("Rb1chambre") && ((RadioButton)Controls["Rb1chambre"]).Checked) typeDemande = "Appartement 1 chambre";
                if (Controls.ContainsKey("Rb2chambre") && ((RadioButton)Controls["Rb2chambre"]).Checked) typeDemande = "Appartement 2 chambres";
                if (Controls.ContainsKey("Rb3chambre") && ((RadioButton)Controls["Rb3chambre"]).Checked) typeDemande = "Appartement 3 chambres";

                table2.AddCell(new Phrase("Type de demande souhaitée : " + typeDemande, fontTexte));
                table2.AddCell(new Phrase("Localisation préférée : " + ComboLocalisation.Text, fontTexte));
                table2.AddCell(new Phrase("Nombre de personnes à loger : " + ComboNombreLoger.Text, fontTexte));
                table2.AddCell(new Phrase("Autres besoins : " + TxtAutres.Text, fontTexte));
                table2.AddCell(new Phrase("Date souhaitée d’occupation : " + DateOccupation.Value.ToShortDateString(), fontTexte));
                doc.Add(table2);
                doc.Add(new Paragraph("\n"));

                // ================= SECTION 3 =================
                doc.Add(new Paragraph("3. Pièces à fournir", fontSection));
                string pieces = "";
                if (CheckCopiePassport.Checked) pieces += "✓ Carte d’identité/Passport\n";
                if (CheckFacultatif.Checked) pieces += "✓ Photos Passeport\n";
                if (CheckPhotosPassport.Checked) pieces += "✓ Attestation de travail/Revenus\n";
                if (CheckAttestation.Checked) pieces += "✓ Références (Facultatif)\n";
                doc.Add(new Paragraph(pieces, fontTexte));
                doc.Add(new Paragraph("\n"));

                // ================= SECTION 4 =================
                doc.Add(new Paragraph("4. Engagement du demandeur", fontSection));
                PdfPTable table4 = new PdfPTable(2);
                table4.WidthPercentage = 100;
                table4.AddCell(new Phrase("Fait à : " + "", fontTexte));
                table4.AddCell(new Phrase("Le : " + DateEngagement.Value.ToShortDateString(), fontTexte));
                table4.AddCell(new Phrase("Signature : " + TxtSignature.Text, fontTexte));
                doc.Add(table4);

                // ================= FIN =================
                doc.Close();

                MessageBox.Show("PDF généré avec succès sur le Bureau !", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de la génération du PDF : " + ex.Message);
            }
        }
    }
    }

