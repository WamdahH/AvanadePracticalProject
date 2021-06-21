using RandNumbers.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Xunit;



namespace ProjectTests.serviceOne
{
    public class NumbersTest
    {
        [Fact]
        public void GetTest()
        {
            RandNumbersController randNumbersController = new RandNumbersController();
            var randomNumberControllerResult = randNumbersController.GetNumber();

            Assert.NotNull(randomNumberControllerResult);
            Assert.IsType<ActionResult<string>>(randomNumberControllerResult);

        }
    }
}
