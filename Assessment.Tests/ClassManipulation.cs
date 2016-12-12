using System;
using Assessment.Models;
using Xunit;

namespace Assessment.Tests
{
    public class ClassManiuplationTests
    {
        [Fact]
        public void Should_Create_Person()
        {
            var chris = new Person
            {
                FirstName = "Chris",
                LastName = "Ballance"
            };
            chris.SetBirthdate(new DateTime(1982, 7, 16));

            Assert.Equal("Chris", chris.FirstName);
            Assert.Equal("Ballance", chris.LastName);
            Assert.True(chris.Age > 33, "Chris is older than 33");
            Assert.True(chris.Age < 35, "Chris is younger than 35");

        }
    }
}