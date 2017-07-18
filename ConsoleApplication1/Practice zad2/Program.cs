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
            int count = 0;
            char[] M = new char[size] { 'H', 'e', 'l', 'l', 'o' };
            char[] N = new char[size] { 'W', 'o', 'r', 'l', 'd' };
            char[] K = new char[10];

            for (int i=0; i<size;i++) {
                for (int j=0; j<size;j++) {
                    if (M[i] == N[j]) {
                        for (int k=0;k<count ;k++) {
                            if (K[k] == M[i]) {
                                K[count] = M[i];
                                count++;
                            }
                        }
                    }
                }
            }
            for (int i=0;i<count;i++) {
                Console.WriteLine(K[i]);
            }
            Console.ReadLine();
        }
    }
}
