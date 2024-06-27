using System.Numerics;

namespace Assignment_03_part_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q17
            /*
             * Suppose the points are A, B and C. Find the slope of the line passing 
             * through A and B. Find the Slope of the line passing through B and C. 
             * If the slopes are the same, the points are on the same line.
             * if A (x1, y1) and B(x2, y2) then slope of AB is (y1-y2)/(x1-x2) 
             */
            //double x1, y1, x2, y2, x3, y3, slop1, slop2;
            //x1 = double.Parse(Console.ReadLine());
            //y1 = double.Parse(Console.ReadLine());
            //x2 = double.Parse(Console.ReadLine());
            //y2 = double.Parse(Console.ReadLine());
            //x3 = double.Parse(Console.ReadLine());
            //y3 = double.Parse(Console.ReadLine());

            //slop1 = (y1 - y2) / (x1 - x2);
            //slop2 = (y2 - y3) / (x2 - x3);

            //if(slop1 == slop2)
            //{
            //    Console.WriteLine("these points lie on a single straight line");
            //}
            #endregion

            #region Q18
            //Console.WriteLine("Enter the time taken for the task: ");
            //int WorkHours = int.Parse(Console.ReadLine());

            //if (WorkHours >= 2 && WorkHours <= 3)
            //    Console.WriteLine("highly efficient");
            //else if (WorkHours > 3 && WorkHours <= 4)
            //    Console.WriteLine("instructed to increase their speed");
            //else if (WorkHours > 4 && WorkHours <= 5)
            //    Console.WriteLine("provided with training to enhance their speed. ");
            //else
            //    Console.WriteLine("they are required to leave the company.");
            #endregion

            #region Q19
            //Console.WriteLine("Enter size of idntity matrix: ");
            //int n = int.Parse(Console.ReadLine());
            //for (int i = 0; i < n; i++)
            //{
            //    for (int j = 0; j < n; j++)
            //    {
            //        if (i == j)
            //            Console.Write(" 1 ");
            //        else
            //            Console.Write(" 0 ");
            //    }
            //    Console.WriteLine();
            //}
            #endregion

            #region Q20
            //const int size = 100;
            //int[] arr = new int[size];

            //Console.Write("Enter number of array element: ");
            //int numOfElement = Convert.ToInt32(Console.ReadLine());           
            //int sum = 0;

            //for (int i = 0; i < numOfElement; i++)
            //{
            //    Console.Write($"element{i+1}: ");
            //    arr[i] = Convert.ToInt32(Console.ReadLine());
            //    sum += arr[i];
            //}
            //Console.WriteLine($"Sum of array element: {sum}");
            #endregion

            #region Q21
            //int[] arr1 = new int[100];
            //int[] arr2 = new int[100];
            //int[] arr3 = new int[200];

            //int s1, s2, s3, tmp;

            //Console.WriteLine("Enter size of first array: ");
            //s1 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter array elements: ");
            //Console.WriteLine("----------------");
            //for (int i = 0; i < s1; i++) {
            //    arr1[i] = Convert.ToInt32(Console.ReadLine());
            //}

            //Console.WriteLine("================");

            //Console.WriteLine("Enter size of second array: ");
            //s2 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter array elements: ");
            //Console.WriteLine("----------------");
            //for (int i = 0; i < s2; i++)
            //{
            //    arr2[i] = Convert.ToInt32(Console.ReadLine());
            //}

            //s3 = s1 + s2;

            //int k = 0;
            //while( k < s1 )
            //{
            //    arr3[k] = arr1[k];
            //    k++;
            //}

            //for(int j  = 0; j < s2; j++)
            //{
            //    arr3[k] = arr2[j];
            //    k++;
            //}

            //// sorting arr3 using bubble sort
            //for(int i = 0; i < s3 - 1; i++)
            //{
            //    for(int j = 0;j < s3 - 1; j++)
            //    {
            //        if (arr3[j] > arr3[j + 1])
            //        {
            //            tmp = arr3[j + 1];
            //            arr3[j + 1] = arr3[j];
            //            arr3[k] = tmp;
            //        }
            //    }
            //}

            //Console.WriteLine("After merge: ");
            //for (int i = 0; i < s3; i++) {
            //    Console.WriteLine(arr3[i]);
            //}
            #endregion

            #region Q22
            //const int size = 100;
            //int[] arr = new int[size];

            //Console.WriteLine("Enter number of element: ");
            //int n = Convert.ToInt32(Console.ReadLine());

            //int[] freq = new int[n];

            //Console.WriteLine("Enter array element: ");
            //for (int i = 0; i < n; i++)
            //{
            //    arr[i] = Convert.ToInt32(Console.ReadLine()); // 25 12 43 25 10 
            //}

            //for (int i = 0; i < n; i++)
            //{
            //    int count = 1;
            //    for (int j = i + 1; j < n; j++)
            //    {
            //        if (arr[i] == arr[j])
            //        {
            //            count++;
            //            freq[j] = -1;
            //        }
            //    }
            //    if (freq[i] != -1)
            //    {
            //        freq[i] = count;
            //    }
            //}

            //Console.WriteLine("=============");
            //for(int i = 0;i < n; i++)
            //{
            //    if (freq[i] != -1)
            //    {
            //        Console.WriteLine($"{arr[i]} Occers {freq[i]} times");
            //    }
            //}
            #endregion

            #region Q23
            //int[] arr = new int[5];
            //int max = int.MinValue, min = int.MaxValue;

            //Console.WriteLine("Enter array element: ");
            //for(int i =  0; i < arr.Length; i++)
            //{
            //    arr[i] = Convert.ToInt32(Console.ReadLine());
            //}

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    if (arr[i] > max)
            //        max = arr[i];
            //    if (arr[i] < min)
            //        min = arr[i];
            //}
            //Console.WriteLine($"Maximum element: {max}");
            //Console.WriteLine($"Minimum element: {min}");

            #endregion

            #region Q24
            //int[] arr = new int[5];
            //int max = int.MinValue, secMax = int.MinValue;

            //Console.WriteLine("Enter array element: ");
            //for(int i = 0; i < arr.Length; i++)
            //{
            //    arr[i] = Convert.ToInt32(Console.ReadLine());
            //}

            //foreach (int i in arr)   
            //{
            //    if (i > max)
            //    {
            //        secMax = max;
            //        max = i;
            //    }
            //    else if (i > secMax && i != max)
            //    { 
            //        secMax = i;
            //    }
            //}

            //System.Console.WriteLine($"second largest element: {secMax}");

            #endregion

            #region Q25
            ////  ----------------8------------------
            //// |    --------------6------------    |
            //// |   |                           |   |
            ////[7 | 0 | 0 | 0 | 5 | 6 | 7 | 5 | 0 | 7 | 5 | 3 ]
            ////                 |                       |
            ////                  -----------5-----------

            ////const int size = 100;
            //Console.WriteLine("Enter number of element: ");
            //int size = Convert.ToInt32(Console.ReadLine());
            //int[] arr = new int[size];
            //int[] distances = new int[size];
            //int longest = int.MinValue;

            //for (int i = 0; i < size; i++)
            //{
            //    arr[i] = Convert.ToInt32(Console.ReadLine());
            //}

            //for(int i = 0; i < size; i++)
            //{
            //    int cell = 0;
            //    for(int j = i + 1; j < size; j++)
            //    {
            //        if (arr[i] == arr[j])
            //            cell = j - (i+1);
            //    }
            //    distances[i] = cell;
            //    if (distances[i] > longest)
            //        longest = distances[i];
            //}

            //Console.WriteLine($"Longest distance: {longest} cells");
            #endregion

            #region Q26
            //string str = Console.ReadLine();
            //char[] spearator = {' '};
            //int count = str.Length;
            //string[] strList = str.Split(spearator, count, StringSplitOptions.None);
            //for(int i = strList.Length - 1; i >= 0; i--)
            //{
            //    Console.Write($"{strList[i]} ");
            //}
            #endregion

            #region Q27
            //Console.WriteLine("Enter the size: ");
            //int size = Convert.ToInt32(Console.ReadLine());
            //int[,] firstArray = new int[size, size];
            //int[,] secArray = new int[size, size];

            //Console.WriteLine("Enter array element: ");
            //for(int i = 0; i < size; i++)
            //{
            //    for(int j = 0; j < size; j++)
            //    {
            //        firstArray[i, i] = Convert.ToInt32(Console.ReadLine());
            //    }
            //}

            //for (int i = 0; i < size; i++)
            //{
            //    for (int j = 0; j < size; j++)
            //    {
            //        secArray[i, j] = firstArray[i, j];
            //    }
            //}

            //Console.WriteLine("Element of seconed array: ");
            //for(int i = 0; i <size; i++)
            //{
            //    for (int j = 0;j < size; j++)
            //    {
            //        Console.Write($"{secArray[i, j]} ");
            //    }
            //    Console.WriteLine();
            //}
            #endregion

            #region Q28
            //int[] arr = { 1, 2, 3, 4, 5, 6 };
            //for(int i = arr.Length - 1; i >= 0; i--)
            //{
            //    Console.WriteLine(arr[i]);
            //}
            #endregion
        }
    }
}
