using System;
using System.IO;
using System.Linq;
using System.Diagnostics;
using System.Globalization;
using System.Collections;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.text.pdf.security;
using Org.BouncyCastle.Pkcs;
using Org.BouncyCastle.Security;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.X509;
using iTextSharp.text.pdf.interfaces;

namespace GESTAPP.Outils
{
    public static class GnerationPDF
    {
        private static readonly object _logLock = new();
        private static string GetDefaultOutputDirectory()
        {
            var dir = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "GESTAPP", "PDF");
            Directory.CreateDirectory(dir);
            return dir;
        }

        private static string GetDefaultLogFile()
        {
            var logDir = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "GESTAPP", "Logs");
            Directory.CreateDirectory(logDir);
            return Path.Combine(logDir, $"gestapp_{DateTime.Now:yyyyMMdd}.log");
        }

        private static void Log(string message, Exception? ex = null)
        {
            try
            {
                var path = GetDefaultLogFile();
                lock (_logLock)
                {
                    File.AppendAllText(path, $"[{DateTime.Now:yyyy-MM-dd HH:mm:ss}] {message}{Environment.NewLine}");
                    if (ex != null)
                    {
                        File.AppendAllText(path, ex.ToString() + Environment.NewLine);
                    }
                }
            }
            catch
            {
                // Ne pas échouer si la journalisation échoue.
            }
        }

        private static string SanitizeFileName(string name)
        {
            if (string.IsNullOrWhiteSpace(name)) return "document";
            var invalid = Path.GetInvalidFileNameChars();
            return string.Concat(name.Where(c => !invalid.Contains(c))).Trim();
        }

        // Evénement de page pour watermark
        private class WatermarkPageEvent : PdfPageEventHelper
        {
            private readonly string _text;
            private readonly iTextSharp.text.Font _font;
            private readonly float _angle;
            private readonly float _opacity;

            public WatermarkPageEvent(string text, iTextSharp.text.Font font, float angle = 45f, float opacity = 0.15f)
            {
                _text = text ?? string.Empty;
                _font = font ?? iTextSharp.text.FontFactory.GetFont(iTextSharp.text.FontFactory.HELVETICA, 60);
                _angle = angle;
                _opacity = opacity;
            }

            public override void OnEndPage(PdfWriter writer, Document document)
            {
                if (string.IsNullOrEmpty(_text)) return;
                var cb = writer.DirectContentUnder;
                cb.SaveState();
                var gs = new PdfGState { FillOpacity = _opacity, StrokeOpacity = _opacity };
                cb.SetGState(gs);

                BaseFont bf;
                if (_font.BaseFont != null) bf = _font.BaseFont;
                else bf = BaseFont.CreateFont(BaseFont.HELVETICA, BaseFont.CP1252, false);

                cb.BeginText();
                cb.SetColorFill(BaseColor.GRAY);
                cb.SetFontAndSize(bf, 60);
                var pageSize = document.PageSize;
                cb.ShowTextAligned(Element.ALIGN_CENTER, _text, pageSize.Width / 2, pageSize.Height / 2, _angle);
                cb.EndText();

                cb.RestoreState();
            }
        }

        // Tentative de signature numérique si PFX fourni
        private static void TrySignPdf(string sourcePdf, string? pfxPath, string? pfxPassword)
        {
            if (string.IsNullOrWhiteSpace(pfxPath) || !File.Exists(pfxPath))
            {
                Log($"Signature non effectuée : certificat absent ou invalide ({pfxPath}).");
                return;
            }

            try
            {
                // Signature numérique : cette fonctionnalité nécessite une implémentation complexe
                // avec BouncyCastle et iTextSharp. Pour l'instant, on log simplement le message.
                Log($"Signature numériquement du PDF demandée mais non implémentée : {pfxPath}");
                return;
            }
            catch (Exception ex)
            {
                Log("Erreur lors de la tentative de signature du PDF.", ex);
            }
        }



        public static void GenererContratBail(string numeroContrat, string motif, string detailsContrat, string dateCreation,
                                       string idLocataire, string matriculeAgent)
        {
            // Chemin de sauvegarde (tu peux choisir un autre chemin)
            string cheminFichier = $"C:\\Users\\congo\\Documents\\diego\\MEMOIRE_DIEGO_2025\\MEMOIRE_DIEGO2025\\FINAL_MEMOIRE_DIEGO\\APPLICATION\\PDF\\{numeroContrat}.pdf";

            // Création du document
            Document doc = new Document(PageSize.A4, 40, 40, 40, 40);
            PdfWriter.GetInstance(doc, new FileStream(cheminFichier, FileMode.Create));
            doc.Open();

            // Police
            var titreFont = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 16);
            var normalFont = FontFactory.GetFont(FontFactory.HELVETICA, 10);

            // Logo 
            try
            {
                // Mets le chemin de ton logo ici (chemin absolu ou relatif au projet)
                iTextSharp.text.Image logo = iTextSharp.text.Image.GetInstance(@"C:\Users\congo\Documents\diego\MEMOIRE_DIEGO_2025\MEMOIRE_DIEGO2025\FINAL_MEMOIRE_DIEGO\APPLICATION\Icone_Image\Gest_app_1.png");
                // Redimensionner le logo
                logo.ScaleAbsolute(70, 70); // largeur, hauteur en points

                // Aligner à gauche
                logo.Alignment = Element.ALIGN_LEFT;

                doc.Add(logo);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Impossible de charger le logo : " + ex.Message);
            }

            // En-tête
            Paragraph entete = new Paragraph("Direction de Gestion Immobilière\nAdresse : [Avenue : LUKUSA,N° 6,  Quartier : Onattra, Commune : Gombe] | Tél : [+243 844 543 523] | Email : [direction@gestappgmail.com]\n\n", normalFont);
            entete.Alignment = Element.ALIGN_CENTER;
            doc.Add(entete);

            // Titre contrat
            Paragraph titre = new Paragraph("CONTRAT DE BAIL\n\n", titreFont);
            titre.Alignment = Element.ALIGN_CENTER;
            doc.Add(titre);

            // Numéro du contrat
            Paragraph num = new Paragraph($"N° : {numeroContrat}\n\n", normalFont);
            num.Alignment = Element.ALIGN_CENTER;
            doc.Add(num);

            // Tableau des infos
            PdfPTable table = new PdfPTable(2);
            table.WidthPercentage = 100;
            table.SetWidths(new float[] { 2, 4 });

            // Méthode pour ajouter une ligne
            void AjouterLigne(string label, string valeur)
            {
                table.AddCell(new PdfPCell(new Phrase(label, normalFont)) { BackgroundColor = BaseColor.LIGHT_GRAY });
                table.AddCell(new PdfPCell(new Phrase(valeur, normalFont)));
            }

            AjouterLigne("Numéro du contrat", numeroContrat);
            AjouterLigne("Motif", motif);
            AjouterLigne("Détails du contrat", detailsContrat);
            AjouterLigne("Date de création", dateCreation);
            AjouterLigne("ID locataire", idLocataire);
            AjouterLigne("Matricule agent", matriculeAgent);

            doc.Add(table);

            // Mention légale
            doc.Add(new Paragraph("\n✅ Ce contrat de bail est établi en double exemplaire. À conserver comme preuve.\n\n", normalFont));

            // Signature
            doc.Add(new Paragraph("Signature de l’agent : ____________________", normalFont));
            doc.Add(new Paragraph("Signature du locataire : ____________________", normalFont));

            doc.Close();

            // Ouvrir le PDF avec l'application par défaut (Adobe, Edge, etc.)
            var psi = new System.Diagnostics.ProcessStartInfo
            {
                FileName = cheminFichier,
                UseShellExecute = true
            };
            System.Diagnostics.Process.Start(psi);
        }

        /// <summary>Génère un reçu PDF</summary>
        public static void GenererRecu(string numeroRecu, string motif, string codeFrais, string datePaiement, string idLocataire, string matriculeAgent, string montant, string moyenPaiement)
        {
            try
            {
                string cheminFichier = Path.Combine(GetDefaultOutputDirectory(), $"Recu_{numeroRecu}.pdf");

                Document doc = new Document(PageSize.A4, 40, 40, 40, 40);
                PdfWriter.GetInstance(doc, new FileStream(cheminFichier, FileMode.Create));
                doc.Open();

                var titreFont = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 16);
                var normalFont = FontFactory.GetFont(FontFactory.HELVETICA, 10);

                Paragraph titre = new Paragraph("REÇU DE PAIEMENT\n\n", titreFont);
                titre.Alignment = Element.ALIGN_CENTER;
                doc.Add(titre);

                PdfPTable table = new PdfPTable(2);
                table.WidthPercentage = 100;
                
                void AjouterLigne(string label, string valeur)
                {
                    table.AddCell(new PdfPCell(new Phrase(label, normalFont)) { BackgroundColor = BaseColor.LIGHT_GRAY });
                    table.AddCell(new PdfPCell(new Phrase(valeur, normalFont)));
                }

                AjouterLigne("Numéro du reçu", numeroRecu);
                AjouterLigne("Motif", motif);
                AjouterLigne("Code frais", codeFrais);
                AjouterLigne("Date paiement", datePaiement);
                AjouterLigne("ID Locataire", idLocataire);
                AjouterLigne("Matricule agent", matriculeAgent);
                AjouterLigne("Montant payé", montant);
                AjouterLigne("Moyen paiement", moyenPaiement);

                doc.Add(table);
                doc.Add(new Paragraph("\n✅ Ce reçu confirme le paiement. À conserver.\n", normalFont));

                doc.Close();

                var psi = new System.Diagnostics.ProcessStartInfo
                {
                    FileName = cheminFichier,
                    UseShellExecute = true
                };
                System.Diagnostics.Process.Start(psi);
            }
            catch (Exception ex)
            {
                Log($"Erreur lors de la génération du reçu : {ex.Message}", ex);
            }
        }

        /// <summary>Génère une note de remise PDF</summary>
        public static void GenererNoteRemise(string codeNote, string motif, string article, string dateCreation, string numeroAppartement, string idLocataire, string matriculeAgent)
        {
            try
            {
                string cheminFichier = Path.Combine(GetDefaultOutputDirectory(), $"NoteRemise_{codeNote}.pdf");

                Document doc = new Document(PageSize.A4, 40, 40, 40, 40);
                PdfWriter.GetInstance(doc, new FileStream(cheminFichier, FileMode.Create));
                doc.Open();

                var titreFont = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 16);
                var normalFont = FontFactory.GetFont(FontFactory.HELVETICA, 10);

                Paragraph titre = new Paragraph("NOTE DE REMISE\n\n", titreFont);
                titre.Alignment = Element.ALIGN_CENTER;
                doc.Add(titre);

                PdfPTable table = new PdfPTable(2);
                table.WidthPercentage = 100;
                
                void AjouterLigne(string label, string valeur)
                {
                    table.AddCell(new PdfPCell(new Phrase(label, normalFont)) { BackgroundColor = BaseColor.LIGHT_GRAY });
                    table.AddCell(new PdfPCell(new Phrase(valeur, normalFont)));
                }

                AjouterLigne("Code de note", codeNote);
                AjouterLigne("Motif", motif);
                AjouterLigne("Article", article);
                AjouterLigne("Date de création", dateCreation);
                AjouterLigne("Numéro appartement", numeroAppartement);
                AjouterLigne("ID Locataire", idLocataire);
                AjouterLigne("Matricule agent", matriculeAgent);

                doc.Add(table);
                doc.Add(new Paragraph("\n✅ Document de remise officiel.\n", normalFont));

                doc.Close();

                var psi = new System.Diagnostics.ProcessStartInfo
                {
                    FileName = cheminFichier,
                    UseShellExecute = true
                };
                System.Diagnostics.Process.Start(psi);
            }
            catch (Exception ex)
            {
                Log($"Erreur lors de la génération de la note de remise : {ex.Message}", ex);
            }
        }
    }
}