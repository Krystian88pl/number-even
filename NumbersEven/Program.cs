using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumbersEven
{
    internal class Program
    {
        static void Main(string[] args)
        {
                Console.WriteLine("Podaj liczbę, program sprawdzi czy jest parzysta");
                while (true)
                {
                    var number = Number();

                    if (number % 2 == 0)
                    {
                        Console.WriteLine("Twoja liczba jest parzysta");
                    }
                    else
                    {
                        Console.WriteLine("Liczba jest nieparzysta");
                    }

                    Console.WriteLine("Podaj kolejną liczbę lub aby wyjść naciśnij \"x\"");
                }
            }

            private static int Number()
            {
                while (true)
                {
                    var volume = Console.ReadLine();

                    if (volume.ToUpper() == "X")
                        Environment.Exit(0);

                    if (!int.TryParse(volume, out int number))
                    {
                        Console.WriteLine("Podana wartość jest nieprawidłowa, spróbuj ponownie");
                        continue;
                    }
                    return number;
                }
            }
    }
}
