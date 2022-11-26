using System;

namespace Basic_Training_CS
{

    class Maths
    {
        public static void Min(int MinValue1, int MinValue2)
        {
            if (MinValue1 < MinValue2)
            {
                Console.WriteLine("Smaller number is: " + MinValue1);
            }
            else if (MinValue2 == MinValue1)
            {
                Console.WriteLine("Numbers are Equal");
            }
            else
            {
                Console.WriteLine("Smaller number is: " + MinValue2);
            }

        }

        public static void Max(int MaxValue1, int MaxValue2)
        {
            if (MaxValue1 > MaxValue2)
            {
                Console.WriteLine("Maximum number is: " + MaxValue1);
            }
            else if (MaxValue2 == MaxValue1)
            {
                Console.WriteLine("Numbers are Equal");
            }
            else
            {
                Console.WriteLine("Maximum number is: " + MaxValue2);

            }
        }

        public static int Factorial(int n)
        {
            if (n == 1)
            {
                return 1;
            }
            else if (n == 0)
            {
                return 1;
            }
            return n * Factorial(n - 1);
        }

        public static void Sort(int[] arr)
        {
            int i, j, k;
            // for 10 indexes
            for (i = 0; i < 9; i++)
            {
                k = arr[i];
                j = i - 1;

                while (j >= 0 && arr[j] > k)
                {
                    {
                        arr[j + 1] = arr[j];
                        j = j - 1;
                    }
                    arr[j + 1] = k;
                }
            }
            for (int traverse = 0; traverse < 9; traverse++)
            {
                Console.WriteLine(arr[traverse] + " ");
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number for Min Value Calculation: ");
            int MinValue1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter another number for Min Value Calculation: ");
            int MinValue2 = Convert.ToInt32(Console.ReadLine());
            Min(MinValue1, MinValue2);

            Console.WriteLine("Enter a number for Max Value Calculation: ");
            int MaxValue1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter another number for Max Value Calculation: ");
            int MaxValue2 = Convert.ToInt32(Console.ReadLine());
            Max(MaxValue1, MaxValue2);

            Console.WriteLine("Enter a positive value for Factorial Calculation: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(n + "! = " + Factorial(n));


            Console.WriteLine("Sorted array is: ");
            int[] arr = { 41, 1, 9, 13, 5, 6, 2, 18, 7 };
            Sort(arr);
        }
    }

}

