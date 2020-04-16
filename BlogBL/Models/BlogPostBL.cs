using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogBL.Models
{
    public class BlogPostBL
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
        public string Image { get; set; }
        public int UserId { get; set; }
        public IEnumerable<CategoryBL> Categories { get; set; }
        public IEnumerable<CommentBL> Comments { get; set; }
    }
}
