using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string[,] names = new string[,]
            {
                { "Ali", "Hassan" },
                { "Arooj", "Arbab" },
                { "Amna", "Areej" },
                { "Noor", "Zaib" }
            };

           
            for (int i = 0; i <= names.GetUpperBound(0); i++)
            {
                string firstName = names[i, 0];
                string lastName = names[i, 1];

                Console.WriteLine("{0} {1}", firstName, lastName);
            }

            Console.ReadLine();
        }
    }
}