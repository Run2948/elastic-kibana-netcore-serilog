using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using elastic_kibana.Models;
using Microsoft.Extensions.Logging;

namespace elastic_kibana.Controllers
{
    //TODO: 3.在 MVC Controller 中记录自定义消息
    public class HomeController : Controller
    {
        ILogger<HomeController> _logger;
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        public IActionResult Index()
        {
            _logger.LogInformation($"oh hai there! : {DateTime.UtcNow}");
            return View();
        }

        public IActionResult Privacy()
        {
            try
            {
                throw new Exception("oops. i haz cause error in UR codez.");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "ur code iz buggy.");
            }
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
