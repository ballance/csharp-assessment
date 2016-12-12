using System;
using System.Security.Cryptography;
using Xunit;
using Xunit.Sdk;

namespace Assessment.Tests
{
    public class FlowControlTests
    {
        [Fact]
        public void Should_Implement_Fizz_Buzz()
        {
            Assert.Equal("buzz", FlowControl.FizzBuzz(5));
            Assert.Equal("1", FlowControl.FizzBuzz(1));
            Assert.Equal("fizzbuzz", FlowControl.FizzBuzz(90));
            Assert.Equal("fizz", FlowControl.FizzBuzz(9));
            Assert.Equal("7", FlowControl.FizzBuzz(7));
            Assert.Equal("fizzbuzz", FlowControl.FizzBuzz(8505));
            Assert.Equal("8506", FlowControl.FizzBuzz(8506));
        }
    }
}
