using Labb2API.Model;
using Labb3API.API.Model;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Labb3API.API.Services
{
    public class HobbyTrackerRepository : IHobbyTracker
    {
        private AppDbContext _appDbContext;

        public HobbyTrackerRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;   
        }

        public async Task<User> GetAllHobbies(int id)
        {
            return await _appDbContext.Users.Include(uh => uh.JoinTableUserHobbies).ThenInclude(h => h.Hobby).FirstOrDefaultAsync(u => u.UserId == id);
        }

        public async Task<User> GetAllLinks(int id)
        {
            return await _appDbContext.Users.Include(l => l.links).FirstOrDefaultAsync(u => u.UserId == id);
        }

        public IEnumerable<User> GetAllUsers()
        {
            return  _appDbContext.Users;
        }
        public User GetUser(int id)
        {
            return  _appDbContext.Users.FirstOrDefault(u => u.UserId == id);
        }
        public Hobby GetHobby(int id)
        {
            return _appDbContext.Hobbies.FirstOrDefault(h => h.HobbyId == id);
        }
        public Hobby AddHobby(Hobby newHobby)
        {
            _appDbContext.Hobbies.Add(newHobby);
            _appDbContext.SaveChanges();
            return newHobby;
        }
        public JoinTableUserHobby AddJoinTableUserHobby(JoinTableUserHobby newJoinTableUserHobby)
        {
            _appDbContext.JoinHobbyUser.Add(newJoinTableUserHobby);
            _appDbContext.SaveChanges();
            return newJoinTableUserHobby;
        }
        public Link AddNewLink(Link newLink)
        {
            _appDbContext.Links.Add(newLink);
            _appDbContext.SaveChanges();
            return newLink; 
        }
        
    }

}
