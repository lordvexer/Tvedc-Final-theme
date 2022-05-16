
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Tvedc.Entities
{
    [Table("Category")]
    public class Category
    {
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
        public int? GroupID { get; set; }
        public int? type_id { get; set; }
        public DateTime? ModifiedDate { get; set; }
    }
}
