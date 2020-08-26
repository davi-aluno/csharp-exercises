using System;

namespace ValidarNumeros
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 20;
            int b = 10;

            string valida = (a > b ? "A é maior que B" : "B é maior que A");

            Console.WriteLine($"Resutlado: {valida}");
        }
    }
}