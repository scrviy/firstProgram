using System;

namespace firstProgram
{
    public class firstProgram
    {
        static void Main(string[] args)
        {
            double x, y, media;

            Console.WriteLine("Digite o primeiro número: ");
            x = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo número: ");
            y = double.Parse(Console.ReadLine());

            media = (x + y) / 2.0;
            Console.WriteLine("Média = " + media);
        }
    }
}