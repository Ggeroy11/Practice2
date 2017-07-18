using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_zadanie_5
{
    class Program
    {
        static void Main(string[] args)
        {
            const int row = 5, column = 5;
            int[,] Array = new int[row, column];
            int sum = 0;
            int coordmaxi=0,coordmaxj=0,coordmini=0,coordminj=0;
            Random rnd = new Random();
            Console.WriteLine("Двумерный массив \n");
            for (int i = 0; i < row; i++) {
                for(int j=0; j < column; j++) {
                    Array[i, j] = rnd.Next(0, 100);
                    Console.Write(Array[i, j]+" ");
                    }
                Console.WriteLine("\n");
            }
             int  maxAr = Array[0, 0];
             int minAr = Array[0, 0];
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    if (maxAr<Array[i,j]) {
                        maxAr = Array[i, j];
                        coordmaxi = i;
                        coordmaxj = j;
                    }
                    if (minAr > Array[i, j]) {
                        minAr = Array[i, j];
                        coordmini = i;
                        coordminj = j;
                    }
                }
            }
            for (int i=0;i<row ;i++) {
                for (int j=0;j<column;j++) {
                    if (coordmini == i && coordminj == j) {

                    }
                    if (coordmaxj == j && coordmaxi == i) {

                    }
                }

            }
            Console.WriteLine(" \n Минимум двумерного массива {2},\nМаксимум двумерного массива {1},\nСумма элементов массива от максимума до минимум: {0}", sum, maxAr,minAr);
            Console.ReadLine();
            
        }
    }
}
