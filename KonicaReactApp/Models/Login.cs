using System;
using System.Collections.Generic;

#nullable disable

namespace KonicaReactApp.Models
{
    public partial class Login
    {
        public int Id { get; set; }
        public string ClientIpAddress { get; set; }
        public DateTime? LoginTime { get; set; }
        public string LoginName { get; set; }
        public int? EventId { get; set; }

        public virtual EventType Event { get; set; }
    }
}
