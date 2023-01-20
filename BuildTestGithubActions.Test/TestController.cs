using BuildTestGithubActions.Api.Controllers;
using Microsoft.AspNetCore.Mvc;
using NUnit.Framework;
using System.Net;

namespace BuildTestGithubActions.Test
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            //Arrange 
            string text = "Hello Word";

            //Act
            TestController controller = new TestController();
            ObjectResult responseController = (ObjectResult)controller.Get(text);

            //Assert
            Assert.AreEqual((int)HttpStatusCode.InternalServerError, responseController.StatusCode!.Value);
        }
    }
}