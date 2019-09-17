using System;
using OrBoard.Client.Controllers;
using Xunit;

namespace OrBoard.Tests
{
    public class EditCasesControllerTests
    {
        [Fact]
        public void IndexActionShouldEditCase()
        {
            //Arrange
            var EditCase = new EditCasesController();
            var id = 3; //Dummy variable. 
            //Act
            var editcase = EditCase.Index(id);
            //Assert 
            Assert.NotNull(editcase);
        }
    }
}