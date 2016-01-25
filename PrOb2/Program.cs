using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrOb2
{
    class Program
    {       
        static void Main(string[] args)
        {
            double userPojemnosc, userIloscPaliwa, userPojemnoscBaku;
            bool dzialanieProgramu = true;

            Console.WriteLine("Podaj parametry Twego samochodu!");
            Console.Write("Zacznijmy od marki: ");
            string userMarka = Console.ReadLine();
            Console.Write("Teraz model: ");
            string userModel = Console.ReadLine();
            Console.Write("Nastepnie pojemnosc silnika: ");
            while (!double.TryParse(Console.ReadLine(), out userPojemnosc))
            {
                Console.Write("Ale wpisz liczbe!: ");
            }
            Console.Write("Nastepnie ilosc paliwa: ");
            while (!double.TryParse(Console.ReadLine(), out userIloscPaliwa))
            {
                Console.Write("Ale wpisz liczbe!: ");
            }
            Console.Write("Nastepnie pojemnosc baku: ");
            while (!double.TryParse(Console.ReadLine(), out userPojemnoscBaku))
            {
                Console.Write("Ale wpisz liczbe!: ");
            }

            Samochod userSamochod = new Samochod(userMarka, userModel, userPojemnosc, userIloscPaliwa, userPojemnoscBaku);
            

            while (dzialanieProgramu == true)
            {
                Console.WriteLine("1) Rozpocznij jazde");
                Console.WriteLine("2) Brak paliwa? - ZATANKUJ");
                Console.WriteLine("3) Znudzony? To starczy!");

                switch (Console.ReadLine())
                {
                    case "1":
                        {
                            Console.Write("Podaj dystans w km: ");
                            userSamochod.Jedz(int.Parse(Console.ReadLine()));
                            break;
                        }
                    case "2":
                        {
                            Console.Write("Ile paliwa dolewasz?: ");
                            userSamochod.Tankuj(double.Parse(Console.ReadLine()));
                            break;
                        }
                    case "3":
                        {
                            dzialanieProgramu = false;
                            break;
                        }
                    default:
                        break;
                }
                
            }                                   
        }
    }
}
