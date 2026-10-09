// string subject = "Программмирование";

// foreach (char letter in subject)
// {
//     System.Console.WriteLine(letter);
// }
// System.Console.WriteLine(subject.Length);

// int[] grades = { 4, 5, 3, 5, 4 };
// int total = 0;

// foreach (int grade in grades)
// {
//     System.Console.WriteLine(grade);
//     total += grade;
// }
// System.Console.WriteLine(total / grades.Length);


// string[] students = { "Аня", "Ярослав", "Вика" };
// int total = 0;

// foreach (string student in students)
// {
//     total += 1;
// System.Console.WriteLine(student);
// }
// System.Console.WriteLine(total);


// int[] points = { 10, 20, 15 };

// for (int i = 0; i < points.Length; i++)
// {
//     points[i] += 5;
//     System.Console.WriteLine(points[i]);   
// }

// string[] students = { "Аня", "Бороис", "Вика" };
// int number = 1;

// foreach (string student in students)
// {
//     System.Console.WriteLine($"{number}.{student}");
//     number++;
// }


// Самостоятельное задание 1
// int[] points = { 5, 10, 15, 20, 25 };
// int total = 0;
// foreach (int point in points)
// {
//     System.Console.WriteLine(point);
//     total += point;
// }
// System.Console.WriteLine(total);


// Самостоятельное задание 2:
// string[] days = { "Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресение" };

// foreach(string day in days)
// {
//     System.Console.WriteLine(day + "!");
// }

// Console.Write("Введите свою фамилию: ");
// string surname = Console.ReadLine()!.Trim();
// if (string.IsNullOrEmpty(surname))
// {
//     Console.WriteLine("Фамилия не введена. Завершение работы.");
//     return;
// }
// Random rnd = new(surname.GetHashCode() + DateTime.Now.DayOfYear);
// var assigned = Enumerable.Range(1, 10)
// .OrderBy(_ => rnd.Next())
// .Take(2)
// .OrderBy(x => x)
// .ToList();
// Console.WriteLine($"Задачи: №{assigned[0]} и №{assigned[1]}");

// string[] names = { "Антон", "Данил", "Миша" };
// int number = 0;
// foreach (string name in names)
// {
//     number += 1;
//     System.Console.WriteLine($"{number}.{name}");
// }




