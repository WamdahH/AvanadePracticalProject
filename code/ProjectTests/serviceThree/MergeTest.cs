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
    public class MergeTest
    {
        private AppSettings appSettings = new AppSettings()
        {
            numbersServiceURL = "https://wamdahhassan-randnumbers-service.azurewebsites.net",
            lettersServiceURL = "https://wamdahhassan-randletters-service.azurewebsites.net",
            specialCharacterServiceURL = "https://wamdahhassan-randspecialcharacters-service.azurewebsites.net"
        };
        [Fact]
        public async void Get()
        {
            var options = new Mock<IOptions<AppSettings>>();
            options.Setup(x => x.Value).Returns(appSettings);

            MergeController mergeController = new MergeController(options.Object);
            var mergeContollerResult = await mergeController.Get();

            Assert.NotNull(mergeContollerResult);
            Assert.IsType<OkObjectResult>(mergeContollerResult);
        }
    }
}
