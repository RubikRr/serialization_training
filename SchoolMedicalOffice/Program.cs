using System.Text.Json;

namespace SchoolMedicalOffice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> studentsSer = new List<Student>
            {
                new Student("Иванов", "1А", "головная боль"),
                new Student ("Петров", "2Б", "температура"),
                new Student("Сидоров", "3Г", "головная боль"),
                new Student ("Кузнецов", "4А", "боль в горле"),
                new Student("Васильев", "1Б", "головная боль"),
                new Student ("Михайлов", "2А", "кашель"),
                new Student("Новиков", "3Б", "головная боль"),
                new Student ("Козлов", "4Б", "ушибы"),
                new Student("Зайцев", "1Г", "головная боль"),
                new Student ("Соколов", "2Г", "боль в животе"),
                new Student ("Попов", "3А", "головная боль"),
                new Student ("Лебедев", "4Г", "обморок")
            };

            // Сериализуем список в JSON и записываем его в файл
            string jsonStringSer = JsonSerializer.Serialize(studentsSer);
            File.WriteAllText("students.json", jsonStringSer);

            string jsonStringDes = File.ReadAllText("students.json");

            // Десериализуем список из JSON
            List<Student> studentsDes = JsonSerializer.Deserialize<List<Student>>(jsonStringDes);

            Console.WriteLine("Ученики младших классов, обращавшиеся с головной болью:");

            foreach (Student student in studentsDes)
            {
                if (student.Class.StartsWith("1") || student.Class.StartsWith("2") || student.Class.StartsWith("3"))
                {
                    if (student.Reason == "головная боль")
                    {
                        Console.WriteLine(student.LastName);
                    }
                }
            }
        }
    }
}