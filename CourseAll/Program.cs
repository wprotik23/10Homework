using System;
using Lesson1_Struct;


namespace CourseAll
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Main Program. Select lesson?(1,2,3) ");
            int lesson = Convert.ToInt32(Console.ReadLine());
            if (lesson == 1)
            {
                Lesson1_Struct.Program.Main(args);
            }

            if (lesson == 2)
            {

                try
                {
                    Lesson2_Exceptions.ExeptionsMain.MainEx();
                }
                catch (Exception) 
                { 
                }
               
            }
            if (lesson == 3)
            {
                try
                {
                    Lesson3_IOStream.MainIO.MainIOStream();
                }
                catch 
                { 
                }
            }
        }
    }
}
