namespace TodayBirthday
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>
            {
                new Student("Иванов", "Иван", "Иванович", new DateTime(2005, 12, 10)),
                new Student("Петров", "Петр", "Петрович", new DateTime(2006, 3, 15)),
                new Student("Сидоров", "Андрей", "Андреевич", new DateTime(2005, 6, 20)),
                new Student("Кузнецова", "Анастасия", "Васильевна", new DateTime(2005, 2, 5)),
                new Student("Новиков", "Дмитрий", "Петрович", new DateTime(2006, 9, 12)),
                new Student("Морозов", "Артем", "Сергеевич", new DateTime(2005, 8, 8)),
                new Student("Васильев", "Максим", "Александрович", new DateTime(2006, 11, 18)),
                new Student("Федорова", "Елена", "Алексеевна", new DateTime(2005, 7, 1)),
                new Student("Кошкина", "Ольга", "Сергеевна", new DateTime(2006, 4, 7)),
                new Student("Гаврилов", "Андрей", "Михайлович", new DateTime(2005, 10, 23)),
                new Student("Жукова", "Екатерина", "Андреевна", new DateTime(2006, 1, 30)),
                new Student("Макаров", "Илья", "Алексеевич", new DateTime(2005, 5, 16)),
                new Student("Белова", "Валерия", "Сергеевна", new DateTime(2006, 7, 9)),
                new Student("Крылов", "Алексей", "Иванович", new DateTime(2005, 11, 4)),
                new Student("Смирнова", "Мария", "Игоревна", new DateTime(2006, 2, 28)),
                new Student("Романов", "Антон", "Александрович", new DateTime(2005, 9, 25)),
                new Student("Герасимова", "Софья", "Николаевна", new DateTime(2006, 6, 3)),
                new Student("Буров", "Дмитрий", "Владимирович", new DateTime(2005, 4, 19)),
                new Student("Тарасова", "Анастасия", "Олеговна", new DateTime(2006, 4, 7)),
            };

            DateTime today = DateTime.Today;

            bool isAnyBirthdayToday = false;

            foreach (Student student in students)
            {
                if (student.DateOfBirth.Day == today.Day && student.DateOfBirth.Month == today.Month)
                {
                    isAnyBirthdayToday = true;
                    Console.WriteLine($"{student} празднует сегодня свой день рождения!");
                }
            }

            if (!isAnyBirthdayToday)
            {
                Console.WriteLine("Сегодня никто не празднует день рождения.");
            }
        }
    }
    
}