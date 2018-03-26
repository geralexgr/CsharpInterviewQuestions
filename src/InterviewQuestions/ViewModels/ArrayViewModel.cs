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



    }
}
