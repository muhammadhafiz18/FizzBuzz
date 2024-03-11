namespace FizzBuzz
{
    public class Problem : Logic // Inheriting the Logic class because there is a method - LogicForFizzBuzz
    {
        public string[] FooFizzBuzz(int num) // Receiving 30
        {
            string[] stringArray = new string[0]; // Declaring a new array for returning the final result

            for (int i = 1; i <= num; i++) // Iterating till 30 (30 is included)
            {
                Array.Resize(ref stringArray, stringArray.Length + 1); // Expanding the size of array in order to add the result
                stringArray[stringArray.Length - 1] = LogicForFizzBuzz(i); // Appending the result, for getting the result sending 
                // i to the LogicForFizzBuzz in order to check whether the number is divisible by any divisors in Program.cs
            }

            return stringArray; // Returning the result [1, foo, fizz, foo, buzz, .........]
        }
    }
}
