using System;

namespace ConvertationApp
{ 
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ададро ворид кунед: ");
            string num = Console.ReadLine();

            Console.Write("Аз кадом системаи ҳисоб (2,8,10,16): ");
            int from = int.Parse(Console.ReadLine());

            Console.Write("Ба кадом системаи ҳисоб (2,8,10,16): ");
            int to = int.Parse(Console.ReadLine());

            Convertation obj = new Convertation(num, from, to);

            string natija = obj.ConvertNumber();

            Console.WriteLine("Натиҷа: " + natija);
        }
    }
}