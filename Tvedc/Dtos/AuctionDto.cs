using System;

namespace Tvedc.Dtos
{
    public class AuctionDto
    {
        public int ID { get; set; }
        public string Code { get; set; }
        public string Subject { get; set; }
        public DateTime SaleDateFrom { get; set; }
        public DateTime SaleDateTo { get; set; }
        public DateTime PacketDeliveryDate { get; set; }
        public string PacketDeliveryLocation { get; set; }
        public DateTime PacketBazgoshayeeDate { get; set; }
        public string PacketBazgoshayeeLocation { get; set; }
        public string CompanyGuarantyUnit { get; set; }
        public string AuctionDescriptionSummary { get; set; }
        public string AuctionDescription { get; set; }
        public string FileName { get; set; }
        public string TelNo { get; set; }
        public bool IsSaleDocuments { get; set; }
    }
}