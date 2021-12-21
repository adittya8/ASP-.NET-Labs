using DataAccess.Entities;
using DataAccess.Providers;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LayeredArch.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        protected readonly AppDbContext _appDbContext;
        public UserController(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        [HttpGet]
        [Route("get/users")]
        public ActionResult<List<User>> GetUsers()
        {
            var users =  _appDbContext.Users.ToList();
            return Ok(users);
        }
    }
}
