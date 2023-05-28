# Part2
How to use the app:

1. You will be provided with a menu and are asked to input your choice:
    1. Add a new recipe
    2. Display all recipes
    3. Quit
    Enter your choice: 
2. The user will then choose option 1 to add a new recipe.
3. Once option 1 is entered you will then be asked for the name of your recipe Eg. Pancake
4. The program  will then ask for the number of ingredients your recipe contains Eg. 6
5. The program  will then ask for the Name of  Ingredient 1 Eg. Flour
6. The program will ask for the quanitity of Ingredient 1 Eg. 1
7. The program will ask for the unit of measurement for ingredient 1 Eg. Cup
8. The program will ask for the calories per unit for the 1st Ingredient Eg. 200kcal
9. Thee program will then ask what food group that Ingredient belongs to and the program will give you a list of food groups to choose like Fruits,Vegitables, Grains, Protien, Dairy, Oils, Mean and other where you can specify the food group. For Ingredient 1 Eg. Grains
10. It will then ask you the same question for the remaining Ingredients 
11. Once the Ingredients are collected the program will as for the number of steps it takes to create the recipe Eg. 3
12. The program will then get the step instructions from the user
13. The program will show you how you recipe looks and will then ask if you want to scale the quantity of the recipies with a y/n question.
14. If yes you will get ask for the factor that you would like to scale the recipe and will get shown the new scaled recipe
15. The program will then ask if you would like to reset the recipe to the original values if yes it will reset to the origional if not then it will keep the new values.
16. You will then be brought back to the menu that ask you if you like to 1.Add a new recipe 2. Display all recipes or 3. quit
17. If user picks 2 they will get a list of all the recipes that they have created for this example the user will only see "Pancake"
18. The program will ask the user to enter the recipe that would like to display Eg. "Pancake"  the program will then show them the recipe of "Pancake" that they created earilier on.
19. You will then be brought back to the menu that ask you if you like to 1.Add a new recipe 2. Display all recipes or 3. quit
20. If user enters 3. you will get a goodbye message and the program will the stop.

GitHub Repository link: https://github.com/ST10196509/Part2

Program changes:
I did not recieve feedback from part one but here are the following changes that I made.

In part1 I have 2 classes Program.cs and Recipe.cs in part2 I added two more classes Ingredients.cs and Step.cs

Changes in Program.cs:
I added a menu with options 1.Add a new Recipe 2.Display all recipies, and 3 quit. I added this so that it would be much easier to 
add new recipies also it allows the user to add an infinate amount of recipies and does not ask them how many they wnat to create.
I created a list of type Recipe called recipes that will store all the recipes the user creates.
When user choose "1.Add a new recipe" a new recipe will get created by calling the Recipe object and then it calls a method called
EnterDetails which is in the Recipe class that will get all the recipes details. This new recipe will that get added to the recipes list that we created with (recipes.add(recipe)).
If the user chooses "2.Display all recipes" the program first checks if there are recipes in the recipes list if not it will tell the user that there are no recipes.
If there are recipes in the list the program first sorts the list and stores them in a varibale called sortedRecipes.
It then displays the sorted list to the user and askes them which recipe the want the program to display. If found it displays it else it will say "Recipe was not found".
If the user chooses "3.Quit" the program will the display "Goodbye!" and the program will end.

Changes in Recipe.cs:
I added variable Name which will get the Recipe name from the user.
I added a list of type Ingredent called Ingredients which will store all the ingredients for the current recipe.
I added a list of type Step called Setps which will store the setps description for the current recipe.
Variable Factor which will keep track of the user input factor.
The method EnterDetails will:
1. Get the name of the recipe from the user
2. Get the number of ingredients from the user
3. Will then get the name, quantity, unit of measurement, calories per unit, and the food group for each ingredient.
   The program will give the user a list of fooed group they would like to enter if it's not in the list they can select "8.Other" which they can then be more specific on what food group the ingredient is classified under.
4. The Program will then call the Ingredient object which will create the ingredient.
5. The created ingredient will then get added to the list Ingrediets which will store these ingredites within the recipe class. I did this so that when we want to display the recipe later we just need to call the recipe name and the ingredients will be associated to that recipe name.
6. The program will then ask user for the number of steps the recipe will need to be created. And will then ask for the step description.
7. The Program will ask if you would like to scale the recipe it no the recipe will be added to the prgram no yes the program wiil ask user for the scale factor to scale all the recipes quantities.
8. If an only the scale is yes the program will ask the user if they would like to reset the quantites to the origional if yes the quantities will be reset to the origional if no the new quanitie values will be stored.
  The Display method will display the recipe that the user picks based on the recipes that are in the recipes list in the Program.cs
