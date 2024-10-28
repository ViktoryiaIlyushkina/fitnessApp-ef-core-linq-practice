using FitnessApp.Configurations;
using FitnessApp.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.Extensions.Logging;

namespace FitnessApp.Contexts
{
    public class ApplicationContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Goal> Goals { get; set; }
        public DbSet<Workout> Workouts { get; set; }
        public DbSet<Exercise> Exersices { get; set; }
        public DbSet<WorkoutExercise> WorkoutExercises { get; set; }
        public DbSet<Nutrition> Nutritions { get; set; }
        public DbSet<Food> Foods { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = @"Server=(localdb)\mssqllocaldb; Database=FitnessAppDb; Trusted_Connection=True;";
            optionsBuilder.UseSqlServer(connectionString);
        }
        // логгирование с использованием пакета Microsoft.Extensions.Logging.Console
        public static readonly ILoggerFactory MyLoggerFactory = LoggerFactory.Create(builder =>
        {
            builder.AddConsole();
        });
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>(UserConfigure.UserConfigureMethod);
            modelBuilder.Entity<Goal>(GoalConfigure.GoalConfigureMethod);
            modelBuilder.Entity<Workout>(WorkoutConfigure.WorkoutConfigureMethod);
            modelBuilder.Entity<Exercise>(ExerciseConfigure.ExerciseConfigureMethod);
            modelBuilder.Entity<WorkoutExercise>(WorkoutExerciseConfigure.WorkoutExerciseConfigureMethod);
            modelBuilder.Entity<Nutrition>(NutritionConfigure.NutritionConfigureMethod);
            modelBuilder.Entity<Food>(FoodConfigure.FoodConfigureMethod);
        }        
    }
}
