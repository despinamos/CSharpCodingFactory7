using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fraction.Model
{
    internal class Fraction
    {
        private int _numerator;
        private int _denominator;

        public int Numerator
        {
            get { return _numerator; }
            set { _numerator = value; }
        }
        public int Denominator
        {
            get { return _denominator; }
            set
            {
                if (value == 0)
                    throw new ArgumentException("Denominator cannot be zero.");
                _denominator = value;
            }
        }

        public Fraction() { }

        public Fraction(int numerator, int denominator)
        {
            _numerator = numerator;
            _denominator = denominator;
        }

        public static Fraction operator +(Fraction a) => a;
        public static Fraction operator -(Fraction a) => new Fraction(-a.Numerator, a.Denominator);
        public static Fraction operator +(Fraction a, Fraction b) 
            => new Fraction(a.Numerator * b.Denominator 
                + b.Numerator * a.Denominator, a.Denominator * b.Denominator);
        public static Fraction operator -(Fraction a, Fraction b) => a + (-b);
        public static Fraction operator *(Fraction a, Fraction b)
            => new Fraction(a.Numerator * b.Numerator, a.Denominator * b.Denominator);
        public static Fraction operator /(Fraction a, Fraction b)
        {
            try
            {
                if (b.Numerator == 0) throw new DivideByZeroException("Cannot divide by a fraction with a numerator of zero.");
                return a * new Fraction(b.Denominator, b.Numerator);
            } catch(DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
                return null!;
            }
        }

        public override bool Equals(object? obj)
        {
            return obj is Fraction fraction &&
                Numerator == fraction.Numerator &&
                Denominator == fraction.Denominator;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Numerator, Denominator);
        }

        public override string? ToString()
        {
            return $"{Numerator} / {Denominator}";
        }
    }
}
