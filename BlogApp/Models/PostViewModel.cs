using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BlogApp.Models
{
    public class PostViewModel
    {
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public string Body { get; set; }
        public string Image { get; set; }
        public int UserId { get; set; }
        public IEnumerable<CategoryViewModel> Categories { get; set; }
        public IEnumerable<CommentViewModel> Comments { get; set; }
    }
}