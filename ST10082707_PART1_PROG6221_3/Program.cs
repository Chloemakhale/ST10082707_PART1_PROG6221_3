using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ST10082707_PART1_PROG6221_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of the RecipeBook class
            RecipeBook recipes = new RecipeBook();

            // Main menu loop
            while (true)
            {
                Console.WriteLine("=======================================================================================\n");
                Console.WriteLine("\t\tWELCOME ");
                Console.WriteLine("=======================================================================================\n");

                // Display menu options
                Console.WriteLine("1: ENTER RECIPE DETAILS\n");
                Console.WriteLine("2: DISPLAY DETAILS\n");
                Console.WriteLine("3: SCALE RECIPE\n");
                Console.WriteLine("4: RESET AMOUNT\n");
                Console.WriteLine("5: DELETE RECIPE ENTRY\n");
                Console.WriteLine("6: EXIT");

                // Read user input
                string choice = Console.ReadLine();

                switch (choice)
                {
                    // Option to enter recipe details
                    case "1":
                        recipes.InputRecipe();
                        break;

                    // Option to display recipe details
                    case "2":
                        recipes.Display();
                        break;

                    // Option to scale the recipe
                    case "3":
                        Console.WriteLine("Enter scaling factor (0.5, 2, or 3): ");
                        double factor;
                        if (double.TryParse(Console.ReadLine(), out factor))
                        {
                            recipes.Scale();
                        }
                        else
                        {
                            Console.WriteLine("Invalid scaling factor.");
                        }
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