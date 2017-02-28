using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodEquality.Shared
{
    public interface IFood
    {
        string Name { get; }
        FoodGroup Group { get; }
    }
}
