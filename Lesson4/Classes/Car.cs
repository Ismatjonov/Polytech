namespace Lesson4.Classes;

public class Car
{
    public string Brand { get; set; }
    public string Model { get; set; }
    public string Number { get; set; }
    public string Color { get; set; }
    public int Year { get; set; }
    public int Sits { get; set; }
    public Driver driver { get; set; }

    public Car(string brand, string model, string number, string color, int year, int sits)
    {
        Brand = brand;
        Model = model;
        Number = number;
        Color = color;
        Year = year;
        Sits = sits;
    }

    public Car(Driver driver) : this("Unknown", "Unknown", "0000", "Black", 2000, 4)
    {
        this.driver = driver;
    }
    
}