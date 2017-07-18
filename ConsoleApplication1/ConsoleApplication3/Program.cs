using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            string text=Console.ReadLine() ;
            string[] test = text.Split(' ');
            foreach (string s in test) {
                count++; 
            }
            Console.WriteLine("Количество слов в строке {0}", --count);
            Console.ReadLine();
        }
    }
}
