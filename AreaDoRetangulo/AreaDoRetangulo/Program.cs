using System;

namespace AreaDoRetangulo
{
    struct AreaDoRetangulo
    {
        double x, y;

        public double calcularArea()
        {
            x = 400;
            y = 200;
            return x * y;
        }
    }

    class ProgramValidar
    {
        static void Main(string[] args)
        {
            AreaDoRetangulo area = new AreaDoRetangulo();

            Console.WriteLine($"Área do retângulo: {area.calcularArea()}");
        }
    }
}