using System;
using System.Collections.Generic;
using Xunit;

namespace Assessment.Tests
{
    public class RegexTests
    {
        [Fact]
        public void Should_Validate_New_Mastercard_Format()
        {
            // Implement the Mastercard number spec as of 2017-01-01 per https://www.mastercard.us/content/dam/mccom/en-us/documents/issuer-2-series-BIN-impact-checklist-aug-2016.pdf
            Assert.True(Regex.ValidateMastercard("5454545454545454"));
            Assert.False(Regex.ValidateMastercard("37266333333333"));
        }

        [Fact]
        public void Should_Contain_Number(string input)
        {
            Assert.True(Regex.ContainsNumber("a7aaa"));
            Assert.False(Regex.ContainsNumber("a;ertiguaz;xlkna;lskj"));
        }

        [Fact]
        public void Should_Contain_Repeating_Letter(string input)
        {
            Assert.True(Regex.ContainsRepeatingLetter("asdfajkl;kjlk;asdoiupoqweroiupoquwerwwqwerqiou"));
            Assert.False(Regex.ContainsRepeatingLetter("asdfajkl;kjlk;asdoiupoqweroiupoquwerzwqwerqiou"));
        }

        [Fact]
        public void EndsWithVowel(string input)
        {
            Assert.True(Regex.ContainsRepeatingLetter("asdfajkl;kjlk;asdoiupoqweroiupoquwerwwqwerqiou"));
            Assert.False(Regex.ContainsRepeatingLetter("asdfajkl;kjlk;asdoiupoqweroiupoquwerzwqwerqiouz"));
        }

        [Fact]
        public void CaptureThreeNumbers(string input)
        {
            Assert.Equal(new List<int>() {1,2,3}, Regex.CaptureThreeNumbers("a1b2c3"));
        }

        [Fact]
        public void IsEmailAddress(string input)
        {
            Assert.True(Regex.IsEmailAddress("cballance@redventures.com"));
        }

        [Fact]
        public void IsUsd(string input)
        {
           Assert.True(Regex.IsUsd("$3.50"));
        }

        [Fact]
        public void IsUrl(string input)
        {
            Assert.True(Regex.IsUrl("https://google.co.uk"));
            Assert.False(Regex.IsUrl("ffp://www.google.com"));
        }
    }
}
