using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ST10082707_PART1_PROG6221_3
{
    internal class RecipeBook
    {
        //declarations

        public String[] ingredients;
        public double[] sum;
        public double[] sumAndextra;
        public string[] measurements;
        public string[] instructions;

        /// <summary>
        ///  Method creates and/or holds instances of an array
        /// </summary>
        /// _________________________________________________________________________________________
        public void InitializeIngredients()
        {
            ingredients = new string[0];
            sum = new double[0];
            sumAndextra = new double[0];
            measurements = new string[0];
            instructions = new string[0];

        }

        /// <summary>
        /// this method Prompts the user to enter the input regarding their ingredients .
        /// Capture the measurements of the ingredients 
        /// and the number of steps/instrutions that will be needed to make the final product
        /// </summary>
        /// <retun></retun>
        /// _______________________________________________________________________________________________________

        public void OutputRecipe()
        {
            // Ask user to enter the ingredients

            Console.Write("Number of Ingredients: \n");
            int Ingredients = 0;
            // converting String to int and making sure user can only enter an int

            try
                {
                     Ingredients = int.Parse(Console.ReadLine());
                }

            catch (Exception ex) 
                {
                       Console.WriteLine("Invalid Try Again using only INT\n");
                       OutputRecipe();
                }

            //Instances to store results of the input above consisting of ingredients in Arrays

            ingredients = new string[Ingredients];
            sum = new double[Ingredients];
            measurements = new string[Ingredients];

            // repeat this block of code as many times as instructed by user input

            for(int i = 0; i < Ingredients; i++) 
          {
            // Console.WriteLine($"Details for ingredient number {i + 1: \n"} );

                Console.Write("Ingredient name: \n");
                ingredients[1] = Console.ReadLine();

                Console.Write("\nQuantity: \n");
                sum[i] = double.Parse(Console.ReadLine());

                Console.Write("\nUnit (grams {g},milliliters {mL},kilograms {kg} etc): \n");
                measurements[i] = Console.ReadLine();

          }

            // the process of storing user input , to be able to weigh later

             sumAndextra = new double[Ingredients];
            Array.Copy(sum, sumAndextra, Ingredients);

            // local variable to use in exception

            int InstructionsNo = 0;

            while (InstructionsNo == 0)
            {
                try

                {
                    //this method recieves input from user on number of instructions
                    Console.Write("\n number of instructions needed: \n");
                    InstructionsNo = int.Parse(Console.ReadLine();


                    // number of Instructions to be stored in Array
                    instructions = new string[InstructionsNo];

                    //displays total number of instructions according to the number that is unputted by user
                      
                    for (int i = 0; i < InstructionsNo; i++) ;
                        {
                            Console.Write($"\n Instruction Number {i + 1}: \n");

                        }
                }

                // error message display
                catch (Exception e) { Console.WriteLine("Invalid, Try Again using only INT"); }
            }

         /// <summary>
         /// VOID to prompt user to select scaling methods
         /// displays error or success pof scaling 
         /// </summary>
         /// <return></return>
         /// ___________________________________________________________________________________________________________________________________
            
        
        public void Scale()
            {
                // user can select a scaling method of their choice
                Console.WriteLine("Enter one of scaling factor using a coma: 0,5 or 2 or 3 \n");
                double scale = 0;

                try 
                    {
                    scale = double.Parse(Console.ReadLine());

                    // error message display if user uses different scaling input
                    if (scale != 0.5 && scale != 2 && scale != 3)
                    {
                        Console.WriteLine("Invalid\n");
                        Scale();
                        return;

                    }

                // calculate scaling by multiplying the quantity to the scale and making it the sum
                for (int i = 0; i < sum.Length; i++)
                    {
                        sum[i] = sumAndextra[i] * scale;
                        Scale();

                    }
                }

                 // error message display takes us back to the begining of the method 
                  catch(Exception e) 
                      {
                        Console.WriteLine("Invalid\n");
                        Scale();

                      }

                // display once successful
                Console.WriteLine($"Scaling complete, choose option 2 to confirm\n");
           }


            /// <summary>
            /// VOID to display ingredients a user has inputes
            /// displays all steps inputed by user 
            /// </summary>
            /// <return></return>
            /// ____________________________________________________________________________________________________________________________
            
























        }
    }




















        }
    }
