using FitnessApp.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessApp.Configurations
{
    public class WorkoutConfigure
    {
        public static void WorkoutConfigureMethod(EntityTypeBuilder<Workout> builder)
        {
            builder.HasKey(workout => workout.Id);
            builder.HasData(
                new Workout
                {
                    Id = 1,
                    UserId = 1,
                    Type = "Cardio",
                    Date = new DateTime(2023, 03, 05),
                    Duration = 45,
                    CaloriesBurned = 500
                },
                new Workout
                {
                    Id = 2,
                    UserId = 2,
                    Type = "Strength",
                    Date = new DateTime(2023, 04, 20),
                    Duration = 60,
                    CaloriesBurned = 650
                },
                new Workout
                {
                    Id = 3,
                    UserId = 3,
                    Type = "Yoga",
                    Date = new DateTime(2023, 05, 12),
                    Duration = 30,
                    CaloriesBurned = 300
                },
                new Workout
                {
                    Id = 4,
                    UserId = 4,
                    Type = "Cardio",
                    Date = new DateTime(2023, 06, 28),
                    Duration = 35,
                    CaloriesBurned = 400
                },
                new Workout
                {
                    Id = 5,
                    UserId = 5,
                    Type = "Strength",
                    Date = new DateTime(2023, 07, 14),
                    Duration = 50,
                    CaloriesBurned = 550
                },
                new Workout
                {
                    Id = 6,
                    UserId = 6,
                    Type = "Yoga",
                    Date = new DateTime(2023, 08, 05),
                    Duration = 40,
                    CaloriesBurned = 350
                },
                new Workout
                {
                    Id = 7,
                    UserId = 7,
                    Type = "Cardio",
                    Date = new DateTime(2023, 09, 21),
                    Duration = 45,
                    CaloriesBurned = 500
                },
                new Workout
                {
                    Id = 8,
                    UserId = 8,
                    Type = "Strength",
                    Date = new DateTime(2023, 10, 10),
                    Duration = 60,
                    CaloriesBurned = 650
                },
                new Workout
                {
                    Id = 9,
                    UserId = 9,
                    Type = "Yoga",
                    Date = new DateTime(2023, 11, 02),
                    Duration = 30,
                    CaloriesBurned = 300
                },
                new Workout
                {
                    Id = 10,
                    UserId = 10,
                    Type = "Cardio",
                    Date = new DateTime(2023, 12, 18),
                    Duration = 35,
                    CaloriesBurned = 400
                },
                new Workout
                {
                    Id = 11,
                    UserId = 11,
                    Type = "Strength",
                    Date = new DateTime(2024, 01, 05),
                    Duration = 50,
                    CaloriesBurned = 550
                },
                new Workout
                {
                    Id = 12,
                    UserId = 12,
                    Type = "Yoga",
                    Date = new DateTime(2024, 02, 22),
                    Duration = 40,
                    CaloriesBurned = 350
                },
                new Workout
                {
                    Id = 13,
                    UserId = 13,
                    Type = "Cardio",
                    Date = new DateTime(2024, 03, 11),
                    Duration = 45,
                    CaloriesBurned = 500
                },
                new Workout
                {
                    Id = 14,
                    UserId = 14,
                    Type = "Strength",
                    Date = new DateTime(2024, 04, 03),
                    Duration = 60,
                    CaloriesBurned = 650
                },
                new Workout
                {
                    Id = 15,
                    UserId = 15,
                    Type = "Yoga",
                    Date = new DateTime(2024, 05, 17),
                    Duration = 30,
                    CaloriesBurned = 300
                }
                );
        }
    }
}
