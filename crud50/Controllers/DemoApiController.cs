using crud50.models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace crud50.Controllers
{
    [Route("api/demo")]
    [ApiController]
    public class DemoApiController : ControllerBase
    {
        private readonly ApiDemoDbContext _apiDemoDbContext;
        public DemoApiController(ApiDemoDbContext apiDemoDbContext)
        {
            _apiDemoDbContext = apiDemoDbContext;
        }
        [HttpGet]
        [Route("get-user-List")]
        public async Task<IActionResult> GetAsync()
        {
            var users=await _apiDemoDbContext.User.ToListAsync();
            return Ok(users);
        }
    }
}
