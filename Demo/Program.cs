namespace Demo
{
    internal class Program
    {
        static void Main()
        {
            // Generics
            // C# feature 2005 C# 2.0
            // Before 2005 Class Object

            #region Generic Ex01 : SWAP
            // SWAP

            //int A = 4, B = 5;

            //Console.WriteLine($"A : {A}");
            //Console.WriteLine($"B : {B}");

            //Console.WriteLine("------------- After SWAP -------------");

            //Helper.SWAP( ref A,ref B ); // Passing by ref

            //Console.WriteLine($"A : {A}");
            //Console.WriteLine($"B : {B}");

            //double L = 1.5, K = 2.6;
            //Console.WriteLine($"K : {K}");
            //Console.WriteLine($"L : {L}");

            //Console.WriteLine("------------- After SWAP -------------");

            //Helper.SWAP( ref K,ref L ); // Passing by ref
            //Console.WriteLine($"K : {K}");
            //Console.WriteLine($"L : {L}");

            // Point : X,Y
            //Point P01 = new Point(1, 1);
            //Point P02 = new Point(2, 2);

            //Console.WriteLine($"P01 : {P01}");
            //Console.WriteLine($"P02 : {P02}");

            //Helper.SWAP(ref P01, ref P02);
            //Console.WriteLine("------------- After SWAP -------------")

            //Console.WriteLine($"P01 : {P01}");
            //Console.WriteLine($"P02 : {P02}"); 
            //----------------------------------------------------------------

            //int A = 4, B = 5;

            //Console.WriteLine($"A : {A}");
            //Console.WriteLine($"B : {B}");

            //Console.WriteLine("------------- After SWAP -------------");

            //Helper.SWAP(ref A, ref B); // Passing by ref

            //Console.WriteLine($"A : {A}");
            //Console.WriteLine($"B : {B}");

            //double L = 1.5, K = 2.6;
            //Console.WriteLine($"K : {K}");
            //Console.WriteLine($"L : {L}");

            //Console.WriteLine("------------- After SWAP -------------");

            //Helper.SWAP( ref K,ref L ); // Passing by ref
            //Console.WriteLine($"K : {K}");
            //Console.WriteLine($"L : {L}");

            // Point : X,Y
            //Point P01 = new Point(1, 1);
            //Point P02 = new Point(2, 2);

            //Console.WriteLine($"P01 : {P01}");
            //Console.WriteLine($"P02 : {P02}");

            //Helper.SWAP(ref P01, ref P02);
            //Console.WriteLine("------------- After SWAP -------------")

            //Console.WriteLine($"P01 : {P01}");
            //Console.WriteLine($"P02 : {P02}"); 
            #endregion

            #region Generic Ex02 : LinearSearch
            // Linear search
            // 4 7 8 9 10 1 2 3 5 12 -1 -13 11
            // Index

            // int[] Numbers = {8,7,6,1,2,3,4,5,6,12,-1,-13,9};

            // int Index = Helper.LinearSearch(Numbers, 4); // 6
            // int Index = Helper.LinearSearch(Numbers, 12); // 9
            // Console.WriteLine($"Index : {Index}");

            //Employee E01= new Employee() { Id = 1 , Name = "Malak" , Salary=12000,Age=23 };
            //Employee E02= new Employee() { Id = 2 , Name = "Nada" , Salary=13000,Age=21 };
            //Employee E03= new Employee() { Id = 3 , Name = "Noura" , Salary=14000,Age=22 };
            //Employee E04= new Employee() { Id = 4 , Name = "Mariam" , Salary=15000,Age=20 };

            //Employee[] employees = new Employee[] { E01,E02,E03, E04 };

            //int Index = Helper.LinearSearch(employees, E03);
            //Console.WriteLine($"Index : {Index}");

            //if (E01.Equals(E02))
            //    Console.WriteLine("E01==E02"); 
            #endregion

            #region Equality in Class or struct
            // Equality in class or struct
            // Equals
            // 'Class' has Equals function which is inherited from object class ---> Compare Reference ==
            // 'Struct' has Equals function which is inherited from object class ---> Compare Data 
            // Struct doesn't have the implementation of == operator

            //Employee E01= new Employee() { Id = 1 , Name = "Malak" , Salary=12000,Age=23 };
            //Employee E02= new Employee() { Id = 1 , Name = "Malak" , Salary=12000,Age=23 };
            //Employee E02= new Employee() { Id = 2 , Name = "Nada" , Salary=13000,Age=21 };

            //Console.WriteLine($"E01 : {E01.GetHashCode}");
            //Console.WriteLine($"E02 : {E02.GetHashCode}");

            //if(E01.Equals(E02))
            //    Console.WriteLine("E01 == E02");
            //else 
            //    Console.WriteLine("E01 != E02");

            //if(E01 == E02)
            //    Console.WriteLine("E01 == E02");
            //else 
            //    Console.WriteLine("E01 != E02");

            #endregion

            #region Generic Ex03 : BubbleSort
            // 2,3,9,8,7,6,5,4,1,12,-1,0
            // Sorting : Bubble Sort

            //int[] Numbers = { 2, 3, 9, 8, 7, 6, 5, 4, 1, 12, -1, 0 };

            //Helper.PrintArray(Numbers);

            //Console.WriteLine();

            //Helper.BubbleSort(Numbers); // Ascending Sort
            //Console.WriteLine();

            //Helper.PrintArray(Numbers);

            //Point[] points = 
            //{
            //    new Point(6,6),
            //    new Point(2,2),
            //    new Point(4,4),
            //    new Point(3,3),
            //    new Point(1,1),     
            //    new Point(5,5) 
            //};

            //Helper.PrintArray(points);

            //Helper.BubbleSort(points);
            //Helper.PrintArray(points);

            //ICompareable : CompareTo()
            // int
            // + : Caller > Parameter
            // - : Caller < Parameter
            // 0 : Caller = Parameter

            //Employee E01 = new Employee() { Id = 1, Name = "Malak", Salary = 12000, Age = 23 };
            //Employee E02 = new Employee() { Id = 2, Name = "Nada", Salary = 13000, Age = 21 };
            //Employee E03 = new Employee() { Id = 3, Name = "Noura", Salary = 14000, Age = 22 };
            //Employee E04 = new Employee() { Id = 4, Name = "Mariam", Salary = 15000, Age = 20 };

            //Employee[] employees = new Employee[] { E01, E02, E03, E04 };

            //Helper.PrintArray(employees);

            //Helper.BubbleSort(employees);

            //Console.WriteLine();

            //Helper.PrintArray(employees);

            // Array.Sort(employees); 
            #endregion

            #region is and as Casting operator
            //Point[] points =
            //{
            //    new Point(6,6),
            //    new Point(2,2),
            //    new Point(4,4),
            //    new Point(3,3),
            //    new Point(1,1),
            //    new Point(5,5)
            //};

            //Helper.PrintArray(points);

            //Helper.BubbleSort(points);

            //Helper.PrintArray(points);

            //Point P01=new Point(1,1);
            //Point P02=new Point(2,2);

            //if(P01.CompareTo(null)>0)
            //    Console.WriteLine("P01 is greater than P02");
            //else
            //    Console.WriteLine("P01 is not greater than P02"); 
            #endregion

            #region Non Generic ICompareable vs Generic ICompareable

            //Point[] points =
            //{
            //    new Point(6,6),
            //    new Point(2,2),
            //    new Point(4,4),
            //    new Point(3,3),
            //    new Point(1,1),
            //    new Point(5,5)
            //};

            //Helper.PrintArray(points);

            //Helper.BubbleSort(points);

            //Helper.PrintArray(points)

            //Employee E01 = new Employee() { Id = 1, Name = "Malak", Salary = 12000, Age = 23 };
            //Employee E02 = new Employee() { Id = 2, Name = "Nada", Salary = 13000, Age = 21 };
            //Employee E03 = new Employee() { Id = 3, Name = "Noura", Salary = 14000, Age = 22 };
            //Employee E04 = new Employee() { Id = 4, Name = "Mariam", Salary = 15000, Age = 20 };

            //Employee[] employees = new Employee[] { E01, E02, E03, E04 };

            //Helper.PrintArray(employees);

            //Helper.BubbleSort(employees);

            //Console.WriteLine();

            //Helper.PrintArray(employees); 
            #endregion

            #region Built-In generic  IEquatable
            //Employee E01 = new Employee() { Id = 1, Name = "Malak", Salary = 12000, Age = 23 };
            //Employee E02 = new Employee() { Id = 1, Name = "Malak", Salary = 12000, Age = 23 };
            //Employee E02 = new Employee() { Id = 2, Name = "Nada", Salary = 13000, Age = 21 };
            //Employee E03 = new Employee() { Id = 3, Name = "Noura", Salary = 14000, Age = 22 };
            //Employee E04 = new Employee() { Id = 4, Name = "Mariam", Salary = 15000, Age = 20 };

            //Employee[] employees = new Employee[] { E01, E02, E03, E04 };

            //int Index = Helper.LinearSearch(employees, E03);
            //Console.WriteLine($"Index : {Index}");

            //if (E01.Equals(E02))
            //    Console.WriteLine("E01 == E02"); 
            //else
            //     Console.WriteLine("E01 != E02");

            // Built-in Generic interface : IEquatable 
            #endregion

            #region Built-in generic interface IEqualityComparer

            //Employee E01 = new Employee() { Id = 1, Name = "Malak", Salary = 12000, Age = 23 };
            //Employee E02 = new Employee() { Id = 2, Name = "Nada", Salary = 13000, Age = 21 };
            //Employee E03 = new Employee() { Id = 3, Name = "Noura", Salary = 14000, Age = 22 };
            //Employee E04 = new Employee() { Id = 4, Name = "Mariam", Salary = 15000, Age = 20 };

            //Employee[] employees = new Employee[] { E01, E02, E03, E04 };

            //int Index = Helper.LinearSearch(employees, new Employee() { Id = 2, Name = "Nada", Salary = 12000, Age = 21 });
            //int Index = Helper.LinearSearch(employees, new Employee() { Name = "Nada"},new EmployeeEqualityComparer());

            //Console.WriteLine($"Index : {Index}");

            #endregion

            #region IComparer with BubbleSort
            //Employee E01 = new Employee() { Id = 1, Name = "Malak", Salary = 12000, Age = 23 };
            //Employee E02 = new Employee() { Id = 2, Name = "Nada", Salary = 13000, Age = 21 };
            //Employee E03 = new Employee() { Id = 3, Name = "Noura", Salary = 14000, Age = 22 };
            //Employee E04 = new Employee() { Id = 4, Name = "Mariam", Salary = 15000, Age = 20 };

            //Employee[] employees = new Employee[] { E01, E02, E03, E04 };

            //Helper.PrintArray(employees);

            //Helper.BubbleSort(employees); // Sort based on age
            //Helper.BubbleSort(employees,new EmployeeComparerSalary()); // Sort based on salary
            //Helper.BubbleSort(employees,new EmployeeComparerNameLength()); // Sort based on name length

            //Console.WriteLine();

            //Helper.PrintArray(employees);

            //Array.Sort(employees); 
            #endregion


        }

    }
}
