using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Webpopytka_4_1.Models
{
    public class UsersModel
    {
        public int id { get; set; }

        [Required(ErrorMessage = "Required")]
        public string name { get; set; }

        [Required(ErrorMessage = "Required")]
        [EmailAddress(ErrorMessage ="Invalid email adress")]
        public string email { get; set; }

        [Required(ErrorMessage = "Required")]
        public string password { get; set; }

        [Required(ErrorMessage = "Required")]
        [Compare("Password", ErrorMessage = "Passwords do not match")]
        public string confirmPassword { get; set; }

        public System.DateTime dataRegistration { get; set; }

        public Nullable<System.DateTime> dataEndLogin { get; set; }

        public int status { get; set; }
    }
}