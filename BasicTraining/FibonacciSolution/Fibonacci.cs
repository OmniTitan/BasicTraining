using System;
using System.Collections.Generic;
using System.Linq;

namespace FibonacciSolution
{
    public static class Fibonacci
    {
        public static IEnumerable<int> DoFibonacciUpTo(int numberUpTo)
        {
            List<int> returnListInts = new List<int>();

            if(numberUpTo <= 0)
            {
                return returnListInts;
            }

            int last1 = 1;
            int last2 = 1;
            int current;

            returnListInts.Add(1);
            returnListInts.Add(1);

            while (true)
            {
                current = last1 + last2;
                last2 = last1;
                last1 = current;
                if(current > numberUpTo)
                {
                    break;
                }
                returnListInts.Add(current);
            }

            return returnListInts;
        }

        public static IEnumerable<int> DoFibonacciForNValues(int n)
        {
            List<int> returnListInts = new List<int>();

            if(n == 0)
            {
                return returnListInts;
            }

            int last = 1;
            int beforeLast = 1;
            int current;

            returnListInts.Add(beforeLast);
            returnListInts.Add(last);

            for(int i = 3; i <= n; i++)
            {
                current = last + beforeLast;
                beforeLast = last;
                last = current;
                returnListInts.Add(current);
            }

            return returnListInts;
        }

        public static int GetNthFibonacciValue(int n)
        {
            if (n <= 0)
            {
                throw new ArgumentException();
            }

            IList<int> fibonacciInts;
            fibonacciInts = DoFibonacciForNValues(n).ToList<int>();

            return fibonacciInts[fibonacciInts.Count() - 1];
            
        }
    }
}
