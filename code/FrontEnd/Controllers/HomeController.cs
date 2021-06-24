using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using FrontEnd.Models;
using System.Net.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;

namespace FrontEnd.Controllers
{
    public class HomeController : Controller

    {
        private AppSettings Configuration;

        public HomeController(IOptions<AppSettings> settings)
        {
            Configuration = settings.Value;
        }

        public async Task<IActionResult> Index()
        {
            var mergedService = $"{Configuration.mergedServiceURL}/Merge";
            var mergedResponseCall = await new HttpClient().GetStringAsync(mergedService);
            ViewBag.responseCall = mergedResponseCall;

            return View();
        }
    }
}
