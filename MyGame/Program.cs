using System;

namespace MyGame
{
    public class Program
    {
        private static void Main(string[] args)
        {
            int numEnemys = int.Parse(args[0]);
            Enemy[] enemies = new Enemy[numEnemys];

            for(int i = 0; i < numEnemys; i++)
            {
                Console.Write($"Nome do inimigo {i + 1}: ");
                string name = Console.ReadLine();

                enemies[i] = new Enemy(name);
            }

            for (int j = 0; j < numEnemys; j++)
            {
                Console.WriteLine($"{enemies[j].GetName()} {enemies[j].GetHealth()} {enemies[j].GetShield()}");
            }

            enemies[0].TakeDamage(50);
            enemies[1].TakeDamage(17);

            foreach (Enemy enemi in enemies)
            {
                Console.WriteLine($"Depois de dano: {enemi.GetHealth()} {enemi.GetShield()}");
            }
            
            enemies[0].PickupPowerUp(PowerUp.Health, 20);
            enemies[1].PickupPowerUp(PowerUp.Shield, 10);
        
            foreach (Enemy enemi in enemies)
            {
                Console.WriteLine($"Depois dos powerups: {enemi.GetHealth()} {enemi.GetShield()}");        
            }
            
            Console.WriteLine($"Total de powerups apanhados: {Enemy.GetTotalPowerUps()}");    
        }
    }
}
