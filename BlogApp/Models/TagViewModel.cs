using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BlogApp.Models
{
    public class TagViewModel
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
        public IEnumerable<PostViewModel> Posts { get; set; }
    }
}