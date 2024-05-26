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

        public string[] ingredients;
        public double[] sum;
        public double[] sumAndExtra;
        public string[] measurements;
        public string[] instructions;

        /// <summary>
        /// Initializes arrays for ingredients, sums, measurements, and instructions.
        /// </summary>
        /// ________________________________________________________________________________________________________________________________________________

        public void InitializeIngredients()
        {
            ingredients = new string[0];
            sum = new double[0];
            sumAndExtra = new double[0];
            measurements = new string[0];
            instructions = new string[0];
        }

        /// <summary>
        /// Prompts the user to input ingredients, quantities, measurements, and instructions.
        /// </summary>
        /// ________________________________________________________________________________________________________________________________________________

        public void OutputRecipe()
        {
            // Ask the user to enter the number of ingredients

            Console.Write("Number of Ingredients: \n");
            int Ingredients = 0;

            try
            {
                Ingredients = int.Parse(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine("Invalid input. Please enter an integer.\n");
                OutputRecipe();
            }

            ingredients = new string[Ingredients];
            sum = new double[Ingredients];
            measurements = new string[Ingredients];

            for (int i = 0; i < Ingredients; i++)
            {
                Console.Write("Ingredient name: \n");
                ingredients[i] = Console.ReadLine();

                Console.Write("\nQuantity: \n");
                sum[i] = double.Parse(Console.ReadLine());

                Console.Write("\nUnit (grams {g}, milliliters {mL}, kilograms {kg}, etc.): \n");
                measurements[i] = Console.ReadLine();
            }

            sumAndExtra = new double[Ingredients];
            Array.Copy(sum, sumAndExtra, Ingredients);

            int InstructionsNo = 0;

            while (InstructionsNo == 0)
            {
                try
                {
                    Console.Write("\nNumber of instructions needed: \n");
                    InstructionsNo = int.Parse(Console.ReadLine());

                    instructions = new string[InstructionsNo];

                    for (int i = 0; i < InstructionsNo; i++)
                    {
                        Console.Write($"\nInstruction Number {i + 1}: \n");
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Invalid input. Please enter an integer.\n");
                }
            }
        }

        /// <summary>
        /// Allows the user to scale the quantities of ingredients.
        /// </summary>
        /// ________________________________________________________________________________________________________________________________________________

        public void Scale()
        {
            Console.WriteLine("Enter a scaling factor using a comma-separated value: 0.5, 2, or 3 \n");
            double scale = 0;

            try
            {
                scale = double.Parse(Console.ReadLine());

                if (scale != 0.5 && scale != 2 && scale != 3)
                {
                    Console.WriteLine("Invalid scaling factor.\n");
                    Scale();
                    return;
                }

                for (int i = 0; i < sum.Length; i++)
                {
                    sum[i] = sumAndExtra[i] * scale;
                }

                Console.WriteLine($"Scaling complete. Choose option 2 to confirm.\n");
            }
            catch (Exception e)
            {
                Console.WriteLine("Invalid input.\n");
                Scale();
            }
        }

        /// <summary>
        /// Displays the ingredients and instructions entered by the user.
        /// </summary>
        /// ________________________________________________________________________________________________________________________________________________

        public void Display()
        {
            Console.WriteLine("Ingredients: \n");

            for (int i = 0; i < ingredients.Length; i++)
            {
                Console.WriteLine($"============={sum[i]} {measurements[i]} of {ingredients[i]}==============\n");
            }

            Console.WriteLine("Instructions\n");

            for (int i = 0; i < instructions.Length; i++)
            {
                Console.WriteLine($"========= {instructions[i]} ===========\n");
            }
        }

        /// <summary>
        /// Resets the quantities of ingredients to their original values before scaling.
        /// </summary>
        /// ________________________________________________________________________________________________________________________________________________
        public void Reset()
        {
            for (int i = 0; i < sum.Length; i++)
            {
                sum[i] = sumAndExtra[i] / 2;
            }

            Console.WriteLine($"Reset complete. Choose option 2 to confirm.\n");
        }

        /// <summary>
        /// Resets all arrays to their default values when option 4 is selected.
        /// </summary>
        public void DELETE()
        {
            ingredients = new string[0];
            sum = new double[0];
            measurements = new string[0];
            instructions = new string[0];

            Console.WriteLine($"DELETE COMPLETE. Choose option 2 to confirm.\n");
        }
    }
}
//_________________________________________________END________________________________________________________________________________