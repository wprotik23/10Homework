using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int x = 5;
            int y = 7;
            Calc calcc = new Calc(new FileCalc());
            calcc.print(Convert.ToString(calcc.operation()));
        }
    }
}
