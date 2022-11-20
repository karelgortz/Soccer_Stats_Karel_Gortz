using Microsoft.AspNetCore.Identity;
using Project_Karel_Gortz.Data;
using Project_Karel_Gortz.Models.Database;
using Project_Karel_Gortz.Models.Users;


namespace Project_Karel_Gortz.Services
{
    public class FixtureService
    {
        private readonly ApplicationDbContext _context;

        public FixtureService(ApplicationDbContext applicationDbContext)
        {
            _context = applicationDbContext;
        }

        public List<FixtureDb> GetAllFixtures()
        {
            return _context.Fixtures.ToList();
        }

    }
}
