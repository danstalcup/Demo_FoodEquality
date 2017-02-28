using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodEquality.Value
{
    public struct CalorieCount : IComparable, IComparable<CalorieCount>, IEquatable<CalorieCount>
    {
        public CalorieCount(int Value)
        {
            _value = Value;
        }

        public int Value
        {
            get
            {
                return _value;
            }
        }

        public override string ToString()
        {
            return $"{Value} cal";
        }

        private readonly int _value;

        #region Comparison
        public int CompareTo(object obj)
        {
            if(obj == null)
            {
                throw new ArgumentNullException("obj");
            }
            if(!(obj is CalorieCount))
            {
                throw new ArgumentException("Parameter must be of type CalorieCount", "obj");
            }
            return CompareTo((CalorieCount)obj);
        }

        public int CompareTo(CalorieCount cc)
        {
            return Value.CompareTo(cc.Value);
        }

       

        public static bool operator <(CalorieCount x, CalorieCount y)
        {
            return x.Value < y.Value;
        }

        public static bool operator >(CalorieCount x, CalorieCount y)
        {
            return x.Value > y.Value;
        }
        public static bool operator <=(CalorieCount x, CalorieCount y)
        {
            return x.Value <= y.Value;
        }
        public static bool operator >=(CalorieCount x, CalorieCount y)
        {
            return x.Value >= y.Value;
        }
        #endregion

        #region Equality

        public override bool Equals(object obj)
        {
            if(!(obj is CalorieCount))
            {
                return false;
            }

            return Equals((CalorieCount)obj);
        }

        public bool Equals(CalorieCount other)
        {
            return other.Value == Value;
        }

        public static bool operator ==(CalorieCount x, CalorieCount y)
        {
            return x.Equals(y);
        }

        public static bool operator !=(CalorieCount x, CalorieCount y)
        {
            return !x.Equals(y);
        }

        public override int GetHashCode()
        {
            return Value;
        }

        #endregion 
    }
}
