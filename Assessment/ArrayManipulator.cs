using System;

namespace Assessment
{
    public class ArrayManipulator
    {
        private int[] _currentArray;

        public ArrayManipulator() : this(null) { }

        public ArrayManipulator(int[] initialArray)
        {
            _currentArray = initialArray ?? new int[0];
        }

        public int Sum(int[] input)
        {
            return -1;
        }

        public int[] Remove(int indexToRemove)
        {
            return _currentArray;
        }

        public int[] RemoveWithoutCopy(int indexToRemove)
        {
            return _currentArray;
        }

        public int[] Append(int toAppend)
        {
            return _currentArray;
        }

        public int[] Truncate(int placesToTruncate)
        {
            return _currentArray;
        }

        public int[] Prepend(int toPrepend)
        {
            return _currentArray;
        }

        public int[] Concat(int[] left, int[] right)
        {
            return _currentArray;
        }

        public int[] Insert(int item, int index)
        {
            return new[] { 1 };

        }

        public int Count(int[] input)
        {
            return -1;
        }

        public int[] Duplicates(int[] input)
        {
            return new[] { 1 };
        }

        public int[] Square()
        {
            return _currentArray;
        }

        public int[] FindAllOccurrances(int occuranceToFind)
        {
            return new[] { 1 };
        }
    }
}