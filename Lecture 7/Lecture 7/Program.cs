using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Lecture_7
{
    class Person
    {
        string name;
        int Age;
        public string Name
        {
            set
            {
                if (value == null)
                    Console.WriteLine("Номро пур намоед!");
                else
                    name = value;
            }
            get
            {
                return name;
            }
        }
    class Program
    {
        static void SayHello()
        {
            Console.WriteLine("Hello World!");
        }
        class Formula
        {
            public static int Square(int x)
            {
                return x * x;
            }
        }

       class Calculate
        {
            public static void Add(int a, int b)
            {
                Console.WriteLine(a + b);
            }
            public static void Minus(int a, int b)
            {
                Console.WriteLine(a - b);
            }
            public static void Multipy(int a, int b)
            {
                Console.WriteLine(a * b);
            }
            public static void Divide(int a, int b)
            {
                Console.WriteLine(a / b);
            }
        }

        static void ShowArray(int[] arr)
        {
            for(int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
        }

        static int[] CreateArray(int n)
        {
            int[] arr = new int[n];
            Random random = new Random();
            for (int i = 0; i < n; i++)
                arr[i] = random.Next(1, 20);
            return arr;
        }

            static void Main(string[] args)
            {

                int a = int.Parse(Console.ReadLine());
                int b = int.Parse(Console.ReadLine());
                char n = char.Parse(Console.ReadLine());
                switch (n)
                {
                    case '+': Calculate.Add(a, b); break;
                    case '-': Calculate.Minus(a, b); break;
                    case '*': Calculate.Multipy(a, b); break;
                    case '/': Calculate.Divide(a, b); break;
                    default: Console.WriteLine("Error!"); break;
                }

                /*int result = Formula.Square(5);
                Console.WriteLine(result);

                SayHello();

                Calculate.Add(8, 5);

                int[] mas = { 1, 2, 3, 4, 5, 6 };
                ShowArray(mas);
                Console.WriteLine();

                int[] nums = CreateArray(20);
                ShowArray(nums);*/

            }

        }
    }
}
