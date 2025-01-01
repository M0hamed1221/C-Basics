using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ass04
{
    internal class Program
    {
        static void Main(string[] args)

        {

            #region Write a program to allow the user to enter a string and print the REVERSE of it.

            string intput = Console.ReadLine();
                   string output=     (intput.Reverse()).ToString();
            Console.WriteLine(output);
            #endregion
        }
    }
}
