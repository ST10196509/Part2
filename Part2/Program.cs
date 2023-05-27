using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;

namespace Part2
{
    public class Program
    {
        static void Main(string[] args)
        {
            //List that will contain all the recipies.
            List<Recipe> recipes = new List<Recipe>();
            bool quit = false;

            while (!quit)
            {
                Console.WriteLine("\n1. Add a new recipe");
                Console.WriteLine("2. Display all recipes");
                Console.WriteLine("3. Quit");
                Console.Write("Enter your choice: ");
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                string choice = Console.ReadLine();
                Console.ForegroundColor = ConsoleColor.White;

                switch (choice) 
                {
                    case "1":
                        //Creates a new recipe. This does not contain a constructor
                        Recipe recipe = new Recipe();
                        //Creates the recipe by getting the details from the user
                        recipe.EnterDetails();
                        //Adds the recipe to the collection.
                        recipes.Add(recipe);
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Recipe added successfuly.");
                        Console.ForegroundColor = ConsoleColor.White;
                        break;

                    case "2":
                        //If the recipies list is empty.
                        if (recipes.Count == 0)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("No recipes found.");
                            Console.ForegroundColor = ConsoleColor.White;
                            break;
                        }

                        // Sort the recipes by name. this is how to sort a list (var variablename = listname.OrderBy(r => r.attribute) )
                        var sortedRecipes = recipes.OrderBy(r => r.Name);
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.Write("\n--------------------------");
                        Console.WriteLine("\nRecipies");
                        Console.WriteLine("--------------------------");

                        /* 
                        This code iterates through the sorted recipes
                        collection and prints the name of each recipe
                        to the console.*/
                        foreach (Recipe r in sortedRecipes)
                        {
                            Console.WriteLine($"{r.Name}");
                        }
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.White;

                        Console.Write("Enter the name of the recipe to display: ");
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        //Gets recipe name from the user
                        string recipeName = Console.ReadLine();
                        Console.ForegroundColor = ConsoleColor.White;
                        //Compares the gottenRecipe(recipeName) to the names in the recipes list and stores it in selectedRecipe.
                        Recipe selectedRecipe = recipes.Find(r => r.Name.ToLower() == recipeName.ToLower().Trim());

                        //if gottenRecipe(recipeName) is not found in the recipe list.
                        if (selectedRecipe == null)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Recipe was not found.");
                            Console.ForegroundColor = ConsoleColor.White;
                            break;
                        }
                        else
                        {
                            selectedRecipe.Display();
                        }

                        break;

                    case "3":
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Goodbye!");
                        Console.ForegroundColor = ConsoleColor.White;
                        quit = true;
                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Invalid choice.");
                        
                        Console.ForegroundColor = ConsoleColor.White;
                        break;
                }
            }
        }
    }
}