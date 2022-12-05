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
        private int _health;
        private int _stamina;
        private int _damage;

        public Player(int health, int stamina, int damage)
        {
            _health = health;
            _stamina = stamina;
            _damage = damage;
        }

        public void ShowStats()
        {
            Console.WriteLine("Здоровье - " + _health + "\nВыносливость - " + _stamina + "\nАтака - " + _damage);
        }
    }
}
