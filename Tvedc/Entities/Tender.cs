using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Tvedc.Entities
{
    [Table("Tender")]
    public class Tender
    {
        public int ID { get;set; }
        public string Code { get;set; }
        public string Subject { get;set; }
        public DateTime SaleDateFrom { get;set; }
        public DateTime SaleDateTo { get;set; }
        public DateTime PacketDeliveryDate { get;set; }
        public string PacketDeliveryLocation { get;set; }
        public DateTime PacketBazgoshayeeDate { get; set; }
        public string PacketBazgoshayeeLocation { get; set; }
        public string CompanyGuarantyUnit { get; set; }
        public string TenderDescriptionSummary { get; set; }
        public string TenderDescription { get; set; }
        public string FileName { get; set; }
        public string TelNo { get; set; }
        public DateTime ModifiedDate { get; set; }
        public bool Visible { get; set; }
        public bool RequireGrade { get; set; }
        public bool IsSaleDocuments { get; set; }
    }
}
