using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            bool polin = true;
            Console.WriteLine("Введите строку");
            string text1 = Console.ReadLine();
            for (int i = 0; i < text1.Length/2; i++)
            {
                if (text1[i]!=text1[text1.Length-i-1]) {
                    polin = false;
                }
            }
            if (polin == false)
            {
                Console.WriteLine("Не палидром");
            }
            else {
                Console.WriteLine("Палидром");
            }
            
            Console.ReadLine();
        }
    }
}
