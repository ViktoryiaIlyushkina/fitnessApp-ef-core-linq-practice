using FitnessApp.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessApp.Configurations
{
    public class UserConfigure
    {
        public static void UserConfigureMethod(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(user => user.Id);
            //параллелизм через метод IsConcurrencyToken()
            builder.Property(u => u.Name).IsConcurrencyToken();
            //создание временной таблицы для хранения истории изменений таблицы Users
            builder.ToTable("Users", t => t.IsTemporal());
            builder.HasData(
                new User
                {
                    Id = 1,
                    Name = "JohnDoe",
                    Password = "123456",
                    Email = "john.doe@example.com",
                    Gender = "Male",
                    Birthdate = new DateTime(1990, 05, 12),
                    Weight = 80.5m,
                    Height = 1.83m
                },
                new User
                {
                    Id = 2,
                    Name = "JaneSmith",
                    Password = "789012",
                    Email = "jane.smith@example.com",
                    Gender = "Female",
                    Birthdate = new DateTime(1995, 08, 21),
                    Weight = 65.0m,
                    Height = 1.70m
                },
                new User
                {
                    Id = 3,
                    Name = "AlexJohnson",
                    Password = "456789",
                    Email = "alex.johnson@example.com",
                    Gender = "Male",
                    Birthdate = new DateTime(1987, 11, 03),
                    Weight = 90.0m,
                    Height = 1.90m
                },
                new User
                {
                    Id = 4,
                    Name = "EmilyBrown",
                    Password = "012345",
                    Email = "emily.brown@example.com",
                    Gender = "Female",
                    Birthdate = new DateTime(1992, 03, 15),
                    Weight = 55.0m,
                    Height = 1.65m
                },
                new User
                {
                    Id = 5,
                    Name = "MichaelWilson",
                    Password = "678901",
                    Email = "michael.wilson@example.com",
                    Gender = "Male",
                    Birthdate = new DateTime(1989, 07, 28),
                    Weight = 75.0m,
                    Height = 1.78m
                },
                new User
                {
                    Id = 6,
                    Name = "SarahDavis",
                    Password = "234567",
                    Email = "sarah.davis@example.com",
                    Gender = "Female",
                    Birthdate = new DateTime(1991, 01, 18),
                    Weight = 60.0m,
                    Height = 1.68m
                },
                new User
                {
                    Id = 7,
                    Name = "DavidGarcia",
                    Password = "890123",
                    Email = "david.garcia@example.com",
                    Gender = "Male",
                    Birthdate = new DateTime(1988, 04, 05),
                    Weight = 85.0m,
                    Height = 1.85m
                },
                new User
                {
                    Id = 8,
                    Name = "JessicaMiller",
                    Password = "345678",
                    Email = "jessica.miller@example.com",
                    Gender = "Female",
                    Birthdate = new DateTime(1993, 12, 09),
                    Weight = 58.0m,
                    Height = 1.63m
                },
                new User
                {
                    Id = 9,
                    Name = "ChristopherRodriguez",
                    Password = "901234",
                    Email = "christopher.rodriguez@example.com",
                    Gender = "Male",
                    Birthdate = new DateTime(1986, 09, 22),
                    Weight = 95.0m,
                    Height = 1.95m
                },
                new User
                {
                    Id = 10,
                    Name = "JenniferWilson",
                    Password = "567890",
                    Email = "jennifer.wilson@example.com",
                    Gender = "Female",
                    Birthdate = new DateTime(1994, 06, 11),
                    Weight = 62.0m,
                    Height = 1.67m
                },
                new User
                {
                    Id = 11,
                    Name = "MatthewLee",
                    Password = "012345",
                    Email = "matthew.lee@example.com",
                    Gender = "Male",
                    Birthdate = new DateTime(1990, 02, 25),
                    Weight = 70.0m,
                    Height = 1.75m
                },
                new User
                {
                    Id = 12,
                    Name = "ElizabethMartin",
                    Password = "678901",
                    Email = "elizabeth.martin@example.com",
                    Gender = "Female",
                    Birthdate = new DateTime(1991, 09, 08),
                    Weight = 57.0m,
                    Height = 1.62m
                },
                new User
                {
                    Id = 13,
                    Name = "DanielTaylor",
                    Password = "234567",
                    Email = "daniel.taylor@example.com",
                    Gender = "Male",
                    Birthdate = new DateTime(1985, 03, 17),
                    Weight = 88.0m,
                    Height = 1.88m
                },
                new User
                {
                    Id = 14,
                    Name = "KatherineGarcia",
                    Password = "890123",
                    Email = "katherine.garcia@example.com",
                    Gender = "Female",
                    Birthdate = new DateTime(1992, 10, 26),
                    Weight = 61.0m,
                    Height = 1.66m
                },
                new User
                {
                    Id = 15,
                    Name = "AnthonyJackson",
                    Password = "345678",
                    Email = "anthony.jackson@example.com",
                    Gender = "Male",
                    Birthdate = new DateTime(1993, 05, 04),
                    Weight = 78.0m,
                    Height = 1.80m
                }
                );
        }
    }
}
