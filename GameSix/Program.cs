using System;

namespace GameSix
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Insira um número de Inimigos: ");
            int num_inimigos = int.Parse(Console.ReadLine());
            Foe[] array_inimigos = new Foe[num_inimigos];

            for (int i=0; i < array_inimigos.Length; i++)
            {
                Console.Write("Insira um Nome: ");
                string nome_inimigo = Console.ReadLine();
                array_inimigos[i] = new Foe(nome_inimigo);
            }
            Console.WriteLine(" ");
            foreach(var inimigo in array_inimigos)
            {
                Console.WriteLine($"Nome do Inimigo: {inimigo.GetName()}");
            }

            array_inimigos[0].TakeDamage(50);
            array_inimigos[0].PickupPowerUp(PowerUp.Health, 30);
            array_inimigos[0].PickupPowerUp(PowerUp.Shield, 60);
        }
    }
}
