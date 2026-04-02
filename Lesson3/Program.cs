class Program
{
    static void Main()
    {
        // Создание объекта
        Student student = new Student("Бахтовар", "Исматҷонов", 17, "Донишкадаи политехникии Донишгоҳи техникии Тоҷикистон дар шаҳри Хуҷанд", "Технологияҳои рақами", 2, 4.77, true);

        // Работа с методами
        student.ShowInfo();

        Console.WriteLine();

        student.AddGrade(5);
        student.AddGrade(4.5);

        student.MissClass();
        student.MissClass();

        student.CheckScholarship();

        Console.WriteLine();
        student.NextCourse();

        Console.WriteLine();
        student.ShowInfo();

        // Статический метод
        Student.UniversityRules();
        
    }
}