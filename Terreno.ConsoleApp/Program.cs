using System;

namespace Terreno.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a medida do primeiro lado do terreno");
            string strprimeirolado = Console.ReadLine();
            Console.WriteLine("Digite a medida do segundo lado do terreno");
            string strsegundolado = Console.ReadLine();
           
            decimal primeirolado = Convert.ToInt32(strprimeirolado);
            decimal segundolado = Convert.ToInt32(strsegundolado);

            decimal area;
            area = primeirolado * segundolado;
            Console.WriteLine($"A área do terreno é {area}");
            Console.ReadLine();


            

        }
    }
}
