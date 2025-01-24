using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal class Methods
    {
        public static void SWAP<T>(ref T X, ref T Y)
        {
            T temp = X;
            X = Y;
            Y = temp;
        }

        public static void BubbleSortOptimized(int[] arr)
        {
            bool swapped;

            for (int i = 0; i < arr.Length; i++)
            {
                swapped = false;
                for (int j = 0; j < arr.Length-i-1; j++)
                {
                    if (arr[j] > arr[j+1])
                        SWAP(ref arr[j],ref arr[j + 1]);
                        swapped = true;    
                }
                if (!swapped)
                {
                    break;
                }
            }
        }

        public static void PrintArray<T>(T[] Arr)
        {
            foreach (T i in Arr)
            {
                Console.WriteLine($"{i} ");  
            }
        }

        public static void ReverseArray(ArrayList arrayList)
        {
            int right = arrayList.Count - 1;
            int left = 0;

            while (left < right)
            {
                object temp = arrayList[left];
                arrayList[left] = arrayList[right];
                arrayList[right] = temp;

                left++;
                right--;
            }

        }
    }
}
