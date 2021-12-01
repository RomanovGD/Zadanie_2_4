using System;
using System.Text;

namespace pr2_4
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine("Задание IV.\n");            
            StringBuilder str1 = new StringBuilder();
            StringBuilder str2 = new StringBuilder();
            str1.Append(3);
            str2.Append(0);
            Console.WriteLine(str1);
            Console.WriteLine(str2);
            int k = 9;
            for (int i = 5; i > 1; i--)
            {
                for (int j = 0; j < 1; j++)
                {
                    str1.Insert(0, 2 + " ");
                    Console.Write(str1);
                }
                Console.WriteLine();
                for (int j = 0; j < 1; j++)
                {
                    str2.Insert(0, k + " ");
                    Console.Write(str2);
                    k--;
                }
                Console.WriteLine();
            }
        }
    }
}
