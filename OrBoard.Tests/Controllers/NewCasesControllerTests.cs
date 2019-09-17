using System;
using OrBoard.Client.Controllers;
using Xunit;

namespace OrBoard.Tests
{
    public class NewCasesControllerTests
    {
        [Fact]
        public void IndexActionShouldAddNewCase()
        {
            //Arrange
            var NewCase = new NewCasesController();
            //Act
            var caseadd = NewCase.Index();
            //Assert 
            Assert.NotNull(caseadd);
        }
    }
}