using System;

namespace Lesson2_Exceptions
{
    public static class ExeptionsMain
    {
        public static void MainEx()
        {

            Console.WriteLine("Select Task");
            int task = Convert.ToInt32(Console.ReadLine());
            if (task == 1)
            {
                OverflowMethod();
            }
            else if (task == 2)
            {
                try
                {
                    RangeMethod();
                }
                catch (IndexOutOfRangeException)
                {
                    Console.WriteLine("Index Out of Range Exception");
                    
                }
            }

        } 
        public static void OverflowMethod()
            
        {
                OverflowMethod();
            
        }
        public static void RangeMethod()
        {
            int[] arr = { 1, 2, 3, 5 };
            for (int i = 0; i < 10; i++)
            {
                arr[i] = 8;
            }
        }

    }
}
