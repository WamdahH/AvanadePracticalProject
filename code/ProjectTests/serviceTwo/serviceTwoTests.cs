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
   
    public class serviceTwoTests
    {
        [Fact]
        public void GetTest()
        {
            RandLettersController randLettersController = new RandLettersController();
            var randLettersControllerResult = randLettersController.Get();

            Assert.NotNull(randLettersControllerResult);
            Assert.IsType<ActionResult<string>>(randLettersControllerResult);
        }
    }
}
