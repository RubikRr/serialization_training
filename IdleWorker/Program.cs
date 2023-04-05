using System.Text.Json;

namespace IdleWorker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>()
            {
                new Employee { Name = "John", Experience = 2, IsMarried = false, Salary = 3000 },
                new Employee { Name = "Bob", Experience = 5, IsMarried = true, Salary = 4000 },
                new Employee { Name = "Mike", Experience = 1, IsMarried = false, Salary = 2000 },
                new Employee { Name = "Alex", Experience = 3, IsMarried = true, Salary = 5000 },
                new Employee { Name = "David", Experience = 4, IsMarried = false, Salary = 3500 }
            };
            string jsonStringSer = JsonSerializer.Serialize(employees);
            File.WriteAllText("employees.json", jsonStringSer);

            Console.WriteLine("Employees serialized to employees.json");
            string jsonStringDes = File.ReadAllText("employees.json");

            // Десериализуем список из JSON
            List<Employee> employeesDes = JsonSerializer.Deserialize<List<Employee>>(jsonStringDes);
            // Ищем холостого работника с наименьшим стажем работы
            Employee richestSingleEmployee = new Employee() { Name = "Noname", Experience = 0, IsMarried = false, Salary = 0 };

            foreach (Employee emp in employeesDes)
            {
                if (!emp.IsMarried && emp.Salary > richestSingleEmployee.Salary)
                {
                    richestSingleEmployee = emp;
                }
            }

            if (richestSingleEmployee != null)
            {
                Console.WriteLine($"The richest single employee is {richestSingleEmployee.Name} with a salary of {richestSingleEmployee.Salary}");
            }
            else
            {
                Console.WriteLine("There are no single employees in the list.");
            }
        }
    }
}