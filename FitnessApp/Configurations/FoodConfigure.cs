using FitnessApp.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessApp.Configurations
{
    public class FoodConfigure
    {
        public static void FoodConfigureMethod(EntityTypeBuilder<Food> builder)
        {
            builder.HasKey(food => food.Id);
            builder.HasData(
                new Food
                {
                    Id = 1,
                    Name = "Eggs",
                    Category = "Meat",
                    Calories = 155,
                    Protein = 13,
                    Carbohydrates = 1,
                    Fat = 11
                },
                new Food
                {
                    Id = 2,
                    Name = "Oatmeal",
                    Category = "Grains",
                    Calories = 389,
                    Protein = 13,
                    Carbohydrates = 66,
                    Fat = 6
                },
                new Food
                {
                    Id = 3,
                    Name = "Banana",
                    Category = "Fruits",
                    Calories = 89,
                    Protein = 1,
                    Carbohydrates = 23,
                    Fat = 0
                },
                new Food
                {
                    Id = 4,
                    Name = "Chicken Breast",
                    Category = "Meat",
                    Calories = 165,
                    Protein = 31,
                    Carbohydrates = 0,
                    Fat = 3
                },
                new Food
                {
                    Id = 5,
                    Name = "Rice",
                    Category = "Grains",
                    Calories = 360,
                    Protein = 7,
                    Carbohydrates = 77,
                    Fat = 1
                },
                new Food
                {
                    Id = 6,
                    Name = "Broccoli",
                    Category = "Vegetables",
                    Calories = 34,
                    Protein = 3,
                    Carbohydrates = 7,
                    Fat = 0
                },
                new Food
                {
                    Id = 7,
                    Name = "Salmon",
                    Category = "Fish",
                    Calories = 208,
                    Protein = 20,
                    Carbohydrates = 0,
                    Fat = 13
                },
                new Food
                {
                    Id = 8,
                    Name = "Cheese",
                    Category = "Dairy",
                    Calories = 400,
                    Protein = 25,
                    Carbohydrates = 2,
                    Fat = 30
                },
                new Food
                {
                    Id = 9,
                    Name = "Buckwheat",
                    Category = "Grains",
                    Calories = 340,
                    Protein = 13,
                    Carbohydrates = 62,
                    Fat = 2
                },
                new Food
                {
                    Id = 10,
                    Name = "Pear",
                    Category = "Fruits",
                    Calories = 57,
                    Protein = 0,
                    Carbohydrates = 15,
                    Fat = 0
                },
                new Food
                {
                    Id = 11,
                    Name = "Beef",
                    Category = "Meat",
                    Calories = 213,
                    Protein = 27,
                    Carbohydrates = 0,
                    Fat = 11
                },
                new Food
                {
                    Id = 12,
                    Name = "Potato",
                    Category = "Vegetables",
                    Calories = 77,
                    Protein = 2,
                    Carbohydrates = 17,
                    Fat = 0
                },
                new Food
                {
                    Id = 13,
                    Name = "Tuna",
                    Category = "Fish",
                    Calories = 130,
                    Protein = 25,
                    Carbohydrates = 0,
                    Fat = 3
                },
                new Food
                {
                    Id = 14,
                    Name = "Milk ",
                    Category = "Dairy",
                    Calories = 60,
                    Protein = 3,
                    Carbohydrates = 5,
                    Fat = 3
                },
                new Food
                {
                    Id = 15,
                    Name = "Orange",
                    Category = "Fruits",
                    Calories = 47,
                    Protein = 1,
                    Carbohydrates = 12,
                    Fat = 0
                }
                );
        }
    }
}
