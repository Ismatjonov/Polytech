namespace Olymp3;

class Program
{
    static void Main(string[] args)
    {
        string input = Console.ReadLine();
        string[] vars = input.Split(" ");
        List<int> numbers = new List<int>();
        numbers.Add(int.Parse(vars[0]));
        numbers.Add(int.Parse(vars[1]));
    }
}