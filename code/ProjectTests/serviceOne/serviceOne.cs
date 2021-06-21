using RandNumbers.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Xunit;
using RandNumbers;


namespace ProjectTests.serviceOne
{
    class serviceOne
    {
        public void GetRandNumberTest()
        {
            RandNumbersController randNumbersController = new RandNumbersController();
            var randomNumberControllerResult = randNumbersController.GetType();

            Assert.NotNull(randomNumberControllerResult);
            Assert.IsType<ActionResult<string>>(randomNumberControllerResult);

        }
    }
}
