namespace Lesson4.Classes;

public class Book
{
    public string Nom { get; set; }
    public string Muallif { get; set; }
    public string ISBN { get; set; }
    public string Namud { get; set; }
    public string Nashriyot { get; set; }
    public int Sol { get; set; }
    public int Sahifa { get; set; }

    public Book(string nom, string muallif, string isbn, string namud, string nashriyot, int sol, int sahifa)
    {
        Nom = nom;
        Muallif = muallif;
        ISBN = isbn;
        Namud = namud;
        Nashriyot = nashriyot;
        Sol = sol;
        Sahifa = sahifa;
    }

    public void Info()
    {
        Console.WriteLine($"Номи китоб: {Nom}");
        Console.WriteLine($"Муаллиф: {Muallif}");
        Console.WriteLine($"Раками байналхалкии стандарти ISBN: {ISBN}");
        Console.WriteLine($"Намуд: {Namud}");
        Console.WriteLine($"Нашриёт: {Nashriyot}");
        Console.WriteLine($"Соли нашр: {Sol}");
        Console.WriteLine($"Сахифа: {Sahifa}");
    }
}