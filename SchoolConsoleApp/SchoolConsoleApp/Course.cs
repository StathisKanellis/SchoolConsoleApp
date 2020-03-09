using System;
using System.Collections.Generic;

namespace SchoolConsoleApp
{
    class Course
    {
        public string Title { get; set; }
        public string Stream { get; set; }
        public string Type { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public List<Student> students { get; set; } = new List<Student>();
        public List<Trainer> trainers { get; set; } = new List<Trainer>();
        public List<Assignment> assigments { get; set; } = new List<Assignment>();

    }
}
