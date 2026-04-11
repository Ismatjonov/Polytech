using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        Article article = new Article();
        article.ReadFromFile("article.txt");
        Console.WriteLine("=== Article ===");
        article.Print();

        News news = new News();
        news.ReadFromFile("news.txt");
        Console.WriteLine("\n=== News ===");
        news.Print();

        Advertisement ad = new Advertisement();
        ad.ReadFromFile("ad.txt");
        Console.WriteLine("\n=== Advertisement ===");
        ad.Print();
    }
}