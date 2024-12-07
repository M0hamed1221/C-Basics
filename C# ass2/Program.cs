using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__ass2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Qst1

            Console.WriteLine("Please Enter Your Number:");

            if (int.TryParse(Console.ReadLine(), out int input))
            {
                Console.WriteLine("Your number is {0}", input);
            }
            else
            {
                Console.WriteLine(" Please enter a valid number.");
            }
            #endregion

        }
    }
}
