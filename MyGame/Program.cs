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
        }
    }
}
