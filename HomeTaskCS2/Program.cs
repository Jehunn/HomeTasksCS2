using System;
using System.Threading;

namespace HomeTaskCS2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int[] arr = { 1, 2, 3, 4 };
            //AddInt(arr);


            int num;
            SetZero(out num);
            var result = num;


            Console.WriteLine(num);
            string name = "Huseyn";
            name = null;

            SetZero(ref name);
            Console.WriteLine(name);


            int[] numbers = { 19, 8, 52 };
            SetZero(numbers);

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }


            int num1 = -72;
            MakePositive(ref num1);
            Console.WriteLine(num1);

            numbers = new int[] { 34, 23, -12, 33, -23, -4, 5 };

            MakePositive(ref numbers);

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }

            int number = 12;

            AddTen(ref number);

            Console.WriteLine(number);

            int point = 23;
            CorrectPoint(ref point);

            Console.WriteLine(point);

            numbers = new int[] { 4, 3, 2, 5, 6, 8, 9 };

            MakeEven(ref numbers);
            Console.WriteLine("Even numbers:");

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }

        }



        #region HomeTask
        //static void AddInt(int[] arr)
        //{
        //    int count = 0;
        //    for(int i=0; i < arr.Length; i++)
        //    {
        //        if (arr[i] >= arr.Length) ;

        //    }

        //    int[] newArr = new int[count];

        //}
        #endregion


        
        static void AddTen(ref int num)
        {
            num += 10;
        }

        
        static void CorrectPoint(ref int point)
        {
            if (point < 0)
            {
                point = 0;
            }
            else if (point > 100)
            {
                point = 100;
            }
        }

        
        static void MakeEven(ref int[] arr)
        {
            int count = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                    count++;
            }
            int[] arrNew = new int[count];

            int j = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    arrNew[j] = arr[i];
                    j++;
                }
            }

            arr = arrNew;
        }

        static void SetZero(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = 0;
            }
            arr = new int[arr.Length];
        }

        static void SetZero(out int number)
        {
            number = 0;
        }

        static void SetZero(ref string str)
        {
            str = "0";
        }

        static void MakePositive(ref int num)
        {
            if (num < 0)
                num *= -1;
        }

        static void AddZero(ref string str)
        {
            str = str + "0";
        }

        static void MakePositive(ref int[] arr)
        {
            int count = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > 0)
                    count++;
            }

            int[] newArr = new int[count];
            int j = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > 0)
                {
                    newArr[j] = arr[i];
                    j++;
                }
            }

            arr = newArr;
        }





    }
}   
