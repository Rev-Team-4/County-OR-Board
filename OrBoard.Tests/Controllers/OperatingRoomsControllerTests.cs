using System;
using OrBoard.Client.Controllers;
using Xunit;

namespace OrBoard.Tests
{
    public class OperatingRoomsControllerTests
    {
        [Fact]
        public void AddNewRoomActionShouldAddNewRoom()
        {   
            //Arrange
            var ORRoom = new OperatingRoomsController();
            //Act
            var NewRoom = ORRoom.AddNewRoom();
            //Assert 
            Assert.NotNull(NewRoom);
        }

        [Fact]
        public void ViewRoomsActionShouldViewRooms()
        {
            //Arrange
            var ORRoom = new OperatingRoomsController();
            //Act
            var ViewRoom = ORRoom.ViewRooms();
            //Assert 
            Assert.NotNull(ViewRoom);
        }

        
        [Fact]
        public void ViewHospitalsActionShouldViewHospitals()
        {
            //Arrange
            var ORRoom = new OperatingRoomsController();
            //Act
            var ViewHospital = ORRoom.ViewHospitals();
            //Assert 
            Assert.NotNull(ViewHospital);
        }
    }
}