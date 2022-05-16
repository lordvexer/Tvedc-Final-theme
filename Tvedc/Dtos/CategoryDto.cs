using System;

namespace Tvedc.Dtos
{
    public class CategoryDto
    {
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
        public int? GroupID { get; set; }
        public int? type_id { get; set; }
        public DateTime? ModifiedDate { get; set; }
    }
}
