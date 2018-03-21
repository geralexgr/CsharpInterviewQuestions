using System;
using System.Collections.Generic;
using System.Text;

namespace InterviewQuestions.ViewModels
{
    public static class RecursionViewModel
    {

        public static int Fibonacci(int n)
        {
            if (n == 0) return 0;
            else if (n == 1) return 1;
            else
            {
                return Fibonacci(n - 1) + Fibonacci(n - 2);
            }
        }

    }
}
