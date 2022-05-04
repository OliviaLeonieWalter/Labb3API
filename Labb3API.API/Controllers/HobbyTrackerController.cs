using Labb2API.Model;
using Labb3API.API.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Labb3API.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HobbyTrackerController : ControllerBase
    {
        private IHobbyTracker _userRepo;

        public HobbyTrackerController(IHobbyTracker user)
        {
            _userRepo = user;
        }

        [HttpGet("users")]
        public IActionResult GetAllUsers()
        {
            return Ok(_userRepo.GetAllUsers());
        }
        [HttpGet("hobbies/{id:int}")]
        public IActionResult GetUserHobbies(int id)
        {
            var result = _userRepo.GetAllHobbies(id);
            if(result != null) return Ok(result);
            return NotFound($"User with {id} not found...");
        }
        [HttpGet("links/{id:int}")]
        public IActionResult GetAllLinks(int  id)
        {
            var result = _userRepo.GetAllLinks(id);
            if(result != null) return Ok(result);
            return NotFound($"User with {id} not found...");
        }
        [HttpPost("addhobby/{id:int}")]
        public ActionResult AddNewHobby(int id, Hobby hobby)
        {
            try
            {
                var userToAddHobby = _userRepo.GetUser(id);
                if (userToAddHobby != null)
                {
                    _userRepo.AddHobby(hobby);
                    _userRepo.AddJoinTableUserHobby(
                        new JoinTableUserHobby()
                        {
                            HobbyId = hobby.HobbyId,
                            UserId = userToAddHobby.UserId,
                        }
                    );
                }
                return Ok();
            }
            catch (System.Exception)
            {
                return BadRequest();
            }
        }
        [HttpPost("addlinks/userid/{userid:int}/hobbyid/{hobbyid:int}")]
        public ActionResult AddnewLink(int hobbyid, Link link, int userid)
        {
            try
            {
                var userToAddLink = _userRepo.GetUser(userid);
                var addlinktohobby = _userRepo.GetHobby(hobbyid);

                if (addlinktohobby != null && userToAddLink != null)
                {
                    link.UserId = userid;
                    link.HobbyId = hobbyid;
                    
                    _userRepo.AddNewLink(link);                        
                }
                return Ok();
            }
            catch (System.Exception)
            {
                return BadRequest();
            }
        }

    }
}
