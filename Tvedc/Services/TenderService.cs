using AutoMapper;
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
        private readonly IMapper _mapper;

        public TenderService(TvedcContext context, IMapper mapper)
        {
            this._context = context;
            this._mapper = mapper;
        }

        public async Task<List<AuctionDto>> GetLastAuctions()
        {
            var auctions = await _context.Auctions
                .Where(p => p.Visible)
                .OrderByDescending(p => p.SaleDateTo)
                .Take(10)
                .ToListAsync();
            return _mapper.Map<List<AuctionDto>>(auctions);
        }

        public async Task<List<TenderDto>> GetLastTenders()
        {
            var tenders = await _context.Tenders
                .Where(p => p.Visible)
                .OrderByDescending(p => p.SaleDateTo)
                .Take(10)
                .ToListAsync();

            return _mapper.Map<List<TenderDto>>(tenders);
        }
    }
}
