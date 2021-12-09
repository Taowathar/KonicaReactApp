using System;

namespace KonicaReactApp.Models
{
    public class Naplo
    {
        public int DokumentumId { get; set; }
        public int EsemenyId { get; set; }
        public DateTime HappenedAt { get; set; }

        public virtual Document Dokumentum { get; set; }
        public virtual Esemeny Esemeny { get; set; }
    }
}
