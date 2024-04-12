using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._1._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] arr = { "A", "B", "O", "B", "A" };
            int count = 0;
            for (int i = 0; i < 3; i++)
            {
                if(arr[i]== arr[4 - i])
                {
                    count++;
                    if (count == 2)
                    {
                        Console.WriteLine("да абоба палиндром");
                    }
                } 
            }
        }
    }
}
