using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using APIProject.Data;
using APIProject.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace APIProject.Controllers
{

    public class UsersController : BaseAPIController
    {
        private readonly DataContext _context;
        public UsersController(DataContext context)
        {
            _context = context;

        }

        [HttpGet]
        [AllowAnonymous]
        public async Task<ActionResult<IEnumerable<AppUser>>> GetUsers()
        {

            return await _context.Users.ToListAsync();
        }

        [Authorize]
        [HttpGet("{id}")]
        public ActionResult<AppUser> GetUser(int id)
        {
            return _context.Users.Find(id);
        }
    }
}