using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assessment.Driver
{
    public class Program
    {
        public static void Main(string[] args)
        {
            RunArrays();
            Console.WriteLine("Done.");
            Console.ReadKey();
        }

        public static void RunArrays()
        {
            var arrays = new ArrayManipulator();

            int test = arrays.Sum(new int[]{ 1, 2, 3});


        }
    }
}
