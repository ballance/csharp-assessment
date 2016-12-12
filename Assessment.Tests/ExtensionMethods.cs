using Xunit;

namespace Assessment.Tests
{
    public class ExtensionMethodTests
    {
        [Fact]
        public void Should_Reverse_String_With_Extension_Method()
        {
            var reversed = "The quick brown fox jumps over the lazy dog.".Reverse();
            var reversedExpected = ".god yzal eht revo spmuj xof nworb kciuq ehT";
            Assert.Equal(reversedExpected, reversed);
        }
    }
}