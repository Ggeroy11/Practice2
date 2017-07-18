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
            int[] A = new int[size];
            int[,] B = new int[row, column];
            Console.WriteLine("\nОдномерный массив");
            for (int i = 0; i < A.Length; i++)
            {
                string number = Console.ReadLine();
                A[i] = Int32.Parse(number);
            }
            Random rnd = new Random();
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    B[i, j] = rnd.Next(0, 100);
                }
            }
            Console.WriteLine("\nДвумерный массив\n");
            for (int i=0;i<row;i++) {
                for (int j=0;j<column;j++) {
                    Console.Write(B[i, j]+" ");
                }
                Console.WriteLine("\n");
            }
            int maxA = A[0];
            int minA = A[0];
            int maxB = B[0, 0];
            int minB = B[0, 0];

            for (int i = 0; i < A.Length; i++)
            {
                if (maxA < A[i])
                {
                    maxA = A[i];
                }
                else if (minA > A[i])
                {
                    minA = A[i];
                }
            }

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    if (maxB < B[i, j])
                    {
                        maxB = B[i, j];
                    }
                    else if (minB > B[i, j])
                    {
                        minB = B[i, j];
                    }
                }
            }
            string output = String.Format("Минимум A {0} , Максимум A {1}, Минимум B {2},Максимум B {3}", minA, maxA, minB, maxB);
            Console.WriteLine(output);
            Console.ReadLine();
        }
    }
}
