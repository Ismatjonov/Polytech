class Program
{
    static void Main()
    {
        // Китоби бадеӣ
        Book fiction = new Book(
            "Ҷиноят ва ҷазо",
            "Фёдор Достоевский",
            "978-5-17-118366-7",
            "Бадеӣ",
            "Эксмо",
            1866,
            430
        );

        // Китоби таълимӣ
        Book education = new Book(
            "C# барои шурӯъкунандагон",
            "Ҷон Смит",
            "978-1-23-456789-0",
            "Таълимӣ",
            "TechPress",
            2022,
            250
        );

        // Намоиши маълумот
        fiction.ShowInfo();
        Console.WriteLine("Китоб калон аст? " + fiction.IsBigBook());

        education.ShowInfo();
        Console.WriteLine("Китоб калон аст? " + education.IsBigBook());
    }
}