using System;

namespace AdmissionManagement
{
    public class Student
    {
        private string name;
        private int age;
        private string course;
        private string status;

        public Student(string studentName, int studentAge, string selectedCourse)
        {
            name = studentName;
            age = studentAge;
            course = selectedCourse;
            status = "Pending";
        }

        public void ProcessAdmission()
        {
            if (age >= 18)
            {
                status = "Admitted";
            }
            else
            {
                status = "Rejected (Underage)";
            }
        }

        public void DisplayDetails()
        {
            Console.WriteLine($"Student: {name} | Age: {age} | Course: {course} | Status: {status}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- Student Admission System --- \n");

            Student student1 = new Student("Venisha", 19, "Computer Science");
            Student student2 = new Student("Hardi", 16, "Mathematics");
            Student student3 = new Student("Rahul", 18, "Physics");

            student1.ProcessAdmission();
            student2.ProcessAdmission();
            student3.ProcessAdmission();

            student1.DisplayDetails();
            student2.DisplayDetails();
            student3.DisplayDetails();

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadLine();
        }
    }
}