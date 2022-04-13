using System;

namespace Tvedc.Entities
{
    public class News
    {
        public int Id { get; set; }
        public long NewsId { get; set; }
        public string Title { get; set; }
        public string Excerpt { get; set; }
        public string Href { get; set; }
        public string MediaHref { get; set; }
        public string Extention { get; set; }
        public DateTime NewsDate { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
