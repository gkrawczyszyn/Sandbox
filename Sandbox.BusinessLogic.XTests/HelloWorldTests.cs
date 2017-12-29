using System;
using Xunit;
using Sandbox.BusinessLogic;

namespace Sandbox.BusinessLogic.XTests
{
    public class HelloWorldTest
    {
        [Fact]
        public void Test1()
        {
            // arrange
            const string name = "tester";

            // act
            var response = HelloWorld.Welcome(name);

            // assert
            Assert.Equal(response, $"Welcome {name}");
        }
    }
}
