using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BlogApp.Models
{
    public class PostViewModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
        public string Image { get; set; }
        public int UserId { get; set; }
        public IEnumerable<CategoryViewModel> Categories { get; set; }
        public IEnumerable<CommentViewModel> Comments { get; set; }
    }
}