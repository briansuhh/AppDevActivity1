﻿using System;
using System.Collections.Generic;
using System.Linq;

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

        // Module 4: Search student
        static void SearchStudent()
        {
            Console.Clear();
            Console.Write("Enter name to search: ");
            string query = Console.ReadLine();

            var found = students
                .Where(s => s.FullName.ToLower().Contains(query.ToLower()))
                .ToList();

            if (found.Count == 0)
            {
                Console.WriteLine("No matching student found.");
            }
            else
            {
                foreach (var s in found)
                {
                    Console.WriteLine($"ID: {s.Id}, Name: {s.FullName}, Course: {s.Course}");
                }
            }

            Console.WriteLine("Press Enter to continue.");
            Console.ReadLine();
        }

        // Module 5: Delete student
        static void DeleteStudent()
        {
            Console.Clear();
            Console.Write("Enter ID to delete: ");
            if (int.TryParse(Console.ReadLine(), out int id))
            {
                var student = students.FirstOrDefault(s => s.Id == id);
                if (student != null)
                {
                    students.Remove(student);
                    Console.WriteLine("Student deleted.");
                }
                else
                {
                    Console.WriteLine("Student not found.");
                }
            }
            else
            {
                Console.WriteLine("Invalid input.");
            }

            Console.WriteLine("Press Enter to continue.");
            Console.ReadLine();
        }

        // Inner class for student data
        class Student
        {
            public int Id { get; set; }
            public string FullName { get; set; }
            public string Course { get; set; }
        }
    }
}
