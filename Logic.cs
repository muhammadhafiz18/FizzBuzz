namespace FizzBuzz
{
    public class Logic
    {
        public string LogicForFizzBuzz(int num) // Receiving the i from Problem class
        {
            string resultString = ""; // Declaring the string for returning the value that is assigned to the final result variable

            foreach (var divisor in Program.divisors) // Itarating through Program.divisors for checking the number whether it is
                // by any number in Program.divisors
            {
                if (num % divisor == 0) // if num(let's say 2) (i from Problem.cs) is divisible by 30 for example,
                                        // it goes to the second case
                {
                    switch (divisor)
                    {
                        case 2: resultString += "Foo"; // if divisor (i from Problem.cs) is 2, then Foo is added to the resultString
                        break;

                        case 3: resultString += "Fizz"; // if divisor is 3, then Fizz is added to the resultString
                        break;

                        case 5: resultString += "Buzz"; // if divisor is 5, then Buzz is added to the resultString
                        break;

                        case 7: resultString += "Shee";
                        break;

                        case 11: resultString += "Boo";
                        break;
                        // Add the conditions as needed, but do not forget to give the initial value of divisors as well
                    }

                }
            }
            if (resultString == "") // If even after the loop, inside the resultString is nothing, then the num itself is added
                // to the resultString, but int now is string
            {
                resultString += $"{num}";
            }

            return resultString; // So, if the number is 30, then the returning result is "FooFizzBuzz"
        }
    }
}
