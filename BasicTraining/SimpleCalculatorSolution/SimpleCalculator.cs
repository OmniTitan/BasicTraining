using System;

namespace SimpleCalculatorSolution
{
    public static class SimpleCalculator
    {
        public static double Calculate(string sum)
        {
            var sumParts = getSumParts(sum);

            if(sumParts.Item2 == null)
            {
                return sumParts.Item1;
            }

            switch (sumParts.Item2)
            {
                case "/":
                    return (double)sumParts.Item1 / (double)sumParts.Item3;
                case "+":
                    return sumParts.Item1 + sumParts.Item3;
                case "-":
                    return sumParts.Item1 - sumParts.Item3;
                case "*":
                    return sumParts.Item1 * sumParts.Item3;
                default:
                    throw new ArgumentException();    
            }

            
        }


        private static Tuple<int, string, int> getSumParts(string sum)
        {
            if(sum == null)
            {
                throw new ArgumentNullException();
            }

            string[] sumParts = sum.Split(' ');

            if(sumParts.Length == 2 || sumParts.Length > 3)
            {
                throw new ArgumentException();
            }

            int first;
            int second;

            try
            {
                first = int.Parse(sumParts[0]);
            } catch
            {
                throw new ArgumentException();
            }

            try
            {
                
                if(sumParts.Length > 1)
                {
                    second = int.Parse(sumParts[2]);

                    return Tuple.Create(first, sumParts[1], second);
                }
                return Tuple.Create<int, string, int>(first, null, 0);
            }
            catch
            {
                throw new InvalidCastException();
            }

        
            
        }
        
        // Hint: You may want to split out the pieces of the calculator into other methods (one for add, one for subtract etc)
        // Hint 2: You may want to split the functionality to split the string into its 3 parts (number1, operator, number2) into a different method too
    }
}
