using API.Data;
using API.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsersController : ControllerBase
    {
        private readonly DataContext _context;
        public UsersController(DataContext context)
        {
            _context = context;

        }

        // The below code is Synchronous, 
        // [HttpGet]
        // public ActionResult<IEnumerable<AppUser>> GetUsers(){
        //     var users = _context.Users.ToList();
        //     return users;
        //     // We could have just called: return _context.Users.ToList();
        // }

        // [HttpGet("{id}")]
        // public AppUser GetUser(int id){
        //     return _context.Users.Find(id);
        // }

        //The below code is Async 
        [HttpGet]
        public async Task<ActionResult<IEnumerable<AppUser>>> GetUsers(){ 
            return await _context.Users.ToListAsync();
            // We could have just called: return _context.Users.ToList();
        }

          [HttpGet("{id}")]
        public async Task<AppUser> GetUser(int id){
            return await _context.Users.FindAsync(id);
        }
    }

    //The below code is asynchronous
      
}