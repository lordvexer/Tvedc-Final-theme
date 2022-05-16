using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Tvedc.Entities
{
    [Table("Permissions")]
    public class Permission
    {
        public int FileId { get; set; }
        public string  UserName { get; set; }
        public string Type { get; set; }
    }
}
