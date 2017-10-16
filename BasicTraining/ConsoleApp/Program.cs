using FizzBuzzSolution;
using FibonacciSolution;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var upTo = ConsoleIO.GetInt("Please enter a number to do the fibonacci sequence up to");

            var results = Fibonacci.DoFibonacciUpTo(upTo);

            ConsoleIO.WriteCollection(results);

            ConsoleIO.WaitForKeyPress();
        }
    }
}
