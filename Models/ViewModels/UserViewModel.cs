using System;

namespace Webpopytka_4_1.Models.ViewModels
{
    public class UserViewModel
    {
        public string Id { get; set; }
        public string Name{ get; set; }
        public string Email { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime? LastLoginTime { get; set; }
        public bool IsLoggedIn { get; set; }
    }
}