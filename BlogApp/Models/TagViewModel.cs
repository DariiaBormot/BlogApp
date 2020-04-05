using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BlogApp.Models
{
    public class TagViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public IEnumerable<PostViewModel> Posts { get; set; }
    }
}