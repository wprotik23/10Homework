using System;

namespace Threading
{
    class Program
    {
        static void Main(string[] args)
        {
            double[,] arrayNum= new double[100,100];
            double[][,] listOfArrays= new  double[4][,];
            listOfArrays[0] = new double[100,100];
            listOfArrays[1] = new double[100, 100];
            listOfArrays[2] = new double[100, 100];
            listOfArrays[3] = new double[100, 100];
            Summ allsum = new Summ();

            allsum.FillArr(100, 100, arrayNum);
            for (int i=0; i < 100; i++)
            {
                Console.WriteLine(arrayNum[i,3]);
            }
            //allsum.threading(4,arrayNum);

            allsum.ParseArray(4, arrayNum, listOfArrays);

            Console.WriteLine(listOfArrays[2][1,1]);
            for (int i = 0; i < 27; i++)
            {
                Console.WriteLine(listOfArrays[0][i, 1]);
            }
        }

    }
}
