using System;
using InterviewQuestions.ViewModels;
using InterviewQuestions.Helpers;


namespace InterviewQuestions
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome!");

            var array = ArrayViewModel.LeftRotationByD(new int[] { 1, 2, 3, 4, 5 }, 1);
            var fib = RecursionViewModel.Fibonacci(3);

            Console.ReadKey();
        }
    }
}
