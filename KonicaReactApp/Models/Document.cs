
namespace KonicaReactApp.Models
{
    public class Document
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Extension { get; set; }
        public int MainId { get; set; }
        public string Source { get; set; }
    }
}
