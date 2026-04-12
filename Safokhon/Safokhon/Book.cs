using System;

class Book
{
    // Поля (fields)
    private string title;
    private string author;
    private string isbn;
    private string type;
    private string publisher;
    private int year;
    private int pages;

    // Хосиятҳо (properties)
    public string Title
    {
        get { return title; }
        set { title = value; }
    }

    public string Author
    {
        get { return author; }
        set { author = value; }
    }

    public string ISBN
    {
        get { return isbn; }
        set { isbn = value; }
    }

    public string Type
    {
        get { return type; }
        set { type = value; }
    }

    public string Publisher
    {
        get { return publisher; }
        set { publisher = value; }
    }

    public int Year
    {
        get { return year; }
        set { year = value; }
    }

    public int Pages
    {
        get { return pages; }
        set { pages = value; }
    }

    // Конструктор
    public Book(string title, string author, string isbn, string type, string publisher, int year, int pages)
    {
        this.title = title;
        this.author = author;
        this.isbn = isbn;
        this.type = type;
        this.publisher = publisher;
        this.year = year;
        this.pages = pages;
    }

    // Метод барои намоиш додани маълумот
    public void ShowInfo()
    {
        Console.WriteLine("Ном: " + title);
        Console.WriteLine("Муаллиф: " + author);
        Console.WriteLine("ISBN: " + isbn);
        Console.WriteLine("Намуд: " + type);
        Console.WriteLine("Нашриёт: " + publisher);
        Console.WriteLine("Соли нашр: " + year);
        Console.WriteLine("Саҳифаҳо: " + pages);
        Console.WriteLine("---------------------------");
    }

    // Метод барои санҷиши китоб (мисол: китоб калон аст ё не)
    public bool IsBigBook()
    {
        return pages > 300;
    }
}