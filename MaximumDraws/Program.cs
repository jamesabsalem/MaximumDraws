using System;
using System.Collections.Generic;

namespace MaximumDraws
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int> { 1, 2 };
            foreach (var i in list)
            {
                var x=  maximumDraws(i);
                Console.WriteLine(x);
            }
        }
        public static int maximumDraws(int n)
        {
            return 1 + n;
        }
    }
}
