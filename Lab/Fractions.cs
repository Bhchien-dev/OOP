using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1_OOP
{
    public class Fractions
    {
        public List<Rational_fraction> frac = new List<Rational_fraction>();
        public void add(int num1, int num2)
        {
            frac.Add(new Rational_fraction(num1, num2));
        }
        double value(Rational_fraction f)
        {
            return (Convert.ToDouble(f.numerator) / Convert.ToDouble(f.denominator));
        }
        public void get_minmax()
        {
            double minf = value(frac[0]);
            double maxf = value(frac[0]);
            Rational_fraction fracmax = frac[0];
            Rational_fraction fracmin = frac[0];
            foreach(Rational_fraction i in frac)
            {
                if (value(i) > maxf) { maxf = value(i); fracmax = i; }
                if (value(i) < minf) { minf = value(i); fracmin = i; }
            }
            Console.WriteLine("Max: {0}/{1}, Min: {2}/{3}", fracmax.numerator, fracmax.denominator, 
                                                            fracmin.numerator, fracmin.denominator);
            return;
        } 
        public void get_geartless(Rational_fraction f)
        {
            int geater = 0;
            int less = 0;
            foreach (Rational_fraction i in frac)
            {
                if (value(i) > value(f)) geater++;
                if (value(i) < value(f)) less++;
            }
            Console.WriteLine(">{0}/{1}: {2}", f.numerator, f.denominator, geater);
            Console.WriteLine("<{0}/{1}: {2}", f.numerator, f.denominator, less);
            return;
        }
    }
}
