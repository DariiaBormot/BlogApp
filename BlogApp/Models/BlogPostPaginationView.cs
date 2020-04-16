using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BlogApp.Models
{
    public class BlogPostPaginationView
    {
        public IEnumerable<PostViewModel> Posts { get; set; }
        public PageInfo PageInfo { get; set; }
    }
}