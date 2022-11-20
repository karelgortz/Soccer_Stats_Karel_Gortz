using System.ComponentModel.DataAnnotations;

namespace Project_Karel_Gortz.Models.ModelBinding
{
    public class PostBindingModel
    {
        [Required(ErrorMessage = "Please enter a title!")]
        [Display(Name = "Title")]
        public string Title { get; set; }
        [Required(ErrorMessage = "Please enter your post content!")]
        [Display(Name = "Content")]
        public string Content { get; set; }
        public int? FixtureId { get; set; }
        public int? PostId { get; set; }
    }
}
