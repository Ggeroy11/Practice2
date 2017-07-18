using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_zad2
{
    class Program
    {
        static void Main(string[] args)
        {
            const int size = 5;
            const int sizeK = 10;
            char[] M = new char[size] { 'H', 'e', 'l', 'l', 'o' };
            char[] N = new char[size] { 'W', 'o', 'r', 'l', 'd' };
            char[] K = new char[sizeK] ;
            for (int i=0;i<size;i++) {
                K[i] = M[i];
                if (i == 4) {
                    for (int j=5,k=0 ;j<sizeK;j++,k++) {
                        K[j] = N[k];
                    }
                }
            }
            for (int i=0;i<sizeK;i++) {
                if (i < size)
                {
                    Console.Write(K[i]);
                }
                else if (i == size)
                {
                    Console.Write(" "+K[i]);
                }
                else {
                    Console.Write(K[i]);
                }
            }
            Console.ReadLine();
        }
    }
}
