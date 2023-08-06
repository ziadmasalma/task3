using System.Diagnostics.Metrics;
using task3._2;

List<Employees> employees = new List<Employees>();
int choose = 0;

while (choose != 3)
{
    Console.WriteLine("enter what you want : " +
        "\n1: enter a new employee " +
        "\n2: get data for all employees" +
        "\n3: end project");

    if (!int.TryParse(Console.ReadLine(), out choose))
    {
        Console.WriteLine("Invalid input. Please enter a valid number.");
        continue;
    }

    switch (choose)
    {
        case 1:
            Console.WriteLine("enter the name :");
            string name = Console.ReadLine();
            Console.WriteLine("enter the age ");
            if (!int.TryParse(Console.ReadLine(), out int age))
            {
                Console.WriteLine("Invalid input for age. Please enter a valid number.");
                continue;
            }
            Console.WriteLine("enter the salary");
            if (!float.TryParse(Console.ReadLine(), out float salary))
            {
                Console.WriteLine("Invalid input for salary. Please enter a valid number.");
                continue;
            }
            employees.Add(new Employees(name, age, salary));
            break;
        case 2:
            Console.WriteLine("this is the employee data");
            foreach (Employees employee in employees)
            {
                Console.WriteLine("name : " + employee.name + " age : " + employee.age + " salary : " + employee.salary);
            }
            break;
        case 3:
            Console.WriteLine("Ending the project.");
            break;
        default:
            Console.WriteLine("you entered a wrong number");
            break;
    }
}
