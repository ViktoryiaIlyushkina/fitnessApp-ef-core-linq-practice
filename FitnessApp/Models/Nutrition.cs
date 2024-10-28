using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessApp.Models
{
    public class Nutrition
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public string? MealType { get; set; }
        public int Calories { get; set; }
        public decimal Protein { get; set; }
        public decimal Carbohydrates { get; set; }
        public decimal Fat { get; set; }

        public int UserId { get; set; }
        public User? User { get; set; }
    }
}
