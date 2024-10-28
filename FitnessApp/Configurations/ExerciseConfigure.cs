using FitnessApp.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessApp.Configurations
{
    public class ExerciseConfigure
    {
        public static void ExerciseConfigureMethod(EntityTypeBuilder<Exercise> builder)
        {
            builder.HasKey(exercise => exercise.Id);
            builder.HasData(
                new Exercise
                {
                    Id = 1,
                    Name = "Push-ups",
                    Type = "Strength",
                    Description = "Classic exercise for chest muscles"
                },
                new Exercise
                {
                    Id = 2,
                    Name = "Squats",
                    Type = "Strength",
                    Description = "Exercise for legs and glutes"
                },
                new Exercise
                {
                    Id = 3,
                    Name = "Pull-ups",
                    Type = "Strength",
                    Description = "Exercise for back muscles"
                },
                new Exercise
                {
                    Id = 4,
                    Name = "Running",
                    Type = "Cardio",
                    Description = "Running in place or on a treadmill"
                },
                new Exercise
                {
                    Id = 5,
                    Name = "Jumping",
                    Type = "Cardio",
                    Description = "Jumping in place or with a jump rope"
                },
                new Exercise
                {
                    Id = 6,
                    Name = "Cycling",
                    Type = "Cardio",
                    Description = "Riding a bicycle"
                },
                new Exercise
                {
                    Id = 7,
                    Name = "Swimming",
                    Type = "Cardio",
                    Description = "Swimming in a pool"
                },
                new Exercise
                {
                    Id = 8,
                    Name = "Stretching",
                    Type = "Stretching",
                    Description = "Stretching muscles to improve flexibility"
                },
                new Exercise
                {
                    Id = 9,
                    Name = "Yoga",
                    Type = "Stretching",
                    Description = "A complex of stretching and flexibility exercises"
                },
                new Exercise
                {
                    Id = 10,
                    Name = "Pilates",
                    Type = "Stretching",
                    Description = "A complex of exercises for muscle strengthening and flexibility"
                },
                new Exercise
                {
                    Id = 11,
                    Name = "Abdominals",
                    Type = "Strength",
                    Description = "Exercise for abdominal muscles"
                },
                new Exercise
                {
                    Id = 12,
                    Name = "Pull",
                    Type = "Strength",
                    Description = "Exercise for back and arms"
                },
                new Exercise
                {
                    Id = 13,
                    Name = "Press",
                    Type = "Strength",
                    Description = "Exercise for chest muscles"
                },
                new Exercise
                {
                    Id = 14,
                    Name = "Rowing",
                    Type = "Cardio",
                    Description = "Rowing on a rowing machine"
                },
                new Exercise
                {
                    Id = 15,
                    Name = "Walking",
                    Type = "Cardio",
                    Description = "Fast walking"
                }
                );
        }
    }
}
