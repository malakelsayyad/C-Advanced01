using System.Collections;

namespace Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Question01
            //int[] Numbers = { 1, 2, 3, 4, 8, 9, 6, 7, 5 };

            //Console.WriteLine("Array before sorting");
            //Methods.PrintArray(Numbers);

            //Console.WriteLine();

            //Console.WriteLine("Array after sorting");
            //Methods.BubbleSortOptimized(Numbers);
            //Methods.PrintArray(Numbers);
            #endregion

            #region Question02

            //Range<int> range = new Range<int>(0,10);
            //Console.WriteLine($"Range is from {range.Min} to {range.Max}");

            //bool index = range.isInRange(15);
            //if (index) 
            //{
            //    Console.WriteLine($"In range ");
            //}
            //else
            //    Console.WriteLine($"Not in range");

            #endregion

            #region Question03

            //ArrayList arrayList = new ArrayList() {1,2,3,4,5,6};

            //Console.WriteLine("Before reverse");
            //foreach (int i in arrayList)
            //{
            //    Console.WriteLine(i);
            //}

            //Console.WriteLine("------------------------");

            //Console.WriteLine("After reverse");
            //Methods.ReverseArray(arrayList);
            //foreach (int i in arrayList)
            //{
            //    Console.WriteLine(i);
            //}

            #endregion

            #region Question04

            //List<int> list = new List<int>() { 1,2,3,4,5,6,7,8,9,10};
            //List<int> Even = new List<int>() ;

            //foreach (var item in list)
            //{
            //    if (item % 2 == 0)
            //    { 
            //      Even.Add(item);
            //    }
            //}


            //foreach (var item in Even)
            //{

            //    Console.WriteLine($"{item}");
            //}

            #endregion

            #region Question05

            //FixedSizeList<int> fixedSizeList = new FixedSizeList<int>(5);
            //try
            //{

            //    fixedSizeList.Add(1);
            //    fixedSizeList.Add(2);
            //    fixedSizeList.Add(3);
            //    fixedSizeList.Add(4);
            //    fixedSizeList.Add(5);


            //    fixedSizeList.Add(6);  
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine($"Error: {ex.Message}");
            //}

            //try
            //{
            //    Console.WriteLine(fixedSizeList.Get(2));
            //    Console.WriteLine(fixedSizeList.Get(5)); 
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine($"Error: {ex.Message}");
            //}

            #endregion

            #region Question06

            //string S = "Malak";
            //Dictionary<char, int> charCount = new Dictionary<char, int>();

            //for (int i = 0; i < S.Length; i++)
            //{
            //    char c = S[i];
            //    if (charCount.ContainsKey(c))
            //    {
            //        charCount[c]++;
            //    }
            //    else
            //    {
            //        charCount[c] = 1;
            //    }
            //}

            //int index = -1;
            //for (int i = 0; i < S.Length; i++)
            //{
            //    if (charCount[S[i]] == 1)
            //    {
            //        index = i;
            //        break;
            //    }
            //}

            //if (index != -1)
            //{
            //    Console.WriteLine($"The first non-repeated character is at index: {index}");
            //}
            //else
            //{
            //    Console.WriteLine("No non-repeated character found.");
            //}
            #endregion
        }
    }
}
