using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._2
{
    internal class Program
    {
        static void sorting(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int j= 0; j < array.Length; j++)
                {
                    if (array[i] < array[j])
                    {
                        int temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            int[,] myarray = new int[3, 4];
            Random rnd = new Random();
            for (int i = 0; i < myarray.GetLength(0); i++)
            {
                for (int j = 0; j < myarray.GetLength(1); j++)
                {
                    myarray[i, j] = rnd.Next(50);
                }
            }
            Console.WriteLine("\tИзначальный массив\t");
            for (int i = 0; i < myarray.GetLength(0); i++)
            {
                for (int j = 0; j < myarray.GetLength(1); j++)
                {
                    Console.Write(myarray[i,j] + "\t");
                }
                Console.WriteLine("");
            }
            Console.WriteLine("");
            int[] lastrow = new int[4];
            for (int i =2; i <3; i++)
            {
                for (int j = 0; j < 4; j++)
                    lastrow[j] = myarray[i, j];
                sorting(lastrow);
            }
            for (int k = 0; k < lastrow.Length; k++)
            {
                myarray[2,k] = lastrow[k];
            }
            Console.WriteLine("\tОтсортированная последняя строка\t");
            for (int i = 0; i < myarray.GetLength(0); i++)
            {
                for (int j = 0; j < myarray.GetLength(1); j++)
                {
                    Console.Write(myarray[i, j] + "\t");
                }
                Console.WriteLine("");
            }
            Console.ReadKey();
        } 
    }
}
