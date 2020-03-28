using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //
            var (x, y) = GetPoint(200, 300);
            Console.WriteLine("x:" + x);
            Console.WriteLine("y:" + y);

            Console.ReadKey();

        }

        #region Tuples
        public static (int x, int y) GetPoint(int x, int y)
        {
            return (x, y);
        }
        #endregion

        abstract class Shape { };
    }

}
