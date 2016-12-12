using Xunit;

namespace Assessment.Tests
{
    public class LogicalOperatorTests
    {
        [Fact]
        public void Should_Verify_Or()
        {
            Assert.True(LogicalOperators.Or(true, true));
            Assert.True(LogicalOperators.Or(false, true));
            Assert.True(LogicalOperators.Or(true, false));
            Assert.False(LogicalOperators.Or(false, false));
        }

        [Fact]
        public void Should_Verify_And()
        {
            Assert.True(LogicalOperators.And(true, true));
            Assert.False(LogicalOperators.And(false, true));
            Assert.False(LogicalOperators.And(true, false));
            Assert.False(LogicalOperators.And(false, false));
        }

        [Fact]
        public void Should_Verify_Xor()
        {
            Assert.False(LogicalOperators.Xor(true, true));
            Assert.True(LogicalOperators.Xor(false, true));
            Assert.True(LogicalOperators.Xor(true, false));
            Assert.False(LogicalOperators.Xor(false, false));
        }

        [Fact]
        public void Should_Verify_Nand()
        {
            Assert.False(LogicalOperators.Nand(true, true));
            Assert.True(LogicalOperators.Nand(false, true));
            Assert.True(LogicalOperators.Nand(true, false));
            Assert.True(LogicalOperators.Nand(false, false));
        }
    }
}