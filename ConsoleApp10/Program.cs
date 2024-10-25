using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
   class MyArray:iCalc, iOutput2, iCalc2
    {
        private int length;
        private int[] arr;
        private static readonly Random rnd = new Random();
        public int Length {  get { return length; } }

        public MyArray() {
            arr = new int[10];
        }
        public MyArray(int length) 
        {
            arr = new int[length];
            for(int i = 0; i < arr.Length; i++)
            {
                arr[i] = rnd.Next(1,30);
            }
            Console.WriteLine("Array has been created!");
        }

        public void ShowArr()
        {
            Console.WriteLine("Array: ");
            for(int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine(" ");
        }

        public int Less(int valueToCompare)
        {
            int count = 0;
            for(int i = 0; i < arr.Length ; i++)
            {
                if (arr[i] < valueToCompare)
                {
                    count++;
                }
            }
            return count;
        }

        public int Greater(int valueToCompare)
        {
            int count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > valueToCompare)
                {
                    count++;
                }
            }
            return count;
        }

        public void ShowEven()
        {
            Console.Write("Even num: ");
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] %2 == 0)
                {
                    Console.WriteLine(arr[i]);
                }
            }
        }

        public void ShowOdd()
        {
            Console.Write("Odd num: ");
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 != 0)
                {
                    Console.Write(arr[i] + " ");
                }
            }
            Console.WriteLine(" ");
        }

        public int EqualToValue(int valueToCompare)
        {
            int count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == valueToCompare)
                {
                    count++;
                }
            }
            return count;
        }

        public int CountDistinct()
        {
            int res = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                bool isDistinct = true;

                for (int j = 0; j < i; j++) 
                {
                    if (arr[i] == arr[j]) 
                    {
                        isDistinct = false;
                        break;
                    }
                }

                if (isDistinct)
                {
                    res++;
                }
            }
            return res;
        }



    }
}
