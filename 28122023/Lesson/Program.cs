using System;

namespace Lesson
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 10;
            int[] numArr = { 23, -34,-6,10,4 };
            int count;


            SetZero(out count);
            Console.WriteLine(num);
            SetZero( numArr);
            Console.WriteLine(numArr[0]);
            string text = "salam";
            SetZero(ref text);
            Console.WriteLine(text);


            MakePositive(ref numArr);
            for (int i = 0; i < numArr.Length; i++)
            {
                Console.WriteLine(numArr[i]);
            }

        }

        static void SetZero(out int num)
        {
            num = 0;
        }

        static void SetZero(int[] arr)
        {
            arr[0] = 0;
        }

        static void SetZero(ref string str)
        {
            str = "0";
        }

        static void MakePositive(ref int[] arr)
        {
            int count = 0;
            int index = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > 0) count++;
            }

            int[] positivArr = new int[count];

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > 0)
                {
                    positivArr[index++] = arr[i];
                }
            }

            arr=positivArr;
        }
    }
}
