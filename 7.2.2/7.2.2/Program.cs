using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._2._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите что-то");
            string str = Console.ReadLine();
            str = str.Replace("  ", " ");
            Console.WriteLine(str);
            Console.ReadLine();
        }
    }
}
