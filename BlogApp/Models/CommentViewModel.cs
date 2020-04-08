using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BlogApp.Models
{
    public class CommentViewModel
    {
        public int Id { get; set; }
        [Required]
        public string Body { get; set; }
    }
}