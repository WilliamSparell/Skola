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
            
            int firstIndex = 0, secondIndex = 0, mergedIndex = 0;
            //while either array still has an element
            while (firstIndex < first.Length || secondIndex < second.Length)
            {
                if (firstIndex >= first.Length)
                {
                    merged[mergedIndex++] = second[secondIndex++];
                }
                else if (secondIndex >= second.Length)
                {
                    merged[mergedIndex++] = first[firstIndex++];
                }
                else
                {
                    if (first[firstIndex] < second[secondIndex])
                    {
                        merged[mergedIndex++] = first[firstIndex++];
                    }
                    else
                    {
                        merged[mergedIndex++] = second[secondIndex++];
                    }
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
        public static void QuickSort(int[] array)
        {
            QuickSortPart(array, 0, array.Length - 1);
        }
        public static void QuickSortPart(int[] array, int low, int high) // funkar inte
        {
            if (high == low)
                return;
            
            var pivot = low;
            int leftIndex = low + 1, rightIndex = high;
            while (leftIndex < rightIndex)
            {
                if (array[leftIndex] <= array[pivot])
                    leftIndex++;
                if (array[rightIndex] >= array[pivot])
                    rightIndex--;
                if (array[leftIndex] > array[pivot] && array[rightIndex] < array[pivot])
                {
                    int temp = array[leftIndex];
                    array[leftIndex] = array[rightIndex];
                    array[rightIndex] = temp;
                    leftIndex++;
                    rightIndex--;
                }
            }

            if (array[rightIndex] < array[pivot]) 
            {
                int temp = array[rightIndex];
                array[rightIndex] = array[pivot];
                array[pivot] = temp;
                pivot = rightIndex;
            }
            else
            {
                int temp = array[rightIndex - 1];
                array[rightIndex - 1] = array[pivot];
                array[pivot] = temp;
                pivot = rightIndex - 1;
            }
            QuickSortPart(array, low, pivot - 1);
            QuickSortPart(array, pivot + 1, high);
            //return array;
        }
        public static void TestQuickSort()
        {
            Console.WriteLine("TestQuickSort");
            Random rnd = new Random();
            int[] arr = new int[12];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rnd.Next(0, 5000);
            }
            QuickSort(arr);

            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
        }
    }
}
