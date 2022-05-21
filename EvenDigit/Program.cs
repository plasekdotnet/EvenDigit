using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvenDigit
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var komunikat = "";
                Console.WriteLine("Podaj liczbę");
                var enteredNumber = GetInput();

                var result = IsOdd(enteredNumber);

                if (!result)
                {
                    komunikat = "parzysta";
                }
                else
                {
                    komunikat = "nieparzysta";
                }
                Console.WriteLine($"Wprowadzona liczba jest {komunikat}") ;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.ReadLine();
            }
           // Console.ReadKey();
        }

        private static int GetInput()
        {
            if (!int.TryParse(Console.ReadLine(), out int input))
                throw new Exception("Podana wartosc jest nieprawidłowa.");
            return input;
        }

        public static bool IsOdd(int number1)
        {
            return number1 % 2 != 0;
        }
    }
}
