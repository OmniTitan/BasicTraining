using System;

namespace SmallestBiggestSolution
{
    public static class SmallestBiggest
    {
        public static int GetSmallest(int[] numbers)
        {
            if(numbers.Length == 0)
            {
                throw new ArgumentException();
            }

            int lowest = numbers[0];

            foreach(int i in numbers)
            {
                if (i < lowest)
                {
                    lowest = i;
                }
            }

            return lowest;
        }

        public static int GetBiggest(int[] numbers)
        {
            if (numbers.Length == 0)
            {
                throw new ArgumentException();
            }

            int biggest = numbers[0];

            foreach (int i in numbers)
            {
                if (i > biggest)
                {
                    biggest = i;
                }
            }

            return biggest;
        }
    }
}
