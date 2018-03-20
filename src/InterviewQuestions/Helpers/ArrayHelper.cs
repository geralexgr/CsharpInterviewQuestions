using System;
using System.Collections.Generic;
using System.Text;

namespace InterviewQuestions.Helpers
{
    public static class ArrayHelper
    {


        public static void PrintIntArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
        }



    }
}
