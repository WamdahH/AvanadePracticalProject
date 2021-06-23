using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace RandNumbers.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RandNumbersController : ControllerBase
    {

            [HttpGet("{length}")]
            public ActionResult<string> GetNumber(int length = 6 & 8)
            {
            const string numbers = "123456789";
            var random = new Random();
            var randomNumber = new string(Enumerable.Repeat(numbers, length).Select(s => s[random.Next(s.Length)]).ToArray());
            return randomNumber.ToString();
            }

    }
}











   
