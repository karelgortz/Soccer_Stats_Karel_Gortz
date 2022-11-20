using System.ComponentModel.DataAnnotations;

namespace Project_Karel_Gortz.Models.ModelBinding
{
    public class CommentBindingModel
    {
        [Required(ErrorMessage = "Please enter your post content!")]
        [Display(Name = "Content")]
        public string Content { get; set; }
        public int? PostId { get; set; }
        public int? CommentId { get; set; }
        public int? FixtureId { get; set; }
    }
}
