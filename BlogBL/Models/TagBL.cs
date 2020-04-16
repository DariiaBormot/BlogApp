using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogBL.Models
{
    public class TagBL
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public IEnumerable<BlogPostBL> Posts { get; set; }
    }
}
