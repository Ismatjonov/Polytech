namespace Lesson4.Classes;

public partial class Rectangle
{
    public int A { get; set; }
    public int B { get; set; }

    public Rectangle(int a, int b)
    {
        A = a;
        B = b;
    }

    public void Perimeter()
    {
        Console.WriteLine($"Периметри росткунча: {(A + B) * 2}");
    }

    public void Area()
    {
        Console.WriteLine($"Масохати росткунча: {A * B}");
    }
}