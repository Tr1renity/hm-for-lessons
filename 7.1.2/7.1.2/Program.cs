using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._1._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите кол-во элементов массива:");
            int n = int.Parse(Console.ReadLine());
            string[] chars = new string[n];
            Random rnd = new Random(); 
            int[] ranom = new int[1];
            for (int i = 0; i < n; i++)
            {
                if(rnd.Next(0,100) <=50)
                {
                    chars[i]= "i";
                }
                else
                {
                    chars[i] = "/i";
                }
            }
            for (int i = 0; i < n; i++)
            {
                Console.Write(chars[i] + "\t");
            }
            Console.WriteLine("");
            Console.WriteLine("массив");
            for (int i = 0; i < n; i++)
            {
                if (chars[i].StartsWith("/i"))
                {
                    chars[i] = "#";
                }
            }
            for (int i = 0; i < n; i++)
            {
                if (chars[i].StartsWith("i")) 
                {
                    chars[i] = "/i";
                }
            }
            for (int i = 0; i < n; i++)
            {
                Console.Write(chars[i] + "\t");
            }
            Console.ReadKey();

        }
    }
}
