using System;
using System.Collections.Generic;

#nullable disable

namespace KonicaReactApp.Models
{
    public partial class Dokumentumok
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Extension { get; set; }
        public int MainId { get; set; }
        public string Source { get; set; }
    }
}
