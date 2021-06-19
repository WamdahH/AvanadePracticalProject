using FluentAssertions;
using LanguageExt.UnitsOfMeasure;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Moq;
using RandLetters.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace ProjectTests
{
   public class RandLettersControllerTests
    {
        private Mock<IActionResult> mockRepo;
        private RandLettersController randLettersController;
        private ILogger<RandLettersController> _logger;
        private readonly object randomLetter;
        private readonly object getLetter;
        private RandLettersController randomLettersController;


        public RandLettersControllerTests()
        {
            mockRepo = new Mock<IActionResult>();
            randLettersController = new randLettersController(mockRepo.Object);
        }

        [Fact]
        public void Get_LowerCase_Letter()
        {
            //Arrange
            object p = mockRepo.Setup(repo => repo.lowerCaseLetter.FindByCondition(c => c.Id == iterator.IsAny<int>())).Returns(randomLetter);
            var controllerActionResult = randLettersController.Get(1);
            controllerActionResult.Should().NotBeNull();
            controllerActionResult.Should().BeOfType < ActionResult<string>getLetter()>

        ;
        }

    
    }
}
