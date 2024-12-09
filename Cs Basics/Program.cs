using System.Data.SqlTypes;

namespace Cs_Basics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region  Q1:Write a program that allows the user to enter a number then print it.

            //Console.WriteLine("Please Enter Your Number:");

            //if (int.TryParse(Console.ReadLine(), out int input))
            //{
            //    Console.WriteLine("Your number is {0}", input);
            //}
            //else
            //{
            //    Console.WriteLine("Please enter a valid number.");
            //}
            #endregion
            #region Q2:Write C# program that converts a string to an integer, but the string contains non-numeric characters. And mention what will happen 


            //string S1 = "m1221";
            //int num = (int)S1; /*Error	CS0030	Cannot convert type 'string' to 'int'*/

            //string S1 = "m1221";
            //int num = Convert.ToInt32(S1); /*The input string 'm1221' was not in a correct format.'*/



            //Console.WriteLine("Please enter a string to convert to an integer:");
            //string input = Console.ReadLine();

            //// use try.parse to check if it will work or not 
            //if (int.TryParse(input, out int safeNumber))
            //{
            //    Console.WriteLine($"tryparse succeeded , The int value : {safeNumber}");
            //}
            //else
            //{
            //    Console.WriteLine("tryparse failed! The string contains non_numaric values.");
            //}

            #endregion

            #region Q3:Write C# program that Perform a simple arithmetic operation with floating-point numbers And mention what will happen


            //decimal num1 = 0.1;
            //decimal num2 = 0.2;

            //decimal sum = num1 + num2;

            //Console.WriteLine($"The precise sum of {num1} and {num2} is: {sum}");


            /*Severity	Code	Description	Project	File	Line	Suppression State
Error	CS0664	Literal of type double cannot be implicitly converted to type 'decimal'; use an 'M' suffix to create a literal of this type	Cs Basics	D:\Mohamed\C# ass2\Cs Basics\Program.cs	49	Active
*/
            //decimal num1 = 0.1m;
            //decimal num2 = 0.2m;

            //decimal sum = num1 + num2;

            //Console.WriteLine($"The precise sum of {num1} and {num2} is: {sum}");



            #endregion
            #region Q4 :Write C# program that Extract a substring from a given string.


            //Console.WriteLine("Enter youe string");
            //string input = Console.ReadLine();
            //Console.WriteLine("enter the start point for your substring ?");

            //int start = 0;
            //Console.WriteLine("how many letters to you want to substring ?");

            //int lenght = 0;


            //try
            //{
            //    string result = input.Substring(start,lenght);
            //    Console.WriteLine($"The  substring is: {result}");
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex);
            //}

            #endregion
            #region Q5 :Write C# program that Assigning one value type variable to another and modifying the value of one variable and mention what will happen

            //int num1 = 10; 
            //int num2 = num1;

            //Console.WriteLine($"Before update:");
            //Console.WriteLine($"number1 = {num1}");
            //Console.WriteLine($"number2 = {num2}");

            //// Modify the value of number2
            //num2 = 20;

            //Console.WriteLine($"After update number2:");
            //Console.WriteLine($"number1 = {num1}"); 
            //Console.WriteLine($"number2 = {num2}");
            /* first it get the vaules of num1 then it get the new vaules but num never changes*/
            #endregion
            #region Q6 :Write C# program that Assigning one reference type variable to another and modifying the object through one variable and mention what will happen
            //employee employee_1 = new employee { Name = "MOHAMED", Age = 30 };
            //employee employee_2 = employee_1;


            //Console.WriteLine($"Before update:");
            //Console.WriteLine($"employee_1: Name = {employee_1.Name}, Age = {employee_1.Age}");
            //Console.WriteLine($"employee: Name = {employee_2.Name}, Age = {employee_2.Age}");

            //// Modify the value of number2
            //employee_2.Name = "KHALED";
            //employee_2.Age = 35;

            //Console.WriteLine($"After update :");
            //Console.WriteLine($"employee_1: Name = {employee_1.Name}, Age = {employee_1.Age}");
            //Console.WriteLine($"employee: Name = {employee_2.Name}, Age = {employee_2.Age}");
            /* employee_1 GET THE SAME VAULES AFTER UPDATE AS BOTH WILL REFRENCE THE SAME VAULES*/
            #endregion
            #region Q7 :Write C# program that take two string variables and print them as one variable 
            //Console.WriteLine("YOUR FIRST VAULES ??");
            //string S1=Console.ReadLine();
            //Console.WriteLine("YOUR SECOND VAULES ??");
            //string S2=Console.ReadLine();
            //string RESULT =S1+ S2;
            //Console.WriteLine(RESULT);
            #endregion
            #region Q8 :Which of the following statements is correct about the C#.NET code snippet given below?
            //int d;
            //d = Convert.ToInt32(!(30 < 20));

            /*The value 1 is assigned to d*/

            /* 30< 20 IS FALSE AND ! IS FALSE SO IT TURN TO TRUE نفي النفي اثبات */
            #endregion
            #region Q9 :Which of the following is the correct output for the C# code given below?
            Console.WriteLine(13 / 2 + " " + 13 % 2);

            /*6.5 1*/
            /*
             THE FIRST SIGN / IS DIVIDE 
            THE SECOND ONE REMAINDERO OF THE DIVISION
             */
            #endregion
            #region Q10 :What will be the output of the C# code given below?
            int num = 1, z = 5;


            if (!(num <= 0))
                Console.WriteLine(++num + z++ + " " + ++z);
            else
                Console.WriteLine(--num + z-- + " " + --z);


            /*7 7*/

           


            #endregion

            /*  DONE*/
        }


        class employee
        {
            public string Name { get; set; }
            public int Age { get; set; }
        }
    }
}