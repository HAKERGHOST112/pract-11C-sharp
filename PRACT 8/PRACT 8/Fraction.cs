using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace PRACT_8
{
    internal class Fraction
    {
        public int numerator, denominator, integer, sing;

        public Fraction(int sing, int integer, int numerator, int denominator)
        {
            this.numerator = numerator;
            this.denominator = denominator;
            this.integer = integer;
            this.sing = sing;
        }
        public Fraction()
        {
            this.numerator = 0;
            this.denominator = 1;
            this.integer = 0;
            this.sing = 1;
        }

        public Fraction Addition(Fraction other)
        {
            Fraction rez = new Fraction();
            rez.denominator = this.denominator * other.denominator;
            rez.numerator = this.numerator * other.denominator + this.denominator * other.numerator;
            return rez;
        }

        public Fraction Correct_Fraction()
        {
            Fraction rez = new Fraction();
            rez.integer = this.numerator / this.denominator;
            rez.numerator = this.numerator % this.denominator;
            rez.denominator = this.denominator;
            return rez;
        }
        public Fraction Shorter_Fraction()
        {
            Fraction rez = new Fraction();
            int a = this.numerator;
            int b = this.denominator;
            while (a != b)
            {
                if (a > b)
                {
                    a = a - b;
                }
                else
                {
                    b = b - a;



                }
            }
            rez.numerator = this.numerator / a;
            rez.denominator = this.denominator / a;
            return rez;

        }
        public override string ToString()
        {
            return integer + "(" + numerator + "/" + denominator;
        }
        static public Fraction operator +(Fraction d1, Fraction d2)
        {
            Fraction rez = new Fraction();
            rez.denominator = d1.denominator * d2.denominator;
            rez.numerator = d1.numerator * d2.denominator + d1.denominator * d2.numerator;
            rez.integer=d1.integer + d2.integer;
            rez.integer=rez.integer+rez.numerator/rez.denominator;
            rez.numerator=rez.numerator%rez.denominator;
            return rez;
        }
        static public Fraction operator -(Fraction d1, Fraction d2)
        {
            Fraction rez = new Fraction();
            rez.denominator = d1.denominator * d2.denominator;
            rez.numerator = d1.numerator * d2.denominator - d1.denominator * d2.numerator;
            return rez;
        }
        static public Fraction operator *(Fraction d1, Fraction d2)
        {
            Fraction rez = new Fraction();
            rez.numerator = d1.numerator * d2.numerator;
            rez.denominator = d1.denominator * d2.denominator;
            return rez;
        }

        static public Fraction operator /(Fraction d1, Fraction d2)
        {
            Fraction rez = new Fraction();
            rez.numerator = d1.numerator * d2.denominator;
            rez.denominator = d1.denominator * d2.numerator;
            return rez;
        }
        public static bool operator >(Fraction d1, Fraction d2)
        {
            int a = d1.numerator * d2.denominator;
            int b = d2.numerator * d1.denominator;
            return a > b;
        }
        public static bool operator <(Fraction d1, Fraction d2)
        {
            int a = d1.numerator * d2.denominator;
            int b = d2.numerator * d1.denominator;
            return a < b;
        }
        public static bool operator >=(Fraction d1, Fraction d2)
        {
            int a = d1.numerator * d2.denominator;
            int b = d2.numerator * d1.denominator;
            return a >= b;
        }
        public static bool operator <=(Fraction d1, Fraction d2)
        {
            int a = d1.numerator * d2.denominator;
            int b = d2.numerator * d1.denominator;
            return a <= b;
        }
        public static bool operator !=(Fraction d1, Fraction d2)
        {
            return !(d1 == d2);
        }
        public static bool operator ==(Fraction d1, Fraction d2)
        {
            if (ReferenceEquals(d1, d2)) return true;
            if (ReferenceEquals(d2, null) || ReferenceEquals(d2, null)) return false;
            int a = d1.numerator * d2.denominator;
            int b = d2.numerator * d1.denominator;
            return a == b;
        }
        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }
            Fraction other = (Fraction)obj;
            return this == other;
        }
        public override int GetHashCode()
        {
            unchecked
            {
                int hash = 17;
                hash = hash * 23 + numerator.GetHashCode();
                hash = hash * 23 + denominator.GetHashCode();
                hash = hash * 23 + integer.GetHashCode();
                hash = hash * 23 + sing.GetHashCode();
                return hash;
            }
        }
        public static Fraction Parse(string str)
        {
            Fraction rez = new Fraction();
            int id = str.IndexOf(' ');
            String str_integer= str.Substring(0, id);
            rez.integer=Convert.ToInt32(str_integer);
            str=str.Substring(id+1);
            int id2=str.IndexOf('/');
            string str_numerator= str.Substring(0, id2);
            string str_denominator=str.Substring(id2+1);
            rez.numerator= Convert.ToInt32(str_numerator);
            rez.denominator= Convert.ToInt32(str_denominator);
            return rez;
        }
    }
        
            
            
            

            


          
            

        
          
        


    
}
