using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        static int Add(int a, int b) => a + b;

        public float Substract(float a, float b) => a - b;

        int Multiply(int x, int y) => x * y;
    }
}
