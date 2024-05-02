using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2D_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] numberGrid =
            {
                {4, 2 },
                {3, 7 },
                {6, 8 },
            };

            Console.WriteLine(numberGrid[0,1]);


            Console.ReadLine();
        }
    }
}
