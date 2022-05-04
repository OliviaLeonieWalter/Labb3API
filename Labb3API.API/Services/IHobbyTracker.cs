using Labb2API.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Labb3API.API.Services
{
    public interface IHobbyTracker
    {
        IEnumerable<User> GetAllUsers();

        User GetUser(int id);
        Hobby GetHobby(int id);

        Task<User> GetAllLinks(int id);

        Task<User> GetAllHobbies(int id);

        Hobby AddHobby(Hobby newHobby);
        
        JoinTableUserHobby AddJoinTableUserHobby(JoinTableUserHobby newJoinTableUserHobby);

        Link AddNewLink(Link newLink);
    }
}
