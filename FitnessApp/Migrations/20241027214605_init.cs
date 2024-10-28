using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FitnessApp.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Exersices",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Exersices", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Foods",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Category = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Calories = table.Column<int>(type: "int", nullable: false),
                    Protein = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Carbohydrates = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Fat = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Foods", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                        .Annotation("SqlServer:IsTemporal", true)
                        .Annotation("SqlServer:TemporalHistoryTableName", "UsersHistory")
                        .Annotation("SqlServer:TemporalHistoryTableSchema", null)
                        .Annotation("SqlServer:TemporalPeriodEndColumnName", "PeriodEnd")
                        .Annotation("SqlServer:TemporalPeriodStartColumnName", "PeriodStart"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                        .Annotation("SqlServer:IsTemporal", true)
                        .Annotation("SqlServer:TemporalHistoryTableName", "UsersHistory")
                        .Annotation("SqlServer:TemporalHistoryTableSchema", null)
                        .Annotation("SqlServer:TemporalPeriodEndColumnName", "PeriodEnd")
                        .Annotation("SqlServer:TemporalPeriodStartColumnName", "PeriodStart"),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true)
                        .Annotation("SqlServer:IsTemporal", true)
                        .Annotation("SqlServer:TemporalHistoryTableName", "UsersHistory")
                        .Annotation("SqlServer:TemporalHistoryTableSchema", null)
                        .Annotation("SqlServer:TemporalPeriodEndColumnName", "PeriodEnd")
                        .Annotation("SqlServer:TemporalPeriodStartColumnName", "PeriodStart"),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true)
                        .Annotation("SqlServer:IsTemporal", true)
                        .Annotation("SqlServer:TemporalHistoryTableName", "UsersHistory")
                        .Annotation("SqlServer:TemporalHistoryTableSchema", null)
                        .Annotation("SqlServer:TemporalPeriodEndColumnName", "PeriodEnd")
                        .Annotation("SqlServer:TemporalPeriodStartColumnName", "PeriodStart"),
                    Gender = table.Column<string>(type: "nvarchar(max)", nullable: true)
                        .Annotation("SqlServer:IsTemporal", true)
                        .Annotation("SqlServer:TemporalHistoryTableName", "UsersHistory")
                        .Annotation("SqlServer:TemporalHistoryTableSchema", null)
                        .Annotation("SqlServer:TemporalPeriodEndColumnName", "PeriodEnd")
                        .Annotation("SqlServer:TemporalPeriodStartColumnName", "PeriodStart"),
                    Birthdate = table.Column<DateTime>(type: "datetime2", nullable: false)
                        .Annotation("SqlServer:IsTemporal", true)
                        .Annotation("SqlServer:TemporalHistoryTableName", "UsersHistory")
                        .Annotation("SqlServer:TemporalHistoryTableSchema", null)
                        .Annotation("SqlServer:TemporalPeriodEndColumnName", "PeriodEnd")
                        .Annotation("SqlServer:TemporalPeriodStartColumnName", "PeriodStart"),
                    Weight = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                        .Annotation("SqlServer:IsTemporal", true)
                        .Annotation("SqlServer:TemporalHistoryTableName", "UsersHistory")
                        .Annotation("SqlServer:TemporalHistoryTableSchema", null)
                        .Annotation("SqlServer:TemporalPeriodEndColumnName", "PeriodEnd")
                        .Annotation("SqlServer:TemporalPeriodStartColumnName", "PeriodStart"),
                    Height = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                        .Annotation("SqlServer:IsTemporal", true)
                        .Annotation("SqlServer:TemporalHistoryTableName", "UsersHistory")
                        .Annotation("SqlServer:TemporalHistoryTableSchema", null)
                        .Annotation("SqlServer:TemporalPeriodEndColumnName", "PeriodEnd")
                        .Annotation("SqlServer:TemporalPeriodStartColumnName", "PeriodStart"),
                    PeriodEnd = table.Column<DateTime>(type: "datetime2", nullable: false)
                        .Annotation("SqlServer:IsTemporal", true)
                        .Annotation("SqlServer:TemporalHistoryTableName", "UsersHistory")
                        .Annotation("SqlServer:TemporalHistoryTableSchema", null)
                        .Annotation("SqlServer:TemporalPeriodEndColumnName", "PeriodEnd")
                        .Annotation("SqlServer:TemporalPeriodStartColumnName", "PeriodStart"),
                    PeriodStart = table.Column<DateTime>(type: "datetime2", nullable: false)
                        .Annotation("SqlServer:IsTemporal", true)
                        .Annotation("SqlServer:TemporalHistoryTableName", "UsersHistory")
                        .Annotation("SqlServer:TemporalHistoryTableSchema", null)
                        .Annotation("SqlServer:TemporalPeriodEndColumnName", "PeriodEnd")
                        .Annotation("SqlServer:TemporalPeriodStartColumnName", "PeriodStart")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                })
                .Annotation("SqlServer:IsTemporal", true)
                .Annotation("SqlServer:TemporalHistoryTableName", "UsersHistory")
                .Annotation("SqlServer:TemporalHistoryTableSchema", null)
                .Annotation("SqlServer:TemporalPeriodEndColumnName", "PeriodEnd")
                .Annotation("SqlServer:TemporalPeriodStartColumnName", "PeriodStart");

            migrationBuilder.CreateTable(
                name: "Goals",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GoalType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Goals", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Goals_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Nutritions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MealType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Calories = table.Column<int>(type: "int", nullable: false),
                    Protein = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Carbohydrates = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Fat = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Nutritions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Nutritions_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Workouts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Duration = table.Column<int>(type: "int", nullable: false),
                    CaloriesBurned = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Workouts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Workouts_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "WorkoutExercises",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Sets = table.Column<int>(type: "int", nullable: false),
                    Reps = table.Column<int>(type: "int", nullable: false),
                    WorkoutId = table.Column<int>(type: "int", nullable: false),
                    ExerciseId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkoutExercises", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WorkoutExercises_Exersices_ExerciseId",
                        column: x => x.ExerciseId,
                        principalTable: "Exersices",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_WorkoutExercises_Workouts_WorkoutId",
                        column: x => x.WorkoutId,
                        principalTable: "Workouts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Exersices",
                columns: new[] { "Id", "Description", "Name", "Type" },
                values: new object[,]
                {
                    { 1, "Classic exercise for chest muscles", "Push-ups", "Strength" },
                    { 2, "Exercise for legs and glutes", "Squats", "Strength" },
                    { 3, "Exercise for back muscles", "Pull-ups", "Strength" },
                    { 4, "Running in place or on a treadmill", "Running", "Cardio" },
                    { 5, "Jumping in place or with a jump rope", "Jumping", "Cardio" },
                    { 6, "Riding a bicycle", "Cycling", "Cardio" },
                    { 7, "Swimming in a pool", "Swimming", "Cardio" },
                    { 8, "Stretching muscles to improve flexibility", "Stretching", "Stretching" },
                    { 9, "A complex of stretching and flexibility exercises", "Yoga", "Stretching" },
                    { 10, "A complex of exercises for muscle strengthening and flexibility", "Pilates", "Stretching" },
                    { 11, "Exercise for abdominal muscles", "Abdominals", "Strength" },
                    { 12, "Exercise for back and arms", "Pull", "Strength" },
                    { 13, "Exercise for chest muscles", "Press", "Strength" },
                    { 14, "Rowing on a rowing machine", "Rowing", "Cardio" },
                    { 15, "Fast walking", "Walking", "Cardio" }
                });

            migrationBuilder.InsertData(
                table: "Foods",
                columns: new[] { "Id", "Calories", "Carbohydrates", "Category", "Fat", "Name", "Protein" },
                values: new object[,]
                {
                    { 1, 155, 1m, "Meat", 11m, "Eggs", 13m },
                    { 2, 389, 66m, "Grains", 6m, "Oatmeal", 13m },
                    { 3, 89, 23m, "Fruits", 0m, "Banana", 1m },
                    { 4, 165, 0m, "Meat", 3m, "Chicken Breast", 31m },
                    { 5, 360, 77m, "Grains", 1m, "Rice", 7m },
                    { 6, 34, 7m, "Vegetables", 0m, "Broccoli", 3m },
                    { 7, 208, 0m, "Fish", 13m, "Salmon", 20m },
                    { 8, 400, 2m, "Dairy", 30m, "Cheese", 25m },
                    { 9, 340, 62m, "Grains", 2m, "Buckwheat", 13m },
                    { 10, 57, 15m, "Fruits", 0m, "Pear", 0m },
                    { 11, 213, 0m, "Meat", 11m, "Beef", 27m },
                    { 12, 77, 17m, "Vegetables", 0m, "Potato", 2m },
                    { 13, 130, 0m, "Fish", 3m, "Tuna", 25m },
                    { 14, 60, 5m, "Dairy", 3m, "Milk ", 3m },
                    { 15, 47, 12m, "Fruits", 0m, "Orange", 1m }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Birthdate", "Email", "Gender", "Height", "Name", "Password", "Weight" },
                values: new object[,]
                {
                    { 1, new DateTime(1990, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "john.doe@example.com", "Male", 1.83m, "JohnDoe", "123456", 80.5m },
                    { 2, new DateTime(1995, 8, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "jane.smith@example.com", "Female", 1.70m, "JaneSmith", "789012", 65.0m },
                    { 3, new DateTime(1987, 11, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "alex.johnson@example.com", "Male", 1.90m, "AlexJohnson", "456789", 90.0m },
                    { 4, new DateTime(1992, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "emily.brown@example.com", "Female", 1.65m, "EmilyBrown", "012345", 55.0m },
                    { 5, new DateTime(1989, 7, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "michael.wilson@example.com", "Male", 1.78m, "MichaelWilson", "678901", 75.0m },
                    { 6, new DateTime(1991, 1, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "sarah.davis@example.com", "Female", 1.68m, "SarahDavis", "234567", 60.0m },
                    { 7, new DateTime(1988, 4, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "david.garcia@example.com", "Male", 1.85m, "DavidGarcia", "890123", 85.0m },
                    { 8, new DateTime(1993, 12, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "jessica.miller@example.com", "Female", 1.63m, "JessicaMiller", "345678", 58.0m },
                    { 9, new DateTime(1986, 9, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "christopher.rodriguez@example.com", "Male", 1.95m, "ChristopherRodriguez", "901234", 95.0m },
                    { 10, new DateTime(1994, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "jennifer.wilson@example.com", "Female", 1.67m, "JenniferWilson", "567890", 62.0m },
                    { 11, new DateTime(1990, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "matthew.lee@example.com", "Male", 1.75m, "MatthewLee", "012345", 70.0m },
                    { 12, new DateTime(1991, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "elizabeth.martin@example.com", "Female", 1.62m, "ElizabethMartin", "678901", 57.0m },
                    { 13, new DateTime(1985, 3, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "daniel.taylor@example.com", "Male", 1.88m, "DanielTaylor", "234567", 88.0m },
                    { 14, new DateTime(1992, 10, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "katherine.garcia@example.com", "Female", 1.66m, "KatherineGarcia", "890123", 61.0m },
                    { 15, new DateTime(1993, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "anthony.jackson@example.com", "Male", 1.80m, "AnthonyJackson", "345678", 78.0m }
                });

            migrationBuilder.InsertData(
                table: "Goals",
                columns: new[] { "Id", "Description", "EndDate", "GoalType", "StartDate", "UserId" },
                values: new object[,]
                {
                    { 1, "Lose 5 kg of weight", new DateTime(2023, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Weight Loss", new DateTime(2023, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 2, "Gain 3 kg of muscle mass", new DateTime(2023, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mass Gain", new DateTime(2023, 4, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 3, "Reduce body fat percentage to 15%", new DateTime(2023, 8, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Fat Percentage Reduction", new DateTime(2023, 5, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 4, "Lose 3 kg of weight", new DateTime(2023, 9, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Weight Loss", new DateTime(2023, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 5, "Gain 2 kg of muscle mass", new DateTime(2023, 10, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mass Gain", new DateTime(2023, 7, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 5 },
                    { 6, "Reduce body fat percentage to 18%", new DateTime(2023, 11, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Fat Percentage Reduction", new DateTime(2023, 8, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 6 },
                    { 7, "Lose 4 kg of weight", new DateTime(2023, 12, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Weight Loss", new DateTime(2023, 9, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 7 },
                    { 8, "Gain 4 kg of muscle mass", new DateTime(2024, 1, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mass Gain", new DateTime(2023, 10, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 8 },
                    { 9, "Reduce body fat percentage to 20%", new DateTime(2024, 2, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Fat Percentage Reduction", new DateTime(2023, 11, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 9 },
                    { 10, "Lose 2 kg of weight", new DateTime(2024, 3, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Weight Loss", new DateTime(2023, 12, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 10 },
                    { 11, "Gain 5 kg of muscle mass", new DateTime(2024, 4, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mass Gain", new DateTime(2024, 1, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 11 },
                    { 12, "Reduce body fat percentage to 16%", new DateTime(2024, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Fat Percentage Reduction", new DateTime(2024, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 12 },
                    { 13, "Lose 6 kg of weight", new DateTime(2024, 7, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Weight Loss", new DateTime(2024, 4, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 13 },
                    { 14, "Gain 3 kg of muscle mass", new DateTime(2024, 8, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mass Gain", new DateTime(2024, 5, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 14 },
                    { 15, "Reduce body fat percentage to 17%", new DateTime(2024, 9, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Fat Percentage Reduction", new DateTime(2024, 6, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 15 }
                });

            migrationBuilder.InsertData(
                table: "Nutritions",
                columns: new[] { "Id", "Calories", "Carbohydrates", "Date", "Fat", "MealType", "Protein", "UserId" },
                values: new object[,]
                {
                    { 1, 400, 50m, new DateTime(2023, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 10m, "Breakfast", 20m, 1 },
                    { 2, 550, 60m, new DateTime(2023, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 15m, "Lunch", 30m, 2 },
                    { 3, 450, 40m, new DateTime(2023, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 12m, "Dinner", 25m, 3 },
                    { 4, 350, 45m, new DateTime(2023, 6, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 8m, "Breakfast", 18m, 4 },
                    { 5, 600, 70m, new DateTime(2023, 7, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 18m, "Lunch", 35m, 5 },
                    { 6, 500, 50m, new DateTime(2023, 8, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 13m, "Dinner", 28m, 6 },
                    { 7, 420, 55m, new DateTime(2023, 9, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 11m, "Breakfast", 22m, 7 },
                    { 8, 580, 65m, new DateTime(2023, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 16m, "Lunch", 32m, 8 },
                    { 9, 480, 45m, new DateTime(2023, 11, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 14m, "Dinner", 27m, 9 },
                    { 10, 380, 48m, new DateTime(2023, 12, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 9m, "Breakfast", 19m, 10 },
                    { 11, 620, 75m, new DateTime(2024, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 20m, "Lunch", 38m, 11 },
                    { 12, 520, 55m, new DateTime(2024, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 15m, "Dinner", 30m, 12 },
                    { 13, 440, 58m, new DateTime(2024, 3, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 12m, "Breakfast", 24m, 13 },
                    { 14, 600, 70m, new DateTime(2024, 4, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 18m, "Lunch", 36m, 14 },
                    { 15, 500, 50m, new DateTime(2024, 5, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 13m, "Dinner", 29m, 5 }
                });

            migrationBuilder.InsertData(
                table: "Workouts",
                columns: new[] { "Id", "CaloriesBurned", "Date", "Duration", "Type", "UserId" },
                values: new object[,]
                {
                    { 1, 500, new DateTime(2023, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 45, "Cardio", 1 },
                    { 2, 650, new DateTime(2023, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 60, "Strength", 2 },
                    { 3, 300, new DateTime(2023, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 30, "Yoga", 3 },
                    { 4, 400, new DateTime(2023, 6, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 35, "Cardio", 4 },
                    { 5, 550, new DateTime(2023, 7, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 50, "Strength", 5 },
                    { 6, 350, new DateTime(2023, 8, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 40, "Yoga", 6 },
                    { 7, 500, new DateTime(2023, 9, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 45, "Cardio", 7 },
                    { 8, 650, new DateTime(2023, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 60, "Strength", 8 },
                    { 9, 300, new DateTime(2023, 11, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 30, "Yoga", 9 },
                    { 10, 400, new DateTime(2023, 12, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 35, "Cardio", 10 },
                    { 11, 550, new DateTime(2024, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 50, "Strength", 11 },
                    { 12, 350, new DateTime(2024, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 40, "Yoga", 12 },
                    { 13, 500, new DateTime(2024, 3, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 45, "Cardio", 13 },
                    { 14, 650, new DateTime(2024, 4, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 60, "Strength", 14 },
                    { 15, 300, new DateTime(2024, 5, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 30, "Yoga", 15 }
                });

            migrationBuilder.InsertData(
                table: "WorkoutExercises",
                columns: new[] { "Id", "ExerciseId", "Reps", "Sets", "WorkoutId" },
                values: new object[,]
                {
                    { 1, 4, 15, 3, 1 },
                    { 2, 2, 10, 4, 2 },
                    { 3, 9, 5, 2, 3 },
                    { 4, 5, 20, 3, 4 },
                    { 5, 1, 8, 4, 5 },
                    { 6, 10, 3, 2, 6 },
                    { 7, 6, 12, 3, 7 },
                    { 8, 3, 6, 4, 8 },
                    { 9, 11, 10, 2, 9 },
                    { 10, 7, 15, 3, 10 },
                    { 11, 12, 8, 4, 11 },
                    { 12, 13, 5, 2, 12 },
                    { 13, 8, 10, 3, 13 },
                    { 14, 14, 6, 4, 14 },
                    { 15, 15, 15, 2, 15 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Goals_UserId",
                table: "Goals",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Nutritions_UserId",
                table: "Nutritions",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_WorkoutExercises_ExerciseId",
                table: "WorkoutExercises",
                column: "ExerciseId");

            migrationBuilder.CreateIndex(
                name: "IX_WorkoutExercises_WorkoutId",
                table: "WorkoutExercises",
                column: "WorkoutId");

            migrationBuilder.CreateIndex(
                name: "IX_Workouts_UserId",
                table: "Workouts",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Foods");

            migrationBuilder.DropTable(
                name: "Goals");

            migrationBuilder.DropTable(
                name: "Nutritions");

            migrationBuilder.DropTable(
                name: "WorkoutExercises");

            migrationBuilder.DropTable(
                name: "Exersices");

            migrationBuilder.DropTable(
                name: "Workouts");

            migrationBuilder.DropTable(
                name: "Users")
                .Annotation("SqlServer:IsTemporal", true)
                .Annotation("SqlServer:TemporalHistoryTableName", "UsersHistory")
                .Annotation("SqlServer:TemporalHistoryTableSchema", null)
                .Annotation("SqlServer:TemporalPeriodEndColumnName", "PeriodEnd")
                .Annotation("SqlServer:TemporalPeriodStartColumnName", "PeriodStart");
        }
    }
}
