using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Return_Statement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cubeNumber = cube(6);
            Console.WriteLine(cubeNumber);
            Console.ReadLine();
        }
        static int cube(int num) 
        {
            int result = num * num * num;
            return result;
        }
    }
}
