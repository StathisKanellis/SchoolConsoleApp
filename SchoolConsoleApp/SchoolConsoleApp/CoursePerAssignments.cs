using System;
using System.Collections.Generic;

namespace SchoolConsoleApp
{
    class CoursePerAssignments
    {
        Course Course;
        List<Assignment> Assignments;

        public CoursePerAssignments(Course course, List<Assignment> assignments)
        {
            Course = course;
            Assignments = assignments;
            foreach (var item in assignments)
            {
                item.course = course;
            }
        }

        public void Output()
        {
            Console.WriteLine();
            Console.WriteLine("~~~~~~~~~~~ Course Per Assignments ~~~~~~~~~~");
            Console.WriteLine($"  {Course.Title}  -------  { Course.Stream}  -------  {Course.Type}");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            foreach (var item in Assignments)
            {
                Console.Write("\t");
                Console.WriteLine($" {item.Title}   {item.Description} ");
            }

        }
    }
}
