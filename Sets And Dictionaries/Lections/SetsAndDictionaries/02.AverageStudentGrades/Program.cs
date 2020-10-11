using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.AverageStudentGrades
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, List<decimal>> students = new Dictionary<string, List<decimal>>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();

                string student = input[0];
                decimal grade = decimal.Parse(input[1]);

                if(!students.ContainsKey(student))
                {
                    students[student] = new List<decimal>();
                    students[student].Add(grade);
                }
                else
                {
                    students[student].Add(grade);
                }
            }

            foreach (var student in students)
            {
                Console.WriteLine($"{student.Key} -> {string.Join(' ', student.Value)} (avg: {String.Format("{0:0.00}", student.Value.Average())})");
            }
        }
    }
}
