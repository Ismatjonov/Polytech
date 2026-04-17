namespace MyProject;

public class Text
{
    private Dictionary<string, int> words = new ();
    private string text;

    public Text(string text)
    {
        this.text = text;
    }

    public string Content
    {
        set => text = value;
        get => text;
    }
    public int Length
    {
        get => text.Length;
    }

    public int Word
    {
        get => text.Split([' ', ',', '.', '!'], StringSplitOptions.RemoveEmptyEntries).Length;
    }

    public int Sentence
    {
        get => text.Split(['.', '!', '?'], StringSplitOptions.RemoveEmptyEntries).Length;
    }

    public string[] Sentences
    {
        get
        {
            return text.Split(['.', '!', '?'],
                StringSplitOptions.RemoveEmptyEntries);
        }
    }

    public string[] Words
    {
        get
        {
            return text.ToLower().Split(new char[] { ' ', '.', ',', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);
        }
    }

    public char[] Symbols
    {
        get
        {
            return text.ToCharArray();
        }
    }

    public int Basomad(string word)
    {
        int count = 0;
        for (int i = 0; i < text.Split(' ').Length; i++)
        {
            if(Words[i] == word)
                count++;
        }
        return count;
    }

    public void SaveToFile(string filename)
    {
        File.WriteAllText(filename, text);
    }

    public string ToUpperCase()
    {
        return text.ToUpper();
    }

    public string ToLowerCase()
    {
        return text.ToLower();
    }

    public string ReplaceWord(string oldText, string newText)
    {
        text = text.Replace(oldText, newText);
        return text;
    }
    
    public void LoadFromFile(string filename)
    {
        text = File.ReadAllText(filename);
    }
    
    public Dictionary<string, int> GetWordFrequency()
    {
        var result = new Dictionary<string, int>();

        foreach (var w in Words)
        {
            if (!result.ContainsKey(w))
                result[w] = 1;
            else
                result[w]++;
        }
        return result;
    }

    public string this[int index]
    {
        get => Sentences[index];
    }
    
    public string Reverse()
    {
        return new string(text.Reverse().ToArray());
    }
    
    public void Print() => Console.WriteLine(text);
}