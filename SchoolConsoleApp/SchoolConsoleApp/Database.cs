using System;
using System.Collections.Generic;

namespace SchoolConsoleApp
{
    class Database
    {
        public List<Course> courses { get; set; }
        public List<Trainer> trainers { get; set; }
        public List<Student> students { get; set; }
        public List<Assignment> assignments { get; set; }
        public List<CoursePerStudents> coursePerStudents { get; set; }
        public List<CoursePerTrainers> coursePerTrainers { get; set; }
        public List<CoursePerAssignments> coursePerAssignments { get; set; }
        public List<AssignmentsPerStudent> assignmentsPerStudent { get; set; }
        public List<StudentsPerCourses> studentsPerCourses { get; set; }
        public Database()
        {
            Course c1 = new Course() { Title = "CB8", Stream = "JAVA", Type = "Full Time", StartDate = new DateTime(2019, 11, 25), EndDate = new DateTime(2020, 03, 15) };
            Course c2 = new Course() { Title = "CB8", Stream = "C#", Type = "Full Time", StartDate = new DateTime(2019, 11, 25), EndDate = new DateTime(2020, 03, 15) };
            Course c3 = new Course() { Title = "CB8", Stream = "JAVA", Type = "Part Time", StartDate = new DateTime(2019, 11, 05), EndDate = new DateTime(2020, 05, 30) };
            Course c4 = new Course() { Title = "CB8", Stream = "C#", Type = "Part Time", StartDate = new DateTime(2019, 11, 05), EndDate = new DateTime(2020, 05, 30) };
            Course c5 = new Course() { Title = "CB8", Stream = "SQL", Type = "Full Time", StartDate = new DateTime(2019, 11, 25), EndDate = new DateTime(2020, 03, 15) };
            Course c6 = new Course() { Title = "CB8", Stream = "CSS", Type = "Full Time", StartDate = new DateTime(2019, 11, 25), EndDate = new DateTime(2020, 03, 15) };
            Course c7 = new Course() { Title = "CB8", Stream = "SQL", Type = "Part Time", StartDate = new DateTime(2019, 11, 05), EndDate = new DateTime(2020, 05, 30) };
            Course c8 = new Course() { Title = "CB8", Stream = "CSS", Type = "Part Time", StartDate = new DateTime(2019, 11, 05), EndDate = new DateTime(2020, 05, 30) };

            courses = new List<Course>() { c1, c2, c3, c4, c5, c6, c7, c8 };

            Trainer tr1 = new Trainer() { FirstName = "George", LastName = "Pasparakis", Subject = "Leader Agademic Programmer" };
            Trainer tr2 = new Trainer() { FirstName = "Konstantinos", LastName = "Zitis", Subject = "Agademic Programmer" };
            Trainer tr3 = new Trainer() { FirstName = "Ektoras", LastName = "Gkatsos", Subject = "Agademic Programmer" };
            Trainer tr4 = new Trainer() { FirstName = "Panagiotis", LastName = "Bozas", Subject = "Programmer Developer" };

            trainers = new List<Trainer>() { tr1, tr2, tr3, tr4 };

            Student st1 = new Student() { FirstName = "Giorgos", LastName = "Poulakos", DateOfBirth = new DateTime(1988, 05, 12), TuitionFees = 2500 };
            Student st2 = new Student() { FirstName = "Thanos", LastName = "Christidis", DateOfBirth = new DateTime(1987, 03, 25), TuitionFees = 2500 };
            Student st3 = new Student() { FirstName = "Kyriakos", LastName = "Zotiadis", DateOfBirth = new DateTime(1990, 06, 05), TuitionFees = 2500 };
            Student st4 = new Student() { FirstName = "Eleni", LastName = "Parisi", DateOfBirth = new DateTime(1989, 11, 22), TuitionFees = 2500 };
            Student st5 = new Student() { FirstName = "Stathis", LastName = "Kanellis", DateOfBirth = new DateTime(1981, 04, 12), TuitionFees = 2500 };
            Student st6 = new Student() { FirstName = "Alexandros", LastName = "Nomikos", DateOfBirth = new DateTime(1976, 04, 07), TuitionFees = 2500 };
            Student st7 = new Student() { FirstName = "Ioannis", LastName = "Manthos", DateOfBirth = new DateTime(1979, 09, 20), TuitionFees = 2500 };
            Student st8 = new Student() { FirstName = "Xenofontas", LastName = "Vlachogiannis", DateOfBirth = new DateTime(1985, 01, 28), TuitionFees = 2500 };
            Student st9 = new Student() { FirstName = "Albi", LastName = "Alikaj", DateOfBirth = new DateTime(1987, 01, 14), TuitionFees = 2500 };
            Student st10 = new Student() { FirstName = "Alexandros", LastName = "Perikleous", DateOfBirth = new DateTime(1990, 07, 10), TuitionFees = 2500 };

            students = new List<Student>() { st1, st2, st3, st4, st5, st6, st7, st8, st9, st10 };

            Assignment a1 = new Assignment() { Title = "Individual Project - Part A", Description = "Design School", SubDateTime = new DateTime(2020, 01, 10), OralMark = 0D, TotalMark = 100D };
            Assignment a2 = new Assignment() { Title = "Individual Project - Part B", Description = "Design Hospital", SubDateTime = new DateTime(2020, 02, 06), OralMark = 0D, TotalMark = 100D };
            Assignment a3 = new Assignment() { Title = "Individual Project - Part C", Description = "Design E-Shop", SubDateTime = new DateTime(2020, 02, 20), OralMark = 0D, TotalMark = 100D };
            Assignment a4 = new Assignment() { Title = "Individual Project - Part D", Description = "Design Hotel", SubDateTime = new DateTime(2020, 04, 21), OralMark = 0D, TotalMark = 100D };
            Assignment a5 = new Assignment() { Title = "Individual Project - Part E", Description = "Design Library", SubDateTime = new DateTime(2020, 05, 18), OralMark = 0D, TotalMark = 100D };

            assignments = new List<Assignment>() { a1, a2, a3, a4, a5 };

            List<Student> studs1 = new List<Student>() { st1, st2, st3, st4};
            List<Student> studs2 = new List<Student>() { st5, st6, st7, st8, st9, st10 };

            CoursePerStudents CPS1 = new CoursePerStudents(c1, studs1);
            CoursePerStudents CPS2 = new CoursePerStudents(c2, studs2);

            coursePerStudents = new List<CoursePerStudents>() { CPS1, CPS2 };

            List<Trainer> trains1 = new List<Trainer>() { tr1, tr2 };
            List<Trainer> trains2 = new List<Trainer>() { tr3, tr4 };

            CoursePerTrainers CPT1 = new CoursePerTrainers(c1, trains1);
            CoursePerTrainers CPT2 = new CoursePerTrainers(c2, trains2);

            coursePerTrainers = new List<CoursePerTrainers>() { CPT1, CPT2 };

            List<Assignment> assign1 = new List<Assignment>() { a1, a2, };
            List<Assignment> assign2 = new List<Assignment>() { a2, a3, };
            List<Assignment> assign3 = new List<Assignment>() { a3, a4, a5 };
            List<Assignment> assign4 = new List<Assignment>() { a4 };
            List<Assignment> assign5 = new List<Assignment>() { a5 };

            CoursePerAssignments CRA1 = new CoursePerAssignments(c2, assign1);
            CoursePerAssignments CRA2 = new CoursePerAssignments(c5, assign2);
            CoursePerAssignments CRA3 = new CoursePerAssignments(c8, assign3);
            CoursePerAssignments CRA4 = new CoursePerAssignments(c7, assign4);
            CoursePerAssignments CRA5 = new CoursePerAssignments(c6, assign5);

            coursePerAssignments = new List<CoursePerAssignments>() { CRA1, CRA2, CRA3, CRA4, CRA5 };

            AssignmentsPerStudent SPCPA1 = new AssignmentsPerStudent(st1, assign1);
            AssignmentsPerStudent SPCPA2 = new AssignmentsPerStudent(st2, assign2);
            AssignmentsPerStudent SPCPA3 = new AssignmentsPerStudent(st3, assign3);
            AssignmentsPerStudent SPCPA4 = new AssignmentsPerStudent(st4, assign1);
            AssignmentsPerStudent SPCPA5 = new AssignmentsPerStudent(st5, assign1);
            AssignmentsPerStudent SPCPA6 = new AssignmentsPerStudent(st6, assign2);
            AssignmentsPerStudent SPCPA7 = new AssignmentsPerStudent(st7, assign3);
            AssignmentsPerStudent SPCPA8 = new AssignmentsPerStudent(st8, assign4);
            AssignmentsPerStudent SPCPA9 = new AssignmentsPerStudent(st9, assign5);
            AssignmentsPerStudent SPCPA10 = new AssignmentsPerStudent(st10, assign5);

            assignmentsPerStudent = new List<AssignmentsPerStudent>() { SPCPA1, SPCPA2, SPCPA3, SPCPA4, SPCPA5, SPCPA6, SPCPA7, SPCPA8, SPCPA9, SPCPA10 };

            StudentsPerCourses SPC1 = new StudentsPerCourses(st1, c1);
            StudentsPerCourses SPC2 = new StudentsPerCourses(st1, c2);
            StudentsPerCourses SPC3 = new StudentsPerCourses(st2, c2);
            StudentsPerCourses SPC4 = new StudentsPerCourses(st2, c3);
            StudentsPerCourses SPC5 = new StudentsPerCourses(st2, c4);
            StudentsPerCourses SPC6 = new StudentsPerCourses(st4, c4);
            StudentsPerCourses SPC7 = new StudentsPerCourses(st4, c5);
            StudentsPerCourses SPC8 = new StudentsPerCourses(st4, c6);
            StudentsPerCourses SPC9 = new StudentsPerCourses(st5, c7);
            StudentsPerCourses SPC10 = new StudentsPerCourses(st5, c8);
            StudentsPerCourses SPC11 = new StudentsPerCourses(st6, c8);
            StudentsPerCourses SPC12 = new StudentsPerCourses(st7, c8);
            StudentsPerCourses SPC13 = new StudentsPerCourses(st8, c8);

            studentsPerCourses = new List<StudentsPerCourses>() { SPC1, SPC2, SPC3, SPC4, SPC5, SPC6, SPC7, SPC8, SPC9, SPC10, SPC11, SPC12, SPC13 };
        }
        public void PrintAllStudents()
        {
            Console.WriteLine($"{"FIRST NAME ",12} | {"LAST NAME    ",16} | {"DATE OF BIRTH",10} | {"TUITION FEES",10} |");
            Console.WriteLine("================================================================");
            foreach (var item in students)
            {
                Console.WriteLine($"{item.FirstName,12} | {item.LastName,16} | {item.DateOfBirth.ToString("d"),13} | {item.TuitionFees,12} |");
            }
            Console.WriteLine();
        }

