using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Ass004
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Write a program to allow the user to enter a string and print the REVERSE of it.

            //Console.WriteLine("insert your string");
            //string intput = Console.ReadLine();
            //string output = new string (intput.Reverse().ToArray());
            //Console.WriteLine(output);

            /*Anthore solution*/

            //Console.WriteLine("Insert your string:");
            //string input = Console.ReadLine();
            //char[] outputArray = new char[input.Length];

            //for (int i = 0; i < input.Length; i++)
            //{
            //    outputArray[i] = input[input.Length - 1 - i];

            //}
            //Console.WriteLine(outputArray);
            #endregion
            #region Write a program to allow the user to enter int and print the REVERSED of it.


            //Console.WriteLine("insert your number");
            //bool reslut;
            //int input;
            // reslut = int.TryParse(Console.ReadLine(),out input) ;

            //if (reslut)
            //{


            //    char[] numberArray = input.ToString().ToCharArray();
            //    Array.Reverse(numberArray);

            //    string reversedNumber = new string(numberArray);

            //    Console.WriteLine("Reversed number:");
            //    Console.WriteLine(reversedNumber);

            //}


            #endregion

            #region Write a program in C# Sharp to find prime numbers within a range of numbers.
            //Console.WriteLine("Prime numbers between 1 and 50:");

            //string output = ""; 
            //int rangeStart = 1, rangeEnd = 50;

            //for (int i = rangeStart; i <= rangeEnd; i++)
            //{
            //    bool isPrime = true;

            //    if (i <= 1) // Numbers 0 and 1 are not prime
            //    {
            //        continue;
            //    }

            //    for (int j = 2; j <= Math.Sqrt(i); j++) 
            //    {
            //        if (i % j == 0) 
            //        {
            //            isPrime = false;
            //            break; // Exit the loop early for efficiency
            //        }
            //    }

            //    if (isPrime)
            //    {
            //        output += i + ", ";
            //    }
            //}

            //Console.WriteLine(output); /**/


            #endregion
            #region . Write a program in C# Sharp to convert a decimal number into binary without using an array.

            //Console.WriteLine("Enter a decimal number:");
            //if (int.TryParse(Console.ReadLine(), out int decimalNumber))
            //{
            //    string binaryNumber = "";

            //    // avoid the case if the entered num is zero 
            //    if (decimalNumber == 0)
            //    {
            //        binaryNumber = "0";
            //    }
            //    else
            //    {
            //        while (decimalNumber > 0)
            //        {
            //            int remainder = decimalNumber % 2; // Get the remainder (0 or 1)
            //            binaryNumber = remainder + binaryNumber; // Prepend to the binary string
            //            decimalNumber /= 2; // Divide by 2
            //        }
            //    }

            //    Console.WriteLine($"Binary representation: {binaryNumber}");
            //}
            //else
            //{
            //    Console.WriteLine("Invalid input. Please enter a valid decimal number.");
            //}

            #endregion

            #region .Create a program that asks the user to input three points (x1, y1), (x2, y2), and (x3, y3), and determines whether these points lie on a single straight line.

            /* so the point be in a strauight line the distance between the y point get repeated in the three point or the x get repeated so it be striaght virtically or hiroziontally */
            // Console.WriteLine("Enter the coordinates of the first point (x1, y1):");
            // Console.Write("x1: ");
            // double x1 = double.Parse(Console.ReadLine());
            // Console.Write("y1: ");
            // double y1 = double.Parse(Console.ReadLine());

            // Console.WriteLine("Enter the coordinates of the second point (x2, y2):");
            // Console.Write("x2: ");
            // double x2 = double.Parse(Console.ReadLine());
            // Console.Write("y2: ");
            // double y2 = double.Parse(Console.ReadLine());

            // Console.WriteLine("Enter the coordinates of the third point (x3, y3):");
            // Console.Write("x3: ");
            // double x3 = double.Parse(Console.ReadLine());
            // Console.Write("y3: ");
            // double y3 = double.Parse(Console.ReadLine());

            // /*by Logic */

            // if (x1== x2 && x2 == x3)
            // {


            //     Console.WriteLine("the point are in line hrizaontally");
            // }
            // else if (y1 == y2 && y2 == y3)
            // {
            //     Console.WriteLine("the point are in line virtically");

            // }

            //else 
            // {
            //     Console.WriteLine("the point are not in line");

            // }
            // /*by math */

            // if((y2 - y1) * (x3 - x1) == (y3 - y1) * (x2 - x1))
            // {
            //     Console.WriteLine("the point are in line");

            // }
            #endregion
            #region
            //Within a company, the efficiency of workers is evaluated based on the duration required to complete a specific task. A worker's efficiency level is determined as follows: 
            //            -If the worker completes the job within 2 to 3 hours, they are considered highly efficient.
            //            - If the worker takes 3 to 4 hours, they are instructed to increase their speed.
            //            - If the worker takes 4 to 5 hours, they are provided with training to enhance their speed.
            //            - If the worker takes more than 5 hours, they are required to leave the company.
            //To calculate the efficiency of a worker, the time taken for the task is obtained via user input from the keyboard.
    
                //Console.WriteLine("Enter the time (in hours) taken by the worker to complete the task:");
                //double timeTaken;

                //// Try to parse the input
                //if (double.TryParse(Console.ReadLine(), out timeTaken))
                //{
                //    // Evaluate efficiency based on time taken
                //    if (timeTaken >= 2 && timeTaken <= 3)
                //    {
                //        Console.WriteLine("The worker is highly efficient.");
                //    }
                //    else if (timeTaken > 3 && timeTaken <= 4)
                //    {
                //        Console.WriteLine("The worker needs to increase their speed.");
                //    }
                //    else if (timeTaken > 4 && timeTaken <= 5)
                //    {
                //        Console.WriteLine("The worker needs training to enhance their speed.");
                //    }
                //    else if (timeTaken > 5)
                //    {
                //        Console.WriteLine("The worker is required to leave the company.");
                //    }
                //    else
                //    {
                //        Console.WriteLine("The time entered is invalid (less than 2 hours). Please input a time greater than or equal to 2 hours.");
                //    }
                //}
                //else
                //{
                //    Console.WriteLine("Invalid input! Please enter a valid number for the time.");
                //}
       



        #endregion

    }
}
}