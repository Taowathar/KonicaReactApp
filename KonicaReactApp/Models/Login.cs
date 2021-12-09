using System;

namespace KonicaReactApp.Models
{
    public class Login
    {
        public string Id { get; set; }
        public string ClientIpAddress { get; set; }
        public DateTime LoginTime { get; set; }
        public string LoginName { get; set; }
        public int EventId { get; set; }

        public virtual EventType Event { get; set; }
    }
}
