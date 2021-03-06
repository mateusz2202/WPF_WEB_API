using API_SHOP.IServices;
using API_SHOP.Models;
using Microsoft.AspNetCore.Mvc;

namespace API_SHOP.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly IAccountService _accountService;

        public AccountController(IAccountService accountService)
        {
            _accountService = accountService;
        }
        [HttpPost("register")]
        public ActionResult RegisterUser([FromBody] RegisterUserDTO dto)
        {
            _accountService.RegisterUser(dto);
            return Ok();
        }
        [HttpPost("login")]
        public ActionResult Login([FromBody] LoginDTO dto)
        {
            var token=_accountService.GetToken(dto);
            return Ok(token);
        }
        [HttpGet("user/{email}")]
        public ActionResult GetUser([FromRoute] string email)
        {
            var user = _accountService.GetUserByEmail(email);
            return Ok(user);
        }
    }
}
