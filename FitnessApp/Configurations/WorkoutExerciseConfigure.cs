using FitnessApp.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessApp.Configurations
{
    public class WorkoutExerciseConfigure
    {
        public static void WorkoutExerciseConfigureMethod(EntityTypeBuilder<WorkoutExercise> builder)
        {
            builder.HasKey(workoutExercise => workoutExercise.Id);
            builder.HasData(
                new WorkoutExercise
                {
                    Id = 1,
                    WorkoutId = 1,
                    ExerciseId = 4,
                    Sets = 3,
                    Reps = 15
                },
                new WorkoutExercise
                {
                    Id = 2,
                    WorkoutId = 2,
                    ExerciseId = 2,
                    Sets = 4,
                    Reps = 10
                },
                new WorkoutExercise
                {
                    Id = 3,
                    WorkoutId = 3,
                    ExerciseId = 9,
                    Sets = 2,
                    Reps = 5
                },
                new WorkoutExercise
                {
                    Id = 4,
                    WorkoutId = 4,
                    ExerciseId = 5,
                    Sets = 3,
                    Reps = 20
                },
                new WorkoutExercise
                {
                    Id = 5,
                    WorkoutId = 5,
                    ExerciseId = 1,
                    Sets = 4,
                    Reps = 8
                },
                new WorkoutExercise
                {
                    Id = 6,
                    WorkoutId = 6,
                    ExerciseId = 10,
                    Sets = 2,
                    Reps = 3
                },
                new WorkoutExercise
                {
                    Id = 7,
                    WorkoutId = 7,
                    ExerciseId = 6,
                    Sets = 3,
                    Reps = 12
                },
                new WorkoutExercise
                {
                    Id = 8,
                    WorkoutId = 8,
                    ExerciseId = 3,
                    Sets = 4,
                    Reps = 6
                },
                new WorkoutExercise
                {
                    Id = 9,
                    WorkoutId = 9,
                    ExerciseId = 11,
                    Sets = 2,
                    Reps = 10
                },
                new WorkoutExercise
                {
                    Id = 10,
                    WorkoutId = 10,
                    ExerciseId = 7,
                    Sets = 3,
                    Reps = 15
                },
                new WorkoutExercise
                {
                    Id = 11,
                    WorkoutId = 11,
                    ExerciseId = 12,
                    Sets = 4,
                    Reps = 8
                },
                new WorkoutExercise
                {
                    Id = 12,
                    WorkoutId = 12,
                    ExerciseId = 13,
                    Sets = 2,
                    Reps = 5
                },
                new WorkoutExercise
                {
                    Id = 13,
                    WorkoutId = 13,
                    ExerciseId = 8,
                    Sets = 3,
                    Reps = 10
                },
                new WorkoutExercise
                {
                    Id = 14,
                    WorkoutId = 14,
                    ExerciseId = 14,
                    Sets = 4,
                    Reps = 6
                },
                new WorkoutExercise
                {
                    Id = 15,
                    WorkoutId = 15,
                    ExerciseId = 15,
                    Sets = 2,
                    Reps = 15
                }
                );
        }
    }
}
