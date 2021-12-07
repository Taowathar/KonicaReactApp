using System;
using System.Collections.Generic;

#nullable disable

namespace KonicaReactApp.Models
{
    public partial class Naplo
    {
        public int DokumentumId { get; set; }
        public int EsemenyId { get; set; }
        public DateTime HappenedAt { get; set; }

        public virtual Dokumentumok Dokumentum { get; set; }
        public virtual Esemeny Esemeny { get; set; }
    }
}
