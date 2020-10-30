using System;

namespace Lesson007_Task3
{
    class MainClass
    {

        static int counter(int a)
        {
            if (a == 1)
                return 1;
            return a + counter(a - 1);

        }
        public static void Main(string[] args)
        {
            
            Console.WriteLine(counter(6));
        }
    }
}
