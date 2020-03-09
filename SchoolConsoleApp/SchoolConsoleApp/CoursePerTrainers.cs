using System;
using System.Collections.Generic;

namespace SchoolConsoleApp
{
    class CoursePerTrainers
    {
        Course Course;
        List<Trainer> Trainers;

        public CoursePerTrainers(Course course, List<Trainer> trainers)
        {
            Course = course;
            Trainers = trainers;
            foreach (var item in trainers)
            {
                item.course = course;
            }
        }

        public void Output()
        {
            Console.WriteLine();
            Console.WriteLine("~~~~~~~~~~~ Course Per Trainers ~~~~~~~~~~");
            Console.WriteLine($"  {Course.Title}  -------  {Course.Stream }  -------  {Course.Type}");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            foreach (var item in Trainers)
            {
                Console.Write("\t");
                Console.WriteLine($" {item.FirstName} {item.LastName} ");
            }
        }
    }
}
