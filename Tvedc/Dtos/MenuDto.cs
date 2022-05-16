using System.ComponentModel.DataAnnotations.Schema;

namespace Tvedc.Dtos
{
    public class MenuDto
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int? ParentId { get; set; }
        public string Url { get; set; }
        public int Level { get; set; }
        public int DisplayOrder { get; set; }
        public bool Visible { get; set; }
        public string UserName { get; set; }
        public bool? IsMainMenu { get; set; }
    }
}
