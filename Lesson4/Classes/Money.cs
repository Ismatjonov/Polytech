namespace Lesson4.Classes;

public class Money
{
    private int somoni;
    private int diram;

    public int Somoni
    {
        get
        {
            return somoni;
        }
        set
        {
            if (value < 0)
            {
                somoni = 0;
            }
            else
            {
                somoni = value;
            }
        }
    }

    public int Diram
    {
        get
        {
            return diram;
        }
        set
        {
            if (value > 0 && value < 100)
            {
                diram = value;
            }
            else
            {
                Console.WriteLine("Танга аз 100 боло ва аз 0 поён шуда наметавонад!");
                diram = 0;
            }
        }
    }

    public Money(int somoni, int diram)
    {
        Somoni = somoni;
        Diram = diram;
    }

    public void Balance()
    {
        Console.WriteLine($"Баланс: {Somoni}сомони {Diram}дирам.");
    }

    public void Kharid(decimal kharid)
    {
        int common1 = Somoni * 100 + Diram;
        int common2 = (int)(100 * kharid);
        int total = common1 - common2;
        Somoni = total / 100;
        Diram = total % 100;
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine($"Нархи харид: {common2 / 100}сомони {common2 % 100}дирам.");
        Console.ResetColor();
    }

    public void Daromad(decimal daromad)
    {
        int common1 = Somoni * 100 + Diram;
        int common2 = (int)(100 * daromad);
        int total = common1 + common2;
        Somoni = total / 100;
        Diram = total % 100;
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"Хачми даромад: {common2 / 100}сомони {common2 % 100}дирам.");
        Console.ResetColor();
    }
}