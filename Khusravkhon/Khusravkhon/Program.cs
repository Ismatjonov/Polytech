class Program
{
    static void Main()
    {
        Formula f = new Formula();
        f.Expression = "12+3-5";
        
        Formula f2 = new Formula();
        f2.Expression = "123-25+36";

        Console.WriteLine(f.Calculate()); 
        Console.WriteLine(f2.Calculate());
    }
}