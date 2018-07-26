using System;
using System.Collections.Generic;

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

            while (1 > 0)
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
            throw new NotImplementedException();
        }

        public static int GetNthFibonacciValue(int n)
        {
            throw new NotImplementedException();
        }
    }
}
