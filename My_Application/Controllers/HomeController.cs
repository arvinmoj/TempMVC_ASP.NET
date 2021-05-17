using Data;
using System.Linq;
using ViewModels.Error;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;

namespace My_Application.Controllers
{
    public class HomeController : Infrastructure.BaseControllerWithDatabase
    {
        private readonly DatabaseContext _databaseContext;

        public HomeController(DatabaseContext databaseContext): base(databaseContext)
        {
        }

        public IActionResult Index()
        {
            return View();
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