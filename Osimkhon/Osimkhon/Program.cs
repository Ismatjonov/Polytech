using System;

// Барномаи асосӣ
class Program
{
    static void Main()
    {
        Shape rect = new Rectangle(0, 0, 5, 4);
        Shape circle = new Circle(2, 2, 3);

        rect.PrintInfo();
        circle.PrintInfo();

        Console.WriteLine("\n--- Муқоиса ---");
        Console.WriteLine(rect.IsBiggerThan(circle) ? "Rectangle калонтар" : "Circle калонтар");

        Console.WriteLine("\n--- Scale ---");
        rect.Scale(2);
        circle.Scale(0.5);

        rect.PrintInfo();
        circle.PrintInfo();

        Console.WriteLine("\n--- Move ---");
        rect.Move(10, 5);
        rect.PrintInfo();

        Console.WriteLine("\n--- Clone ---");
        Shape copy = rect.Clone();
        copy.PrintInfo();
    }
}