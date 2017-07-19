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
            char[] arrM = new char[size] { 'H', 'e', 'l', 'l', 'o' };
            char[] arrN = new char[size] { 'H', 'e', 'l', 'l', 'o' };
            char[] arrK = new char[size];

            for (int i=0; i<size;i++) {
                for (int j=0; j<size;j++) {
                    if (arrM[i] == arrN[j]) {
                        bool corect = false;
                        for (int k=0;k<size ;k++) {
                            if (arrK[k] == arrM[i]) {
                                corect = true;
                            }
                        }
                        if (!corect) {
                            arrK[count] = arrN[i];
                            count++;
                        }
                    }
                }
            }
            for (int i=0;i<arrK.Length;i++) {
                Console.WriteLine(arrK[i]);
            }
            Console.ReadLine();
        }
    }
}
