using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CICDTesting.Models;
using Microsoft.Extensions.Configuration;

namespace CICDTesting.Controllers
{
    public class HomeController : Controller
    {
        private IConfiguration Configuration;
        public HomeController(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        public IActionResult Index()
        {
            string helloMessage = Configuration["HelloMessage"];
            ViewData["HelloMessage"] = helloMessage;

            //both ways can read ASPNETCORE_ENVIRONMENT variable
            // Configuration/IConfigration can read configuration sources: setting files, environment variables, etc.
            //string environment = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT");
            string environment = Configuration["ASPNETCORE_ENVIRONMENT"];
            ViewData["Environment"] = environment;
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
