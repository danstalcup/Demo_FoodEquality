using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using FoodEquality.Shared;

namespace FoodEquality.Value
{
    public struct FoodV : IFood, IEquatable<FoodV>
    {
        public FoodV(string Name, FoodGroup Group)
        {
            _group = Group;
            _name = Name;
        }

        public FoodGroup Group
        {
            get
            {
                return _group;
            }
        }

        public string Name
        {
            get
            {
                return _name;  
            }
        }

        public override string ToString()
        {
            return $"{Name} - {Group}";
        }

        private readonly string _name;
        private readonly FoodGroup _group;

        #region Equality

        public bool Equals(FoodV other)
        {
            return this._name.Equals(other.Name,StringComparison.CurrentCultureIgnoreCase) && this._group == other.Group;
        }

        public override bool Equals(object obj)
        {
            if(obj is IFood)
            {
                return Equals((FoodV)obj);
            }
            else
            {
                return false;
            }
        }

        public static bool operator ==(FoodV left, FoodV right)
        {
            return left.Equals(right);
        }

        public static bool operator !=(FoodV left, FoodV right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return _name.GetHashCode() ^ _group.GetHashCode();
        }

        #endregion
   
    }
}
