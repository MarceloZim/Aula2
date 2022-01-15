using System;

namespace ExerciciosCondicionais
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite sua idade, para poder identificar qual é seu status da vida.");
            var numero = Console.ReadLine();
            var idade = Convert.ToInt32(numero);

            if (idade >= 13 && idade <= 19)
            {
                Console.WriteLine(idade + " anos | você é Adolecente, aproveite.");
            }
            else if (idade >= 19 && idade <= 60)
            {
                Console.WriteLine(idade + " anos | você é Adulto, periodo responsavel.");
            }
            else if (idade > 60)
            {
                Console.WriteLine(idade + " anos | você é idoso, cuidar com a saúde.");
            }
            else if (idade < 13)
            {
                Console.WriteLine(idade + " anos | você é aborecente, vai brincar vai.");
            }
        }
    }
}
