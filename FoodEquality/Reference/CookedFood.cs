using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FoodEquality.Shared;

namespace FoodEquality.Reference
{
    public sealed class CookedFood : FoodR
    {
        public CookedFood(string Name, FoodGroup Group, string CookingMethod) : base(Name, Group)
        {
            _cookingMethod = CookingMethod;
        }        

        public string CookingMethod
        {
            get
            {
                return _cookingMethod;
            }
        }

        public override string ToString()
        {
            return $"{base.ToString()} - {CookingMethod}";
        }

        private string _cookingMethod;

        public override bool Equals(object obj)
        {
            if(!base.Equals(obj))
            {
                return false;            
            }
            var cf = (CookedFood)obj;
            return cf.CookingMethod == CookingMethod;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode() ^ CookingMethod.GetHashCode();
        }

        public static bool operator ==(CookedFood x, CookedFood y)
        {
            return x.Equals(y);
        }

        public static bool operator !=(CookedFood x, CookedFood y)
        {
            return !x.Equals(y);
        }
    }
}
