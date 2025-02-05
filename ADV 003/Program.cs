namespace ADV_003
{
    internal class Program
    {

        #region iven a Queue, implement a function to reverse the elements of a queue using a stack.

        private static void Reverse(Queue<int> values)
        {
            if (values == null || values.Count == 0)
            {
                return;
            }

            Stack<int> stack = new Stack<int>();

            // Empty the Queue as fill the stack 
            while (values.Count > 0)
            {
                stack.Push(values.Dequeue());
            }

           // Refill the que again from the stack but revers it as stack as lifo 
            while (stack.Count > 0)
            {
                values.Enqueue(stack.Pop());
            }
        }

        #endregion


        #region   Given a Stack, implement a function to check if a string of parentheses is balanced using a stack.



        private static bool IsBalanced(string input)
        {
            int roundCount = 0; // Counter for ()
            int curlyCount = 0; // Counter for {}
            int squareCount = 0; // Counter for []

            // Iterate through each character in the string
            foreach (char ch in input)
            {
                switch (ch)
                {
                    case '(':
                        roundCount++; // Increment 
                        break;
                    case ')':
                        roundCount--; // Decrement 
                        break;
                    case '{':
                        curlyCount++; // Increment 
                        break;
                    case '}':
                        curlyCount--; // Decrement 
                        break;
                    case '[':
                        squareCount++; // Increment
                        break;
                    case ']':
                        squareCount--; // Decrement 
                        break;
                }

              
                if (roundCount < 0 || curlyCount < 0 || squareCount < 0)
                {
                    return false;
                }
            }

         
            return roundCount == 0 && curlyCount == 0 && squareCount == 0;
        }


        #endregion
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            string input = "[()]{}";
            bool result = IsBalanced(input);

            Console.WriteLine($"Input: {input}");
            Console.WriteLine(result ? "Balanced" : "Not Balanced");
        }
    }
}
