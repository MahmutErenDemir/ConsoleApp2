using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class dizi
    {
        static void Main(string[] args)
        {
            string[] boolArray = new string[3];
            boolArray[0] = "true";
            boolArray[1] = "false";
            boolArray[2] = "true";
            
            int[] sum = { 1, 5, 9 };
            
            for (int i = 0; i < boolArray.Length; i++)
            {
                Console.WriteLine(boolArray[i]);
                Console.WriteLine(boolArray.Length);
                Console.WriteLine(sum[i]);

            }
            int[,] matrix = new int[3,3] ;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.WriteLine("enter" + i + j + "element");
                    
                    matrix[i, j] = Convert.ToInt32(Console.ReadLine());

                }
            }

            for (int i = 0; i <3; i++)
            {
                for (int j = 0; j < 3; j++)
                {    
                    Console.Write(matrix[i, j] + "\t ");
                   

                }
                     Console.WriteLine();
            }
            int[] sumn = { 1, 2, 3 };
        Console.WriteLine(sumn.IsReadOnly);
        sumn[2] = 12;
        }
       

    }
}
