# Основы языка программирования C#

## Оглавление
1. [Введение в C#](#введение-в-c)
2. [История и особенности](#история-и-особенности)
3. [Установка и подготовка](#установка-и-подготовка)
4. [Первая программа](#первая-программа)
5. [Типы данных](#типы-данных)
6. [Переменные и константы](#переменные-и-константы)
7. [Операторы](#операторы)
8. [Условные операторы](#условные-операторы)
9. [Циклы](#циклы)
10. [Массивы](#массивы)
11. [Методы и функции](#методы-и-функции)
12. [Строки и работа с текстом](#строки-и-работа-с-текстом)

---

## Введение в C#

C# (произносится "си-шарп") — это современный объектно-ориентированный язык программирования, созданный компанией Microsoft. Он используется для разработки приложений, игр, веб-сервисов и многого другого.

### Зачем изучать C#?

- ✅ Популярный и востребованный язык
- ✅ Мощная платформа .NET
- ✅ Легкий синтаксис для начинающих
- ✅ Большое сообщество разработчиков
- ✅ Множество библиотек и фреймворков

---

## История и особенности

### История создания

- **2000** - Объявлен консорциумом ECMA
- **2002** - Выпуск первой версии C# 1.0
- **Настоящее время** - C# продолжает развиваться (текущая версия 12.0+)

### Основные особенности

1. **Объектно-ориентированный** - всё является объектом
2. **Управляемый код** - работает в виртуальной машине CLR
3. **Типобезопасный** - проверка типов на этапе компиляции
4. **Сборка мусора** - автоматическое управление памятью
5. **Кроссплатформенный** - работает на Windows, Linux, macOS

---

## Установка и подготовка

### Требования

- Компьютер с ОС Windows, Linux или macOS
- Интернет-соединение

### Установка инструментов

#### Вариант 1: Visual Studio Community (рекомендуется)

```
1. Перейдите на https://visualstudio.microsoft.com/
2. Скачайте Visual Studio Community (бесплатная версия)
3. Запустите установщик
4. Выберите рабочую нагрузку "Разработка классических приложений .NET"
5. Завершите установку
```

#### Вариант 2: Visual Studio Code + .NET SDK

```
1. Скачайте .NET SDK с https://dotnet.microsoft.com/
2. Установите Visual Studio Code с https://code.visualstudio.com/
3. Установите расширение C# в VS Code
```

---

## Первая программа

### "Hello, World!"

```csharp
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Hello, World!");
    }
}
```

### Разбор кода

| Строка | Назначение |
|--------|-----------|
| `using System;` | Подключение пространства имен System |
| `class Program` | Определение класса Program |
| `static void Main()` | Точка входа в программу |
| `Console.WriteLine()` | Вывод текста в консоль |

---

## Типы данных

### Числовые типы

| Тип | Размер | Диапазон | Пример |
|-----|--------|----------|--------|
| `byte` | 1 байт | 0 - 255 | `byte age = 25;` |
| `short` | 2 байта | -32,768 - 32,767 | `short year = 2024;` |
| `int` | 4 байта | -2.1M - 2.1M | `int count = 100;` |
| `long` | 8 байт | -9.2E18 - 9.2E18 | `long id = 1000000000;` |
| `float` | 4 байта | ±3.4E±38 | `float price = 19.99f;` |
| `double` | 8 байт | ±1.7E±308 | `double pi = 3.14159;` |
| `decimal` | 16 байт | ±7.9E±28 | `decimal amount = 99.99m;` |

### Логический тип

```csharp
bool isActive = true;
bool isEmpty = false;
```

### Символьный и строковый типы

```csharp
char letter = 'A';                    // Один символ
string name = "John Doe";            // Строка текста
```

---

## Переменные и константы

### Объявление переменных

```csharp
// Явное указание типа
int age = 25;
string name = "Иван";
double salary = 50000.50;

// Неявное указание типа (var)
var country = "Россия";  // Тип определяется автоматически
var population = 146000000;
```

### Константы

```csharp
const double PI = 3.14159;
const string COMPANY = "TechCorp";
const int MAX_USERS = 1000;

// Попытка изменить константу вызовет ошибку
// PI = 3.14;  // Ошибка!
```

### Правила именования

- ✅ `firstName` - camelCase для переменных
- ✅ `MAX_SIZE` - UPPER_CASE для констант
- ✅ `CalculateTotal` - PascalCase для методов и классов
- ❌ `1name` - не начинайте с цифры
- ❌ `first-name` - не используйте дефисы

---

## Операторы

### Арифметические операторы

```csharp
int a = 10, b = 3;

Console.WriteLine(a + b);   // 13 (сложение)
Console.WriteLine(a - b);   // 7 (вычитание)
Console.WriteLine(a * b);   // 30 (умножение)
Console.WriteLine(a / b);   // 3 (целочисленное деление)
Console.WriteLine(a % b);   // 1 (остаток от деления)
```

### Операторы сравнения

```csharp
int x = 5, y = 10;

Console.WriteLine(x == y);  // false (равно)
Console.WriteLine(x != y);  // true (не равно)
Console.WriteLine(x < y);   // true (меньше)
Console.WriteLine(x > y);   // false (больше)
Console.WriteLine(x <= y);  // true (меньше или равно)
Console.WriteLine(x >= y);  // false (больше или равно)
```

### Логические ��ператоры

```csharp
bool a = true, b = false;

Console.WriteLine(a && b);  // false (И - AND)
Console.WriteLine(a || b);  // true (ИЛИ - OR)
Console.WriteLine(!a);      // false (НЕ - NOT)
```

### Операторы присваивания

```csharp
int num = 5;

num += 3;   // num = num + 3;  (8)
num -= 2;   // num = num - 2;  (6)
num *= 2;   // num = num * 2;  (12)
num /= 3;   // num = num / 3;  (4)
```

---

## Условные операторы

### Оператор if-else

```csharp
int age = 18;

if (age >= 18)
{
    Console.WriteLine("Вы взрослый");
}
else
{
    Console.WriteLine("Вы несовершеннолетний");
}
```

### Оператор if-else if-else

```csharp
int score = 75;

if (score >= 90)
{
    Console.WriteLine("Отличная оценка");
}
else if (score >= 80)
{
    Console.WriteLine("Хорошая оценка");
}
else if (score >= 70)
{
    Console.WriteLine("Удовлетворительная оценка");
}
else
{
    Console.WriteLine("Неудовлетворительная оценка");
}
```

### Тернарный оператор

```csharp
int age = 20;
string status = (age >= 18) ? "Взрослый" : "Ребенок";
Console.WriteLine(status);  // Взрослый
```

### Оператор switch

```csharp
int day = 3;

switch (day)
{
    case 1:
        Console.WriteLine("Понедельник");
        break;
    case 2:
        Console.WriteLine("Вторник");
        break;
    case 3:
        Console.WriteLine("Среда");
        break;
    default:
        Console.WriteLine("Неизвестный день");
        break;
}
```

---

## Циклы

### Цикл for

```csharp
// Простой цикл от 1 до 5
for (int i = 1; i <= 5; i++)
{
    Console.WriteLine(i);
}

// Вывод:
// 1
// 2
// 3
// 4
// 5
```

### Цикл while

```csharp
int count = 0;

while (count < 5)
{
    Console.WriteLine(count);
    count++;
}
```

### Цикл do-while

```csharp
int i = 0;

do
{
    Console.WriteLine(i);
    i++;
} while (i < 5);

// Цикл do-while выполняется минимум один раз
```

### Цикл foreach

```csharp
string[] fruits = { "Яблоко", "Банан", "Апельсин" };

foreach (string fruit in fruits)
{
    Console.WriteLine(fruit);
}

// Вывод:
// Яблоко
// Банан
// Апельсин
```

### Управление циклами

```csharp
// break - выход из цикла
for (int i = 0; i < 10; i++)
{
    if (i == 5) break;
    Console.WriteLine(i);
}

// continue - переход к следующей итерации
for (int i = 0; i < 5; i++)
{
    if (i == 2) continue;
    Console.WriteLine(i);
}
```

---

## Массивы

### Объявление и инициализация

```csharp
// Объявление пустого массива
int[] numbers = new int[5];

// Инициализация массива
int[] ages = { 18, 25, 30, 35, 40 };

// Объявление и инициализация
string[] names = new string[] { "Иван", "Мария", "Петр" };
```

### Доступ к элементам

```csharp
int[] scores = { 85, 90, 78, 92, 88 };

Console.WriteLine(scores[0]);   // 85 (первый элемент)
Console.WriteLine(scores[2]);   // 78
Console.WriteLine(scores.Length);  // 5 (длина массива)
```

### Изменение элементов

```csharp
int[] numbers = { 1, 2, 3, 4, 5 };

numbers[2] = 99;  // Изменение третьего элемента
Console.WriteLine(numbers[2]);  // 99
```

### Двумерные массивы

```csharp
// Таблица 3x3
int[,] matrix = new int[3, 3];

// Инициализация
int[,] table = {
    { 1, 2, 3 },
    { 4, 5, 6 },
    { 7, 8, 9 }
};

Console.WriteLine(table[1, 2]);  // 6
```

### Полезные методы работы с массивами

```csharp
int[] numbers = { 5, 2, 8, 1, 9 };

Array.Sort(numbers);        // Сортировка
Array.Reverse(numbers);     // Реверс
int max = numbers.Max();    // Максимальное значение
int min = numbers.Min();    // Минимальное значение
int sum = numbers.Sum();    // Сумма элементов
```

---

## Методы и функции

### Определение метода

```csharp
// Синтаксис:
// [модификатор] [тип возврата] [название метода] ([параметры])
// {
//     [тело метода]
// }

static void Greet()
{
    Console.WriteLine("Привет!");
}

static int Add(int a, int b)
{
    return a + b;
}

// Вызов методов
Greet();                    // Привет!
int result = Add(3, 5);    // 8
```

### Параметры и возвращаемые значения

```csharp
// Метод с параметрам��
static void PrintMessage(string message)
{
    Console.WriteLine(message);
}

// Метод с возвращаемым значением
static int Multiply(int x, int y)
{
    return x * y;
}

// Метод с несколькими параметрами
static void CalculateArea(double width, double height)
{
    double area = width * height;
    Console.WriteLine($"Площадь: {area}");
}

// Использование
PrintMessage("Hello");          // Hello
int product = Multiply(4, 5);  // 20
CalculateArea(5, 10);          // Площадь: 50
```

### Параметры по умолчанию

```csharp
static void PrintInfo(string name, int age = 25)
{
    Console.WriteLine($"Имя: {name}, Возраст: {age}");
}

PrintInfo("Иван");              // Имя: Иван, Возраст: 25
PrintInfo("Мария", 30);         // Имя: Мария, Возраст: 30
```

### Перегрузка методов

```csharp
// Методы с одним именем, но разными параметрами
static int Sum(int a, int b)
{
    return a + b;
}

static double Sum(double a, double b)
{
    return a + b;
}

static int Sum(int a, int b, int c)
{
    return a + b + c;
}

// Использование
Console.WriteLine(Sum(2, 3));           // 5
Console.WriteLine(Sum(2.5, 3.5));       // 6.0
Console.WriteLine(Sum(1, 2, 3));        // 6
```

---

## Строки и работа с текстом

### Создание и конкатенация строк

```csharp
string firstName = "Иван";
string lastName = "Иванов";

// Конкатенация (объединение)
string fullName = firstName + " " + lastName;
Console.WriteLine(fullName);  // Иван Иванов

// Альтернативный способ
string greeting = string.Concat("Привет, ", fullName);
```

### Интерполяция строк

```csharp
string name = "Мария";
int age = 28;

// Использование $
string message = $"Мое имя {name}, мне {age} лет";
Console.WriteLine(message);  // Мое имя Мария, мне 28 лет
```

### Полезные методы для работы со строками

```csharp
string text = "Hello World";

Console.WriteLine(text.Length);           // 11 (длина строки)
Console.WriteLine(text.ToUpper());        // HELLO WORLD
Console.WriteLine(text.ToLower());        // hello world
Console.WriteLine(text.Replace("World", "C#"));  // Hello C#
Console.WriteLine(text.Substring(0, 5));  // Hello
Console.WriteLine(text.Contains("World")); // true
Console.WriteLine(text.StartsWith("Hello")); // true
Console.WriteLine(text.EndsWith("World"));   // true
Console.WriteLine(text.Trim());           // Удаление пробелов в начале и конце
```

### Разделение и объединение строк

```csharp
// Разделение строки
string cities = "Москва,Санкт-Петербург,Казань";
string[] cityArray = cities.Split(',');

foreach (string city in cityArray)
{
    Console.WriteLine(city);
}

// Объединение строк
string[] words = { "Hello", "from", "C#" };
string result = string.Join(" ", words);
Console.WriteLine(result);  // Hello from C#
```

---

## Практические задания

### Задание 1: Калькулятор
Создайте программу, которая запрашивает два числа и операцию, затем выводит результат.

### Задание 2: Проверка четности
Напишите программу, которая проверяет, четное ли число.

### Задание 3: Таблица умножения
Создайте программу, которая выводит таблицу умножения на 5.

### Задание 4: Поиск максимума
Найдите максимальное значение в массиве.

### Задание 5: Реверс строки
Напишите функцию, которая разворачивает строку в обратном порядке.

---

## Заключение

Вы изучили основные концепции языка программирования C#:
- Типы данных и переменные
- Операторы и условные конструкции
- Циклы и массивы
- Методы и функции
- Работу со строками

Это отличное начало для углубленного изучения C# и разработки полноценных приложений на этом языке.

## Дальнейшее обучение

- 📚 Объектно-ориентированное программирование (ООП)
- 📚 Классы и объекты
- 📚 Наследование и полиморфизм
- 📚 Исключения и обработка ошибок
- 📚 Работа с файлами и потоками
- 📚 LINQ и работа с данными

---

**Удачи в обучении программированию на C#! 🚀**
