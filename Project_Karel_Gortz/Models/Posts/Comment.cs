using Project_Karel_Gortz.Models.Users;

namespace Project_Karel_Gortz.Models.Posts
{
    public class Comment
    {
        public int? Id { get; set; }
        public string? Content { get; set; }
        //public bool IsDeleted { get; set; }
        public CustomUser? Author { get; set; }
        public bool? IsDeleted { get; set; } = false;
        public DateTime TimeStamp { get; set; }


        public int? PostId { get; set; }
        public Post? Post { get; set; }
    }
}
