using System.Numerics;
using static AdvancedOOP01.Program;
namespace AdvancedOOP01
{
    internal class Program
    {


        #region The Bubble Sort algorithm has a time complexity of O(n^2) in its worst and average cases, which makes it inefficient for large datasets. How we can optimize the Bubble Sort algorithm And implement the code of this optimized bubble sort algorithm

        public static class Helper<T>where T : IComparable<T>
        {

            public static void Swap(ref T t1, ref T t2)
            {
                if (t1 is null || t2 is null)
                {
                    return;
                }
                else
                {
                    T Holder = t1;
                    t1 = t2;
                    t2 = Holder;


                }

            }
        }
        public static void BubbleSort<T>(T[] arr) where T : IComparable<T>
        {
            if (arr == null || arr.Length <= 1)
            {
                return;
            }

            bool swapped;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                swapped = false;
                for (int j = 0; j < arr.Length - 1 - i; j++)
                {
                    if (arr[j].CompareTo(arr[j + 1]) == 1)
                    {
                        Helper<T>.Swap(ref arr[j], ref arr[j + 1]);
                        swapped = true;
                    }
                }
                // If nothing swapped exist the loop 
                if (!swapped)
                    break;
            }
        }

        #endregion

        #region Qst 2

        public  class Range<T> where T : INumber<T>, IComparable<T>
        {
            public T Min { get; set; }
            public T Max { get; set; }

            public Range(T min , T max)
            {
                if (min.CompareTo(max) > 0)
                {
                    throw new ArgumentException("min value Must be Greater than the max value");
                }
                Min = min;
                Max = max;
            }

            public bool IsInRange(T value)
            {
                return value.CompareTo(Min) >= 0 && value.CompareTo(Max) <= 0;
            }
            public T Length() => Max - Min; /*will work fine as  i use INumber<T> */

            public override string ToString()
            {
                return $"Range: [{Min}, {Max}]";
            }
        }

        #endregion
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
      
    }
}
