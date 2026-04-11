using System;

class Program
{
    static void Main()
    {
        try
        {
            Time t = new Time(09, 51, 03);
            t.Show();

            t.AddTime(4, 46, 31); // иловаи вақт
            t.Show();

            t.SetMinute(20); // хатогӣ (Exception)
            t.Show();
        }
        catch (Exception ex)
        {
            Console.WriteLine("Хатогӣ: " + ex.Message);
        }
    }
}