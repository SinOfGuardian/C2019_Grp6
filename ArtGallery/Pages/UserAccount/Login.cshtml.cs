using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ArtGallery.Pages.User
{
   
    public class LoginModel : PageModel
    {
        public ClientInfo client = new ClientInfo();
        public string errorMessage = "";
        public string successMessage = "";

        public void OnGet()
        {

        }
        public void OnPost()
        {

            client.Username = Request.Form["Username"];
            client.Email = Request.Form["Email"];
            client.Password = Request.Form["Password"];

            if (client.Username.Length == 0 || client.Email.Length == 0 || client.Password.Length == 0)
            {
                errorMessage = "All the field are required";
                return;
            }
            //SAVE
            try
            {
                string connectionString = "Data Source =.\\sqlexpress; Initial Catalog = ArtGallery2; Integrated Security = True; Pooling = False";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    String sql = "INSERT INTO Account " +
                        "(Username, Email, Password) VALUES " +
                        "(@Username, @Email, @Password);";

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@Username", client.Username);
                        command.Parameters.AddWithValue("@Email", client.Email);
                        command.Parameters.AddWithValue("@Password", client.Password);

                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                errorMessage = ex.Message;
                return;
            }
            client.Username = ""; client.Email = ""; client.Password = "";
            successMessage = "New Client Added Correctly";

            Response.Redirect("/UserAccount/Login");

        }
    }
  
}
