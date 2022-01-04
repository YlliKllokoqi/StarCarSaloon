using Application.DTOs.Identity;
using Application.Services.Identity;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Crm.Sdk.Messages;
using Model.Identity;
using System.Threading.Tasks;

namespace UI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly IAccountService accountService;
        private readonly IMapper mapper;

        public AccountController(IAccountService accountService, IMapper mapper)
        {
            this.accountService = accountService;
            this.mapper = mapper;
        }

        [HttpPost("login")]
        public async Task<ActionResult<object?>> Login(LoginModel login)
        {
            var account = mapper.Map<LoginDTO>(login);
            var result = await accountService.Login(account);
            return result;
        }

        [HttpPost("register")]
        public async Task<IActionResult> Register(RegisterModel register)
        {
            var account = mapper.Map<RegisterDTO>(register);
            var result = await accountService.Register(account);
            //if(result == null) {
            //    return BadRequest("Registation Failed");
            //}
            //else
            //{
                return Ok("Registration successful");
            //}
            
        }
    }
}
