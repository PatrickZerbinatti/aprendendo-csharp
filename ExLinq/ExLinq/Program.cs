using System;
using System.IO;
using System.Collections.Generic;
using ExLinq.Entities;
using System.Linq;
using System.Globalization;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"c:\temp\in.txt";

            Console.Write("Enter Salary: ");
            double salary = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            List<Employee> employees = new List<Employee>();
            try { 
                using (StreamReader sr = File.OpenText(path)) 
                { 
                    while (!sr.EndOfStream) 
                    {
                        string[] columns = sr.ReadLine().Split(',');
                        employees.Add(new Employee(columns[0], columns[1], double.Parse(columns[2],CultureInfo.InvariantCulture)));
                    }

                    var email = employees.Where(e => e.Salary > salary).OrderBy(e => e.Email).Select( e => e.Email);
                    Console.WriteLine($"Email of people whose salary is more than {salary.ToString("F2", CultureInfo.InvariantCulture)}: ");
                    foreach (string str in email) 
                    { 
                        Console.WriteLine(str); 
                    }
                    var sumSalary = employees.Where(e => e.Name[0] == 'M').Sum(e => e.Salary);

                    Console.WriteLine("Sum of salary of people whose name starts with 'M': " + sumSalary.ToString("F2",CultureInfo.InvariantCulture));

                } 
            } catch (IOException e) 
            { 
                Console.WriteLine("An error occurred"); Console.WriteLine(e.Message); 
            }
        }
    }
}