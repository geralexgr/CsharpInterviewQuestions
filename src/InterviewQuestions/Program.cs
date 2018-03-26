using System;
using InterviewQuestions.ViewModels;
using InterviewQuestions.Helpers;
using System.Collections.Generic;

namespace InterviewQuestions
{
    class Program
    {
        static void Main(string[] args)
        {

            /* EXAMPLES  */

            var array = ArrayViewModel.LeftRotationByD(new int[] { 1, 2, 3, 4, 5 }, 1);
            LinkedList<int> linkedlist = new LinkedList<int>(new int[] { 1, 2, 3, 4, 5 });

            var fibN1 = 40;
            var watch = System.Diagnostics.Stopwatch.StartNew();
            var fib = RecursionViewModel.Fibonacci(fibN1);
            watch.Stop();
            var elapsedMs = watch.ElapsedMilliseconds;
            Console.WriteLine(string.Format("Fib Recursion n = {0} solution {2} Elapsed Ms {1}", fibN1, elapsedMs, fib));


            Console.WriteLine(string.Format("Fib DP n = {0} solution {1}", fibN1, RecursionViewModel.Fibonacci_DynamicProgramming(fibN1)));

            var fibN2 = 40000;
            var watch2 = System.Diagnostics.Stopwatch.StartNew();
            var fib2 = RecursionViewModel.Fibonacci_DynamicProgramming(fibN2);
            watch2.Stop();
            var elapsedMs2 = watch2.ElapsedMilliseconds;
            Console.WriteLine(string.Format("Fib DP n = {0} solution {2}  Elapsed Ms {1}", fibN2, elapsedMs2, fib2));


            var palindrome = StringViewModel.IsStringPalindrome("Savvas");
            var sorted = LinkedListViewModel.InsertItemInSortedList(linkedlist, new LinkedListNode<int>(1));
            var removed = LinkedListViewModel.RemoveDuplicatesFromSortedList(linkedlist);
            ArrayViewModel.PrintMultiplicationTable(10);
            var result = ArrayViewModel.MaximumSumSubArray(new int[] { -2, -3, 4, -1, -2, 1, 5, -3 });
            /* END OF EXAMPLES  */

            Console.ReadKey();
        }
    }
}
