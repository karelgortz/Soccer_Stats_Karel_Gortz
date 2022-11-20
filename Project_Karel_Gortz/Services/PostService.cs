using Project_Karel_Gortz.Data;
using Project_Karel_Gortz.Models.ModelBinding;
using Project_Karel_Gortz.Models.Posts;

namespace Project_Karel_Gortz.Services
{
    public class PostService
    {
        private readonly ApplicationDbContext _context;

        public PostService(ApplicationDbContext applicationDbContext)
        {
            _context = applicationDbContext;
        }

        public void DeletePost(int postId)
        {
            _context.Posts.Find(postId).IsDeleted = true;
            _context.SaveChanges();
        }
        public void EditPost(PostBindingModel model)
        {
            Post toUpdate = _context.Posts.Find(model.PostId);
            toUpdate.Title = model.Title;
            toUpdate.Content = model.Content;
            _context.Posts.Update(toUpdate);
            _context.SaveChanges();
        }
    }
}
