using System;
using System.Numerics;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Sonbol
{
    internal class Program
    {
        #region Q1


        //public static void PrintShape(string pattern, int count )
        //{
        //    for (int i = 0; i < count; i++)
        //    {
        //        Console.WriteLine(pattern);
        //    }
        //}

        // -------

        //public static void swap (ref int x , ref int  y)
        //{
        //    int temp = x;  
        //    x = y; 
        //    y = temp;   
        //}
        #endregion


        #region Q2

        //static void ChangeByValue(int[] arr)
        //{
        //    arr[0] = 100;   // ده هيسمع بره
        //    arr = new int[3] { 7, 7, 7 }; // ده مش هيسمع بره
        //}

        //static void ChangeByReference(ref int[] arr)
        //{
        //    arr[0] = 200;   // ده هيسمع بره
        //    arr = new int[3] { 7, 7, 7 }; // ده بردو هيسمع بره
        //}

        //static void PrintArray(int[] arr)
        //{
        //    for (int i = 0; i < arr.Length; i++)
        //    {
        //        Console.Write(arr[i] + " ");
        //    }
        //    Console.WriteLine();
        //}


        #endregion

        #region Q3

        //public static void SumAndSub (int x, int y, ref int sum, ref int sub)
        //{
        //    sum = x + y;
        //    sub = x - y;

        //}

        #endregion

        #region Q4

        //public static void SumNum (int num)
        //{

        //    int NewNum = 0;

        //    while (num > 0)
        //    {
        //        int RightNum = num % 10;
        //        num = num / 10;
        //        NewNum += RightNum;


        //    }

        //    Console.WriteLine($"Sum of digits = {NewNum}");

        //}

        #endregion

        #region Q5

        //public static bool IsPrime (int num) {

        //   if (num <= 1) return false;

        //   for (int i = 2; i < num - 1; i++)
        //    {
        //        if (num % i == 0) return false; 

        //    }

        //   return true;

        //}


        #endregion

        #region Q6

        //public static void MinMaxArray(int[] num, ref int Max, ref int min)
        //{
        //    for (int i = 0; i < num.Length; i++) {

        //        if (num[i] > Max) Max = num[i];

        //        else if (num[i] < min) min = num[i];


        //    }

        //}




        #endregion

        #region Q7

        //public static void factorialOfTheNum (int num )
        //{
        //    int result = 1;

        //    for ( int i = 1; i <= num; i++ )
        //    {
        //        result *= i;

        //    }

        //    Console.WriteLine($"Factorial of {num} = {result}");
        //}

        #endregion

        #region Q8

        //public static string ChangeChar(string name, int position, char c)
        //{

        //    if (position < 0 || position >= name.Length)
        //    {
        //        return "Invalid position"; 

        //    }

        //    return name.Substring(0, position) + c + name.Substring(position + 1);

        //}

        #endregion


        #region Q9

        //public static int SumArray(int[] arr)
        //{
        //    int sum = 0;

        //    for (int i = 0; i < arr.Length; i++)
        //    {
        //        sum += arr[i];
        //    }

        //    return sum;
        //}

        #endregion


        #region Q10

        //public static int[] MergeArrays(int[] arr1, int[] arr2)
        //{
        //    int size = arr1.Length + arr2.Length;
        //    int[] merged = new int[size];


        //    for (int i = 0; i < arr1.Length; i++)
        //    {
        //        merged[i] = arr1[i];
        //    }


        //    for (int i = 0; i < arr2.Length; i++)
        //    {
        //        merged[arr1.Length + i] = arr2[i];
        //    }


        //    Array.Sort(merged);

        //    return merged;
        //}

        #endregion

        static void Main(string[] args)
        {


            #region Q1

            //by value --> بتبعت القيمه نفسها ولو حصل تعديل علي القيمه مش بتسمع فالمتغير الاصلي  
            //example --> static void PrintShape 
            //PrintShape("21", 7);

            // _______

            // by reference --> بتبعت المكان نفسه ولو حصل اي تعديل قيمه بتسمع فالمتغير الاصلي 
            //example --> static void Swap 

            //int x = 7;
            //int y = 9;
            //Console.WriteLine($"Befor swaping \n x = {x} \n y = {y} ");
            //swap (ref x , ref y);
            //Console.WriteLine($"After swaping \n x = {x} \n y = {y} ");

            #endregion


            #region Q2

            //int[] numbers = { 1, 2, 3 };

            //ChangeByValue(numbers);
            //Console.Write("After ChangeByValue: ");
            //PrintArray(numbers);

            //ChangeByReference(ref numbers);
            //Console.Write("After ChangeByReference: ");

            //PrintArray(numbers);

            #endregion


            #region Q3

            //int x = 7; 
            //int y = 3; 
            //int sum = 0;
            //int sub = 0;   

            //SumAndSub (x, y , ref sum, ref sub);    

            //Console.WriteLine ($" sum = {sum} \n sub = + {sub} " );  

            #endregion


            #region Q4

            //SumNum (25);

            #endregion


            #region Q5

            //Console.WriteLine(IsPrime(7));  
            //Console.WriteLine(IsPrime(21)); 
            //Console.WriteLine(IsPrime(0));  


            #endregion


            #region Q6

            //int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 };
            //int max = arr[0];   
            //int min = arr[1];
            //MinMaxArray(arr, ref max, ref min);



            //Console.WriteLine($"max = {max} \nmin = {min}");

            #endregion


            #region Q7

            // factorialOfTheNum(7);
            #endregion


            #region Q8

            //Console.WriteLine(ChangeChar("Hello", 1, 'a'));  
            //Console.WriteLine(ChangeChar("Sonbol", 3, 'p'));

            #endregion


            #region Q9

            //int[] numbers = { 7, 21};
            //Console.WriteLine("Sum = " + SumArray(numbers));

            #endregion


            #region Q10

            //int[] arr1 = { 7, 5, 3 };
            //int[] arr2 = { 2, 4, 6 };

            //int[] result = MergeArrays(arr1, arr2);

            //Console.Write("Merged & Sorted Array: ");
            //foreach (int num in result)
            //{
            //    Console.Write(num + " ");
            //}

            #endregion


            #region Q12

            //int[] numbers = { 1, 2, 3, 4, 7 };

            //int min = numbers[0];
            //int max = numbers[0];

            //for (int i = 1; i < numbers.Length; i++)
            //{
            //    if (numbers[i] < min)
            //        min = numbers[i];
            //    if (numbers[i] > max)
            //        max = numbers[i];
            //}

            //Console.WriteLine($"Minimum element = {min}");
            //Console.WriteLine($"Maximum element = {max}");

            #endregion


            #region Q13

            //int[] arr = { 10, 5, 8, 20, 15 };

            //Array.Sort(arr);

            //int secondLargest = arr[arr.Length - 2];

            //Console.WriteLine($"Second largest element = {secondLargest}");

            #endregion


            #region Q15

            //Console.WriteLine("Enter a sentence: ");
            //string input = Console.ReadLine();

            //string word = "";

            //for (int i = input.Length - 1; i >= 0; i--)
            //{
            //    if (input[i] == ' ')
            //    {
            //        if (word != "")
            //        {
            //            
            //            for (int j = word.Length - 1; j >= 0; j--)
            //            {
            //                Console.Write(word[j]);
            //            }
            //            Console.Write(" ");
            //            word = "";
            //        }
            //    }
            //    else
            //    {
            //        word += input[i];
            //    }
            //}


            //if (word != "")
            //{
            //    for (int j = word.Length - 1; j >= 0; j--)
            //    {
            //        Console.Write(word[j]);
            //    }
            //}

            #endregion


            #region Q16

            //Console.Write("Enter number of rows: ");
            //int rows = int.Parse(Console.ReadLine());

            //Console.Write("Enter number of columns: ");
            //int cols = int.Parse(Console.ReadLine());

            //int[,] arr1 = new int[rows, cols];
            //int[,] arr2 = new int[rows, cols];


            //Console.WriteLine("Enter elements of first array:");
            //for (int i = 0; i < rows; i++)
            //{
            //    for (int j = 0; j < cols; j++)
            //    {
            //        Console.Write($"Element [{i},{j}]: ");
            //        arr1[i, j] = int.Parse(Console.ReadLine());
            //    }
            //}


            //for (int i = 0; i < rows; i++)
            //{
            //    for (int j = 0; j < cols; j++)
            //    {
            //        arr2[i, j] = arr1[i, j];
            //    }
            //}


            //Console.WriteLine("Elements of second array: ");

            //for (int i = 0; i < rows; i++)
            //{
            //    for (int j = 0; j < cols; j++)
            //    {
            //        Console.Write(arr2[i, j] + " ");
            //    }
            //    Console.WriteLine();
            //}

            #endregion


            #region Q17

            //int[] arr = { 1, 2, 3, 4, 5 };
            //Array.Reverse(arr); 

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.Write(arr[i] + " ");
            //}

            //Console.WriteLine();

            //حل اخر

            //int[] arr = { 1, 2, 3, 4, 5 };

            //Console.WriteLine("Array in Reverse Order:");
            //for (int i = arr.Length - 1; i >= 0; i--)
            //{
            //    Console.Write(arr[i] + " ");
            //}

    
            #endregion



        }
    }
}
