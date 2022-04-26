using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tvedc.Data;
using Tvedc.Dtos;
using Tvedc.Interfaces;

namespace Tvedc.Services
{
    public class TenderService : ITenderService
    {
        private readonly TvedcContext _context;

        public TenderService(TvedcContext context)
        {
            this._context = context;
        }
        public async Task<List<TenderDto>> GetLastTenders()
        {
            return await _context.Tenders
                .Where(p => p.Visible)
                .OrderByDescending(p => p.SaleDateTo)
                .Take(10)
                .Select(p => new TenderDto
                {
                    PacketBazgoshayeeLocation = p.PacketBazgoshayeeLocation,
                    Code = p.Code,
                    PacketDeliveryDate = p.PacketDeliveryDate,
                    PacketBazgoshayeeDate = p.PacketBazgoshayeeDate,
                    IsSaleDocuments = p.IsSaleDocuments,
                    CompanyGuarantyUnit = p.CompanyGuarantyUnit,
                    FileName = p.FileName,
                    ID = p.ID,
                    PacketDeliveryLocation = p.PacketDeliveryLocation,
                    RequireGrade = p.RequireGrade,
                    SaleDateFrom = p.SaleDateFrom,
                    SaleDateTo = p.SaleDateTo,
                    Subject = p.Subject,
                    TelNo = p.TelNo,
                    TenderDescription = p.TenderDescription,
                    TenderDescriptionSummary = p.TenderDescriptionSummary,
                })
                .ToListAsync();
        }
    }
}
