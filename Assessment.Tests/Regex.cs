using System;
using Xunit;

namespace Assessment.Tests
{
    public class RegexTests
    {
        //[Fact]
        public void Should_Validate_New_Mastercard_Format()
        {
            // Link to m/c format
            var regex = new Regex();
            Assert.True(regex.ValidateMastercard("5454545454545454"));
            Assert.False(regex.ValidateMastercard("37266333333333"));
        }
    }
}