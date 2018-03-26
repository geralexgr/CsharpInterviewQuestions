using System;
using System.Collections.Generic;
using System.Text;

namespace InterviewQuestions.ViewModels
{
    public static class ArrayViewModel
    {


        public static int[] LeftRotationByD(int[] a, int k)
        {
            int[] b = new int[a.Length];

            int index;
            int length = a.Length;
            int place;

            for (int i = 0; i < length; i++)
            {
                index = i - k;
                place = length + index;

                if (index >= 0) b[index] = a[i];
                else b[place] = a[i];  
            }
            return b;
        }

        public static void PrintMultiplicationTable(int n)
        {

            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    Console.Write(i * j + " ");
                }
                Console.WriteLine();
            }
        }

        public static int MaximumSumSubArray(int[] a)
        {
            int max = a[0];
            int temp_max = a[0];

            for (int i = 1; i < a.Length; i++)
            {
                temp_max += a[i];
                if (temp_max < a[i]) temp_max = a[i];
                if (temp_max > max) max = temp_max;
            }
            return max;
        }



    }
}
