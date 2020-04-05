using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BlogApp.Models
{
    public class UserViewModel
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Avatar { get; set; }
        //public DateTime RegistrationDate { get; set; }
        public IEnumerable<PostViewModel> Posts { get; set; }
    }
}