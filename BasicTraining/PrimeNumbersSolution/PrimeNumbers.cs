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
                // Throw the exception.
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
            throw new NotImplementedException();
        }

        public static IEnumerable<int> GetPrimesUpTo(int upTo)
        {
            throw new NotImplementedException();
        }

        public static bool IsAPrimeNumber(int isThisAPrime)
        {
            throw new NotImplementedException();
        }
    }
}
