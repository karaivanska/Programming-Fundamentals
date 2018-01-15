using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

class filterBase
{
    static void Main()
    {
        Dictionary<string, string> employeesPosition = new Dictionary<string, string>();
        Dictionary<string, int> employeesAge = new Dictionary<string, int>();
        Dictionary<string, double> employeesSalary = new Dictionary<string, double>();

        var input = Console.ReadLine();

        while (input != "filter base")
        {
            var commandArgs = input.Split(new char[] { ' ', '-', '>' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

            string name = commandArgs[0];
            string value = commandArgs[1];

            int age = 0;
            double salary = 0;

            if (int.TryParse(value, out age))
            {
                employeesAge[name] = age;
            }
            else if (double.TryParse(value, out salary))
            {
                employeesSalary[name] = salary;
            }
            else
            {
                employeesPosition[name] = value;
            }


            input = Console.ReadLine();
        }

         input = Console.ReadLine().ToLower();

        if (input == "position")
        {
            foreach (KeyValuePair<string, string> employee in employeesPosition)
            {
                Console.WriteLine($"Name: {employee.Key}");
                Console.WriteLine($"Position: {employee.Value}");
                Console.WriteLine(new string('=', 20));
            }
        }
        else if (input == "salary")
        {
            foreach (KeyValuePair<string, double> employee in employeesSalary)
            {
                Console.WriteLine($"Name: {employee.Key}");
                Console.WriteLine($"Salary: {employee.Value:F2}");
                Console.WriteLine(new string('=', 20));
            }
        }
        else
        {
            foreach (KeyValuePair<string, int> employee in employeesAge)
            {
                Console.WriteLine($"Name: {employee.Key}");
                Console.WriteLine($"Age: {employee.Value}");
                Console.WriteLine(new string('=', 20));
            }
        }
    }
}


