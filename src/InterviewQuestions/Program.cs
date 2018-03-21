using System;
using InterviewQuestions.ViewModels;
using InterviewQuestions.Helpers;


namespace InterviewQuestions
{
    class Program
    {
        static void Main(string[] args)
        {

            /* EXAMPLES  */

            var array = ArrayViewModel.LeftRotationByD(new int[] { 1, 2, 3, 4, 5 }, 1);
            var fib = RecursionViewModel.Fibonacci(3);
            var palindrome = StringViewModel.IsStringPalindrome("Savvas");

            /* END OF EXAMPLES  */

            Console.ReadKey();
        }
    }
}
