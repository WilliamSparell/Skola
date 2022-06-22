using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datalogi_övning_1
{
    internal class Sort
    {
        public static int[] BubbleSort(int[] oldArray)
        {
            int[] array = oldArray.ToArray();
            for (int j = 0; j < array.Length; j++)
            {
                for (int i = 0; i < array.Length -1; i++)
                {
                    if (array[i] > array[i + 1])
                    {
                        int temp = array[i];
                        array[i] = array[i + 1];
                        array[i + 1] = temp;
                    }
                }
            }
            return array;
        }
        public static void TestBubbleSort()
        {
            Random rnd = new Random();
            int[] arr = new int[10];
            for (int i = 0; i < arr.Length; i++)
            { 
                arr[i] = rnd.Next(0, 5000);
            }
            int[] sorted = BubbleSort(arr);

            foreach (var numbers in sorted)
            {
                Console.WriteLine(numbers);
            }
        }
        public static int[] MergeSort(int[] first, int[] second)
        {
            
            int[] merged = new int[second.Length + first.Length];
            
            int firstIndex = 0, seconedIndex = 0, indexResult = 0;
            //while either array still has an element
            while (firstIndex < first.Length || seconedIndex < second.Length)
            {
                //if both arrays have elements  
                if (firstIndex < first.Length && seconedIndex < second.Length)
                {
                    //If item on left array is less than item on right array, add that item to the result array 
                    if (first[firstIndex] <= second[seconedIndex])
                    {
                        merged[indexResult] = first[firstIndex];
                        firstIndex++;
                        indexResult++;
                    }
                    // else the item in the right array wll be added to the results array
                    else
                    {
                        merged[indexResult] = second[seconedIndex];
                        seconedIndex++;
                        indexResult++;
                    }
                }
                //if only the left array still has elements, add all its items to the results array
                else if (firstIndex < first.Length)
                {
                    merged[indexResult] = first[firstIndex];
                    firstIndex++;
                    indexResult++;
                }
                //if only the right array still has elements, add all its items to the results array
                else if (seconedIndex < second.Length)
                {
                    merged[indexResult] = second[seconedIndex];
                    seconedIndex++;
                    indexResult++;
                }
            }
            return merged;
        }
        public static void TestMergeSort()
        {
            Random rnd = new Random();
            int[] firstArray = new int[10];
            int[] secondArray = new int[10];
            for (int i = 0; i < firstArray.Length; i++)
            {
                firstArray[i] = rnd.Next(0, 5000);
                secondArray[i] = rnd.Next(0, 5000);
            }
            int[] sorted = MergeSort(firstArray, secondArray);

            foreach (var numbers in sorted)
            {
                Console.WriteLine(numbers);
            }
        }
    }
}
