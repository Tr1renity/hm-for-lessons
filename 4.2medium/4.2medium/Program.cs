using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._2medium
{
    internal class Program
    {

        static void Main(string[] args)
        {
            int[,] myarray = new int[4, 4];
            int count = 0;
            int temp;
            int k = 0;
            int t = 0;
            bool diman = true;
            Random rnd = new Random();
            for (int i = 0; i < myarray.GetLength(0); i++)
            {
                for (int j = 0; j < myarray.GetLength(1); j++)
                {
                    myarray[i, j] = rnd.Next(-25, 25);
                }
            }
            for (int i = 0; i < myarray.GetLength(0); i++)
            {
                for (int j = 0; j < myarray.GetLength(1); j++)
                {
                    Console.Write(myarray[i, j] + "\t");
                }
                Console.WriteLine("");
            }
            for (int i = 0; i < myarray.GetLength(0) & diman; i++)
            {
                for (int j = 0; j < myarray.GetLength(1) & diman; j++)
                {
                    if (count == 2)
                    {
                        k = i;
                        t = j;
                        diman = false;
                        break;
                    }
                    if (myarray[i, j] < 0)
                    {
                        count++;
                    }
                }
            }
            diman = true;
            int g = k;
            int h = t;
            for (; g < myarray.GetLength(0) && diman; g++)
            {
                for (; h < myarray.GetLength(1) && diman; h++)
                {
                    if (g == myarray.GetLength(0) - 1 && h == myarray.GetLength(1) - 1)
                    {
                        diman = false;
                        break;
                    }
                    int q = g;
                    int r = h;
                    if (r + 1 < myarray.GetLength(1))
                    {
                        for (q = g; q < myarray.GetLength(0); q++)
                        {
                            for (r += 1; r < myarray.GetLength(1); r++)
                            {
                                if (myarray[g, h] < myarray[q, r])
                                {
                                    temp = myarray[g, h];
                                    myarray[g, h] = myarray[q, r];
                                    myarray[q, r] = temp;
                                }
                            }
                            r = -1;
                        }
                    }
                    else
                    {
                        for (q += 1; q < myarray.GetLength(0); q++)
                        {
                            for (r = 0; r < myarray.GetLength(1); r++)
                            {
                                if (myarray[g, h] < myarray[q, r])
                                {
                                    temp = myarray[g, h];
                                    myarray[g, h] = myarray[q, r];
                                    myarray[q, r] = temp;
                                }
                            }
                        }
                        q = -1;
                    }
                }
                h = 0;
            }
            Console.WriteLine();
            for (int i = 0; i < myarray.GetLength(0); i++)
            {
                for (int j = 0; j < myarray.GetLength(1); j++)
                {
                    Console.Write(myarray[i, j] + "\t");
                }
                Console.WriteLine("");
            }
            Console.Read();
        }

    }
}
