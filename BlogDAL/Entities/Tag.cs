using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogDAL.Entities
{
    public class Tag
    {
        public Tag()
        {
            Posts = new List<Post>();
        }
        public int Id { get; set; }
        public string Name { get; set; }

        ICollection<Post> Posts { get; set; }

    }
}
