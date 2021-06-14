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
        static void Main()
        {
            Random random = new Random();
            // random lowercase letter
            int a = random.Next(0, 26);
            char ch = (char)('a' + a);
            Console.WriteLine(ch);
        }
    }
}
