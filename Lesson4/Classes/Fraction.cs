namespace Lesson4.Classes;

public class Fraction
{
    private int x;
    private int y;

    public int X
    {
        get => x;
        set => x = value;
    }
    public int Y
    {
        get
        {
            return y;
        }
        set
        {
            if (value != 0)
            {
                y = value;
            }
            else
            {
                y = 1;
            }
        }
    }

    public Fraction(int x, int y)
    {
        X = x;
        Y = y;
    }

    public float Adad
    {
        get
        {
            return (float)X / Y;
        }
    }

    public void Print()
    {
        Console.WriteLine($"Табдилдихи ба сатр: {X}/{Y}");
    }

    public void Ikhtisor()
    {
        int tempX = 1;
        int tempY = 1;
        for (int i = 1; i < Y; i++)
        {
            if (X % i == 0 && Y % i == 0)
            {
                tempX = X / i;
                tempY = Y / i;
            }
        }
        Console.WriteLine($"Ихтисори каср: {tempX}/{tempY}");
    }

    public static void Compare(Fraction f1, Fraction f2)
    {
        if(f1.Adad < f2.Adad)
            Console.WriteLine($"Касри калонтарин: {f2.X}/{f2.Y}");
        Console.WriteLine($"Касри калонтарин: {f1.X}/{f1.Y}");
    }
}