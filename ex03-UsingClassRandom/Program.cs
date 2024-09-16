using System;

namespace  Project03
{
    class Program
    {
        static void Main(string[] args) 
        {
           Random dado = new Random();
           int roll01 =  dado.Next();
           int roll02 = dado.Next(101);
           int roll03 = dado.Next(50, 101);

           Console.WriteLine($"First roll: {roll01}");
           Console.WriteLine($"Second roll: {roll02}");
           Console.WriteLine($"Third roll: {roll03}");                    
           
        }
    }
}
