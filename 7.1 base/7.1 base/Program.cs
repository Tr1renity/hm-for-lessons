using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._1_base
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[] chars = new char[10];
            for (int i = 0;i< chars.Length; i++)
            {
                chars[i] = '*'; 
            }
            for (int i = 0; i < chars.Length; i++)
            {
                Console.Write(chars[i] + "\t");
            }
            Console.Read();
        }
    }
}
