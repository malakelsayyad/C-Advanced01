using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    //Generic class
    internal static class Helper<T01> where T01 : class , IComparable,ICloneable,IComparer, new()
    {
        // Generic Constraints:
        // 1.Primary Constraints [0 : 1]
        // class
        // struct
        // special type
        // enum
        // notnull

        // 2.Secondary Constraints [0 : M ]
        // T Implements interface

        // 3.Constructor Constraints


        #region Generic BubbleSort
        // T : Must be the same type as IComparable
        //public static void BubbleSort<T>(T[] Arr) where T : IComparable<T>
        //{
        //    if (Arr?.Length > 0)
        //    {
        //        for (int i = 0; i < Arr.Length; i++)
        //        {
        //            for (int j = 0; j < Arr.Length - i - 1; j++)
        //            {
        //                if (Arr[j].CompareTo(Arr[j + 1])>0)
        //                    SWAP(ref Arr[j], ref Arr[j + 1]);
        //            }

        //        }
        //    }
        //}

        //public static void BubbleSort<T>(T[] Arr,IComparer<T> comparer) where T : IComparable<T>
        //{
        //    if (Arr?.Length > 0)
        //    {
        //        for (int i = 0; i < Arr.Length; i++)
        //        {
        //            for (int j = 0; j < Arr.Length - i - 1; j++)
        //            {
        //                if (comparer.Compare(Arr[j], Arr[j+1])>0)
        //                    SWAP(ref Arr[j], ref Arr[j + 1]);
        //            }

        //        }
        //    }
        //}

        #endregion

        #region Non Generic BubbleSort
        //public static void BubbleSort(int[] Arr)
        //{
        //    if (Arr?.Length > 0)
        //    {
        //        for (int i = 0; i < Arr.Length; i++)
        //        {
        //            for (int j = 0; j < Arr.Length - i - 1; j++)
        //            {
        //                if (Arr[j] > Arr[j + 1])
        //                    SWAP(ref Arr[j], ref Arr[j + 1]);
        //            }

        //        }
        //    }
        //}
        #endregion

        #region Generic LinearSearch

        // Generic LinearSearch
        // public static int LinearSearch<T>(T[] Arr, T value)
        //{
        //    if (Arr?.Length > 0)
        //        for (int i = 0; i < Arr.Length; i++)
        //        {
        //            if (Arr[i].Equals(value))
        //            {
        //                return i;
        //            }
        //        }
        //    return -1;
        //}

        //public static int LinearSearch<T>(T[] Arr, T value,IEqualityComparer<T> equalityComparer)
        //{
        //    if (Arr?.Length > 0)
        //        for (int i = 0; i < Arr.Length; i++)
        //        {
        //           if(equalityComparer.Equals(Arr[i], value)) return i;
        //        }
        //    return -1;
        //}

        #endregion

        #region Non generic LinearSearch
        //public static int LinearSearch(int[] Arr, int value)
        //{
        //    if (Arr?.Length > 0)
        //        for (int i = 0; i < Arr.Length; i++)
        //        {
        //            if (Arr[i] == value)
        //            {
        //                return i;
        //            }
        //        }
        //    return -1;
        //} 
        #endregion

        #region Generic Swap
        //Generic Swap
        //public static void SWAP<T>(ref T X, ref T Y)
        //{
        //    T temp = X;
        //    X = Y;
        //    Y = temp;
        //}

        #endregion

        #region Methods

        //public static void Print(string data)
        //{
        //    Console.WriteLine(data);
        //}

        //public static void Welcome<T1>(T1 t1)
        //{

        //}

        //public static void PrintArray<T>(T[] Arr)
        //{
        //    foreach (T i in Arr)
        //    {
        //        Console.WriteLine($"{i} ");  
        //    }
        //}

        #endregion

        #region Non Generic Swap
        //public static void SWAP(ref int X, ref int Y)
        //{
        //    int Temp = X;
        //    X = Y;
        //    Y = Temp;
        //}

        //public static void SWAP(ref double X, ref double Y)
        //{
        //    double Temp = X;
        //    X = Y;
        //    Y = Temp;
        //}

        //public static void SWAP(ref Point X, ref Point Y)
        //{
        //    Point Temp = X;
        //    X = Y;
        //    Y = Temp;
        //} 
        #endregion


    }
}
