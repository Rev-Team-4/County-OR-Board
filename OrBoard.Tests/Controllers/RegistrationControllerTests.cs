using System;
using OrBoard.Client.Controllers;
using Xunit;

namespace OrBoard.Tests
{
    public class RegistrationControllerTests
    {
        [Fact]
        public void ProviderActionShouldAddNewProvider()
        {
            //Arrange
            var Register = new RegistrationController();
            //Act
            var Provider = Register.Provider();
            //Assert   
            Assert.NotNull(Provider);
        }

        [Fact]
        public void FacilityActionShouldAddNewFacility()
        {
            //Arrange
            var Register = new RegistrationController();
            //Act
            var Facility = Register.Facility();
            //Assert
            Assert.NotNull(Facility);
        }
    }
}