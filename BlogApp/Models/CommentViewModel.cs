using System.ComponentModel.DataAnnotations;

namespace BlogApp.Models
{
    public class CommentViewModel
    {
        public int Id { get; set; }

        [Required]
        public string Body { get; set; }

    }
}