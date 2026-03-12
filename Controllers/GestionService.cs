using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;

public class GestionService
{
    private string connectionString = "server=localhost;database=gestion_locative;uid=root;pwd=;";

    

    // Ajouter une notification
    public void AjouterNotification(string message, string destinataireRole)
    {
        using (MySqlConnection conn = new MySqlConnection(connectionString))
        {
            conn.Open();
            string query = "INSERT INTO Notifications (Message, DestinataireRole, IsRead) VALUES (@msg, @role, 0)";
            using (MySqlCommand cmd = new MySqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@msg", message);
                cmd.Parameters.AddWithValue("@role", destinataireRole);
                cmd.ExecuteNonQuery();
            }
        }
    }

    // Récupérer notifications d’un rôle
    public List<string> GetNotifications(string destinataireRole)
    {
        List<string> notifications = new List<string>();
        using (MySqlConnection conn = new MySqlConnection(connectionString))
        {
            conn.Open();
            string query = "SELECT Id, Message FROM Notifications WHERE DestinataireRole=@role AND IsRead=0";
            using (MySqlCommand cmd = new MySqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@role", destinataireRole);
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string notif = $"[ID {reader.GetInt32("Id")}] {reader.GetString("Message")}";
                        notifications.Add(notif);
                    }
                }
            }
        }
        return notifications;
    }

    // Marquer notification comme lue
    public void MarquerCommeLue(int idNotification)
    {
        using (MySqlConnection conn = new MySqlConnection(connectionString))
        {
            conn.Open();
            string query = "UPDATE Notifications SET IsRead=1 WHERE Id=@id";
            using (MySqlCommand cmd = new MySqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@id", idNotification);
                cmd.ExecuteNonQuery();
            }
        }
    }

    // ============================
    // 📋 Suivi des dossiers
    // ============================

    // Changer l’état d’un dossier
    public void ChangerEtatDossier(int idDossier, string nouvelEtat)
    {
        using (MySqlConnection conn = new MySqlConnection(connectionString))
        {
            conn.Open();
            string query = "UPDATE Dossiers SET EtatDossier=@etat, DateUpdate=NOW() WHERE Id=@id";
            using (MySqlCommand cmd = new MySqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@etat", nouvelEtat);
                cmd.Parameters.AddWithValue("@id", idDossier);
                cmd.ExecuteNonQuery();
            }
        }

        // 🔔 On ajoute aussi une notification automatiquement
        AjouterNotification($"L’état du dossier {idDossier} a été changé en : {nouvelEtat}", "Administrateur");
    }

    // Obtenir l’état actuel d’un dossier
    public string GetEtatDossier(int idDossier)
    {
        string etat = "";
        using (MySqlConnection conn = new MySqlConnection(connectionString))
        {
            conn.Open();
            string query = "SELECT EtatDossier FROM Dossiers WHERE Id=@id";
            using (MySqlCommand cmd = new MySqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@id", idDossier);
                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        etat = reader.GetString("EtatDossier");
                    }
                }
            }
        }
        return etat;
    }
}
