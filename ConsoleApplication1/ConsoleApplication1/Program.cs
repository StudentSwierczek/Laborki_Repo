using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class Program
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public static int Add(int a, int b) => a + b;

        public float Substract(float a, float b) => a - b;

        int Multiply(int x, int y) => x * y;
    }
}
