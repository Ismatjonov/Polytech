

// Синфи асосӣ (abstract)
abstract class Publication
{
    public string Name { get; set; }
    public string Author { get; set; }
    public string Text { get; set; }
    public string Time { get; set; }
    public string Place { get; set; }

    // Метод барои чоп
    public virtual void Print()
    {
        Console.WriteLine("Ном: " + Name);
        Console.WriteLine("Муаллиф: " + Author);
        Console.WriteLine("Матн: " + Text);
        Console.WriteLine("Вакт: " + Time);
        Console.WriteLine("Чой: " + Place);
    }

    // Метод барои хондан аз файл (abstract)
    public abstract void ReadFromFile(string path);
}

// Синфи Article
class Article : Publication
{
    public Article() { }

    public override void ReadFromFile(string path)
    {
        if (!File.Exists(path))
        {
            Console.WriteLine("Файл ёфт нашуд: " + path);
            return;
        }

        string[] data = File.ReadAllLines(path);

        if (data.Length >= 5)
        {
            Name = data[0];
            Author = data[1];
            Text = data[2];
            Time = data[3];
            Place = data[4];
        }
    }
}

// Синфи News
class News : Publication
{
    public News() { }

    public override void ReadFromFile(string path)
    {
        string[] data = File.ReadAllLines(path);
        Name = data[0];
        Author = data[1];
        Text = data[2];
        Time = data[3];
        Place = data[4];
    }
}

// Синфи Advertisement
class Advertisement : Publication
{
    public Advertisement() { }

    public override void ReadFromFile(string path)
    {
        string[] data = File.ReadAllLines(path);
        Name = data[0];
        Author = data[1];
        Text = data[2];
        Time = data[3];
        Place = data[4];
    }
}
