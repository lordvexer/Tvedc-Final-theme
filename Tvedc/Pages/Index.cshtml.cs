using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tvedc.Data;
using Tvedc.Entities;

namespace Tvedc.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly DataContext _context;
        private readonly IConfiguration _config;

        public IndexModel(ILogger<IndexModel> logger, DataContext context, IConfiguration config)
        {
            _logger = logger;
            this._context = context;
            this._config = config;
        }

        public List<News> News { get; set; }

        public void OnGet()
        {
            var newsCount = int.Parse(_config["NewsCount"]);
            News = _context.News.OrderByDescending(p=> p.NewsDate).Take(newsCount).ToList();
        }
    }
}
