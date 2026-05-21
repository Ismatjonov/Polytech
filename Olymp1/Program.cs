using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Olymp1;

class Program
{
    static void Main(string[] args)
    {
        string input = Console.ReadLine();
        string b = Console.ReadLine();
        
        
        List<char> symbols = new List<char>();
        symbols.AddRange(input.ToCharArray());
        
        List<char> sb = new List<char>();
        sb.AddRange(b.ToCharArray());

        int count = 0;
        for (int i = 0; i < sb.Count; i++)
        {
            if (symbols.Contains(sb[i]))
            {
                count++;
            }
            else
            {
                Console.WriteLine("IMPOSSIBLE");
                break;
            }
        }
        if(count > 1)
            Console.WriteLine(symbols.Count - count);
        
        Console.ReadLine();
    }
}