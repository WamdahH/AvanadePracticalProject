using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace RandSpecialCharacter.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RandSpecialCharacterController : ControllerBase
    {
       [HttpGet]
        public ActionResult<string> GetCharacter(int length = 1)
        {
            const string character = "$%#@!*?;:^&";
            var random = new Random();
            var randchar = new string(Enumerable.Repeat(character, length).Select(s => s[random.Next(s.Length)]).ToArray());
            return randchar.ToString();
        }
    }
}
