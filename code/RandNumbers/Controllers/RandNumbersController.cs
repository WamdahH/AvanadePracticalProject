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
      /*  public static string RandomSixDigitNumberGenerator(int length = 6)
        {
            const string numbers = "123456789";
            var random = new Random();
            var randomNumber = new string(Enumerable.Repeat(numbers, length).Select(s => s[random.Next(s.Length)]).ToArray());
            return randomNumber;
        }*/
            [HttpGet("{length}")]
            public ActionResult<string> Get(int length)
            {
            const string numbers = "123456789";
            var random = new Random();
            var randomNumber = new string(Enumerable.Repeat(numbers, length).Select(s => s[random.Next(s.Length)]).ToArray());
            return randomNumber.ToString();
            }
          
        
    }
}

    /*[ApiController]
    [Route("[controller]")]
    public class RanNumbersController : ControllerBase
    {
        
             private static readonly int[] Numbers = new[]
             {
             1,2,3,4,5,6,7,8,9,0
         };

             [HttpGet]
             public ActionResult<string> Get()
             {
                 var rnd = new Random();
                 var returnIndex = rnd.Next(0, 9);
                 return Numbers[returnIndex].ToString();
             }*/

/*       public int RandomNumber(string[] args)
       {
           int min = 0;
           int max = 6;

           Random random = new Random();
           int number = random.Next(min, max);

           return number;
       }

       public int RandomNumber()
       {
           int min = 0;
           int max = 9;
           Random random = new Random();
           return random.Next(min, max);
       }


public void Main()
{
    Random r = new Random();
    int genRand = r.Next(10, 50);
    Console.WriteLine("Random Number = " + genRand);
}*//*
// Generates a random password.  
// 4-LowerCase + 4-Digits + 2-UpperCase  
int num = random.Next();
public string RandomPassword()
{
    var passwordBuilder = new StringBuilder();

    // 4-Letters lower case   
    passwordBuilder.Append(RandomString(4, true));

    // 4-Digits between 1000 and 9999  
    passwordBuilder.Append(RandomNumber(1000, 9999));

    // 2-Letters upper case  
    passwordBuilder.Append(RandomString(2));
    return passwordBuilder.ToString();
}
}
}
*/
/*using System;
using System.Text;

namespace ConsoleApp7
{
    class RandomNumberSample
    {
        public void Main(string[] args)
        {
            var generator = new RandomGenerator();
            var randomNumber = generator.RandomNumber(0, 5);
            Console.WriteLine($"Random number between 5 and 100 is {randomNumber}");

            var randomString = generator.RandomString(10);
            Console.WriteLine($"Random string of 10 chars is {randomString}");

            var randomPassword = generator.RandomPassword();
            Console.WriteLine($"Random string of 6 chars is {randomPassword}");

            Console.ReadKey();
        }
    }

    public class RandomGenerator
    {
        // Instantiate random number generator.  
        // It is better to keep a single Random instance 
        // and keep using Next on the same instance.  
        private readonly Random _random = new Random();

        // Generates a random number within a range.      
        public int RandomNumber(int min, int max)
        {
            return _random.Next(min, max);
        }

        // Generates a random string with a given size.    
        public string RandomString(int size, bool lowerCase = false)
        {
            var builder = new StringBuilder(size);

            // Unicode/ASCII Letters are divided into two blocks
            // (Letters 65–90 / 97–122):   
            // The first group containing the uppercase letters and
            // the second group containing the lowercase.  

            // char is a single Unicode character  
            char offset = lowerCase ? 'a' : 'A';
            const int lettersOffset = 26; // A...Z or a..z: length = 26  

            for (var i = 0; i < size; i++)
            {
                var @char = (char)_random.Next(offset, offset + lettersOffset);
                builder.Append(@char);
            }

            return lowerCase ? builder.ToString().ToLower() : builder.ToString();
        }

        // Generates a random password.  
        // 4-LowerCase + 4-Digits + 2-UpperCase  
        public string RandomPassword()
        {
            var passwordBuilder = new StringBuilder();

            // 4-Letters lower case   
            passwordBuilder.Append(RandomString(4, true));

            // 4-Digits between 1000 and 9999  
            passwordBuilder.Append(RandomNumber(1000, 9999));

            // 2-Letters upper case  
            passwordBuilder.Append(RandomString(2));
            return passwordBuilder.ToString();
        }
    }
}*/