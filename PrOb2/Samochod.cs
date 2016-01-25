using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PrOb2
{
    class Samochod
    {
        public string Marka;
        public string Model;
        public Silnik SilnikSamochodu;

        public Samochod(string marka, string model, double pojemnosc, double iloscPaliwa, double pojemnoscBaku)
        {
            this.Marka = marka;
            this.Model = model;
            this.SilnikSamochodu = new Silnik(pojemnosc, iloscPaliwa, pojemnoscBaku);
        }

        public Samochod(string marka, string model, double pojemnosc, double iloscPaliwa)
            :this(marka, model, pojemnosc, iloscPaliwa, Silnik.DomyslnaPojemnoscBaku)
        {

        }

        public Samochod(string marka, string model, Silnik silnik)
        {
            this.Marka = marka;
            this.Model = model;
            this.SilnikSamochodu = silnik;
        }

        public bool Dzialaj(int dystans)
        {
            double spalanie = (4 * this.SilnikSamochodu.Pojemnosc) / 100;
            double wykorzystanepaliwo = dystans * spalanie;

            if (this.SilnikSamochodu.IloscPaliwa < wykorzystanepaliwo)
            {
                this.SilnikSamochodu.IloscPaliwa = 0;
                Console.WriteLine("No, probowalem ale skonczylo sie paliwo <chlip chlip>");
                return false;
            }

            this.SilnikSamochodu.IloscPaliwa -= wykorzystanepaliwo;

            return true;
        }

        public void Jedz(int dystans)
        {
            Console.WriteLine("Jade");
            Thread.Sleep(dystans * 100);
            if (this.Dzialaj(dystans))
            {
                Console.WriteLine("Jestem");
            }
            else
            {
                Console.WriteLine("Nie udało sie dojechac :(");
            };
            
        }

        public bool Tankuj(double paliwo)
        {
            if (paliwo <= 0)
            {
                Console.WriteLine("No, daleko to Ty nie ujedziesz");
                return false;
            }
            else
            {
                this.SilnikSamochodu.IloscPaliwa += paliwo;
                if (this.SilnikSamochodu.IloscPaliwa > this.SilnikSamochodu.PojemnoscBaku)
                {
                    this.SilnikSamochodu.IloscPaliwa = this.SilnikSamochodu.PojemnoscBaku;
                }
                Console.WriteLine("Napoiles swoj samochod");
                Console.WriteLine("Teraz masz tyyyle paliwa: " + this.SilnikSamochodu.IloscPaliwa);
                return true;
            }
        }

    }
}
