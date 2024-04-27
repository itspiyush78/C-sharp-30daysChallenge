using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace While_loop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int index = 1;
            while (index <= 8)
            {
                Console.WriteLine(index);
                index++;
            }

            Console.ReadLine();
        }
    }
}
