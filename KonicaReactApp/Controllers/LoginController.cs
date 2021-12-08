using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KonicaReactApp.Models;
using KonicaReactApp.Services;
using Microsoft.AspNetCore.Http;
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
    }
}
