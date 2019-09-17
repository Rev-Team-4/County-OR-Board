using System;
using OrBoard.Client.Controllers;
using Xunit;

namespace OrBoard.Tests
{
    public class LoginControllerTests
    {
        [Fact]
        public void IndexActionShouldLogUseIn()
        {
            //Arrange
            var Login = new LoginController();
            //Act
            var NewLogin = Login.Index();
            //Assert 
            Assert.NotNull(NewLogin);
        }
    }
}