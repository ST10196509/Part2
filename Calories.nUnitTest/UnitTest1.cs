using Part2;
using System.Security.Cryptography;
using System.Xml.Linq;

namespace Calories.nUnitTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void GetTotCalories()
        {
           string Name = "Pancake";
            double quantity = 0;
            string unit = "";
            double caloriesPerUnit = 0;
            string foodGroup = "";

            int numIngredients = 1;

            for (int i = 0; i < numIngredients; i++)
            {
                quantity = 6;
                unit = "cup";
                caloriesPerUnit = 20;
                foodGroup = "Grains";
            }

            double totalCalories = quantity * caloriesPerUnit;

            Ingredient ingredient = new Ingredient(Name, quantity, unit, caloriesPerUnit, foodGroup);

            Assert.AreEqual(120,totalCalories);
        }
    }
}