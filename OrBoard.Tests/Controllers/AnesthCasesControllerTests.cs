using System;
using OrBoard.Client.Controllers;
using Xunit;

namespace OrBoard.Tests
{
    public class AnesthCasesControllerTests
    {
        [Fact]
        public void IndexActionShouldReturnAcvm()
        {
            //Arrange
            var anesthetist = new AnesthCasesController();
            //Act
            var anesthcase = anesthetist.Index();
            //Assert
            Assert.NotNull(anesthcase);
        }

        [Fact]
        public void SetStatusActionShouldWriteToDb()
        {
            //Arrange
            var anesthetist = new AnesthCasesController();
            var availability = "Unavailable";
            var id = 3; 
            //Act
            var anesthcase = anesthetist.SetStatus(id, availability);
            //Assert
            Assert.NotNull(anesthcase);
        }
    }
}