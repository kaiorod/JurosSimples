using System;

namespace JurosSimples
{
    class Program
    {
        static void Main(string[] args)
        {
            double j, m, c, i, t;

            Console.Beep();
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("--- Calculo de Juros Simples ---");
            Console.ResetColor();

            Console.Write("\nDigite o valor do Capital (R$): ");
            c = double.Parse(Console.ReadLine());
            Console.Write("Digite a Taxa de Juros (%) : ");
            i = double.Parse(Console.ReadLine());
            Console.Write("Digite o Tempo (meses) : ");
            t = double.Parse(Console.ReadLine());

            
            j = c * (i / 100) * t;
            m = c + j;

            Console.Clear();
            Console.WriteLine($"Capital : {c:C2}");
            Console.WriteLine($"Taxa de Juros : {i} %");
            Console.WriteLine($"Tempo : {t} meses");
            Console.Write($"\nJuros : ");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine($"{j:C2}");
            Console.ResetColor();
            Console.Write($"Montante : ");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine($"{m:C2}");
            Console.ResetColor();
            
        }
    }
}
