using System;

class Program
{
    static void Main()
    {
        int n = 4; // строки
        int m = 4; // столбцы

        int[,] arr = new int[n, m];
 
        int top = 0, bottom = n - 1;
        int left = 0, right = m - 1;

        int num = 1;

        while (num <= n * m)
        {
            // 1. Верхняя строка (слева направо)
            for (int i = left; i <= right; i++)
                arr[top, i] = num++;
            top++;

            // 2. Правый столбец (сверху вниз)
            for (int i = top; i <= bottom; i++)
                arr[i, right] = num++;
            right--;

            // 3. Нижняя строка (справа налево)
            if (top <= bottom)
            {
                for (int i = right; i >= left; i--)
                    arr[bottom, i] = num++;
                bottom--;
            }

            // 4. Левый столбец (снизу вверх)
            if (left <= right)
            {
                for (int i = bottom; i >= top; i--)
                    arr[i, left] = num++;
                left++;
            }
        }
        // Вывод массива
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
                Console.Write(arr[i, j].ToString().PadLeft(4));
            Console.WriteLine();
        }
    }
}