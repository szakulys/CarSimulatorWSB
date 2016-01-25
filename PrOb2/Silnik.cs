using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrOb2
{
    class Silnik
    {
        public readonly double Pojemnosc;
        public double IloscPaliwa;
        public readonly double PojemnoscBaku;
        public const double DomyslnaPojemnoscBaku = 60;

        public Silnik(double pojemnosc, double iloscPaliwa)
            : this(pojemnosc, iloscPaliwa, DomyslnaPojemnoscBaku)
        {
        }

        public Silnik(double pojemnosc, double iloscPaliwa, double pojemnoscBaku)
        {
            if (pojemnoscBaku < 0)
            {
                this.PojemnoscBaku = 1;
            }
            else
            {
                this.PojemnoscBaku = pojemnoscBaku;
            }

            if (iloscPaliwa > this.PojemnoscBaku || (iloscPaliwa < 0))
            {
                this.IloscPaliwa = this.PojemnoscBaku;
            }
            else
            {
                this.IloscPaliwa = iloscPaliwa;
            }

            if (pojemnosc < 0)
            {
                this.Pojemnosc = 2;
            }
            else
            {
                this.Pojemnosc = pojemnosc;
            }
        }

        public static double PrzeliczSpalanie(double spalanie)
        {
            return 253.2 / spalanie;
        }

    }
}
