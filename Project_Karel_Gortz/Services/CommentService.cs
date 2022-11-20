using Project_Karel_Gortz.Data;
using Project_Karel_Gortz.Models.ModelBinding;
using Project_Karel_Gortz.Models.Posts;

namespace Project_Karel_Gortz.Services
{
    public class CommentService
    {
        private readonly ApplicationDbContext _context;

        public CommentService(ApplicationDbContext applicationDbContext)
        {
            _context = applicationDbContext;
        }

        public void DeleteComment(int commentId)
        {
            _context.Comments.Find(commentId).IsDeleted = true;
            _context.SaveChanges();
        }
        public void EditComment(CommentBindingModel model)
        {
            Comment toUpdate = _context.Comments.Find(model.CommentId);
            toUpdate.Content = model.Content;
            _context.Comments.Update(toUpdate);
            _context.SaveChanges();
        }
    }
}
