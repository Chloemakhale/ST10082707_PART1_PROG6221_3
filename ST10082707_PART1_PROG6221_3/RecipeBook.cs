using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

using System;

namespace ST10082707_PART1_PROG6221_3
{
    internal class RecipeBook
    {
        // Declarations

        public string[] ingredients;    // array to store ingredient names
        public double[] sum;            // array to store the current quantity of ingredients
        public double[] initialSum;    // array to store the original ingredient quantities
        public string[] measurements;  // array to store units of measurement
        public string[] instructions;  // array to store cooking instructions

        /// <summary>
        /// Method creates and/hold instances of an array
        /// </summary>
        /// ________________________________________________________________________________________________________________________________________________

        private List<Recipe> recipes = new List<Recipe>();
   
        public delegate void RecipeInputDelegate();

        public void AddRecipe()
        {
            RecipeInputDelegate inputDelegate = InputRecipe;
            inputDelegate();

        }

        /// <summary>
        /// Prompts the user to input ingredients, quantities, measurements, and instructions.
        /// Prompts user to enter unlimited recipes each with a name
        /// </summary>
        /// ________________________________________________________________________________________________________________________________________________

        private void InputRecipe()
        {

            // Ask the user to enter the number of ingredients

            Console.Write("Recipe Name: ");
            string recipeName = Console.ReadLine();

            Recipe recipe = new Recipe(recipeName);

            Console.Write("Number of Ingredients: ");
            int numberOfIngredients = int.Parse(Console.ReadLine());

            Console.Write("Number of Instructions: ");
            int numberOfInstructions = int.Parse(Console.ReadLine());


            for (int i = 0; i < numberOfIngredients; i++)
            {
                Console.Write($"Ingredient name {i + 1}: ");
                recipe.Ingredients.Add(Console.ReadLine());

                Console.Write("Quantity: ");
                double quantity = double.Parse(Console.ReadLine());
                recipe.Quantities.Add(quantity);
                recipe.InitialQuantities.Add(quantity);

                Console.Write("Unit (grams {g}, milliliters {mL}, kilograms {kg} etc): ");
                recipe.Measurements.Add(Console.ReadLine());

                Console.Write("Calories: ");
                recipe.Calories.Add(double.Parse(Console.ReadLine()));

                Console.Write("Food Group: ");
                recipe.FoodGroups.Add(Console.ReadLine());
            }

            for (int i = 0; i < numberOfInstructions; i++)
            {
                Console.Write($"Instruction {i + 1}: ");
                recipe.Instructions.Add(Console.ReadLine());
            }

            recipes.Add(recipe);

        }

        /// <summary>
        /// Allows the user to scale the quantities of ingredients.
        /// </summary>
        /// ________________________________________________________________________________________________________________________________________________

        public void ScaleRecipe(int recipeIndex, double scale)
        {
            if (recipeIndex < 0 || recipeIndex >= recipes.Count)
            {
                Console.WriteLine("Invalid recipe index.");
                return;
            }

            if (scale != 0.5 && scale != 2 && scale != 3)
            {
                Console.WriteLine("Invalid scaling factor. Please enter 0.5, 2, or 3.");
                return;
            }

            Recipe recipe = recipes[recipeIndex];

            for (int i = 0; i < recipe.Quantities.Count; i++)
            {
                recipe.Quantities[i] = recipe.InitialQuantities[i] * scale;
            }

            Console.WriteLine("Scaling complete. Choose option 2 to confirm.");
        }


        /// <summary>
        /// Displays the ingredients and instructions entered by the user.
        /// </summary>
        /// ________________________________________________________________________________________________________________________________________________

        public void Display()
        {
            var sortedRecipes = recipes.OrderBy(r => r.Name).ToList();

            foreach (var recipe in sortedRecipes)
            {
                Console.WriteLine($"\n--- Recipe: {recipe.Name}---");
                Console.WriteLine("Ingredients: ");

                for (int i = 0; i < recipe.Ingredients.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {recipe.Ingredients[i]}: {recipe.Measurements[i]} {recipe.Quantities[i]}, Clories: {recipe.Calories[i]}, Food Group: {recipe.FoodGroups[i]}");
                }

                Console.WriteLine("Instructions: ");

                for (int i = 0; i < recipe.Instructions.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {instructions[i]} ");
                }
                double totalCalories = recipe.GetTotalCalories();
                Console.WriteLine($"Total Calories: {recipe.GetTotalCalories()}");

                if (totalCalories > 300)
                {
                    Console.WriteLine("This recipe exceeds 300 calories!");

                }
            }

            /// <summary>
            /// Resets the quantities of ingredients to their original values before scaling.
            /// </summary>
            /// ________________________________________________________________________________________________________________________________________________
        }

            public void Reset(int recipeIndex)
            {
                if (recipeIndex < 0 || recipeIndex >= recipes.Count)
                {
                    Console.WriteLine("Invalid recipe index.");
                    return;
                }

                Recipe recipe = recipes[recipeIndex];

                for (int i = 0; i < recipe.Quantities.Count; i++)
                {
                    recipe.Quantities[i] = recipe.InitialQuantities[i];
                }

                Console.WriteLine("Reset complete. Choose option 2 to confirm.");
            }

            /// <summary>
            /// Delete all recipes
            /// </summary>
            /// _______________________________________________________________________________________
        
            public void DELETE()
            {
                recipes.Clear();
                Console.WriteLine("All recipes deleted. Choose option 2 to confirm. ");

            }

        internal void Reset()
        {
            throw new NotImplementedException();
        }
    }
    }

//_________________________________________________END Part 2_______________________________________________________________________________