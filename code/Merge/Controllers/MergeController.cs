using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace Merge.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MergeController : ControllerBase
    {
        private IConfiguration Configuration; 


        public MergeController (IConfiguration configuration)
        {
            Configuration = configuration;

        }

        // https://localhost:44361/rannumbers?length=6
        //https://localhost:44321/randletters?length=3

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var numbersService = "http://localhost:34689/RandNumbers/6";
            var numbersResponseCall = await new HttpClient().GetStringAsync(numbersService);

            var lettersService = "http://localhost:4349/RandLetters/2";
            var lettersResponseCall = await new HttpClient().GetStringAsync(lettersService);

            var mergedResponse = $"{numbersResponseCall}{lettersResponseCall}";
            return Ok(mergedResponse);
        }

    }
}
