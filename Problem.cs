namespace FizzBuzz
{
    public class Problem : Logic
    {
        public string[] FooFizzBuzz(int num, Dictionary<int, string> map)
        {
            string[] stringArray = new string[num];

            for (int i = 1; i <= num; i++)
            {
                stringArray[i - 1] = LogicForFizzBuzz(i, map);
            }
            return stringArray;
        }
    }
}
