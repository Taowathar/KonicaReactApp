using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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
    }
}
