using System;

namespace Calculadora_09
{
    class Program
    {
        static void Main(string[] args)
        {
             Valores c = new Valores();

             Console.ForegroundColor = ConsoleColor.Blue;

             Console.WriteLine("Digite uma operação nesse tipo de formato ex: 15 x 6");
             c.ControlarMetodos( Console.ReadLine() );
             Console.WriteLine("Resultado "+c.resultado);

             Console.ResetColor();


             Console.ForegroundColor = ConsoleColor.Magenta;
             
             Console.WriteLine("Digite números separados por ponto e vírgula para calcularmos a média");
             c.CalcularMedia( Console.ReadLine());
             Console.WriteLine("Media: "+c.resultado);

             Console.ResetColor();

            
        }
    }
}
