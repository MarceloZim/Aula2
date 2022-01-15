using System;

namespace LacosDeRepeticao
{
    class Program
    {
        static void Main(string[] args)
        {/*
          ################# DO WHILE ####################
            int n = 1;
            while (n <= 10)
            {
                Console.WriteLine(String.Format("Valor corrente de n é: {0}", n));
                n++;
            }
            Console.Read();*/



            int[] arrayDeInteiros = new int[] { 0, 1, 1, 2, 3, 5, 8, 13 };
            foreach (int inteiro in arrayDeInteiros)
            {
                Console.WriteLine(inteiro);
            }
            Console.Read();

        }
    }
}
