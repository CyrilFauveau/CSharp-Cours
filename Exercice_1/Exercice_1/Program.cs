using System;
using System.Security.Cryptography.X509Certificates;

namespace Exercice_1
{
    class Program
    {
        static void Main(string[] args)
        {
            var game = new Game();
            game.Play();
        }
    }

    public class Game
    {
        private readonly int _randomValue;

        public Game(int maxValue)
        {
            var _randomValue = new Random().Next(maxValue) + 1;
        }

        public Game(): this(100) {}

        public void Play()
        {
            Console.WriteLine("Saisissez un nombre entre 1 et 100");

            bool win = false;

            while (!win)
            {
                int value = Convert.ToInt32(Console.ReadLine());

                if (value < _randomValue)
                {
                    Console.WriteLine("Plus grand");
                }
                else if (value > _randomValue)
                {
                    Console.WriteLine("Plus petit");
                }
                else if (value == _randomValue)
                {
                    Console.WriteLine("Gagné");
                    win = true;
                }
            }
        }
    }
}
