using System;
using System.Collections.Generic;

#nullable disable

namespace KonicaReactApp.Models
{
    public partial class User
    {
        public string Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public byte[] Salt { get; set; }
    }
}
