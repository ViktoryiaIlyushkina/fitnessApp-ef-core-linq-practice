using FitnessApp.Contexts;
using FitnessApp.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Text.RegularExpressions;

namespace FitnessApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                //### All / AllAsync
                //1.Проверить, все ли пользователи старше 18 лет.
                var res0 = db.Users.AsNoTracking().All(u => DateTime.Now.Year - u.Birthdate.Year >= 18);
                //2.Проверить, все ли тренировки пользователя с ID = 3 были типа "Силовая".
                var res1 = db.Workouts.AsNoTracking().Where(w => w.UserId == 3).All(w => w.Type == "Strength");
                //3.Проверить, все ли продукты в категории "Зерновые" имеют количество углеводов больше 50.
                var res2 = db.Foods.AsNoTracking().Where(f => f.Category == "Grains").All(f => f.Carbohydrates > 50);

                //### Any / AnyAsync
                //1.Проверить, есть ли пользователи с именем "Jane".
                var res3 = db.Users.AsNoTracking().Any(u => EF.Functions.Like(u.Name, "%Jane%"));
                //2.Проверить, есть ли тренировки, которые длились меньше 30 минут.
                var res4 = db.Workouts.AsNoTracking().Any(w => w.Duration < 30);
                //3.Проверить, есть ли продукты с количеством белка больше 30.
                var res5 = db.Foods.AsNoTracking().Any(f => f.Protein > 30);

                //### Average / AverageAsync
                //1.Найти средний рост всех пользователей.
                var res6 = db.Users.AsNoTracking().Average(u => u.Height);
                //2.Найти среднюю продолжительность тренировок типа "Йога".
                var res7 = db.Workouts.AsNoTracking().Average(w => w.Duration);
                //3.Найти среднее количество жиров в продуктах категории "Рыба".
                var res8 = db.Foods.AsNoTracking().Average(f => f.Fat);

                //### Contains / ContainsAsync
                //1.Проверить, содержит ли база данных пользователя с именем "Alex".
                var res9 = db.Users.AsNoTracking().Where(u => u.Name.Contains("Alex"));
                //2.Проверить, содержит ли база данных тренировку с типом "Плавание".
                var res10 = db.Workouts.AsNoTracking().Where(w => w.Type!.Contains("Swimming"));
                //3.Проверить, содержит ли база данных продукт с названием "Овсянка".
                var res11 = db.Foods.AsNoTracking().Where(f => f.Name!.Contains("Oatmeal"));

                //### Count / CountAsync
                //1.Подсчитать количество пользователей, у которых установлена цель "Похудение".
                var res12 = db.Users.AsNoTracking().Count(u => u.Goals!.Any(g => g.GoalType == "Weight Loss"));
                //2.Подсчитать количество тренировок, проведенных в 2023 году.
                var res13 = db.Workouts.AsNoTracking().Count(w => w.Date.Year == 2023);
                //3.Подсчитать количество продуктов, которые относятся к категории "Фрукты" или "Овощи".
                var res14 = db.Foods.AsNoTracking().Count(f => f.Category == "Fruits" || f.Category == "Vegetables");

                //### First / FirstAsync
                //1.Получить первого пользователя, у которого вес больше 85 кг.
                try
                {
                    var res15 = db.Users.AsNoTracking().First(u => u.Weight > 85);
                }
                catch(Exception ex) 
                {
                    Console.WriteLine(ex.Message);
                }
                //2.Получить первую тренировку, которая была проведена 2023 - 04 - 15.
                try
                {
                    var res16 = db.Workouts.AsNoTracking().First(w => w.Date == new DateTime(2023, 04, 15));
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                //3.Получить первый продукт, который имеет меньше 50 калорий.
                try
                {
                    var res17 = db.Foods.AsNoTracking().First(f => f.Calories < 50);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                //### FirstOrDefault / FirstOrDefaultAsync
                //1.Получить первого пользователя с именем "Emily", или null, если такого пользователя нет.
                var res18 = db.Users.AsNoTracking().FirstOrDefault(u => EF.Functions.Like(u.Name, "%Emily%"));
                //2.Получить первую тренировку типа "Кардио", или null, если такой тренировки нет.
                var res19 = db.Workouts.AsNoTracking().FirstOrDefault(w => w.Type == "Cardio");
                //3.Получить первый продукт с названием "Тунец", или null, если такого продукта нет.
                var res20 = db.Foods.AsNoTracking().FirstOrDefault(f => f.Name == "Tuna");

                //### Single / SingleAsync
                //1.Получить единственного пользователя с именем "John", если таких пользователей больше одного, то будет выброшено исключение.
                try
                {
                    var res21 = db.Users.AsNoTracking().Single(u => u.Name!.Contains("John"));
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                //2.Получить единственную тренировку с ID = 5, если таких тренировок больше одной, то будет выброшено исключение.
                try
                {
                    var res22 = db.Workouts.AsNoTracking().Single(w => w.Id == 5);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                //3.Получить единственный продукт с названием "Банан", если таких продуктов больше одного, то будет выброшено исключение. 
                try
                {
                    var res23 = db.Foods.AsNoTracking().Single(f => f.Name == "Banana");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

                //### SingleOrDefault / SingleOrDefaultAsync
                //1.Получить единственного пользователя с именем "Sarah", или null, если такого пользователя нет или таких пользователей больше одного.
                var res24 = db.Users.AsNoTracking().SingleOrDefault(u => u.Name.Contains("Sarah"));
                //2.Получить единственную тренировку с ID = 2, или null, если такой тренировки нет или таких тренировок больше одной.
                var res25 = db.Workouts.AsNoTracking().SingleOrDefault(w => w.Id == 2);
                //3.Получить единственный продукт с названием "Сыр", или null, если такого продукта нет или таких продуктов больше одного.
                var res26 = db.Foods.AsNoTracking().SingleOrDefault(f => f.Name == "Cheese");

                //### Select
                //1.Получить список email адресов пользователей.
                var res27 = db.Users.AsNoTracking().Select(u => u.Email).ToList();
                //2.Получить список названий упражнений, которые использовались в тренировке с ID = 4.
                var res28 = db.WorkoutExercises.AsNoTracking().Where(we => we.WorkoutId == 1).Select(we => we.Exercise.Name).ToList();
                //3.Получить список типов целей, которые были установлены пользователями.
                var res29 = db.Goals.AsNoTracking().Select(g => g.GoalType).ToList();

                //### Where
                //1.Получить список пользователей, чей рост меньше 1.70 м.
                var res30 = db.Users.AsNoTracking().Where(u => u.Height < 1.70m).ToList();
                //2.Получить список тренировок, которые длились меньше 40 минут.
                var res31 = db.Workouts.AsNoTracking().Where(w => w.Duration < 40).ToList();
                //3.Получить список продуктов, которые имеют количество белка больше 20.
                var res32 = db.Foods.AsNoTracking().Where(f => f.Protein > 20).ToList();

                //### OrderBy
                //1.Получить список пользователей, отсортированный по возрастанию возраста.
                var res33 = db.Users.AsNoTracking().OrderByDescending(u => u.Birthdate).ToList();
                //2.Получить список тренировок, отсортированный по возрастанию количества сожженных калорий.
                var res34 = db.Workouts.AsNoTracking().OrderBy(w => w.CaloriesBurned).ToList();
                //3.Получить список продуктов, отсортированный по возрастанию количества углеводов. 
                var res35 = db.Foods.AsNoTracking().OrderBy(f => f.Carbohydrates).ToList();

                //### OrderByDescending
                //1.Получить список пользователей, отсортированный по убыванию веса.
                var res36 = db.Users.AsNoTracking().OrderByDescending(u => u.Weight).ToList();
                //2.Получить список тренировок, отсортированный по убыванию продолжительности.
                var res37 = db.Workouts.AsNoTracking().OrderByDescending(w => w.Duration).ToList();
                //3.Получить список продуктов, отсортированный по убыванию количества жиров.
                var res38 = db.Foods.AsNoTracking().OrderByDescending(f => f.Fat).ToList();

                //### ThenBy
                //1.Получить список пользователей, отсортированный по возрастанию веса, а затем по возрастанию роста.
                var res39 = db.Users.AsNoTracking().OrderBy(u => u.Weight).ThenBy(u => u.Height).ToList();
                //2.Получить список тренировок, отсортированный по возрастанию даты, а затем по возрастанию продолжительности.
                var res40 = db.Workouts.AsNoTracking().OrderBy(w => w.Date).ThenBy(w => w.Duration).ToList();
                //3.Получить список продуктов, отсортированный по возрастанию количества калорий, а затем по возрастанию количества белка.
                var res41 = db.Foods.AsNoTracking().OrderBy(f => f.Calories).ThenBy(f => f.Protein).ToList();

                //### ThenByDescending
                //1.Получить список пользователей, отсортированный по возрастанию возраста, а затем по убыванию веса.
                var res42 = db.Users.AsNoTracking().OrderByDescending(u => u.Birthdate).ThenByDescending(u => u.Weight).ToList();
                //2.Получить список тренировок, отсортированный по возрастанию даты, а затем по убыванию количества сожженных калорий.
                var res43 = db.Workouts.AsNoTracking().OrderBy(w => w.Date).ThenByDescending(w => w.CaloriesBurned).ToList();
                //3.Получить список продуктов, отсортированный по возрастанию количества калорий, а затемпо убыванию количества углеводов. 
                var res44 = db.Foods.AsNoTracking().OrderBy(f => f.Calories).ThenByDescending(f => f.Carbohydrates).ToList();

                //### Join
                //1.Получить список пользователей с их целями, включая информацию о типе цели и дате окончания.
                var res45 = db.Users.AsNoTracking().Join(db.Goals,
                    u => u.Id,
                    g => g.UserId, 
                    (u, g) => new
                    {
                        Name = u.Name,
                        Type = g.GoalType,
                        EndDate = g.EndDate
                    }).ToList();
                //2.Получить список тренировок с информацией об упражнениях, включая название упражнения, тип упражнения и количество повторений.
                var res46 = db.Workouts.AsNoTracking()
                    .Join(db.WorkoutExercises,
                        workout => workout.Id,
                        workoutExercise => workoutExercise.WorkoutId,
                        (workout, workoutExercise) => new
                        {
                            workout,
                            workoutExercise
                        })
                    .Join(db.Exersices,
                        wwe => wwe.workoutExercise.ExerciseId,
                        exercise => exercise.Id,
                        (wwe, exercise) => new
                        {
                            WorkoutId = wwe.workout.Id,
                            WorkoutType = wwe.workout.Type,
                            WorkoutDate = wwe.workout.Date,
                            WorkoutDuration = wwe.workout.Duration,
                            ExerciseName = exercise.Name,
                            ExerciseType = exercise.Type,
                            ExercizeRep = wwe.workoutExercise.Reps
                        }
                    ).ToList();
                //3.Получить список продуктов с информацией о их питательной ценности, включая количество калорий, белков, углеводов и жиров.
                var res47 = db.Foods.AsNoTracking().Select(f => new
                {
                    Name = f.Name,
                    NutritionalValue = new
                    {
                        Calories = f.Calories,
                        Protein = f.Protein,
                        Carbohydrates = f.Carbohydrates,
                        Fat = f.Fat
                    }
                }).ToList();

                //### GroupBy
                //1.Сгруппировать тренировки по типу и подсчитать количество тренировок каждого типа.
                var res48 = db.Workouts.AsNoTracking().GroupBy(w => w.Type).Select(g => new
                {
                    g.Key,
                    Count = g.Count()
                });
                //2.Сгруппировать продукты по категории и подсчитать среднее количество калорий в каждой категории.
                var res49 = db.Foods.AsNoTracking().GroupBy(f => f.Category).Select(g => new
                {
                    g.Key,
                    Count = g.Count()
                });
                //3.Сгруппировать цели по типу и подсчитать количество пользователей, которые поставили себе каждую цель.
                var res50 = db.Goals.AsNoTracking().GroupBy(g => g.GoalType).Select(g => new
                {
                    g.Key,
                    Count = g.Count()
                });

                //### Except
                //1.Получить список пользователей, которые не имеют установленных целей.
                var selector1 = db.Users.AsNoTracking();
                var selector2 = db.Users.AsNoTracking().Where(u => u.Goals!.Count < 1);
                var res51 = selector1.Except(selector2).ToList();
                //2.Получить список продуктов, которые не были использованы в записях о питании.
                //var selector3 = db.Foods.AsNoTracking();
                //var selector4 = db.Foods.AsNoTracking().Where(f => F.Nutrtitions!.Count < 1) // нет связи с продуктами
                //var res52 = selector3.Except(selector4).ToList();
                //3.Получить список тренировок, которые не были проведены пользователем с ID = 2.
                var selector5 = db.Workouts.AsNoTracking();
                var selector6 = db.Workouts.AsNoTracking().Where(w => w.UserId == 2);
                var res53 = selector5.Except(selector6).ToList();

                //### Union
                //1.Объединить список пользователей с другим списком пользователей, содержащим дополнительных пользователей.
                var res54 = db.Users.AsNoTracking().Where(u => u.Weight < 70)
                    .Union(db.Users.AsNoTracking().Where(u => u.Height > 1.7m)).ToList();
                //2.Объединить список тренировок с другим списком тренировок, содержащим дополнительные тренировки.
                var res55 = db.Workouts.AsNoTracking().Where(w => w.Type == "Cardio")
                    .Union(db.Workouts.AsNoTracking().Where(w => w.CaloriesBurned > 500)).ToList();
                //3.Объединить список продуктов с другим списком продуктов, содержащим дополнительные продукты.
                var res56 = db.Foods.AsNoTracking().Where(f => f.Category == "Fish")
                    .Union(db.Foods.AsNoTracking().Where(f => f.Calories < 400)).ToList();

                //### Intersect
                //1.Получить список пользователей, которые имеют как цели, так и тренировки.
                var res57 = db.Users.AsNoTracking().Where(u => u.Goals!.Count > 0)
                    .Intersect(db.Users.AsNoTracking().Where(u => u.Workouts!.Count > 0)).ToList();
                //2.Получить список продуктов, которые были использованы как в записях о питании, так и в рецептах.
                //нет таблицы рецепты и нет связи с записями о питании
                //3.Получить список тренировок, которые включают упражнения из определенного списка.
                var res58 = db.WorkoutExercises.AsNoTracking().Where(w => w.Exercise!.Type == "Cardio")
                    .Intersect(db.WorkoutExercises.AsNoTracking().Where(w => w.Sets > 3)).Select(res => res.Workout).ToList();

                //### Sum / SumAsync
                //1.Подсчитать общее количество калорий, сожженных во всех тренировках пользователя с ID = 1.
                var res59 = db.Workouts.AsNoTracking().Where(w => w.UserId == 1)
                    .Sum(w => w.CaloriesBurned);
                //2.Подсчитать общее количество белка во всех записях о питании за 2023 год.
                var res60 = db.Nutritions.AsNoTracking().Where(n => n.Date.Year == 2023)
                    .Sum(n => n.Protein);
                //3.Подсчитать общее количество повторений всех упражнений в тренировке с ID = 3.
                var res61 = db.WorkoutExercises.AsNoTracking().Where(w => w.WorkoutId == 3)
                    .Sum(w => w.Reps);

                //### Min / MinAsync
                //1.Найти минимальное количество калорий, сожженных в тренировке.
                var res62 = db.Workouts.AsNoTracking().Min(w => w.CaloriesBurned);
                //2.Найти минимальное количество белка в продукте.
                var res63 = db.Foods.AsNoTracking().Min(f => f.Protein);
                //3.Найти минимальное количество повторений в упражнении.
                var res64 = db.WorkoutExercises.AsNoTracking().Min(w => w.Reps);

                //### Max / MaxAsync
                //1.Найти максимальную продолжительность тренировки.
                var res65 = db.Workouts.AsNoTracking().Max(w => w.Duration);
                //2.Найти максимальное количество калорий в продукте.
                var res66 = db.Foods.AsNoTracking().Max(f => f.Calories);
                //3.Найти максимальное количество повторений в упражнении.
                var res67 = db.WorkoutExercises.AsNoTracking().Max(w => w.Reps);

                //### Take
                //1.Получить первые 3 пользователя, отсортированных по возрастанию веса.
                var res68 = db.Users.AsNoTracking().OrderBy(u => u.Weight).Take(3);
                //2.Получить первые 5 тренировок, отсортированных по убыванию даты.
                var res69 = db.Workouts.AsNoTracking().OrderByDescending(w => w.Date).Take(5);
                //3.Получить первые 2 продукта, отсортированных по возрастанию количества калорий.
                var res70 = db.Foods.AsNoTracking().OrderBy(f => f.Calories).Take(2);

                //### TakeLast
                //1.Получить последние 2 пользователя, отсортированных по убыванию веса.
                var res71 = db.Users.AsNoTracking().OrderByDescending(u => u.Weight).TakeLast(2); 
                //2.Получить последние 3 тренировки, отсортированных по возрастанию даты.
                var res72 = db.Workouts.AsNoTracking().OrderBy(w => w.Date).TakeLast(3);
                //3.Получить последний продукт, отсортированный по убыванию количества калорий.
                var res73 = db.Foods.AsNoTracking().OrderByDescending(f => f.Calories).TakeLast(1);

                //### Skip
                //1.Пропустить первые 5 пользователей и получить оставшихся, отсортированных по возрастанию роста.
                var res74 = db.Users.AsNoTracking().OrderBy(u => u.Height).Skip(5);
                //2.Пропустить первые 2 тренировки и получить оставшихся, отсортированных по убыванию продолжительности.
                var res75 = db.Workouts.AsNoTracking().OrderByDescending(w => w.Duration).Skip(2);
                //3.Пропустить первый продукт и получить оставшихся, отсортированных по возрастанию количества белка.
                var res76 = db.Foods.AsNoTracking().OrderBy(f => f.Protein).Skip(1);

                //### SkipLast
                //1.Пропустить последние 2 пользователя и получить оставшихся, отсортированных по возрастанию веса.
                var res77 = db.Users.AsNoTracking().OrderBy(u => u.Weight).SkipLast(2);
                //2.Пропустить последние 3 тренировки и получить оставшихся, отсортированных по убыванию даты.
                var res78 = db.Workouts.AsNoTracking().OrderByDescending(w => w.Date).SkipLast(3);
                //3.Пропустить последний продукт и получить оставшихся, отсортированных по возрастанию количества калорий.
                var res79 = db.Foods.AsNoTracking().OrderBy(f => f.Calories).SkipLast(1);

                //### TakeWhile
                //1.Получить пользователей, пока их вес не превысит 75 кг, отсортированных по возрастанию возраста.
                var res80 = db.Users.AsNoTracking().OrderByDescending(u => u.Birthdate).TakeWhile(u => u.Weight > 75);
                //2.Получить тренировки, пока их продолжительность не превысит 40 минут, отсортированных по убыванию даты.
                var res81 = db.Workouts.AsNoTracking().OrderByDescending(w => w.Date).TakeWhile(w => w.Duration <= 40);
                //3.Получить продукты, пока их количество калорий не превысит 150, отсортированных по возрастанию количества белка.
                var res82 = db.Foods.AsNoTracking().OrderBy(f => f.Protein).TakeWhile(f => f.Calories <= 150);

                //### SkipWhile
                //1.Пропустить пользователей, пока их вес не превысит 70 кг, и получить оставшихся, отсортированных по возрастанию роста.
                var res83 = db.Users.AsNoTracking().OrderByDescending(u => u.Birthdate).SkipWhile(u => u.Weight <= 70);
                //2.Пропустить тренировки, пока их продолжительность не превысит 30 минут, и получить оставшихся, отсортированных по убыванию даты.
                var res84 = db.Workouts.AsNoTracking().OrderByDescending(w => w.Date).SkipWhile(w => w.Duration <= 30);
                //3.Пропустить продукты, пока их количество калорий не превысит 100, и получить оставшихся, отсортированных по возрастанию количества углеводов.
                var res85 = db.Foods.AsNoTracking().OrderBy(f => f.Carbohydrates).SkipWhile(f => f.Calories <= 100);

                //### ToList / ToListAsync
                //1.Преобразовать все продукты в список.
                var res86 = db.Foods.AsNoTracking().ToList();
                //2.Преобразовать все тренировки в список.
                var res87 = db.Workouts.AsNoTracking().ToList();
                //3.Преобразовать все цели в список.
                var res88 = db.Goals.AsNoTracking().ToList();
            }
        }
    }
}
