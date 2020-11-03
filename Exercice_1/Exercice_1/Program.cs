using System;
using System.Security.Cryptography.X509Certificates;

namespace Exercice_1
{
    class Program
    {
        static void Main(string[] args)
        {
            var game = new AdvancedGame(5);
            game.Play();
        }
    }

    public class Game
    {
        private readonly int _randomValue;

        public Game(int maxValue)
        {
            _randomValue = new Random().Next(maxValue) + 1;
        }

        public Game(): this(100) {}

        public void Play()
        {
            int value = 0;

            do
            {
                Console.WriteLine("Saisissez un nombre entre 1 et 100");
                value = Convert.ToInt32(Console.ReadLine());
            } while (!Win(value));
        }

        protected virtual bool Win(int value)
        {
            if (value < _randomValue)
            {
                Console.WriteLine("Plus grand");
            }
            else if (value > _randomValue)
            {
                Console.WriteLine("Plus petit");
            }
            else
            {
                Console.WriteLine("Gagné");
                return true;
            }
            return false;
        }
    }

    public class AdvancedGame : Game
    {
        private readonly int _maxTrials;
        private int _actualTrials;

        public AdvancedGame(int maximumTrials): base()
        {
            _maxTrials = maximumTrials;
        }

        protected override bool Win(int value)
        {
            if (value == -1)
            {
                return true;
            }

            if (!base.Win(value))
            {
                int _leftTrials = _maxTrials - _actualTrials - 1;

                Console.WriteLine("Il vous reste " + _leftTrials + " essais");
                if (++_actualTrials == _maxTrials)
                {
                    Console.WriteLine("Vous avez perdu");
                    return true;
                }
            }
            else
            {
                return true;
            }
            return false;
        }
    }
}
