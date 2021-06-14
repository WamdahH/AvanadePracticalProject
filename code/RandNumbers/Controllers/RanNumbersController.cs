using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace RandNumbers.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RanNumbersController : ControllerBase
    {
        public void Main()
        {
            Random r = new Random();
            int genRand = r.Next(0, 9);
            Console.WriteLine("Random Number = " + genRand);
        }
        /*  public void Main(string[] args)
          {
              var randomLetters = generator.RandomLetters(3);
              Console.WriteLine($"{randomLetters}");
          }*/
    }
}
