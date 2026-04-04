using Lesson4.Classes;

namespace Lesson4;

class Program
{
    static void Main(string[] args)
    {
        // Масъалаи 26.1
        Book tojikon = new Book("Точикон", "Бобочон Гафуров", "978-99947-0-323-4", "Илми-таърихи", "Ирфон", 1983, 976);
        tojikon.Info();

        Console.WriteLine();

        Book shohnoma = new Book("Шохнома", "Абулкосим Фурдавси", "978-99947-999-0-0", "Эпос/Хамоса", "Нашриёти муосир",
            1010, 1500);
        shohnoma.Info();
        Console.WriteLine();
        
        // Масъалаи 26.2
        Rectangle rect = new Rectangle(12, 24);
        rect.Perimeter();
        rect.Area();
        Console.WriteLine();
        
        // Масъалаи 26.3
        Fraction fraction = new Fraction(6, 8);
        Console.WriteLine("Табдилдихи ба адади хакики: " + fraction.Adad);
        fraction.Print();
        fraction.Ikhtisor();
        Fraction fraction2 = new Fraction(1, 2);
        Fraction.Compare(fraction, fraction2);
        Console.WriteLine();
        
        // Масъалаи 26.4
        Money money = new Money(5, 20);
        money.Balance();
        money.Kharid(0.80m);
        money.Balance();
        money.Daromad(20.65m);
        money.Balance();
        Console.WriteLine();
        
        // Масъалаи 26.5
        Car kia = new Car("KIA", "K5", "1488CS20", "Сафед", 2015, 4);
        Driver bakhtovar = new Driver("Бахтовар", "Исматджонов", "А05485369", 512583697, "+992937770771", "Мард", "26.06.2006", "к. Таги Сада 175", "08,03,2026", kia);
        bakhtovar.Display();
        bakhtovar.Zakaz(5);
        Console.WriteLine();
        
        // Масъалаи 26.6
        Car bmw = new Car("BMW", "M5 F10", "2552MS02", "Сиёх", 2019, 4);
        Driver muhayo = new Driver("Мухайё", "Сатторова", "А03654789", 515520369, "+992920062606", "Зан", "24.11.2006",
            "к. Юрий Гагарин 39а", "08.03.2026", bmw);
        muhayo.Display();
        
        // Масъалаи 26.7
        
    }
}