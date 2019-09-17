using System;
using OrBoard.Client.Controllers;
using Xunit;

namespace OrBoard.Tests
{
    public class CasesControllerTests
    {
        [Fact]
        public void IndexActionShouldReturnCvm()
        {
            //Arrange
            var CaseControl = new CasesController();
            //Act
            var controlcase = CaseControl.Index();
            //Assert 
            Assert.NotNull(controlcase);
        }

        [Fact]
        public void EditCasesActionShouldEditCase()
        {
            //Arrange
            var CaseControl = new CasesController();
            var id = 3; //Dummy variable to pass into editcase. 
            //Act
            var editcase = CaseControl.EditCases(id);
            //Assert 
            Assert.NotNull(editcase);
        }
    }
}