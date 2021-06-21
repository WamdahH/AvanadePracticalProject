using Merge;
using Merge.Controllers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace ProjectTests.serviceThree
{
    public class serviceThreeTests
    {
        private AppSettings appSettings = new AppSettings()
        {
            numbersServiceURL = "",
            lettersServiceURL = ""

        };
        [Fact]
        public async void GetTests()
        {
            var options = new Mock<IOptions<AppSettings>>();
            options.Setup(x => x.Value).Returns(appSettings);

            MergeController mergeController = new MergeController(options.Object);
            var mergeControllerResult = await mergeController.Get();

            Assert.NotNull(mergeControllerResult);
            Assert.IsType<OkObjectResult>(mergeControllerResult);
        }
    }
}
