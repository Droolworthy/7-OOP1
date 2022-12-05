using System;

namespace _7_OOP1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Player player = new(100,100,25);

            player.ShowStats();
        }
    }

    public class Player 
    {
        int Health;
        int Stamina;
        int Damage;

        public Player(int health, int stamina, int damage)
        {
            Health = health;
            Stamina = stamina;
            Damage = damage;
        }

        public void ShowStats()
        {
            Console.WriteLine("Здоровье - " + Health + "\nВыносливость - " + Stamina + "\nАтака - " + Damage);
        }
    }
}
