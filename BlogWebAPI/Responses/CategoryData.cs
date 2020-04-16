using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BlogWebAPI.Responses
{
    public class CategoryData
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}