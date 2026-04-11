// Синфи хаёлӣ
abstract class Shape
{
    public double X { get; set; }
    public double Y { get; set; }

    public Shape(double x, double y)
    {
        X = x;
        Y = y;
    }

    public abstract double GetArea();
    public abstract double GetPerimeter();

    public virtual void Move(double dx, double dy)
    {
        X += dx;
        Y += dy;
    }

    public abstract void Scale(double factor);

    public bool IsBiggerThan(Shape other)
    {
        return this.GetArea() > other.GetArea();
    }

    public abstract Shape Clone();

    public virtual void PrintInfo()
    {
        Console.WriteLine(this.ToString());
    }

    public override string ToString()
    {
        return $"Shape at ({X}, {Y})";
    }
}

// Rectangle
class Rectangle : Shape
{
    public double Width { get; set; }
    public double Height { get; set; }

    public Rectangle(double x, double y, double width, double height)
        : base(x, y)
    {
        Width = width;
        Height = height;
    }

    public override double GetArea()
    {
        return Width * Height;
    }

    public override double GetPerimeter()
    {
        return 2 * (Width + Height);
    }

    public override void Scale(double factor)
    {
        Width *= factor;
        Height *= factor;
    }

    public override Shape Clone()
    {
        return new Rectangle(X, Y, Width, Height);
    }

    public override string ToString()
    {
        return $"Rectangle: W={Width}, H={Height}, Area={GetArea()}, Perimeter={GetPerimeter()}";
    }
}

// Circle
class Circle : Shape
{
    public double Radius { get; set; }

    public Circle(double x, double y, double radius)
        : base(x, y)
    {
        Radius = radius;
    }

    public override double GetArea()
    {
        return Math.PI * Radius * Radius;
    }

    public override double GetPerimeter()
    {
        return 2 * Math.PI * Radius;
    }

    public override void Scale(double factor)
    {
        Radius *= factor;
    }

    public override Shape Clone()
    {
        return new Circle(X, Y, Radius);
    }

    public override string ToString()
    {
        return $"Circle: R={Radius}, Area={GetArea():F2}, Perimeter={GetPerimeter():F2}";
    }
}