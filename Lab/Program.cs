using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1_OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Fractions arrF1 = new Fractions();
            Fractions arrF2 = new Fractions();
            Rational_fraction F = new Rational_fraction(1, 4);
            Random rd = new Random();
            for (int i = 0; i < 5; i++)
            {
                arrF1.add(rd.Next(1, 10), rd.Next(1, 10));
                arrF2.add(rd.Next(1, 10), rd.Next(1, 10));
            }
            arrF1.get_minmax();
            arrF1.get_geartless(F);
            Polynomial Poly1 = new Polynomial();
            Polynomial Poly2 = new Polynomial();
            Polynomial Poly3 = new Polynomial();
            Poly1.frac = arrF1.frac;
            Poly2.frac = arrF2.frac;
            Poly3 = Poly1 + Poly2;
            Poly3.show();
            return;
        }
    }
}
