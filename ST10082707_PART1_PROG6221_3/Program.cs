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
            /// <summary>
            /// Method used to call class with functions.
            /// </summary>
            /// _______________________________________________________________________________________________________

            RecipeBook book = new RecipeBook();

            // adding a while loop to display statements and execute their actions in the switch statement
            while (true)
            {
                Console.WriteLine("=======================================================================================\n");
                Console.WriteLine("\t\tWELCOME ");
                Console.WriteLine("=======================================================================================\n");


                //while loop to display statements and execute actions
                while (true)
                {
                    Console.WriteLine("1: ENTER RECIPE DETAILS\n");

                    Console.WriteLine("2: DISPLAY DETAILS\n");

                    Console.WriteLine("3: SCALE RECIPE\n");

                    Console.WriteLine("4: RESET AMOUNT\n");

                    Console.WriteLine("5: DELETE RECIPE ENTRY\n");

                    Console.WriteLine("6: EXIT");


                    //reading input...

                    string choose = Console.ReadLine();

                    switch (choose)
                    {

                        //options of choices above
                        case "1":
                            recipes.OUTPUT_RECIPE();
                            break;

                        case "2":
                            recipes.DISPLAY();
                            break;

                        case "3":
                            recipes.SCALE();
                            break;

                        case "4":
                            recipes.RESET();
                            break;

                        case "5":
                            recipes.DELETE();
                            break;

                        case "6":
                            Console.WriteLine("LEAVING. THANK YOU!!");
                            return;

                        default:
                            Console.WriteLine("INVALID OPTION! PLEASE START WITH OPTION 1");
                            break;
                    }

                }


            }
        }
    }
}
///____________________________________________________END___________________________________________________________________________