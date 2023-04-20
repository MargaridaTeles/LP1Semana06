using System;

namespace GameSix
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Insira um número de Inimigos: ");
            int num_inimigos = int.Parse(Console.ReadLine());
            string[] array_inimigos = new string[num_inimigos];

            for (int i=0; i < array_inimigos.Length; i++)
            {
                Console.Write("Insira um Nome: ");
                string nome_inimigo = Console.ReadLine();
                array_inimigos[i] = nome_inimigo;
                Foe inimigo = new Foe(nome_inimigo);
            }

        }
    }
}
