using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part2
{
     class  Program // - ST10196509 -
    {
        //static means we dont need to create an object in order to use it
        static Recipe recipe = new Recipe();

        static void Main(string[] args)// - ST10196509 -
        {

            getNumRecipe();
           
            for (int i = 0; i < recipe.NUMRECIPE; i++)
            {
                emptyLists();
                Console.Write($"Enter the name of the {i + 1} Recipe >");
                recipe.recipeName.Add(Console.ReadLine());
                
                
                
                //Gets the number of ingrediets that the user enters
                getNumIngredients();
                //Get the Ingredients name, quantity and unit of measurement
                getIngredients();
                //Gets the number of steps it take to make the recipe and assigns it to (numOfSteps)
                getNumSteps();
                //Gets the description of how to make the recipe from the user and puts it in the arraylist(ingDescription)
                getDesofSteps();
                
                //Gets weather or not the user wants to scale the quantites of the recipe if so by what factor  
                getScaleQuantity();
                //Asks user if they want to clear everything and start the program again.
                askToClear();

                for (int k = 0; k < recipe.NUMINGREDIENTS; k++)
                {
                    recipe.Dic.Add(recipe.recipeName[i], recipe.recipeName[k] + "hello");
                }
                    
                
                


            }
            /*
            for (int i = 0; i < recipe.NUMRECIPE; i++)
            {
                Console.WriteLine(recipe.Dic[recipe.recipeName[i]]);
            }
            */
            foreach (KeyValuePair<string, string> kvp in recipe.Dic)
            {
                Console.WriteLine("Key: {0}, Value: {1}", kvp.Key, kvp.Value);
            }
                


        }
        public static void emptyLists()
        {
            recipe.ingName.Clear();
            recipe.ingQuantity.Clear();
            recipe.ingUOM.Clear();
            recipe.ingDescription.Clear();
            recipe.recipeName.Clear();

        }
        public static void getNumRecipe()
        {
            Console.Write("How many recipies would you like? >");
            recipe.NUMRECIPE = Convert.ToInt32(Console.ReadLine());
        }


        public static void getNumIngredients() // - ST10196509 -
        {

            try
            {
                Console.Write("How many ingredients do you have? >>");
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                recipe.NUMINGREDIENTS = Convert.ToInt32(Console.ReadLine());
                Console.ForegroundColor = ConsoleColor.White;
            }
            catch (Exception)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("!!!Input needs to be an Int!!!");
                Console.ForegroundColor = ConsoleColor.White;

                getNumIngredients();
            }
        }

        public static void getIngredients() // - ST10196509 -
        {
            for (int i = 0; i < recipe.NUMINGREDIENTS; i++)
            {
                //Asks and captures the name of the ingredient
                Console.Write("What is the name of ingredient " + (i + 1) + ": ");
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                recipe.ingName.Add(Console.ReadLine());
                
                Console.ForegroundColor = ConsoleColor.White;


                bool flag = false; //This flag will chage only when the user enters the correct input
                //This do while loop is to test if what the user enters is an integer or double or else it will ask them to enter correct values
                do
                {
                    try
                    {
                        //Asks and captures the quantity of the ingredients
                        Console.Write("What is the Quanity of ingredient " + (i + 1) + ": ");
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        recipe.ingQuantity.Add(Convert.ToDouble(Console.ReadLine()));//adds whats the user types into the arraylist
                        
                        Console.ForegroundColor = ConsoleColor.White;
                        flag = true;
                    }
                    catch (Exception)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("!!!Input needs to be Int/Double!!!");
                        Console.ForegroundColor = ConsoleColor.White;


                    }
                } while (!flag);

                //Asks and captures the unit of measurement of the ingredients
                Console.Write("What is the Unit of Measurment of Ingredient " + (i + 1) + ": ");
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                recipe.ingUOM.Add(Console.ReadLine());
                
                Console.ForegroundColor = ConsoleColor.White;
            }
        }


        public static void displayFullRecipe() // - ST10196509 -
        {
                //This is the value for the name of the recipe
                string recName = recipe.recipeName[0];    

                Console.ForegroundColor = ConsoleColor.Blue;
                //Display
                Console.WriteLine("==================================================");
                Console.WriteLine($"\tRecipe:\t{recName}");
                Console.WriteLine("==================================================");
                Console.WriteLine("Ingredients:");
                Console.WriteLine("-----------------------");
                for (int t = 0; t < recipe.NUMINGREDIENTS; t++)
                {
                    Console.WriteLine(recipe.ingQuantity[t] + "(" + recipe.ingUOM[t] + ") " + recipe.ingName[t]);
                }
                Console.WriteLine("\nSteps:");
                Console.WriteLine("-----------------------");
                for (int k = 0; k < recipe.NUMOFSTEPS; k++)
                {
                    Console.WriteLine((k + 1) + ": " + recipe.ingDescription[k]);
                }
                Console.WriteLine("==================================================");
                Console.ForegroundColor = ConsoleColor.White;
            
                
            
            
        }

        public static void getNumSteps() // - ST10196509 -
        {

            try
            {
                ////Asks the user how many steps it will take to make the recipe
                Console.Write("How many steps does recipe need to make? >>");
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                recipe.NUMOFSTEPS = Convert.ToInt32(Console.ReadLine());
                Console.ForegroundColor = ConsoleColor.White;
            }
            catch (Exception)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("!!!Input needs to be int!!!");
                Console.ForegroundColor = ConsoleColor.White;

                getNumSteps();
            }
        }
        public static void getDesofSteps() // - ST10196509 -
        {
            for (int i = 0; i < recipe.NUMOFSTEPS; i++)
            {
                Console.Write("Enter description for step" + (i + 1) + ": ");
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                recipe.ingDescription.Add(Console.ReadLine());
                Console.ForegroundColor = ConsoleColor.White;

            }
            displayFullRecipe();

        }
        public static void getScaleQuantity() // - ST10196509 -
        {
            int choice = 0;

            try
            {
                //Asks and captures if the user wants to scale the quantity of the ingredients
                Console.Write("\nDo you want to SCALE the QUANTITY of the ingredients\n1.YES\n2.NO\n>> ");
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                choice = Convert.ToInt32(Console.ReadLine());
                Console.ForegroundColor = ConsoleColor.White;
            }
            catch (Exception)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("!!!Input needs to be 1.(Yes) or 2.(No)!!!");
                Console.ForegroundColor = ConsoleColor.White;

                getScaleQuantity();

            }


            if (choice.Equals(1)) //If the users choice is 1.(Yes)
            {

                try
                {
                    Console.Write("\nBy what FACTOR would you like to change the QUANTITY of the ingredients? \n>> ");
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    recipe.SCALE = Convert.ToDouble(Console.ReadLine());
                    Console.ForegroundColor = ConsoleColor.White;
                }
                catch (Exception)
                {

                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("!!!Input needs to be Int/Double!!!");
                    Console.ForegroundColor = ConsoleColor.White;

                    Console.Write("\nBy what FACTOR would you like to change the QUANTITY of the ingredients? \n>> ");
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    recipe.SCALE = Convert.ToDouble(Console.ReadLine());
                    Console.ForegroundColor = ConsoleColor.White;
                }

                for (int i = 0; i < recipe.NUMINGREDIENTS; i++)
                {
                    /*
                    //This copies the origional arraylist into the new one(ingCurrQuantity) (AddRange is for arraylists)
                    recipe.ingCurrQuantity.AddRange(recipe.ingOrgQuantity);
                   
                    //This times the factor that the user wants to change the ingredients by
                    recipe.ingCurrQuantity[i] = ((double)recipe.ingCurrQuantity[i] *  recipe.SCALE);
                    */

                    recipe.ingQuantity[i] = ((double)recipe.ingQuantity[i] * recipe.SCALE);

                }
                //This displays the new array with the new factor scaled in to the ingredients
                displayFullRecipe();

                //This is only asked if they changed the factor ( Chose option 1.(yes) ) so if they chose option 2 this would not need to be asked
                askReset();


            }
            if (!(choice.Equals(1) || choice.Equals(2))) // If users choice is not 1.(Yes) or 2.(No) ask them to enter again
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("!!!Input needs to be 1.(Yes) or 2.(No)!!!");
                Console.ForegroundColor = ConsoleColor.White;

                getScaleQuantity();
            }
        }
        public static void askReset() // - ST10196509 -
        {
            int choicep = 0;

            try
            {
                //Asks and captures if the user wants to rest the quantites or not
                Console.Write("Do you want the QUANTITITES to be RESET to the ORIGIONAL values?\n1.YES\n2.NO\n>> ");
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                choicep = Convert.ToInt32(Console.ReadLine());
                Console.ForegroundColor = ConsoleColor.White;
            }
            catch (Exception)
            {

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("!!!Input needs to be 1.(Yes) or 2.(No)!!!");
                Console.ForegroundColor = ConsoleColor.White;

                askReset();
            }

            if (choicep.Equals(1))
            {
                for (int i = 0; i < recipe.NUMINGREDIENTS; i++)
                {
                    //This changes the updated array back to the origional one 
                    recipe.ingQuantity[i] = ((double)recipe.ingQuantity[i] / recipe.SCALE);
                }

                displayFullRecipe();
            }
            if (!(choicep.Equals(1) || choicep.Equals(2))) // If users choice is not 1.(Yes) or 2.(No)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("!!!Input needs to be 1.(Yes) or 2.(No)!!!");
                Console.ForegroundColor = ConsoleColor.White;

                askReset();
            }
        }

        public static void askToClear() // - ST10196509 -
        {
            int choice = 0;

            try
            {
                Console.Write("Do you want to clear all the data \n1.Yes\n2.No\n>> ");
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                choice = Convert.ToInt32(Console.ReadLine());
                Console.ForegroundColor = ConsoleColor.White;
            }
            catch (Exception)
            {

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("!!!Input needs to be 1.(Yes) or 2.(No)!!!");
                Console.ForegroundColor = ConsoleColor.White;

                askToClear();

            }

            if (choice.Equals(1))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("!!!ARE YOU CERTAN YOU WANT TO CLEAR ALL DATA!!! ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("\n1.YES\n2.NO\n >> ");
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                choice = Convert.ToInt32(Console.ReadLine());
                Console.ForegroundColor = ConsoleColor.White;

                if (choice.Equals(1))
                {
                    getNumIngredients();
                    getIngredients();
                    getNumSteps();
                    getDesofSteps();
                    displayFullRecipe();
                    getScaleQuantity();
                    askToClear();

                }
            }

            if (!(choice.Equals(1) || choice.Equals(2))) // If users choice is not 1.(Yes) or 2.(No)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("!!!Input needs to be 1.(Yes) or 2.(No)!!!");
                Console.ForegroundColor = ConsoleColor.White;

                askToClear();
            }

        }
    }
}
