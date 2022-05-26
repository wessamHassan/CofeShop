using CofeShop.Shared.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CofeShop.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        private readonly ApplicationDbContext applicationDbContext;

        public UserController(ApplicationDbContext applicationDbContext)
        {
            this.applicationDbContext = applicationDbContext;
        }

        [HttpGet]
        public async Task<ActionResult<User>> Get(string email, string password)
        {
            User user = await applicationDbContext.Users.FirstOrDefaultAsync(x => x.Email == email && x.Password == password);
            
            return user;
           
        }

        [HttpPost]
        public async Task Post(User user)
        {
            applicationDbContext.Add(user);
            await applicationDbContext.SaveChangesAsync();
            //return new CreatedAtRouteResult("GetUser", new { email = user.Email, password = user.Password }, user);
            
        }

    }
}
