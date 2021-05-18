using System;

namespace lab7
{
    public class Rational : IComparable<Rational>
    {
        private int _numerator;
        private int _denominator;

        public Rational(int num, int den)
        {
            Numerator = num;
            Denominator = den;
            
            GCF();
        }

        public int Numerator
        {
            get
            {
                return _numerator;
            }

            set
            {
                _numerator = value;
            }
        }
        
        public int Denominator
        {
            get
            {
                return _denominator;
            }

            set
            {
                if(value != 0) 
                    _denominator = value;
            }
        }

        public int CompareTo(Rational number)
        {
            if (number != null)
            {
                if (this.ToFloat() == number.ToFloat())
                    return 0;
                
                else if (this.ToFloat() <= number.ToFloat())
                    return -1;

                else
                    return 1;
            }
            else 
                throw new Exception("Сomparison is not possible.");
        }

        override public string ToString()
        {
            string result;
            if (Denominator == 1 || Numerator == 0)
                result = $"{Numerator}";
            
            else
                result = $"{Numerator}/{Denominator}";

            return result;
        }
        
        public float ToFloat()
        {
            float result = 0;

            if (this.Denominator != 0)
            {
                result = (float)((float)Numerator / Denominator);
            }

            return result;
        }
        
        public static implicit operator short(Rational number)
        {
            return (short)(number.Numerator / number.Denominator);
        }
        
        public static implicit operator int(Rational number)
        {
            return number.Numerator / number.Denominator;
        }
        
        public static implicit operator long(Rational number)
        {
            return (long)(number.Numerator / number.Denominator);
        }
        
        public static implicit operator double(Rational number)
        {
            return (double)((double)number.Numerator / number.Denominator);
        }

        private void GCF()
        {
            int dnum, dden = Denominator;

            if (Numerator == 0) 
                return;
            
            else if (Numerator < 0)
                dnum = -Numerator;

            else
                dnum = Numerator;

            if (Denominator < 0)
            {
                dden = -Denominator;
            }

            while (dnum != dden)
            {
                if (dnum > dden)
                    dnum -= dden;

                else
                    dden -= dnum;
            }

            Numerator /= dnum;
            Denominator /= dden;
        }

        public static bool operator <(Rational number1, Rational number2)
        {
            if (number1.Numerator * number2.Denominator < number2.Numerator * number1.Denominator)
                return true;
            else 
                return false;
        }
        
        public static bool operator >(Rational number1, Rational number2)
        {
            if (number1.Numerator * number2.Denominator > number2.Numerator * number1.Denominator)
                return true;
            else 
                return false;
        }
        
        public static bool operator ==(Rational number1, Rational number2)
        {
            if ((number1.Numerator == number2.Numerator) && (number1.Denominator == number2.Denominator))
                return true;
            else 
                return false;
        }
        
        public static bool operator !=(Rational number1, Rational number2)
        {
            if ((number1.Numerator == number2.Numerator) && (number1.Denominator == number2.Denominator))
                return false;
            else 
                return true;
        }

        public static Rational operator +(Rational number1, Rational number2)
        {
            return new Rational(number1.Numerator * number2.Denominator + number2.Numerator * number1.Denominator,
                number1.Denominator * number2.Denominator);
        }
        
        public static Rational operator -(Rational number1, Rational number2)
        {
            return new Rational(number1.Numerator * number2.Denominator - number2.Numerator * number1.Denominator,
                                number1.Denominator * number2.Denominator);
        }
        
        public static Rational operator *(Rational number1, Rational number2)
        {
            return new Rational(number1.Numerator * number2.Numerator,
                                number1.Denominator * number2.Denominator);
        }
        
        public static Rational operator /(Rational number1, Rational number2)
        {
            return new Rational(number1.Numerator * number2.Denominator,
                number1.Denominator * number2.Numerator);
        }
        
        public static Rational operator ++(Rational number)
        {
            return new Rational(number.Numerator + number.Denominator, number.Denominator);
        }
        
        public static Rational operator --(Rational number)
        {
            return new Rational(number.Numerator - number.Denominator, number.Denominator);
        }
    }
}