using System;
using System.Collections.Generic;
using System.Linq;

namespace FizzBuzzSolution
{
    public class FizzBuzz
    {
        public static IEnumerable<string> PlayFizzBuzzUpTo(int upTo)
        {
            List<string> fizzBuzzResults = new List<string>();
            for (int i = 1; i <= upTo; i++)
            {
                if(i % 3 == 0 && i % 5 == 0)
                {
                    fizzBuzzResults.Add("FizzBuzz");
                }
                else if (i % 3 == 0)
                {
                    fizzBuzzResults.Add("Fizz");
                }
                else if (i % 5 == 0)
                {
                    fizzBuzzResults.Add("Buzz");
                }
                else
                {
                    fizzBuzzResults.Add(i.ToString());
                }
            }

            return fizzBuzzResults;
        }

        public static IEnumerable<string> PlayFizzBuzz2UpTo(int upTo, IDictionary<int, string> fizzBuzzSettings)
        {
            List<string> fizzBuzzResults = new List<string>();
            
            if(fizzBuzzSettings == null)
            {
                throw new System.ArgumentNullException();
            }

            for (int i = 1; i <= upTo; i++)
            {
                string currentValue = "";

                var sortedKeys = fizzBuzzSettings.Keys.ToList();
                sortedKeys.Sort();

                foreach(var item in sortedKeys)
                {
                    if(i % item == 0)
                    {
                        currentValue = currentValue + fizzBuzzSettings[item];
                    }
                }

                if (currentValue == "")
                {
                    currentValue = i.ToString();
                }

                fizzBuzzResults.Add(currentValue);
            }

            return fizzBuzzResults;

        }
    }
}