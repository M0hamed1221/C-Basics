using System.Collections;

namespace Adv002
{
    internal class Program
    {


        #region You are given an ArrayList containing a sequence of elements. try to reverse 

      
        static void ReverseArrayList(ArrayList list)
        {
            int start = 0;
            int end = list.Count - 1; // to get last index

            //stop in the middel point
            while (start < end)
            {
                // Swap elements at start and end indices
                object temp =  list[start];
                list[start] = list[end];
                list[end] = temp;

                // move to the middel 
                // start => <= end 
                start++;
                end--;
            }
        }
        #endregion

        #region You are given a list of integers. Your task is to find and return a new list containing only the even numbers from the given list.
        static List<int> GetEvenNumbers(List<int> numbers)
        {
            List<int> evenNumbers = new List<int>();

            foreach (int number in numbers)
            {
                if (number % 2 == 0) // is Even
                {
                    evenNumbers.Add(number); // add to the even list
                }
            }

            return evenNumbers;
        }
        #endregion

        #region implement a custom list called FixedSizeList<T>
        public class FixedSizeList<T>
        {
            private T[] _items;
            private int _count;
            public FixedSizeList(int capacity)
            {

                if (capacity <= 0)
                {
                    throw new ArgumentException("Capacity must be greater than zero");
                }

                _items = new T[capacity];
                _count = 0;
            }

          
           

            public void Add(T item)
            {
                if (_count >= _items.Length)
                {
                    throw new InvalidOperationException("Can not add more items. The list is full.");
                }

                _items[_count] = item;
                _count++;
            }
            public T Get(int index)
            {
                if (index < 0 || index >= _count)
                {
                    throw new ArgumentOutOfRangeException( "Index is out of range.");
                }

                return _items[index];
            }
        }


        #endregion


        #region Given a string, find the first non-repeated character in it and return its index. If there is no such character, return -1

        private int NonrepeatedChar(string input)
        {
            Dictionary<char, int> letterCount = new Dictionary<char, int>();
            foreach (char c in input)
            {
                if (letterCount.ContainsKey(c))
                    letterCount[c]++;
                else
                    letterCount[c] = 1;
            }
             for (int i = 0; i < input.Length; i++)
            {
                if (letterCount[input[i]] == 1)
                    return i;
            }
            return -1;


        }

        #endregion

        #region Given a number N and an array of N numbers. Determine if it's palindrome or not
        static bool ISpalindrome(int[] array)
        {
            int left = 0;
            int right = array.Length - 1;

            while (left < right)
            {
                if (array[left] != array[right])
                {
                    return false; // Not a palindrome
                }
                left++;
                right--;
            }

            return true; // Palindrome
        }
        #endregion

        #region Given an array, implement a function to remove duplicate elements from an array.

        static int[] RemoveDuplicatesWithoutHashSet(int[] array)
        {
            if (array.Length == 0)
                return array;

            Dictionary<int, bool> Duplicated = new Dictionary<int, bool>();
            List<int> uniqueList = new List<int>();

            foreach (int num in array)
            {
                if (!Duplicated.ContainsKey(num))
                {
                    Duplicated[num] = true;
                    uniqueList.Add(num);
                }
            }

            return uniqueList.ToArray();
        }
        #endregion  Given an array list , implement a function to remove all odd numbers from it.

        static List<int> RemoveODDNumbers(List<int> numbers)
        {
            List<int> result = new List<int>();

            foreach (int num in numbers)
            {
                if (num % 2 == 0) 
                {
                    result.Add(num);
                }
            }

            return result;
        }
        #region

        #endregion
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
