class Time
{
    private int hour;
    private int minute;
    private int second;

    // Конструктор
    public Time(int h, int m, int s)
    {
        SetTime(h, m, s);
    }

    // Метод барои гузоштани вақт
    public void SetTime(int h, int m, int s)
    {
        if (h < 0 || h > 23)
            throw new ArgumentException("Соат бояд аз 0 то 23 бошад");

        if (m < 0 || m > 59)
            throw new ArgumentException("Дақиқа бояд аз 0 то 59 бошад");

        if (s < 0 || s > 59)
            throw new ArgumentException("Сония бояд аз 0 то 59 бошад");

        hour = h;
        minute = m;
        second = s;
    }

    // Тағйир додани соат
    public void SetHour(int h)
    {
        if (h < 0 || h > 23)
            throw new ArgumentException("Соат нодуруст аст");
        hour = h;
    }

    // Тағйир додани дақиқа
    public void SetMinute(int m)
    {
        if (m < 0 || m > 59)
            throw new ArgumentException("Дақиқа нодуруст аст");
        minute += m;
    }

    // Тағйир додани сония
    public void SetSecond(int s)
    {
        if (s < 0 || s > 59)
            throw new ArgumentException("Сония нодуруст аст");
        second = s;
    }

    // Метод: илова кардани вақт (соат, дақиқа, сония)
    public void AddTime(int h, int m, int s)
    {
        second += s;
        minute += m + second / 60;
        second %= 60;

        hour += h + minute / 60;
        minute %= 60;

        hour %= 24;
    }

    // Намоиши вақт
    public void Show()
    {
        Console.WriteLine($"{hour:D2}:{minute:D2}:{second:D2}");
    }
}