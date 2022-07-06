using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using Microsoft.AspNetCore.Mvc.RazorPages;


namespace ArtGallery.Pages
{
    public class UserListModel : PageModel
    {
        public List<ClientInfo> listClients = new List<ClientInfo>();
        public void OnGet()
        {
            try
            {
                string connectionString = "Data Source=.\\sqlexpress;Initial Catalog=ArtGalleryDB;Integrated Security=True";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string sql = "SELECT * FROM Table";
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                ClientInfo client = new ClientInfo();
                                client.Id = reader.GetInt32(0);
                                client.Username = reader.GetString(1);
                                client.Email = reader.GetString(2);
                                client.Password = reader.GetString(3);

                                listClients.Add(client);
                            }
                          
                        }

                    }
                }
            } 
            catch (Exception ex)
            {
                Console.WriteLine("AAAAAHHFUUCCCCK : " + ex.ToString());
            }
        }
    } 
    public class ClientInfo
    {
        public int Id;
        public string Username;
        public string Email;
        public string Password;

      
    }
}
