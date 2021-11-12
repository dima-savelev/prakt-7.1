using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prakt_5
{
    class Rational : Pair
    {
       public Rational(int initFirst, int initSecond):base(initFirst, initSecond)
        {
            First = initFirst;
            Second = initSecond;
        }
        public static Rational operator +(Rational first, Rational second)
        {
            return new Rational((first.First * second.Second) + (first.Second * second.First), first.Second * second.Second);
        }
        public static Rational operator /(Rational first, Rational second)
        {
            return new Rational(first.First * second.Second, second.First * first.Second);
        }
        public Rational Minus(Rational value)
        {
            return new Rational((First * value.Second) - (Second * value.First), Second * value.Second);
        }
    }
}
