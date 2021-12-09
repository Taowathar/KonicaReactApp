using System;
using KonicaReactApp.Models;
using KonicaReactApp.Services;
using Microsoft.AspNetCore.Mvc;

namespace KonicaReactApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        public ILoginRepository SqlLoginRepository { get; set; }

        public LoginController(ILoginRepository loginRepository)
        {
            this.SqlLoginRepository = loginRepository;
        }

        [HttpPost]
        public void AddLogin(Login login)
        {   
            login.Id = Guid.NewGuid().ToString("N");
            login.ClientIpAddress = HttpContext.Connection.RemoteIpAddress?.ToString();
            login.LoginTime = DateTime.Now;
            SqlLoginRepository.AddLogin(login);
        }

        [HttpGet("{username}")]
        public string GetFailedLogins(string userName)
        {

            if (SqlLoginRepository.GetAccountDisabled(userName)) return "disabled";
            if (SqlLoginRepository.GetFailedLogins(userName) == 4) return "last";
            return null;
        }
    }
}
