using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BlogApp.Models
{
    public class UserViewModel
    {
        public UserViewModel()
        {
            Avatar = "~/assets/images/default.png";
        }
        public int Id { get; set; }

        [MinLength(2), Required]
        [DisplayName("First Name")]
        public string FirstName { get; set; }
        [DisplayName("Last Name")]
        [MinLength(2), Required]
        public string LastName { get; set; }
        [DisplayName("Image")]
        public string Avatar { get; set; }

        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime Birthday { get; set; }
        [EmailAddress]
        public string Email { get; set; }
        public HttpPostedFileBase ImageUpload { get; set; }

    }
}