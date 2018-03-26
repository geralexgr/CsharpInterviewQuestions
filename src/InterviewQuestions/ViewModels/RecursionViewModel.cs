using System;
using System.Collections.Generic;
using System.Numerics;
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

        public static BigInteger Fibonacci_DynamicProgramming(int n)
        {
            var F = new BigInteger[n + 1];
            F[0] = 0;
            F[1] = 1;

            for (int i = 2; i < F.Length; i++)
            {
                F[i] = F[i - 1] + F[i - 2];
            }

            return F[n];
        }

    }
}
