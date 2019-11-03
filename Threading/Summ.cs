using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Threading
{
    class Summ
    {
       
        public double sumAll=0;
        
        public double[,] FillArr(int n, int m, double[,] arrayNum)
        {
            Random rand = new Random();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {

                    arrayNum[i, j] = i;
                        //rand.Next(0, 1000);
                }
            }
            return arrayNum;
        }
        public void threading(int k, double[,] arrayNum)
        {
            double[] avsum = new double[k+1];
            Parallel.For(0, 100,i=>
            {                              
                    for (int j = 0; j < 100; j++)
                    {                                           
                        avsum[k]=avsum[k]+arrayNum[i, j];
                        sumAll = sumAll + arrayNum[i, j];
                    }
                
                Console.WriteLine(avsum[k]);

            }
                
                );
        }
        public void ParseArray(int k , double[,] arrayNum,double[][,] listOfArrays)
        {
            
            for (int i = 0; i < arrayNum.GetLength(0); i++)
            {
                for (int j = 0; j < arrayNum.GetLength(1); j++)
                {
                    int z = i / k;
                    listOfArrays[i % k][z, j] = arrayNum[i, j];
                }
            }


        }      
        
    }
}

