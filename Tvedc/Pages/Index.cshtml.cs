using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tvedc.Data;
using Tvedc.Dtos;
using Tvedc.Entities;
using Tvedc.Interfaces;

namespace Tvedc.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly DataContext _context;
        private readonly IConfiguration _config;
        private readonly ITenderService _tenderService;

        public IndexModel(ILogger<IndexModel> logger, DataContext context, IConfiguration config, ITenderService tenderService)
        {
            _logger = logger;
            this._context = context;
            this._config = config;
            this._tenderService = tenderService;
        }

        public List<News> News { get; set; }
        public List<NewsForArchive> NewsForArchivesNews { get; set; }
        public List<TenderDto> Tenders { get; set; }

        public async Task OnGetAsync()
        {
            var newsCount = int.Parse(_config["NewsCount"]);
            var newsForArchiveCount = int.Parse(_config["NewsForArchiveCount"]);
            News = _context.News.OrderByDescending(p=> p.NewsDate).Take(newsCount).ToList();
            NewsForArchivesNews = _context.NewsForArchives.OrderByDescending(p=> p.NewsDate).Take(newsForArchiveCount).ToList();

            Tenders = await _tenderService.GetLastTenders();
        }
    }
}
