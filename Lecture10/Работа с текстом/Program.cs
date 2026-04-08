using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Работа_с_текстом
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader("C:\\main.txt", Encoding.UTF8);
            StreamWriter sw = new StreamWriter("C:\\newmain.txt", true, Encoding.UTF8);



            try
            {
                string t = sr.ReadToEnd();
                sw.WriteLine(t);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                sw.Close();
            }
        }
    }
}
