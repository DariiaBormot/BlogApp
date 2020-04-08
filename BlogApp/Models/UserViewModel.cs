using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BlogApp.Models
{
    public class UserViewModel
    {
        public int Id { get; set; }

        [MinLength(2), Required]
        public string FirstName { get; set; }

        [MinLength(2), Required]
        public string LastName { get; set; }
        public string Avatar { get; set; }

        [DataType(DataType.Date)]
        public DateTime RegistrationDate { get; set; }
        [EmailAddress]
        public string Email { get; set; }
        public IEnumerable<PostViewModel> Posts { get; set; }
    }
}