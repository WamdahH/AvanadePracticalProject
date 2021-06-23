using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace Merge.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MergeController : ControllerBase
    {

        private AppSettings Configuration;
        public MergeController(IOptions<AppSettings> settings)
        {
            Configuration = settings.Value;
        }
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var numbersService = $"{Configuration.numbersServiceURL}/randnumbers/6";
            var numbersResponseCall = await new HttpClient().GetStringAsync(numbersService);

            var lettersService = $"{Configuration.lettersServiceURL}/randletters/3";
            var lettersResponseCall = await new HttpClient().GetStringAsync(lettersService);

            var mergedResponse = $"{lettersResponseCall}{numbersResponseCall}";
            return Ok(mergedResponse);
        }
    }
}
