using System.Text;

namespace Demo_03_part_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Control statements [for - foreach - while - do while]

            #region [for - foreach]
            // if you asked to print from 1 to 10 what is your code?
            //Console.WriteLine(1);
            //Console.WriteLine(2);
            //Console.WriteLine(3);
            //Console.WriteLine(4);
            //Console.WriteLine(5);
            //Console.WriteLine(6);
            //Console.WriteLine(7);
            //Console.WriteLine(8);
            //Console.WriteLine(9);
            //Console.WriteLine(10);
            // what if printing from 1 to 1000!
            // why loops:

            ////      1          2       4
            //for (int i = 1; i <= 10; i++)
            //{
            //    Console.WriteLine(i);  // 3
            //}


            // for array or array list we can use foreach 
            // but we can not do any operation on index or use control statement like (continue, break)
            //int[] numbers = { 1, 2, 3, 4, 5 };

            //foreach (int number in numbers)
            //{
            //    Console.WriteLine(number);
            //}
            #endregion

            #region [while - do while]
            // while loop same as for only different in syntax

            //int i = 1;                     // 1 
            //while (i <= 10)                // 2
            //{ 
            //    Console.WriteLine(i);      // 3
            //    i++;                       // 4
            //}

            // do while different from for loop and while loop 
            // the statement will be execute at lest only one time befor checking the condition

            // program to acept only positve number from the user

            //int number;
            //bool flag = false;
            //do {
            //    Console.WriteLine("Please Enter Positive Number: ");
            //    //number  = int.Parse(Console.ReadLine());
            //    flag = int.TryParse(Console.ReadLine(), out number);
            //} while (number <= 0 || !flag);
            //Console.WriteLine($"{number} is positive");
            #endregion


            #region String vs StringBuilder
            //string name01;
            //// declear reference from type string
            //// allow 4 byte at stack for reference object
            //// allocate 0 bytes at heap
            //// reference to defualt value null
            //name01 = new string("nouwara");
            //// allocate required byts in heap
            //// intialize value nouwara
            //// call user defined constructor
            //// assigen reference to allocate object

            //string name02 = "Mohamed"; //syntax sugar
            //name02 = name01;

            //name01 = "Adel";
            //Console.WriteLine(name01);
            //Console.WriteLine(name02);

            //// string is an imutable 


            //string message = "Hello";
            //Console.WriteLine(message);
            //Console.WriteLine(message.GetHashCode());
            //message += " Route";
            //Console.WriteLine(message);
            //Console.WriteLine(message.GetHashCode());

            //// string builder
            ////----------------
            //StringBuilder SB = new StringBuilder();
            //SB.Append("Hello");
            //Console.WriteLine(SB);
            //Console.WriteLine(SB.GetHashCode());
            //SB.Append(" Route!");
            //Console.WriteLine(SB);
            //Console.WriteLine(SB.GetHashCode());
            #endregion

            #region 1D Array
            //// if you want to store 3 numbers what is your code
            //int x, y, z;
            //x = int.Parse(Console.ReadLine());
            //y = int.Parse(Console.ReadLine());
            //z = int.Parse(Console.ReadLine());

            //// why Array?
            //// now if you want to store 1000 number what is your code

            //// intializing and declearing an arry

            //int[] numbers = new int[3];
            //numbers[0] = 1;
            //numbers[1] = 2;
            //numbers[2] = 3;

            //int[] numbers2 = new int[3] { 1, 2, 3,};

            //int[] numbers3 = new int[] { 1, 2, 3, 4, 5 };
            //Console.WriteLine(numbers3.Length); // to git size of array

            //int[] numbers4 = { 1, 2, 3 };
            //Console.WriteLine(numbers4.Length);
            //Console.WriteLine(numbers4.Rank); // to git dimentions of array

            //// filling and printing array element

            //const int size = 100; // size of an array must be constant
            //int[] numbers5 = new int[size];

            //Console.Write("Num Of Array Element: ");
            //int NumOfElement = int.Parse(Console.ReadLine());

            //for(int i = 0; i < NumOfElement; i++)
            //{
            //    Console.Write($"Element {i + 1}: ");
            //    numbers5[i] = int.Parse(Console.ReadLine());
            //}

            //Console.WriteLine("===============");
            //Console.WriteLine("Array Elements");
            //Console.WriteLine("===============");

            //for(int i = 0; i < NumOfElement; i++)
            //{
            //    Console.WriteLine(numbers5[i]);
            //}
            #endregion

            #region 2D Array
            //// initalizing and declearing 2D Array
            //int[,] marks = new int[3, 3] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9} };
            //Console.WriteLine(marks.GetLength(0));  // Rows
            //Console.WriteLine(marks.GetLength(1));  // Columns

            //// filling and printing 2D array elements
            //const int rows = 3, columns = 5;
            //int[,] marks = new int[rows, columns];

            //for (int i = 0; i < marks.GetLength(0) /*or i < rows*/; i++) {
            //    Console.WriteLine($"Student {i + 1}: ");
            //    Console.WriteLine("----------");
            //    for (int j = 0; j < marks.GetLength(1); j++)
            //    {
            //        Console.Write($"Subject {j + 1}: ");
            //        marks[i, j] = int.Parse(Console.ReadLine());
            //    }
            //    Console.WriteLine("------------");
            //}
            //Console.WriteLine("===============");
            //Console.WriteLine("Student grades: ");
            //Console.WriteLine("===============");

            //for (int i = 0;i < marks.GetLength(0) ; i++)
            //{
            //    for (int j = 0;j < marks.GetLength(1); j++)
            //    {
            //        Console.Write($"{marks[i, j]}  ");
            //    }
            //    Console.WriteLine();
            //}
            #endregion

            #region Boxing & Unboxing
            // Boxing : Casting from datatybe [value type] to datatybe [reference type]
            // Unboxing: Casting from datatybe [reference type] to datatype [value type]
            object obj;
            // declare reference of tupe object refering to null
            // this reference obj can refer to unstance from type object or any datatype 
            obj = new object();
            obj = new string("Mohamed"); // implicit casting or boxing
            obj = 'A'; 
            obj = 3;
            obj = true;
            bool flag = (bool)obj; //Explicit casting or Unboxing or unsafe casting

            int x = 5;
            object o1 = x; // casting from int[value type] to object [referenc type] 
            Console.WriteLine(o1);

            object o2 = 10;
            o2 = "Ahmed";
            int y = (int) o2; // unboxing 
            #endregion

            #endregion
        }
    }
}
