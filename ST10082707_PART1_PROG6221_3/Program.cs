using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ST10082707_PART1_PROG6221_3
{
    internal class Program
    {
        private static object recipeBook;

        static void Main(string[] args)
        {
            // Created an instance of the RecipeBook class
            RecipeBook recipes = new RecipeBook();

            // Main menu loop
            while (true)
            {
                Console.WriteLine("=======================================================================================\n");
                Console.WriteLine("\t\tWELCOME ");
                Console.WriteLine("=======================================================================================\n");

                // Display menu options
                Console.WriteLine("\n1. Add Recipe");
                Console.WriteLine("2: DISPLAY DETAILS");
                Console.WriteLine("3: SCALE RECIPE");
                Console.WriteLine("4: RESET Recipe");
                Console.WriteLine("5: DELETE RECIPE ENTRY\n");
                Console.WriteLine("6: EXIT");
                Console.Write("Choose an option: ");

                // Read user input
                string choice = Console.ReadLine();

                switch (choice)
                {
                    // Option to enter recipe details
                    case "1":
                        recipes.AddRecipe();
                        break;

                    // Option to display recipe details
                    case "2":
                        recipes.Display();
                        break;

                    // Option to scale the recipe
                    case "3":
                        Console.Write("Enter recipe index to scale: ");
                        int scaleIndex = int.Parse(Console.ReadLine());
                        Console.Write("Enter scaling factor (0.5, 2, or 3): ");
                        double scaleFactor = double.Parse(Console.ReadLine());
                        recipes.ScaleRecipe(scaleIndex, scaleFactor);
                        break;

                    // Option to reset quantities
                    case "4":
                        recipes.Reset();
                        break;

                    // Option to delete recipe entry
                    case "5":
                        recipes.DELETE();
                        break;

                    // Option to exit the program
                    case "6":
                        Console.WriteLine("Exiting. Thank you!");
                        return;

                    // Default case for invalid input
                    default:
                        Console.WriteLine("INVALID OPTION! PLEASE START WITH OPTION 1");
                        break;
                }
            }
        }
    }
}
///_______________________________________END__________________________________________________________________