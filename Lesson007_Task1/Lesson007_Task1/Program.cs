using System;

namespace Lesson007_Task1
{
    class MainClass
    {
       static void Calculate (byte a, sbyte b)
        {
            Console.WriteLine(a + b);

        }
        static void Calculate(short a, ushort b)
        {
            Console.WriteLine(a + b);

        }
        static void Calculate(int a, uint b)
        {
            Console.WriteLine(a + b);

        }
        static void Calculate(long a, ulong b)
        {
            Console.WriteLine(a + (long)b);

        }
        public static void Main(string[] args)
        {
            short a = 2;
            ushort b = 3;
            byte c = 1;
            sbyte d = 5;
            int e = 12;
            uint f = 18;
            long g = 24;
            ulong  h= 31;
            Calculate(a, b);
            Calculate(c, d);
            Calculate(e, f);
            Calculate(g, h);


        }
    }
}
