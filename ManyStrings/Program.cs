using System;

namespace ManyStrings
{
    public class Program
    {
        private static void Main(string[] args)
        {
            int x = 4;
            int y = 5;
            string nome_1 = "Hello guysssss \u00B1,";
            string nome_2 = " Let/'s have fun learning code!";
            string nome_3 = "  haha.";
            string nome_4 = "   ha.";
            string a_1 = "a" + 2;
            string abc_1 = "abc" + x;
            string s_1 = $"valor de x é {x}";
            string s_2 = $"{x} mais {y} é igual a {x + y}";
            
            Console.WriteLine(nome_1);
            Console.WriteLine(nome_2);
            Console.WriteLine(nome_3);
            Console.WriteLine(nome_4);
            Console.WriteLine(a_1);
            Console.WriteLine(abc_1);
            Console.WriteLine(s_1);
            Console.WriteLine(s_2);
            
        }
    }
}