        public void PrintAllTrainers()
        {
            Console.WriteLine($"{"FIRST NAME ",12} | {"LAST NAME    ",16} | {"SUBJECT           ",29} |");
            Console.WriteLine("=================================================================");
            foreach (var item in trainers)
            {
                Console.WriteLine($"{item.FirstName,12} | {item.LastName,16} | {item.Subject,29} |");
            }
            Console.WriteLine();
        }

        public void PrintAllAssignments()
        {
            Console.WriteLine($"{"TITLE            ",30} | {"DESCRIPTION   ",16} | {"SUB DATE TIME",10} | {"ORAL MARK",10} | {"TOTAL MARK",10} |");
            Console.WriteLine("=============================================================================================");
            foreach (var item in assignments)
            {
                Console.WriteLine($"{item.Title,30} | {item.Description,16} | {item.SubDateTime.ToString("d"),13} | {item.OralMark,10} | {item.TotalMark,10} |");
            }
            Console.WriteLine();
        }

        public void PrintAllCourses()
        {
            Console.WriteLine($"{"TITLE",5} | {"STREAM",6} | {"TYPE  ",9} | {"START DATE",10} | {"END DATE",10} |");
            Console.WriteLine("======================================================");
            foreach (var item in courses)
            {
                Console.WriteLine($"{item.Title,5} | {item.Stream,6} | {item.Type,9} | {item.StartDate.ToString("d"),10} | {item.EndDate.ToString("d"),10} |");
            }
            Console.WriteLine();
        }

