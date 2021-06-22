using Microsoft.AspNetCore.Mvc;
using RandLetters.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace ProjectTests.serviceTwo
{
   
    public class LettersTest
    {
        [Fact]
        public void GetLowerCaseTest()
        {
            RandLettersController randLettersController = new RandLettersController();
            var randLettersControllerResult = randLettersController.GetUpperCase();

            Assert.NotNull(randLettersControllerResult);
            Assert.IsType<ActionResult<string>>(randLettersControllerResult);
        }
        [Fact]
        public void GetUpperCaseTest()
        {
            RandLettersController randLettersController = new RandLettersController();
            var randLettersControllerResult = randLettersController.GetLowerCase();

            Assert.NotNull(randLettersControllerResult);
            Assert.IsType<ActionResult<string>>(randLettersControllerResult);
        }
    }
}
