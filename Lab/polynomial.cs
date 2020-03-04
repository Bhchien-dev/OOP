using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1_OOP
{
    public class Polynomial : Fractions
    {
        public static Polynomial operator+(Polynomial arr1, Polynomial arr2)
        {
            Polynomial arr3 = new Polynomial();
            for (int i = 0; i < arr1.frac.Count; i++)
                arr3.add(arr1.frac[i].numerator * arr2.frac[i].denominator
                              + arr1.frac[i].denominator * arr2.frac[i].numerator,
                              arr1.frac[i].denominator * arr2.frac[i].denominator);
            return arr3;
        }
        public void show()
        {
            int x = 0;
            foreach(Rational_fraction i in frac)
            {
                Console.Write(i.numerator + "/" + i.denominator + "x^" + x++ + ' ');
            }
            Console.WriteLine();
        }
    }
}