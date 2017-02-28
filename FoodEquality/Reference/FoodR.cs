using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using FoodEquality.Shared;

namespace FoodEquality.Reference
{
    public class FoodR : IFood
    {       
        public FoodR(string Name, FoodGroup Group)
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

        public static bool operator ==(FoodR x, FoodR y)
        {
            return x.Equals(y);
        }

        public static bool operator !=(FoodR x, FoodR y)
        {
            return !x.Equals(y);
        }

        public override bool Equals(object obj)
        {                        
            if(obj == null)
            {
                return false;
            }
            if(ReferenceEquals(this,obj))
            {
                return true;
            }
            if(GetType() != obj.GetType())
            {
                return false;
            }

            FoodR food = (FoodR)obj;
            return food.Name.Equals( Name , StringComparison.CurrentCultureIgnoreCase) && food.Group == Group;
        }

        public override int GetHashCode()
        {
            return Name.GetHashCode() ^ Group.GetHashCode();
        }
    }
}
