class Student
{
    // Свойства (Properties)
    public string Name { get; set; }
    public string Surname { get; set; }
    public int Age { get; set; }
    public string University { get; set; }
    public string Faculty { get; set; }
    public int Course { get; set; }
    public double GPA { get; set; }
    public bool IsScholarship { get; set; }

    // Поле
    private int _absences;

    // Конструктор
    public Student(string name, string surname, int age, string university, string faculty, int course, double gpa, bool isScholarship)
    {
        Name = name;
        Surname = surname;
        Age = age;
        University = university;
        Faculty = faculty;
        Course = course;
        GPA = gpa;
        IsScholarship = isScholarship;
    }

    // Метод для вывода информации
    public void ShowInfo()
    {
        Console.WriteLine($"Имя: {Name}");
        Console.WriteLine($"Фамилия: {Surname}");
        Console.WriteLine($"Возраст: {Age}");
        Console.WriteLine($"Университет: {University}");
        Console.WriteLine($"Факультет: {Faculty}");
        Console.WriteLine($"Курс: {Course}");
        Console.WriteLine($"Средний балл: {GPA}");
        Console.WriteLine($"Стипендия: {IsScholarship}");
        Console.WriteLine($"Пропуски: {_absences}");
    }

    // Метод повышения курса
    public void NextCourse()
    {
        Course++;
        Console.WriteLine($"{Name} переведен на {Course} курс");
    }

    // Метод добавления оценки
    public void AddGrade(double grade)
    {
        GPA = (GPA + grade) / 2;
        Console.WriteLine($"Новая GPA: {GPA}");
    }

    // Метод пропуска занятия
    public void MissClass()
    {
        _absences++;
    }

    // Проверка стипендии
    public void CheckScholarship()
    {
        IsScholarship = GPA >= 4.5;
    }

    // Статический метод
    public static void UniversityRules()
    {
        Console.WriteLine("Студенты должны посещать занятия и сдавать экзамены.");
    }
}