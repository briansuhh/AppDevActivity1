using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDevActivity1
{
    internal class Program
    {
        // In-memory list of students
        static List<Student> students = new List<Student>();
        static int nextId = 1;
        static void Main(string[] args)
        {
            ShowMenu();
        }

        // Module 1: Display menu
        static void ShowMenu()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("=== Student Management System ===");
                Console.WriteLine("1. Add Student");
                Console.WriteLine("2. List Students");
                Console.WriteLine("3. Search Student");
                Console.WriteLine("4. Delete Student");
                Console.WriteLine("5. Exit");
                Console.Write("Choose an option: ");

                switch (Console.ReadLine())
                {
                    case "1": AddStudent(); break;
                    case "2": ListStudents(); break;
                    case "3": SearchStudent(); break;
                    case "4": DeleteStudent(); break;
                    case "5": return;
                    default: Console.WriteLine("Invalid option. Press Enter to continue."); Console.ReadLine(); break;
                }
            }
        }

        // Module 2: Add student
        static void AddStudent()
        {
            Console.Clear();
            Console.WriteLine("=== Add New Student ===");
            Console.Write("Full Name: ");
            string name = Console.ReadLine();
            Console.Write("Course: ");
            string course = Console.ReadLine();

            students.Add(new Student
            {
                Id = nextId++,
                FullName = name,
                Course = course
            });

            Console.WriteLine("Student added! Press Enter to continue.");
            Console.ReadLine();
        }

        // Module 3: List students
        static void ListStudents()
        {
            Console.Clear();
            Console.WriteLine("=== Student List ===");

            if (students.Count == 0)
            {
                Console.WriteLine("No students found.");
            }
            else
            {
                foreach (var s in students)
                {
                    Console.WriteLine($"ID: {s.Id}, Name: {s.FullName}, Course: {s.Course}");
                }
            }

            Console.WriteLine("Press Enter to continue.");
            Console.ReadLine();
        }
    }
}
