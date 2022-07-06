using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ArtGallery.Pages.User
{
    public class LoginModel : PageModel
    {
        public List<UserInfo> listUser = new List<UserInfo>();
        public void OnGet()
        {

        }
    }

    public class UserInfo
    {
        public int id;
        public string Username;
        public string Email;
        public string Password;

    }
}
