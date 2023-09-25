using Lib.Web.Data;
using Lib.Web.Models;
using Lib.Web.ViewModel;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Lib.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly Context _context;

        public HomeController(ILogger<HomeController> logger, Context context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            var totalBooks = _context.Books.Count();
            var totalImprinters = _context.Imprinters.Count();
          //var totalBookImprinters = _context.BookImprinters.Count();

            var viewModel = new DashboardViewModel
            {
                TotalBooks = totalBooks,
                TotalImprinters = totalImprinters
            };
            return View(viewModel);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}