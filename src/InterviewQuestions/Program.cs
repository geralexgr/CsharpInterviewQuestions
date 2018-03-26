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
            var fib = RecursionViewModel.Fibonacci(3);
            var palindrome = StringViewModel.IsStringPalindrome("Savvas");
            var sorted = LinkedListViewModel.InsertItemInSortedList(linkedlist, new LinkedListNode<int>(1));
            var removed = LinkedListViewModel.RemoveDuplicatesFromSortedList(linkedlist);
            ArrayViewModel.PrintMultiplicationTable(10);
            var result = ArrayViewModel.MaximumSumSubArray(new int[] { -2, -3, 4, -1, -2, 1, 5, -3 });
            var tuple = StringViewModel.LongesConsecutiveCharacters("AABCDDBBBEA");
            /* END OF EXAMPLES  */

            Console.ReadKey();
        }
    }
}
