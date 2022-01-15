using System;

namespace Manipulação_de_texto
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("digite um nome");
            string textoAntigo = Console.ReadLine();
            string textoNovo = textoAntigo.Replace(" ", ";");
            Console.WriteLine(textoNovo);
            
            Console.ReadKey();
        }
    }
}
