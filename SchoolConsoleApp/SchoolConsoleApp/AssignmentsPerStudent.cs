using System;
using System.Collections.Generic;

namespace SchoolConsoleApp
{
    class AssignmentsPerStudent
    {
        Student Student;
        List<Assignment> Assignments;


        public AssignmentsPerStudent(Student student, List<Assignment> assignments)
        {

            Student = student;
            student.assignments = assignments;
            Assignments = assignments;
            foreach (var item in assignments)
            {
                item.student = student;
            }
        }

        public void Output()
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("~~~~~~~~~~~ Assignments Per Students ~~~~~~~~~~");

            Console.WriteLine($"Course: {Student.Course.Title} - {Student.Course.Stream} - {Student.Course.Type} ");
            Console.WriteLine($"Student: {Student.FirstName}  {Student.LastName}");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");

            foreach (var item in Assignments)
            {
                Console.Write("\t");
                Console.WriteLine($" {item.Title}   {item.Description} ");
            }

        }
    }
}
