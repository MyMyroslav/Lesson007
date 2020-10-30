using System;

namespace Lesson007_Task2
{
    class MainClass
    {
        static string first()
        {
            while (true)
            {
                Console.WriteLine("Ви хочете вийти чи зайти (Enter or exit) ?");
                string enter = "enter";
                string exit = "exit";
                string entering = Console.ReadLine();
                if (entering == enter)
                {
                    return enter;
                }
                else if (entering == exit)
                {
                    return exit;
                }
                else
                {
                    Console.WriteLine("Bad term");
                    continue;
                }
            }

        }
        static string second()
        {
            while (true)
            {
                Console.WriteLine("Простий чи пільговий (Simple or Pilg) ?");
                string simple = "simple";
                string pilg = "pilg";
                string entering = Console.ReadLine();
                if (entering == simple)
                {
                    return simple;
                }
                else if (entering == pilg)
                {
                    return pilg;
                }
                else
                {
                    Console.WriteLine("Bad term");
                    continue;
                }
            }

        }
        static string third()
        {
            while (true)
            {
                Console.WriteLine("Заплатіть 7грн");
                string pay = Console.ReadLine();

                if (pay == "7")
                {
                    return pay;
                }
                if (pay != "7")
                {
                    Console.WriteLine("bad term");
                    continue;

                }

            }
        }
        static string fourth()
        {
            while (true)
            {
                Console.WriteLine("Заплатіть 3грн");
                string pay = Console.ReadLine();

                if (pay == "3")
                {
                    return pay;
                }
                if (pay != "3")
                {
                    Console.WriteLine("bad term");
                    continue;

                }

            }
        }
        static void countSize(int count)
        {
            Console.WriteLine($"Entered people: {count}");
        }
        public static void Main(string[] args)
        {

            Console.OutputEncoding = System.Text.Encoding.UTF8;
            int count = 0;
            while (count <= 21)
            {
                string answer = first();
                if (answer == "enter")
                {


                    string answer2 = second();
                    if (answer2 == "simple")
                    {
                        string payment = third();
                        if (payment == "7")
                        {
                            Console.WriteLine("Ви успішно війшли");
                            count++;
                            countSize(count);
                            continue;

                        }
                        countSize(count);
                    }

                    else if (answer2 == "pilg")
                    {


                        string payment = fourth();
                        if (payment == "3")
                        {
                            Console.WriteLine("Ви успішно війшли");
                            count++;
                            countSize(count);
                            continue;

                        }

                    }
                }

                else if (answer == "exit")
                {
                    Console.WriteLine("Щасливої дороги");
                    count--;
                    countSize(count);
                    continue;
                }
                countSize(count);


            }

        }

    }

}
   






