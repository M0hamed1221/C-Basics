namespace Cs_Basics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region  Qst 1

            Console.WriteLine("Please Enter Your Number:");

            // Read the input and convert it to an integer
            if (int.TryParse(Console.ReadLine(), out int input))
            {
                Console.WriteLine("Your number is {0}", input);
            }
            else
            {
                Console.WriteLine("Invalid input! Please enter a valid number.");
            }
            #endregion
        }
    }
}