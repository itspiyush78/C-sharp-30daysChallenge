using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace For_Loop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] luckyumbers = { 2, 8, 9, 10, 11, 12, 13, 14, };
            for (int i = 0; i < luckyumbers.Length; i++)
            {
                Console.WriteLine(luckyumbers[i]);
            }


            Console.ReadLine();
        }
    }
}
