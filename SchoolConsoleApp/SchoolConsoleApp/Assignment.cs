using System;

namespace SchoolConsoleApp
{
    class Assignment
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime SubDateTime { get; set; }
        public double OralMark { get; set; }
        public double TotalMark { get; set; }
        public Course course;
        public Student student;

    }
}
