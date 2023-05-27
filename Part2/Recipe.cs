using System.Collections.Generic;
using System;
using System.Xml;
using System.Text;
using System.Linq;
using System.Web;
using System.Windows;

namespace Part2
{
    //This class is what a recipe contains. so the Recipe name, the ingredients, and the steps
    public class Recipe
    {
        //Name of the recipe
        public string Name { get; set; }
        // A list of type Ingredient that will contain the ingredietns and their attributes
        public List<Ingredient> Ingredients = new List<Ingredient>();
        // A list of type Step that will contain the step desctiprion
        public List<Step> Steps = new List<Step>();
        public double Factor ;
        int numIngredients;
        int numSteps;
        int caloriesPerUnit;

        
        //This method gets the Recipe name, ingrediets(name,quantity,unitofmeasurement,caloriesperunit, foodgroup, and the steps)
        public void EnterDetails()
        {
            //For the try catch so that it can run infinatley until true
            bool breakk = false;
            double quantity = 0;

            //Name of recipe
            Console.Write("Enter the ");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.Write("name");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(" of the recipe: ");
                
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            //Gets the name of the recipe
            Name = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.White;

            
            // This while loop will continue to run until the breakk variable is set to true(user-input is valid).
            while (!(breakk))
            {
                try
                {
                    //-----------Number of Ingredients
                    Console.Write("Enter the ");
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    Console.Write("number");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write(" of ingredients: ");

                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    //Asks user for the number of ingredients
                    numIngredients = int.Parse(Console.ReadLine());
                    Console.ForegroundColor = ConsoleColor.White;

                    // Set the breakk variable to true to break out of the loop.
                    breakk = true;

                }
                //Catch block will be executed if the input is invalid
                catch (FormatException )
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    
                    Console.WriteLine("Incorect Input.");
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }
            
            //Gets details for the ingredients
            for (int i = 0; i < numIngredients; i++)
            {
                //Name of ingredient
                Console.Write("Enter the ");
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.Write("name");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write(" of ingredient");
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.Write($" {i + 1}");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write(": ");

                Console.ForegroundColor = ConsoleColor.DarkYellow;
                //Gets the name of the ingredient
                string name = Console.ReadLine();
                Console.ForegroundColor = ConsoleColor.White;

                
                // This while loop will continue to run until the breakk variable is set to true(user-input is valid).
                breakk = false;
                while (!(breakk))
                {
                    try
                    {
                        //---------Quantity
                        Console.Write("Enter the ");
                        Console.ForegroundColor = ConsoleColor.DarkCyan;
                        Console.Write("quantity");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write(" of the ingredient");
                        Console.ForegroundColor = ConsoleColor.DarkCyan;
                        Console.Write($" {i + 1}");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write(": ");

                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        //Gets the quantity of the ingredient
                        quantity = double.Parse(Console.ReadLine());
                        Console.ForegroundColor = ConsoleColor.White;
                        breakk = true;
                    }
                    catch (FormatException )
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Incorect Input.");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                }
                
                //-------------Unit of Measurement
                Console.Write("Enter the ");
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.Write("unit of measurement");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write(" for the ingredient: ");
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.Write($" {i + 1}");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write(": ");

                Console.ForegroundColor = ConsoleColor.DarkYellow;
                //Gets the unit of measurement from the user
                string unit = Console.ReadLine();
                Console.ForegroundColor = ConsoleColor.White;

                breakk = false;
                while (!(breakk))
                {
                    try
                    {
                        //----------------Calories per unit
                        Console.Write("Enter the ");
                        Console.ForegroundColor = ConsoleColor.DarkCyan;
                        Console.Write("calories per unit");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write(" for the ingredient");
                        Console.ForegroundColor = ConsoleColor.DarkCyan;
                        Console.Write($" {i + 1}");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write(": ");

                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        //Gets the calories per unit from the user
                        caloriesPerUnit = int.Parse(Console.ReadLine());
                        Console.ForegroundColor = ConsoleColor.White;
                        breakk = true;
                    }
                    catch (FormatException)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Incorect Input.");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                }

                //FoodGroup
                Console.Write("Enter the ");
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.Write("food group");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write(" for the ingredient");
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.Write($" {i + 1}");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write(": ");

                Console.ForegroundColor = ConsoleColor.DarkYellow;
                //Gets the food Group from the user
                string foodGroup = Console.ReadLine();
                Console.ForegroundColor = ConsoleColor.White;


                // Create new ingredient object
                Ingredient ingredient = new Ingredient(name, quantity, unit, caloriesPerUnit, foodGroup);
                //Adds the created ingredient object to the ingredients list
                Ingredients.Add(ingredient);

                
                

            }

            // This while loop will continue to run until the breakk variable is set to true(user-input is valid).
            breakk = false;
            while (!(breakk))
            {
                try
                {

                    Console.Write("Enter the ");
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    Console.Write("number");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write(" of steps: ");

                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    //Gets the number of steps need to create the recipe
                    numSteps = int.Parse(Console.ReadLine());
                    Console.ForegroundColor = ConsoleColor.White;
                    breakk = true;
                }
                catch (FormatException )
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Incorect Input.");
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }

            for (int i = 0; i < numSteps; i++)
            {
                Console.Write($"Enter step");
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.Write($"{ i + 1 }");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write($"'s description: ");
                
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                //Gets the step description
                string step = Console.ReadLine();
                Console.ForegroundColor = ConsoleColor.White;
                //Adds the created step object to the Steps list
                AddStep(step);
            }
            
            Display();

            //---------Scale Recipe
            breakk = false;
            string option = "";
            while (!breakk)
            {
                Console.Write("Do you want to ");
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.Write("scale");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write(" the recipe y/n: ");

                Console.ForegroundColor = ConsoleColor.DarkYellow;
                option = Console.ReadLine();
                Console.ForegroundColor = ConsoleColor.White;

                //Exception handling for scale choice
                if (option.Equals("y") || option.Equals("yes") || option.Equals("no")|| option.Equals("n"))
                {
                    breakk = true;
                }
                else 
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Invalid choice Try Agian.");
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }

            switch (option.ToLower().Trim())
            {
                case "y":

                    //Exception handling for scale factor choice                    
                    breakk = false;
                    while (!(breakk))
                    {
                        try
                        {
                            // Scale the recipe.
                            Console.Write("Enter the ");
                            Console.ForegroundColor = ConsoleColor.DarkCyan;
                            Console.Write("scale");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.Write(" factor: ");

                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                            //Gets scale factor from user
                            double scaleFactor = Convert.ToDouble(Console.ReadLine());
                            Console.ForegroundColor = ConsoleColor.White;
                            Scale(scaleFactor);
                            Display();
                            breakk = true;
                        }
                        catch (FormatException)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Incorect Input.");
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                    }


                    //-----------Reset Recipe 
                    breakk = false;
                    string resetQ = "";
                    while (!breakk)
                    {
                        
                        Console.Write("Would you like to ");
                        Console.ForegroundColor = ConsoleColor.DarkCyan;
                        Console.Write("reset");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write(" the quantities to the origional y/n: ");

                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        resetQ = Console.ReadLine();
                        Console.ForegroundColor = ConsoleColor.White;

                        //Exception handling for reset choice
                        if (resetQ.Equals("y") || resetQ.Equals("yes") || resetQ.Equals("no") || resetQ.Equals("n"))
                        {
                            breakk = true;
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Invalid choice Try Agian.");
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                    }
                    switch (resetQ.ToLower().Trim())
                    {
                        case "y":
                        case "yes":
                            ResetQuantities();
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Reset to the origional values");
                            Console.ForegroundColor = ConsoleColor.White;
                            break;

                        case "n":
                        case "no":
                            break;
                    }
                    break;

                case "n":
                case "no":
                    break;
                default:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Invalid choice.");
                    Console.ForegroundColor = ConsoleColor.White;

                    break;
            }
            
        }
        

       


        // This method adds a step to the recipe.
        public void AddStep(string description)
        {
            Steps.Add(new Step
            {
                Description = description
            });
        }

        // This method displays the recipe.
        public void Display()
        {
            Ingredient.delTotalCal cal = Ingredient.calculate;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("--------------------------");
            Console.WriteLine("Recipe: " + Name);
            Console.WriteLine("--------------------------");

            //Iterates through the Ingredients list
            foreach (Ingredient ingredient in Ingredients)
            {
                Console.WriteLine("Ingredient: " + ingredient.Name);
                Console.WriteLine("Quantity: " + ingredient.Quantity + " " + ingredient.Unit);
                Console.WriteLine($"Calories: {ingredient.CaloriesPerUnit} calories per {ingredient.Unit}"  );
                Console.WriteLine("Food Group: " + ingredient.foodGroup);
                Console.WriteLine("----------");
            }
            //Iterates through the Steps list
            foreach (Step step in Steps)
            {
                Console.WriteLine("Step: " + step.Description);
                
            }
            Console.WriteLine("--------------------------");

            Console.ForegroundColor = ConsoleColor.White;

            double totalcaloreies = 0;
            foreach (Ingredient ingredient in Ingredients)
            {
                totalcaloreies += cal(ingredient.Quantity, ingredient.CaloriesPerUnit);
                
            }
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"Total Calories is: {totalcaloreies}kcal");
            Console.ForegroundColor = ConsoleColor.White;
            if (totalcaloreies > 300)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Recipe  exceeds 300 calories");
                Console.ForegroundColor = ConsoleColor.White;
            }



        }

        // This method scales the recipe by a factor.
        public void Scale(double factor)
        {
            foreach (Ingredient ingredient in Ingredients)
            {
                ingredient.Quantity *= factor;
                Factor = factor;
            }
        }

        // This method resets the quantities of the ingredients to 1.
        public void ResetQuantities()
        {
            foreach (Ingredient ingredient in Ingredients)
            {
                ingredient.Quantity /= Factor;
            }
        }

        // This method clears the recipe.
        public void Clear()
        {
            Name = "";
            Ingredients.Clear();
            Steps.Clear();
        }
    }
}