        public void PrintCoursePerStudent()
        {
            foreach (var item in coursePerStudents)
            {
                item.Output();
            }
        }

        public void PrintCoursePerTrainers()
        {
            foreach (var item in coursePerTrainers)
            {
                item.Output();
            }
        }

        public void PrintCoursePerAssignments()
        {
            foreach (var item in coursePerAssignments)
            {
                item.Output();
            }
        }

        public void PrintAssignmentsPerStudent()
        {
            foreach (var item in assignmentsPerStudent)
            {
                item.Output();
            }
        }

        public void PrintStudentsPerCourses()
        {
            foreach (var itemstud in students)
            {
                if (itemstud.courses.Count > 1)
                {
                    Console.WriteLine();
                    Console.WriteLine("~~~~~~~~~~~ Students Per Courses ~~~~~~~~~~");
                    Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                    Console.WriteLine($"  {itemstud.FirstName} {itemstud.LastName}");
                    Console.WriteLine();

                    foreach (var item in itemstud.courses)
                    {
                        Console.Write("\t");
                        Console.WriteLine($"{item.Title} {item.Stream} {item.Type}");
                    }
                }

            }
        }

        public void PrintStudentsSubmitAssignments()
        {
            DateTime DateUser;

            Console.WriteLine("~~~~~~~~~~~~~~ Students To Submit Assignments ~~~~~~~~~~~~~~");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine(" Input date to check studen for submit assignments (dd/MM/yyyy): ");
            while (!DateTime.TryParse(Console.ReadLine(), out DateUser))
            {
                Console.WriteLine("Please input date to check (dd/MM/yyyy): ");
            }
            if (DateUser.DayOfWeek == DayOfWeek.Sunday)
            {
                DateUser.AddDays(-6);
            }
            else if (DateUser.DayOfWeek == DayOfWeek.Saturday)
            {
                DateUser.AddDays(-5);
            }
            else if (DateUser.DayOfWeek == DayOfWeek.Friday)
            {
                DateUser.AddDays(-4);
            }
            else if (DateUser.DayOfWeek == DayOfWeek.Thursday)
            {
                DateUser.AddDays(-3);
            }
            else if (DateUser.DayOfWeek == DayOfWeek.Wednesday)
            {
                DateUser.AddDays(-2);
            }
            else if (DateUser.DayOfWeek == DayOfWeek.Tuesday)
            {
                DateUser.AddDays(-1);
            }
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine();
            foreach (var item in students)
            {
                foreach (var assign in item.assignments)
                {
                    if (assign.SubDateTime >= DateUser && assign.SubDateTime <= DateUser.AddDays(4))
                    {
                        Console.WriteLine($" Student: {item.FirstName} {item.LastName}");
                        Console.WriteLine($"\tAssignement: {assign.Title}");
                        Console.WriteLine($"\tSubmission Date: {assign.SubDateTime.ToString("dd/MM/yyyy")}");
                        Console.WriteLine();

                    }
                }
            }


        }
    }
}
