using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogBL.Models
{
    public class UserBL
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Avatar { get; set; }
        public DateTime Birthday { get; set; }
        public string Email { get; set; }

        public IEnumerable<BlogPostBL> Posts { get; set; }
        public IEnumerable<CommentBL> Comments { get; set; }
    }
}
