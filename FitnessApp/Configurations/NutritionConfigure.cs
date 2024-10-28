using FitnessApp.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessApp.Configurations
{
    public class NutritionConfigure
    {
        public static void NutritionConfigureMethod(EntityTypeBuilder<Nutrition> builder)
        {
            builder.HasKey(nutrition => nutrition.Id);
            builder.HasData(
                new Nutrition
                {
                    Id = 1,
                    UserId = 1,
                    Date = new DateTime(2023, 03, 05),
                    MealType = "Breakfast",
                    Calories = 400,
                    Protein = 20,
                    Carbohydrates = 50,
                    Fat = 10
                },
                new Nutrition
                {
                    Id = 2,
                    UserId = 2,
                    Date = new DateTime(2023, 04, 20),
                    MealType = "Lunch",
                    Calories = 550,
                    Protein = 30,
                    Carbohydrates = 60,
                    Fat = 15
                },
                new Nutrition
                {
                    Id = 3,
                    UserId = 3,
                    Date = new DateTime(2023, 05, 12),
                    MealType = "Dinner",
                    Calories = 450,
                    Protein = 25,
                    Carbohydrates = 40,
                    Fat = 12
                },
                new Nutrition
                {
                    Id = 4,
                    UserId = 4,
                    Date = new DateTime(2023, 06, 28),
                    MealType = "Breakfast",
                    Calories = 350,
                    Protein = 18,
                    Carbohydrates = 45,
                    Fat = 8
                },
                new Nutrition
                {
                    Id = 5,
                    UserId = 5,
                    Date = new DateTime(2023, 07, 14),
                    MealType = "Lunch",
                    Calories = 600,
                    Protein = 35,
                    Carbohydrates = 70,
                    Fat = 18
                },
                new Nutrition
                {
                    Id = 6,
                    UserId = 6,
                    Date = new DateTime(2023, 08, 05),
                    MealType = "Dinner",
                    Calories = 500,
                    Protein = 28,
                    Carbohydrates = 50,
                    Fat = 13
                },
                new Nutrition
                {
                    Id = 7,
                    UserId = 7,
                    Date = new DateTime(2023, 09, 21),
                    MealType = "Breakfast",
                    Calories = 420,
                    Protein = 22,
                    Carbohydrates = 55,
                    Fat = 11
                },
                new Nutrition
                {
                    Id = 8,
                    UserId = 8,
                    Date = new DateTime(2023, 10, 10),
                    MealType = "Lunch",
                    Calories = 580,
                    Protein = 32,
                    Carbohydrates = 65,
                    Fat = 16
                },
                new Nutrition
                {
                    Id = 9,
                    UserId = 9,
                    Date = new DateTime(2023, 11, 02),
                    MealType = "Dinner",
                    Calories = 480,
                    Protein = 27,
                    Carbohydrates = 45,
                    Fat = 14
                },
                new Nutrition
                {
                    Id = 10,
                    UserId = 10,
                    Date = new DateTime(2023, 12, 18),
                    MealType = "Breakfast",
                    Calories = 380,
                    Protein = 19,
                    Carbohydrates = 48,
                    Fat = 9
                },
                new Nutrition
                {
                    Id = 11,
                    UserId = 11,
                    Date = new DateTime(2024, 01, 05),
                    MealType = "Lunch",
                    Calories = 620,
                    Protein = 38,
                    Carbohydrates = 75,
                    Fat = 20
                },
                new Nutrition
                {
                    Id = 12,
                    UserId = 12,
                    Date = new DateTime(2024, 02, 12),
                    MealType = "Dinner",
                    Calories = 520,
                    Protein = 30,
                    Carbohydrates = 55,
                    Fat = 15
                },
                new Nutrition
                {
                    Id = 13,
                    UserId = 13,
                    Date = new DateTime(2024, 03, 11),
                    MealType = "Breakfast",
                    Calories = 440,
                    Protein = 24,
                    Carbohydrates = 58,
                    Fat = 12
                },
                new Nutrition
                {
                    Id = 14,
                    UserId = 14,
                    Date = new DateTime(2024, 04, 03),
                    MealType = "Lunch",
                    Calories = 600,
                    Protein = 36,
                    Carbohydrates = 70,
                    Fat = 18
                },
                new Nutrition
                {
                    Id = 15,
                    UserId = 5,
                    Date = new DateTime(2024, 05, 17),
                    MealType = "Dinner",
                    Calories = 500,
                    Protein = 29,
                    Carbohydrates = 50,
                    Fat = 13
                }
                );
        }
    }
}
