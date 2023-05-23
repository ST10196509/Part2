using System.Collections.Generic;
using System;
using System.Xml;
using System.Text;

namespace Part2
{
    public class Recipe
    {
        //Name of the recipe
        public string Name { get; set; }
        // A list of the ingredients for the recipe.
        public List<Ingredient> Ingredients = new List<Ingredient>();
        // A list of the steps for the recipe.
        public List<Step> Steps = new List<Step>();
        public double Factor ;
        int numIngredients;
        int numSteps;

        public void EnterDetails()
        {
            bool breakk = false;

            double quantity = 0;
            Console.Write("Enter the ");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.Write("name");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(" of the recipe: ");
                
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Name = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.White;

            // This while loop will continue to run until the breakk variable is set to true(user-input is valid).
            while (!(breakk))
            {
                try
                {
                    Console.Write("Enter the ");
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    Console.Write("number");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write(" of ingredients: ");

                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    numIngredients = int.Parse(Console.ReadLine());
                    Console.ForegroundColor = ConsoleColor.White;

                    // Set the breakk variable to true to break out of the loop.
                    breakk = true;

                }
                //Catch block will be executed if the input is invalid
                catch (FormatException ex)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Incorect Input.");
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }
            

            for (int i = 0; i < numIngredients; i++)
            {

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
                string name = Console.ReadLine();
                Console.ForegroundColor = ConsoleColor.White;

                
                // This while loop will continue to run until the breakk variable is set to true(user-input is valid).
                breakk = false;
                while (!(breakk))
                {
                    try
                    {

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
                        quantity = double.Parse(Console.ReadLine());
                        Console.ForegroundColor = ConsoleColor.White;
                        breakk = true;
                    }
                    catch (FormatException ex)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Incorect Input.");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                }

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
                string unit = Console.ReadLine();
                Console.ForegroundColor = ConsoleColor.White;

                // This method adds an ingredient to the recipe.
                Ingredient ingredient = new Ingredient(name, quantity, unit);
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
                    numSteps = int.Parse(Console.ReadLine());
                    Console.ForegroundColor = ConsoleColor.White;
                    breakk = true;
                }
                catch (FormatException ex)
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
                string step = Console.ReadLine();
                Console.ForegroundColor = ConsoleColor.White;
                AddStep(step);
            }
            
            Display();

            Console.Write("Do you want to ");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.Write("scale");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(" the recipe y/n: ");

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            string option = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.White;
            switch (option.ToLower().Trim())
            {
                case "y":
                    // Scale the recipe.
                    Console.Write("Enter the ");
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    Console.Write("scale");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write(" factor: ");

                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    double scaleFactor = Convert.ToDouble(Console.ReadLine());
                    Console.ForegroundColor = ConsoleColor.White;
                    Scale(scaleFactor);
                    Display();

                    //Reset Recipe 
                    Console.Write("Would you like to ");
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    Console.Write("reset");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write(" the quantities to the origional y/n: ");

                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    string resetQ = Console.ReadLine();
                    Console.ForegroundColor = ConsoleColor.White;
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
        //Enter details calls

       


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
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("--------------------------");
            Console.WriteLine("Recipe: " + Name);
            Console.WriteLine("--------------------------");
            

            foreach (Ingredient ingredient in Ingredients)
            {
                Console.WriteLine("Ingredient: " + ingredient.Name);
                Console.WriteLine("Quantity: " + ingredient.Quantity + " " + ingredient.Unit);
                Console.WriteLine("----------");
            }

            foreach (Step step in Steps)
            {
                Console.WriteLine("Step: " + step.Description);
                
            }
            Console.WriteLine("--------------------------");
            Console.ForegroundColor = ConsoleColor.White;
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