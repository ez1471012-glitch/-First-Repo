using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int[,] numbers = new int[3, 3];

            
            numbers[0, 0] = 1; 
            numbers[0, 1] = 2;
            numbers[0, 2] = 3;
           
            numbers[1, 0] = 4;
            numbers[1, 1] = 5; 
            numbers[1, 2] = 6;
            
            numbers[2, 0] = 7; 
            numbers[2, 1] = 8;
            numbers[2, 2] = 9;

            
            for (int row = 0; row < numbers.GetLength(0); row++)
            {
                for (int col = 0; col < numbers.GetLength(1); col++)
                {
                    Console.Write(numbers[row, col] + " ");
                }
                Console.WriteLine();
            }

            
            Console.ReadKey();
        }
    }
}