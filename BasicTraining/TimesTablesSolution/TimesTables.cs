using System;
using System.Collections.Generic;

namespace TimesTablesSolution
{
    public static class TimesTables
    {
        public static IEnumerable<int> GetTimesTableFor(int baseNumber, int timesTablesUpTo)
        {
            if(timesTablesUpTo <= 0)
            {
                throw new ArgumentOutOfRangeException();
            }

            List<int> returnListInts = new List<int>();

            for(int i = 1; i <= timesTablesUpTo; i++)
            {
                returnListInts.Add(i * baseNumber);
            }

            return returnListInts;
        }
    }
}
