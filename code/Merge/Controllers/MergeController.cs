using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Merge.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MergeController : ControllerBase
    {
        //numbers: https://localhost:44361/
        //letters : https://localhost:44321/
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var numbersService = "https://localhost:44361/randnumbers";
            var numbersResponseCall = await new HttpClient().GetStringAsync(numbersService);

            var lettersService = "https://localhost:44321/randletters";
            var lettersResponseCall = await new HttpClient().GetStringAsync(lettersService);

            var mergedResponse = $"{numbersResponseCall}{lettersResponseCall}";
            return Ok(mergedResponse);
        }

    }
}
