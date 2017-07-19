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
            int[,] array = new int[row, column];
            int coordmaxi=0,coordmaxj=0,coordmini=0,coordminj=0;
            Random rnd = new Random();
            Console.WriteLine("Двумерный массив \n");
            for (int i = 0; i < row; i++) {
                for(int j=0; j < column; j++) {
                    array[i, j] = rnd.Next(0, 100);
                    Console.Write(array[i, j]+" ");
                    }
                Console.WriteLine("\n");
            }
             int  maxAr = array[0, 0];
             int minAr = array[0, 0];
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    if (maxAr<array[i,j]) {
                        maxAr = array[i, j];
                        coordmaxi = i;
                        coordmaxj = j;
                    }
                    if (minAr > array[i, j]) {
                        minAr = array[i, j];
                        coordmini = i;
                        coordminj = j;
                    }
                }
            }
            if (coordmini < coordmaxi) {
                int tmp = coordmaxi;
                coordmaxi = coordmini;
                coordmini = tmp;
            }
            if (coordmini>coordmaxi) {
                int tmp = coordmini;
                coordmini = coordmaxi;
                coordmaxi = tmp;
            }
            int sum = 0;
            for (int i = coordmini; i <=coordmaxi; i++)
            {
                int j = 0;
                if (i == coordmini)
                    j = coordminj;
                for (; j < column; j++)
                {
                    sum += array[i, j];
                    if (i == coordmaxi && j == coordmaxj)
                        break;
                }
            }
            
            Console.WriteLine(" \n Минимум двумерного массива {2},\nМаксимум двумерного массива {1},\nСумма элементов массива от максимума до минимум: {0}", sum, maxAr,minAr);
            Console.ReadLine();
            
        }
    }
}
