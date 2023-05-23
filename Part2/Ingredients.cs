using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace Part2
{
     public class Ingredient
    {
       
        public string Name { get; set; } // The name of the ingredient.
        public double Quantity { get; set; } // The quantity of the ingredient.
        public string Unit { get; set; }// The unit of measurement for the ingredient.

        public string foodGroup { get; set; }
        public Ingredient(string name, double quantity, string unit, string foodgroup) 
        {
            Name = name;
            Quantity = quantity;
            Unit = unit;
            foodGroup = foodgroup;

        }
    }
}
