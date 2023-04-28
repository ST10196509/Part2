using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part2
{
    class Recipe //This class is the blueprint of what the recipe needs to contain to make it a recipe
    {
        //Variables private means another class cannot access these variables
        private int numIngredients = 0;
        private int numOfSteps = 0;
        private double scale = 0;
        private int numRecipe = 0;

        //public ArrayList ingName = new ArrayList();
        //public ArrayList ingQuantity = new ArrayList();
        //public ArrayList ingUOM = new ArrayList();
        //public ArrayList ingDescription = new ArrayList();

        public List<string> ingName = new List<string>();
        public List<double> ingQuantity = new List<double>();
        public List<string> ingUOM = new List<string>();
        public List<string> ingDescription = new List<string>();
        public List<string> recipeName = new List<string>();
        public StringBuilder sb = new StringBuilder();
        public IDictionary Dic = new Dictionary<string, string>();
        //Get and set for number of ingredients user enters
        public int NUMINGREDIENTS
        {
            get { return numIngredients; }
            set { numIngredients = value; }
        }
        //Gets and sets the number of steps the user enters
        public int NUMOFSTEPS
        {
            get { return numOfSteps; }
            set { numOfSteps = value; }
        }
        //Gets and sets the scale value that the user enters
        public double SCALE
        {
            get { return scale; }
            set { scale = value; }
        }
        //Gets and sets the value of recipes that the user enters
        public int NUMRECIPE
        {
            get { return numRecipe; }
            set { numRecipe = value; }
        }

    }
}
