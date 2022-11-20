using Project_Karel_Gortz.Data;
using Project_Karel_Gortz.Models.Database;

namespace Project_Karel_Gortz.Services
{
    public class TeamService
    {
        private readonly ApplicationDbContext _context;
        public TeamService(ApplicationDbContext applicationDbContext)
        {
            _context = applicationDbContext;
        }

        public List<TeamDb> GetAllTeams()
        {
            return _context.Teams.ToList();
        }
    }
}
