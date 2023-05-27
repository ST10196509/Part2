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
        public double CaloriesPerUnit { get; set; }
        public string foodGroup { get; set; }
        public double totalCalories { get; set; }

        public delegate double delTotalCal(double x, double y);

        

        public static double calculate(double x, double y)
        {
            return x * y;
        }



        //This is the ingredient constructor
        //This is the blueprint or what attributes an ingredient has
        public Ingredient(string name, double quantity, string unit,double caloriesperunit, string foodgroup) 
        {
            Name = name;
            Quantity = quantity;
            Unit = unit;
            CaloriesPerUnit = caloriesperunit;
            foodGroup = foodgroup;
            
        }
    }
}
