using FitnessApp.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessApp.Configurations
{
    public class GoalConfigure
    {
        public static void GoalConfigureMethod(EntityTypeBuilder<Goal> builder)
        {
            builder.HasKey(goal => goal.Id);
            builder.HasData(
                new Goal
                {
                    Id = 1,
                    UserId = 1,
                    GoalType = "Weight Loss",
                    StartDate = new DateTime(2023, 03, 01),
                    EndDate = new DateTime(2023, 06, 01),
                    Description = "Lose 5 kg of weight"
                },
                new Goal
                {
                    Id = 2,
                    UserId = 2,
                    GoalType = "Mass Gain",
                    StartDate = new DateTime(2023, 04, 15),
                    EndDate = new DateTime(2023, 07, 15),
                    Description = "Gain 3 kg of muscle mass"
                },
                new Goal
                {
                    Id = 3,
                    UserId = 3,
                    GoalType = "Fat Percentage Reduction",
                    StartDate = new DateTime(2023, 05, 08),
                    EndDate = new DateTime(2023, 08, 08),
                    Description = "Reduce body fat percentage to 15%"
                },
                new Goal
                {
                    Id = 4,
                    UserId = 4,
                    GoalType = "Weight Loss",
                    StartDate = new DateTime(2023, 06, 22),
                    EndDate = new DateTime(2023, 09, 22),
                    Description = "Lose 3 kg of weight"
                },
                new Goal
                {
                    Id = 5,
                    UserId = 5,
                    GoalType = "Mass Gain",
                    StartDate = new DateTime(2023, 07, 06),
                    EndDate = new DateTime(2023, 10, 06),
                    Description = "Gain 2 kg of muscle mass"
                },
                new Goal
                {
                    Id = 6,
                    UserId = 6,
                    GoalType = "Fat Percentage Reduction",
                    StartDate = new DateTime(2023, 08, 19),
                    EndDate = new DateTime(2023, 11, 19),
                    Description = "Reduce body fat percentage to 18%"
                },
                new Goal
                {
                    Id = 7,
                    UserId = 7,
                    GoalType = "Weight Loss",
                    StartDate = new DateTime(2023, 09, 03),
                    EndDate = new DateTime(2023, 12, 03),
                    Description = "Lose 4 kg of weight"
                },
                new Goal
                {
                    Id = 8,
                    UserId = 8,
                    GoalType = "Mass Gain",
                    StartDate = new DateTime(2023, 10, 16),
                    EndDate = new DateTime(2024, 01, 16),
                    Description = "Gain 4 kg of muscle mass"
                },
                new Goal
                {
                    Id = 9,
                    UserId = 9,
                    GoalType = "Fat Percentage Reduction",
                    StartDate = new DateTime(2023, 11, 29),
                    EndDate = new DateTime(2024, 02, 29),
                    Description = "Reduce body fat percentage to 20%"
                },
                new Goal
                {
                    Id = 10,
                    UserId = 10,
                    GoalType = "Weight Loss",
                    StartDate = new DateTime(2023, 12, 23),
                    EndDate = new DateTime(2024, 03, 23),
                    Description = "Lose 2 kg of weight"
                },
                new Goal
                {
                    Id = 11,
                    UserId = 11,
                    GoalType = "Mass Gain",
                    StartDate = new DateTime(2024, 01, 27),
                    EndDate = new DateTime(2024, 04, 27),
                    Description = "Gain 5 kg of muscle mass"
                },
                new Goal
                {
                    Id = 12,
                    UserId = 12,
                    GoalType = "Fat Percentage Reduction",
                    StartDate = new DateTime(2024, 03, 10),
                    EndDate = new DateTime(2024, 06, 10),
                    Description = "Reduce body fat percentage to 16%"
                },
                new Goal
                {
                    Id = 13,
                    UserId = 13,
                    GoalType = "Weight Loss",
                    StartDate = new DateTime(2024, 04, 24),
                    EndDate = new DateTime(2024, 07, 24),
                    Description = "Lose 6 kg of weight"
                },
                new Goal
                {
                    Id = 14,
                    UserId = 14,
                    GoalType = "Mass Gain",
                    StartDate = new DateTime(2024, 05, 08),
                    EndDate = new DateTime(2024, 08, 08),
                    Description = "Gain 3 kg of muscle mass"
                },
                new Goal
                {
                    Id = 15,
                    UserId = 15,
                    GoalType = "Fat Percentage Reduction",
                    StartDate = new DateTime(2024, 06, 21),
                    EndDate = new DateTime(2024, 09, 21),
                    Description = "Reduce body fat percentage to 17%"
                }
                );
        }
    }
}
