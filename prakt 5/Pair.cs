using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prakt_5
{
    class Pair
    {
        public Pair(int initFirst, int initSecond)
        {
            First = initFirst;
            Second = initSecond;
        }
        public int First { get; set; }
        public int Second { get; set; }
        //public bool Compare()
        //{
        //    if (First == Second) return true;
        //    else return false;
        //}
        //public bool Compare(Pair value)
        //{
        //    if (First == value.First && Second == value.Second) return true;
        //    else return false;
        //}
        //public bool Compare(Pair second, Pair third)
        //{
        //    if (First == second.First && second.First == third.First && Second == second.Second && second.Second == third.Second) return true;
        //    else return false;
        //}
        public static bool operator true(Pair value)
        {
            if (value.First == value.Second) return true;
            else return false;
        }
        public static bool operator false(Pair value)
        {
          return value.First != value.Second;
        }
        public static bool operator ==(Pair first, Pair second)
        {
            if (first.First == second.First && first.Second == second.Second)
            {
                return true;
            }
            return false;
        }
        public static bool operator !=(Pair first, Pair second)
        {
            if (first == second) return false;
            else return true;
        }
        public int Multiply()
        {
            return First * Second;
        }
        public Pair Multiply(Pair value)
        {
            return new Pair(First * value.First, Second * value.Second);
        }
        public Pair Multiply(Pair second, Pair third)
        {
            return new Pair(First * second.First * third.First, Second * second.Second * third.Second);
        }
        public int Minus()
        {
            return First - Second;
        }
        public Pair Minus(Pair value)
        {
            return new Pair(First - value.First, Second - value.Second);
        }
        public Pair Minus(Pair second, Pair third)
        {
            return new Pair(First - second.First - third.First, Second - second.Second - third.Second);
        }
        public static Pair operator -(Pair first, Pair second)
        {
            return new Pair(first.First - second.First, first.Second - second.Second);
        }
    }
}
