using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodEquality
{
    public class Food_Sample
    {
        private readonly string _name;
        public string Name { get { return _name; } }

        public Food_Sample(string Name)
        {
            this._name = Name;
        }

        public override string ToString()
        {
            return _name;
        }
    }
}
