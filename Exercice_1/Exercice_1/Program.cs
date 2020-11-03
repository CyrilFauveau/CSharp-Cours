using System;

namespace Exercice_1
{
    class Program
    {
        static void Main(string[] args)
        {
            var rnd = new Random();
            var nb = rnd.Next(100) + 1;

            Console.WriteLine(nb);
            Console.WriteLine("Saisissez un nombre entre 1 et 100");

            while (true)
            {
                int value = Convert.ToInt32(Console.ReadLine());

                if (value < nb)
                {
                    Console.WriteLine("Plus grand");
                }
                else if (value > nb)
                {
                    Console.WriteLine("Plus petit");
                }
                else if (value == nb)
                {
                    Console.WriteLine("Gagné");
                    break;
                }
            }
        }
    }
}
