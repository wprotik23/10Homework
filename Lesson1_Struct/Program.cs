using System;
using Printers;

namespace Lesson1_Struct

{
    public enum Colors { Red = 3, Green = 5, White = 1, Black = 123, grey = 50 }

    public class Program
    {
        enum Month { Jan, Feb, Mar, Apr, May, Jun, Jul, Aug, Sep, Oct, Nov, Dec }
        enum LongRange:long {  Max = 9223372036854775807, Min = -9223372036854775808 }
         public static void Main(string[] args)
        {           
            int task = 0;
            while (task != 9)
            {
                Console.WriteLine("Lesson 1. Select task?(1-5) Select 9 to Exit ");
                task = Convert.ToInt32(Console.ReadLine());
                if (task == 1)
                {
                    Console.WriteLine("1.Task1. Page 11. Enter Age");
                    int n = Convert.ToInt32(Console.ReadLine());
                    Person p = new Person("Andrii", "Protasov", 28, new ConsolePrinter());
                    p.Print(n);
                }

                else if (task == 2)
                {
                    Console.WriteLine("2.Task2. Page 11. Rectangle Perimetr");
                    Rectangle r = new Rectangle(12, 23, 45, 56, new ConsolePrinter());
                    r.Print();
                }

                else if (task == 3)
                {
                    Console.WriteLine("3.Task1. Page 17. Enter Month");
                    int mon = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(Enum.GetName(typeof(Month), mon));
                }

                else if (task == 4)
                {
                    Console.WriteLine("4.Task2. Page 17.");

                    Console.WriteLine("Not yet ");
                }

                else if (task == 5)
                {
                    Console.WriteLine("5.Task3. Page 17.");

                    foreach (long l in Enum.GetValues(typeof(LongRange)))
                        Console.WriteLine(l);
                }
            }

            //Console.ReadKey();
        }
        
    }
}
