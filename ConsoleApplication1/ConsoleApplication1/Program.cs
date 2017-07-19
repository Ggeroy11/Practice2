using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите 5 чисел для заполнения одномерного массива");
            const int size = 5;
            const int row = 3;
            const int column = 4;
            int[] arrA = new int[size];
            int[,] arrB = new int[row, column];
            Console.WriteLine("\nОдномерный массив");
            for (int i = 0; i < arrA.Length; i++)
            {
                string number = Console.ReadLine();
                arrA[i] = Int32.Parse(number);
            }
            Random rnd = new Random();
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    arrB[i, j] = rnd.Next(0, 100);
                }
            }
            Console.WriteLine("\nДвумерный массив\n");
            for (int i=0;i<row;i++) {
                for (int j=0;j<column;j++) {
                    Console.Write(arrB[i, j]+" ");
                }
                Console.WriteLine("\n");
            }
            int maxA = arrA[0];
            int minA = arrA[0];
            int maxB = arrB[0, 0];
            int minB = arrB[0, 0];

            for (int i = 0; i < arrA.Length; i++)
            {
                if (maxA < arrA[i])
                {
                    maxA = arrA[i];
                }
                else if (minA > arrA[i])
                {
                    minA = arrA[i];
                }
            }

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    if (maxB < arrB[i, j])
                    {
                        maxB = arrB[i, j];
                    }
                    else if (minB > arrB[i, j])
                    {
                        minB = arrB[i, j];
                    }
                }
            }
           //делай до конца;
            Console.WriteLine("Минимум arrA {0} , Максимум arrA {1}, Минимум arrB {2},Максимум arrB {3}", minA, maxA, minB, maxB);
            
            Console.ReadLine();
        }
    }
}
