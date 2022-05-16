using System;

namespace Tvedc.Entities
{
    public class File
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string FileName { get; set; }
        public long? FileSize { get; set; }
        public string Code { get; set; }
        public bool? IsRider { get; set; }
        public int TypeID { get; set; }
        public bool IsDelete { get; set; }
        public DateTime? ModifiedDate { get; set; }
    }
}
