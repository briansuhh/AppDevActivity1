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


    }
}
