using System;
using Xunit;

namespace Assessment.Tests
{
    public class ArrayManipulationTests
    {
        //[Fact]
        public void Should_Append_To_Array()
        {
            var countToTenArrayInitial = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            var countToTendAppended = new []{ 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 };

            var arrayManipulator = new ArrayManipulator(countToTenArrayInitial);

            var countToTenArrayResult = arrayManipulator.Append(11);

            Assert.Equal(countToTendAppended.Length, countToTenArrayResult.Length);

            for (var i = 0; i < countToTenArrayResult.Length; i++)
            {
                Assert.Equal(countToTendAppended[i], countToTenArrayResult[i]);
            }
        }

        //[Fact]
        public void Should_Truncate_Array()
        {
            var countToTenArrayInitial = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            var conuntToTenTruncatedExpected = new int[] { 1, 2, 3, 4, 5, 6, 7};

            var arrayManipulator = new ArrayManipulator(countToTenArrayInitial);

            var conuntToTenTruncated = arrayManipulator.Truncate(3);

            Assert.Equal(conuntToTenTruncated.Length, conuntToTenTruncatedExpected.Length);

            for (var i = 0; i < conuntToTenTruncated.Length; i++)
            {
                Assert.Equal(conuntToTenTruncated[i], conuntToTenTruncatedExpected[i]);
            }
        }

        //[Fact]
        public void Should_Prepend_TO_Array()
        {
            var countToTenArrayInitial = new [] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            var countToTenPrependedExpected = new [] { 42, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            var arrayManipulator = new ArrayManipulator(countToTenArrayInitial);

            var countToTenPrepended = arrayManipulator.Prepend(42);

            Assert.Equal(countToTenPrepended.Length, countToTenPrepended.Length);

            for (var i = 0; i < countToTenPrepended.Length; i++)
            {
                Assert.Equal(countToTenPrepended[i], countToTenPrependedExpected[i]);
            }
        }

        //[Fact]
        public void Should_Concatenate_Arrays()
        {
            var countToTenInitialLeft = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            var countToTenInitialRight= new[] { 21, 22, 23, 24, 25, 26, 27, 28, 29, 30 };
            var countToTenConcatenatedExpected = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30 };

            var arrayManipulator = new ArrayManipulator();

            var countToTenConcatenated = arrayManipulator.Concat(countToTenInitialLeft, countToTenInitialRight);

            Assert.Equal(countToTenConcatenatedExpected.Length,
                countToTenInitialLeft.Length + countToTenInitialRight.Length);

            for (var i = 0; i < countToTenConcatenated.Length; i++)
            {
                Assert.Equal(countToTenConcatenated[i], countToTenConcatenatedExpected[i]);
            }

            Assert.Equal(countToTenConcatenatedExpected, countToTenConcatenated);
        }

        //[Fact]
        public void Should_Sum_Array()
        {
            var countToTenInitial = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            var sumExpected = 55;

            var arrayManipulator = new ArrayManipulator();

            var sumActual = arrayManipulator.Sum(countToTenInitial);

            Assert.Equal(sumExpected, sumActual);
        }

        //[Fact]
        public void Should_Remove_Specified_Index_From_Array()
        {
            var countToTenArrayInitial = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            var countToTenRemovedExpected = new[] { 1, 2, 3, 4, 6, 7, 8, 9, 10 };

            var arrayManipulator = new ArrayManipulator(countToTenArrayInitial);

            var countToTenRemoved = arrayManipulator.Remove(4);

            Assert.Equal(countToTenRemovedExpected.Length, countToTenRemoved.Length);

            for (var i = 0; i < countToTenRemovedExpected.Length; i++)
            {
                Assert.Equal(countToTenRemovedExpected[i], countToTenRemoved[i]);
            }
        }

        //[Fact]
        public void Should_Remove_Specified_Index_From_Array_Without_Copy()
        {
            var countToTenArrayInitial = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            var countToTenRemovedExpected = new[] { 1, 2, 3, 4, 5, 6, 8, 9, 10 };

            var arrayManipulator = new ArrayManipulator(countToTenArrayInitial);

            var countToTenRemoved = arrayManipulator.RemoveWithoutCopy(6);

            Assert.Equal(countToTenRemovedExpected.Length, countToTenRemoved.Length);

            for (var i = 0; i < countToTenRemovedExpected.Length; i++)
            {
                Assert.Equal(countToTenRemovedExpected[i], countToTenRemoved[i]);
            }
        }

        //[Fact]
        public void Should_Square_Each_Array_Index()
        {
            var countToTenArrayInitial = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            var countToTenSquaredExpected = new[] { 1, 4, 9, 16, 25, 36, 49, 64, 81, 100 };

            var arrayManipulator = new ArrayManipulator(countToTenArrayInitial);

            var countTenSquared = arrayManipulator.Square();

            Assert.Equal(countToTenSquaredExpected.Length, countTenSquared.Length);

            for (var i = 0; i < countToTenSquaredExpected.Length; i++)
            {
                Assert.Equal(countToTenSquaredExpected[i], countTenSquared[i]);
            }
        }
    }
}
