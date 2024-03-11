using FizzBuzz;

class Program
{
    public static int[] divisors = [2, 3, 5, 7, 11, 13]; // The initial value of divisors, if the user wants he/she can change it
    // as he/she wants

    static void Main(string[] args)
    {
        Problem myObject = new Problem(); // creating a new object for the problem FizzBuzz

        var result = myObject.FooFizzBuzz(30); // Giving 30 to the FooFizzBuzz function and receiving the array string to the result

        foreach (var item in result)
        {
            Console.WriteLine(item); // Printing the result for checking the result
        }
    }
}