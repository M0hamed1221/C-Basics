namespace Ass05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Write a program that prints an identity matrix using for loop, in other words takes a value n from the user and shows the identity table of size n * n.
            //Console.Write("Enter the size of the identity matrix (n): ");
            //if (int.TryParse(Console.ReadLine(), out int n) && n > 0)
            //{
            //    Console.WriteLine($"Identity matrix of size {n}x{n}:");
            //    for (int i = 0; i < n; i++)
            //    {
            //        for (int j = 0; j < n; j++)
            //        {
            //            if (i == j)
            //                Console.Write("1 ");
            //            else
            //                Console.Write("0 ");
            //        }
            //        Console.WriteLine();
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Please enter a valid  int.");
            //}

            #endregion
            #region Write a program in C# Sharp to find the sum of all elements of the array.
            //int[] ints = { 1, 2, 3 };
            //int result = 0;
            //foreach (int i in ints)
            //{
            //    result += i;
            //}
            //Console.WriteLine($"The sum of all elements in the array is: {result}");

            #endregion
            #region Write a program in C# Sharp to merge two arrays of the same size sorted in ascending order.

            //int[] array1 = { 1, 3, 5 };
            //int[] array2 = { 2, 4, 6 };
            //int[] mergedArray = new int[array1.Length + array2.Length];

            //int i = 0, j = 0, k = 0;

            //while (i < array1.Length || j < array2.Length)
            //{
            //    if (i < array1.Length && (j >= array2.Length || array1[i] < array2[j]))
            //    {
            //        mergedArray[k++] = array1[i++];
            //    }
            //    else
            //    {
            //        mergedArray[k++] = array2[j++];
            //    }
            //}

            //Console.WriteLine("Merged array in ascending order:");
            //foreach (int num in mergedArray)
            //{
            //    Console.Write(num + " ");
            //}
            //Console.WriteLine();

            #endregion
            #region  Write a program in C# Sharp to count the frequency of each element of an array.

            //int[] array = { 1, 2, 2, 3, 3, 3, 4, 4, 4, 4 };
            //int length = array.Length;

            //Console.WriteLine("Element Frequency");
            //for (int i = 0; i < length; i++)
            //{

            //    bool alreadyCounted = false;
            //    for (int j = 0; j < i; j++)
            //    {
            //        if (array[i] == array[j])
            //        {
            //            alreadyCounted = true;
            //            break;
            //        }
            //    }

            //    if (!alreadyCounted)
            //    {
            //        int count = 1;
            //        for (int k = i + 1; k < length; k++)
            //        {
            //            if (array[i] == array[k])
            //            {
            //                count++;
            //            }
            //        }
            //        Console.WriteLine($"{array[i]} -> {count}");
            //    }
            //}

            #endregion
            #region Write a program in C# Sharp to find maximum and minimum element in an array
            //int[] array = { 1, 2, 2, 3, 3, 3, 4, 4, 4, 4 };
            //int max = array[0];
            //int min = array[0];
            //for (int i = 1; i < array.Length; i++)
            //{
            //    if (array[i] > max)
            //    {
            //        max = array[i];
            //    }
            //    if (array[i] < min)
            //    {
            //        min = array[i];
            //    }
            //}
            //Console.WriteLine("Maximum element: " + max);
            //Console.WriteLine("Minimum element: " + min);
            #endregion
            #region  Write a program in C# Sharp to find the second largest element in an array.
            //int[] array = { 12, 45, 15, 99, 88, 102, 56 };
            ///*start of the bottom */
            //int largest = int.MinValue;
            //int secondLargest = int.MinValue;

            //for (int i = 0; i < array.Length; i++)
            //{
            //    if (array[i] > largest)
            //    {
            //        secondLargest = largest; 
            //        largest = array[i]; 
            //    }
            //    else if (array[i] > secondLargest && array[i] != largest)
            //    {
            //        secondLargest = array[i]; 
            //    }
            //}


            //if (secondLargest != int.MinValue)
            //{
            //    Console.WriteLine("The second largest element is: " + secondLargest);
            //}
            //else
            //{
            //    Console.WriteLine("There is no second largest element.");
            //}

            #endregion
            #region  Write a program in C# Sharp to find the second largest element in an array.
           


               
                Console.Write("Enter the size of the array: ");
                int n = int.Parse(Console.ReadLine());
                        int[] array = new int[n];
                Console.WriteLine("Enter the elements of the array:");
                for (int i = 0; i < n; i++)
                {
                    array[i] = int.Parse(Console.ReadLine());
                }
                int maxDistance = -1;

                for (int i = 0; i < n; i++)
                {
                    for (int j = i + 1; j < n; j++)
                    {
                        if (array[i] == array[j])
                        {
                            int distance = j - i - 1; 
                            if (distance > maxDistance)
                            {
                                maxDistance = distance;
                            }
                        }
                    }
                }

            
                if (maxDistance == -1)
                {
                    Console.WriteLine("No equal elements found with a distance between them.");
                }
                else
                {
                    Console.WriteLine("The longest distance between two equal elements is: " + maxDistance);
                }


            #endregion
            #region  Given a list of space separated words, reverse the order of the words.

            #endregion


        }
    }
}