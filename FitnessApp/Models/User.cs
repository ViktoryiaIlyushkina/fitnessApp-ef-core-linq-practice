using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessApp.Models
{
    public class User
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Password { get; set; }
        public string? Email { get; set; }
        public string? Gender { get; set; }
        public DateTime Birthdate { get; set; }
        public decimal Weight { get; set; }
        public decimal Height { get; set; }

        public List<Goal>? Goals { get; set; }
        public List<Workout>? Workouts { get; set; }
        public List<Nutrition>? Nutritions { get; set; }
    }
}
