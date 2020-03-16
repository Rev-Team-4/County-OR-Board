using System;
using System.Collections.Generic;
using OrBoard.Domain.Models;
using Xunit;

namespace OrBoard.Tests.Models
{
  public class LoginTest
  {
    public List<Login> LoginList = new List<Login>()
    {
      new Login {LoginId=1, UserName="User1", Password="Pass123", CreationDateTime= new DateTime(2020, 1, 5)}, 
      new Login {LoginId=2, UserName="User2", Password="Pass456", CreationDateTime= new DateTime(2020, 1, 10)}
    };
    
    [Fact]
    public void ValidLogIn()
    {
    //Given
    Login TestLogin = new Login(); 
    TestLogin.LoginList = LoginList;
    //When
    var resultLogin = TestLogin.CheckLogin("User1", "Pass123"); 
    //Then
    Assert.True(resultLogin); 
    }

    [Fact]
    public void InvalidLogIn()
    {
    //Given
    Login TestLogin = new Login(); 
    TestLogin.LoginList = LoginList;
    //When
    var resultLogin = TestLogin.CheckLogin("User3", "123Pass"); 
    //Then
    Assert.False(resultLogin); 
    }
  }
}