using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    internal class Program
    {
        public static int GetValue()
        {
            while (true)
            {
                var userValue = Console.ReadLine();
                if (userValue.ToUpper() == "E")
                    Environment.Exit(0);
                {
                    if (!int.TryParse(userValue, out var value))
                    {
                        Console.WriteLine("Podana wartość nie jest liczbą!\nSpróbuj jeszcze raz: ");
                        continue;
                    }
                    return value;
                }
            }
        }
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Cześć, tu gra FizzBuzz! Podaj liczbę!\nTwoja liczba: ");
                var userValue = GetValue();

                var fizzBuzz = new FizzBuzz(userValue);
                fizzBuzz.PlayTheGame();
                Console.WriteLine("Chcesz zagrać jeszcze raz? Jeśli nie wprowadz 'E'");
            }
        }
    }
}
