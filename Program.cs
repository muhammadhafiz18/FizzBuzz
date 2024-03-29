using FizzBuzz;

Dictionary<int, string> map = new Dictionary<int, string>();
map.Add(2, "faa");
map.Add(3, "fizz");
map.Add(5, "buzz");
map.Add(7, "Shee");
map.Add(9, "Woo");
map.Add(11, "Boo");

Problem myObject = new Problem(); 

var result = myObject.FooFizzBuzz(30, map);

foreach (var item in result)
{
    Console.WriteLine(item);
}
