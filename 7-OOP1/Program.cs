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
        public int Health;
        public int Stamina;
        public int Attack;

        public Player(int health, int stamina, int attack)
        {
            Health = health;
            Stamina = stamina;
            Attack = attack;
        }

        public void ShowStats()
        {
            Console.WriteLine("Здоровье - " + Health + "\nВыносливость - " + Stamina + "\nАтака - " + Attack);
        }
    }
}