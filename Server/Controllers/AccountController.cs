using BuisnesLogic.Dto;
using BuisnesLogic.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly IAccountServices accountServices;
        public AccountController(IAccountServices accountServices) {
        this.accountServices = accountServices;
        }
        [HttpPost]
        public async Task<IActionResult> Register(RegisterDto register)
        {
            await accountServices.Register(register);
            return Ok();
        }
    }
}
