namespace MyProject;

class Program
{
    static void Main(string[] args)
    {
        Text text = new Text("Panta rhei — знаменитый афоризм, приписываемый древнегреческому философу Гераклиту, означающий «всё течёт, всё меняется». Эта доктрина утверждает, что реальность находится в постоянном движении, изменении и потоке. Ничто не остаётся прежним, так как все объекты и явления во Вселенной трансформируются.");
        Console.WriteLine("Миқдори калимаҳо: " + text.Word);
        Console.WriteLine("Миқдори ҷумлаҳо: " + text.Sentence);

        Console.WriteLine();
        
        Console.WriteLine("Ҷумлаи интихобшуда: " + text.Sentences[2]);
        
        Console.WriteLine("Калимаи  интихобшуда: " + text.Words[7]);
        
        Console.WriteLine("Символи интихобшуда: " + text.Symbols[22]);

        Console.WriteLine();
        
        Console.WriteLine("Чунин калима " + text.Basomad("что") + "бор вомехӯрад");

        Console.WriteLine();
        
        text.SaveToFile("text.txt");
        // text.LoadFromFile("content.txt");
        
        Console.WriteLine(text.ToUpperCase());
        Console.WriteLine();
        Console.WriteLine(text.ToLowerCase());

        Console.WriteLine();
        
        Console.WriteLine(text.ReplaceWord("Panta", "Tabuna"));
        
        Console.WriteLine(text[2]);
        
        Console.WriteLine(text.Reverse());
        
        Dictionary<string, int> amount = text.GetWordFrequency();
        
        Console.WriteLine();
        // foreach (var word in amount)
        // {
        //     Console.WriteLine($"{word.Key} - {word.Value}");
        // }
        Console.ReadKey();
    }
}