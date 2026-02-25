using System;

namespace AskForInput
{
    public class Program
    {
        private static void Main(string[] args)
        {
        
            Console.WriteLine("Gimme a Num");
            string str_1 = Console.ReadLine();
            int a_1 = int.Parse(str_1);
            Console.WriteLine("Gimme a real Num");
            string str_2 = Console.ReadLine();
            float a_2 = Convert.ToSingle(str_2);
            Console.WriteLine($"{a_1} + {a_2} ={a_1 +a_2}");


        }
    }
}
