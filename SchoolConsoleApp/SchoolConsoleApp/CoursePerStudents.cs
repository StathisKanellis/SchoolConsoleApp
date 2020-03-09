using System;
using System.Collections.Generic;

namespace SchoolConsoleApp
{
    class CoursePerStudents
    {
        Course Course;
        List<Student> Students;

        public CoursePerStudents(Course course, List<Student> students)
        {
            Course = course;
            Students = students;
            foreach (var item in students)
            {
                item.Course = course;
            }
        }
        public void Output()
        {
            Console.WriteLine();
            Console.WriteLine("~~~~~~~~~~~ Course Per Students ~~~~~~~~~~");
            Console.WriteLine($"  {Course.Title}  -------  {Course.Stream }  -------  {Course.Type}");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            foreach (var item in Students)
            {
                Console.Write("\t");
                Console.WriteLine($" {item.FirstName} {item.LastName} ");
            }
            Console.WriteLine();
        }
    }
}
