using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._2._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строчку ");
            string str = (Console.ReadLine()).ToUpper();
            char[] arr = str.ToCharArray();
            int count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i]== 'А')
                {
                    count++;
                }
            }
            Console.WriteLine(count);
            Console.Read();

        }
    }
}
