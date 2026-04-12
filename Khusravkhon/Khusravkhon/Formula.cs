using System;

class Formula
{
    // 🔹 Поле
    private string expression;

    // 🔹 Хосият
    public string Expression
    {
        get { return expression; }
        set { expression = value; }
    }

    // 🔹 Метод
    public int Calculate()
    {
        int result = 0;
        int number = 0;
        char sign = '+';

        foreach (char c in expression)
        {
            // 🔹 Санҷиш бе IsDigit
            if (c >= '0' && c <= '9')
            {
                number = number * 10 + (c - '0');
            }
            else if (c == '+' || c == '-')
            {
                if (sign == '+')
                    result += number;
                else
                    result -= number;

                sign = c;
                number = 0;
            }
        }

        // 🔹 Охирин адад
        if (sign == '+')
            result += number;
        else
            result -= number;

        return result;
    }
}