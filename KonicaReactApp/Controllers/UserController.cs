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
    public class UserController : ControllerBase
    {
        public IUserRepository SqlUserRepository { get; set; }

        public UserController(IUserRepository userRepository)
        {
            this.SqlUserRepository = userRepository;
        }
    }
}
