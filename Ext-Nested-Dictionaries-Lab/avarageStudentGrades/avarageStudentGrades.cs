using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class avarageStudentGrades
{
    static void Main()
    {
        var studentsGrades = new Dictionary<string, List<double>>();
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            string[] input = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            string studentName = input[0];
            double studentGrade = double.Parse(input[1]);

            if (!studentsGrades.ContainsKey(studentName))
            {
                studentsGrades[studentName] = new List<double>();
            }

            studentsGrades[studentName].Add(studentGrade);
        }

        foreach (KeyValuePair<string, List<double>> student in studentsGrades)
        {
            string studentName = student.Key;
            List<double> studentGrade = student.Value;
            double avg = studentGrade.Average();

            Console.Write("{0} -> ", studentName);
            foreach (var grade in studentGrade)
            {
                Console.Write("{0:F2} ", grade);
            }
            
            Console.WriteLine("(avg: {0:F2})", avg);
        }
    }
}


