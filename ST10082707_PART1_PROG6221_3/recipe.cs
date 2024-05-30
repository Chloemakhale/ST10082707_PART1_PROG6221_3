using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ST10082707_PART1_PROG6221_3
{
    internal class Recipe
    {
        public string Name { get; set; }
        public List<string> Ingredients { get; set; }
        public List<double> Quantities { get; set; }
        public List<double> InitialQuantities { get; set; }
        public List<string> Measurements { get; set; }
        public List<string> Instructions { get; set; }
        public List<double> Calories { get; set; }
        public List<string> FoodGroups { get; set; }

        public Recipe(string name)
        {
            Name = name;
            Ingredients = new List<string>();
            Quantities = new List<double>();
            InitialQuantities = new List<double>();
            Measurements = new List<string>();
            Instructions = new List<string>();
            Calories = new List<double>();
            FoodGroups = new List<string>();
        }

        public double GetTotalCalories()
        {
            return Calories.Sum();
        }
    }
}
