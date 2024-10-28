using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessApp.Models
{
    public class Workout
    {
        public int Id { get; set; }
        public string? Type { get; set; }
        public DateTime Date { get; set; }
        public int Duration { get; set; }
        public int CaloriesBurned { get; set; }

        public int UserId { get; set; }
        public User? User { get; set; }

        public List<WorkoutExercise>? WorkoutExercises { get; set; }
    }
}
