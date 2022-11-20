using Project_Karel_Gortz.Models.Database;
using Project_Karel_Gortz.Models.Users;

namespace Project_Karel_Gortz.Models.Posts
{
    public class Post
    {
        public int? Id { get; set; }
        public string? Title { get; set; }
        public string? Content { get; set; }
        //public bool IsDeleted { get; set; }
        //public ApplicationUser User { get; set; }
        //public List<Comment>? Comments { get; set; }
        public CustomUser? Author { get; set; }
        public bool? IsDeleted { get; set; } = false;
        public DateTime TimeStamp { get; set; }

        public ICollection<Comment>? Comments { get; set; }
        public int? FixtureId { get; set; }
        public FixtureDb? Fixture { get; set; }
    }
}
