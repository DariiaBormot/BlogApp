using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogDAL.Entities
{
    public class Category
    {
        public Category()
        {
            Posts = new List<Post>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }


        ICollection<Post> Posts { get; set; }
    }
}
