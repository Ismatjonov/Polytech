namespace Operator;

class Program
{
    static void Main(string[] args)
    {
        Pereg a = new Pereg(25);
        Pereg b = new Pereg(45);
        int summa = a + b;
        Console.WriteLine(summa);
    }
}

class Pereg
{
    private int adad;

    public Pereg(int a)
    {
        adad = a;
    }

    static public int operator +(Pereg a, Pereg b)
    {
        return a.adad + b.adad;
    }
}