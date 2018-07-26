using System;
using System.Collections.Generic;

namespace PrimeNumbersSolution
{
    public static class PrimeNumbers
    {
        public static IEnumerable<int> GetFactors(int factorsOf)
        {
            if(factorsOf < 0)
            {
                throw new NotSupportedException();
            }

            List<int> returnListInts = new List<int>(); 
            for (int i = 1; i <= factorsOf; i++)
            {
                if(factorsOf % i == 0)
                {
                    returnListInts.Add(i);
                }
            }

            return returnListInts;
        }

        public static IEnumerable<int> GetNPrimes(int numberOfPrimesToGet)
        {
            if(numberOfPrimesToGet < 0)
            {
                throw new ArgumentException();
            }

            List<int> returnListInts = new List<int>();
            int i = 1;
            while(returnListInts.Count < numberOfPrimesToGet)
            {
                if (IsAPrimeNumber(i))
                {
                    returnListInts.Add(i);
                }
                i++;
            }

            return returnListInts;

        }

        public static IEnumerable<int> GetPrimesUpTo(int upTo)
        {
            List<int> returnListInts = new List<int>();

            for(int i = 1; i <= upTo; i++)
            {
                if (IsAPrimeNumber(i))
                {
                    returnListInts.Add(i);
                }
            }
            return returnListInts;
        }

        public static bool IsAPrimeNumber(int isThisAPrime)
        {
            if(isThisAPrime < 0)
            {
                throw new NotSupportedException();
            }

            if (isThisAPrime == 0 || isThisAPrime == 1)
            {
                return false;
            }
            

            for (int i = 2; i < isThisAPrime; i++)
            {
                if (isThisAPrime % i == 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
