namespace FizzBuzz
{
    public class Logic
    {
        public string LogicForFizzBuzz(int num, Dictionary<int, string> map)
        {
            string resultString = ""; 

            foreach (var item in map)
            {
                var divisor = item.Key;
                if (num % divisor == 0) 
                {
                    resultString += item.Value;

                }
            }

            if (resultString == "")
            {
                resultString += $"{num}";
            }

            return resultString; 
        }
    }
}
