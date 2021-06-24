using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace RandLetters.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RandLettersController : ControllerBase
    {
        [HttpGet]
        public ActionResult<string> GetUpperCase(int length = 2)
        {
            const string upperCaseLetters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            var random = new Random();
            var randomLetter = new string(Enumerable.Repeat(upperCaseLetters, length).Select(s => s[random.Next(s.Length)]).ToArray());
            return randomLetter.ToString();
        }
      /*  [HttpGet("{length}")]
        public ActionResult<string> GetLowerCase(int length = 3)
        {
            const string lowerCaseLetters = "abdcefghijklmnopqrstuvwxyz";
            var random = new Random();
            var randomLetter = new string(Enumerable.Repeat(lowerCaseLetters, length).Select(s => s[random.Next(s.Length)]).ToArray());
            return randomLetter.ToString();
        }*/
     
    }
}
