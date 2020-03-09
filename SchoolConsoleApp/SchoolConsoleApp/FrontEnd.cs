using System;

namespace SchoolConsoleApp
{
    class FrontEnd
    {
        static Database db = new Database();

        public static void Start()
        {
            Console.Clear();
            ShowMenou();


            string choice = InputChoiceMenou();

            if (choice == "1")
            {
                // Input Data
                InputData();
            }
            else if (choice == "2")
            {
                // Synthetic Data
                InputSynthetic();
            }
            else if (choice == "3")
            {
                // Exit
                Exit.CheckToExitProgram();
            }
        }


        public static void InputSynthetic()
        {
            ShowSynthetic();
            string input = InputChoiceSynthetic();
            if (input == "1")
            {
                //Courses menu
                InputCourses();
            }
            else if (input == "2")
            {
                //Trainers menu
                InputTrainers();
            }
            else if (input == "3")
            {
                //Students menu
                InputStudents();
            }
            else if (input == "4")
            {
                //Assignments menu
                InputAssignments();
            }
            else if (input == "5")
            {
                //Exit
                Exit.CheckToExitFolderSyntetic();
            }

        }

        private static Course InputDataCourse()
        {
            Console.WriteLine();
            Console.WriteLine("______INPUT DATA - COURSE______");
            Console.WriteLine();
            Console.WriteLine("Give Title Course: ");
            string title = Console.ReadLine();
            Console.WriteLine("Give Stream Course: ");
            string stream = Console.ReadLine();
            Console.WriteLine("Give Type Course: ");
            string type = Console.ReadLine();
            Console.WriteLine();
            DateTime startDate;
            while (!DateTime.TryParse(Console.ReadLine(), out startDate))
            {
                Console.WriteLine("Give Start Date Course (yyyy/MM/dd): ");
            }
            DateTime endDate;
            while (!DateTime.TryParse(Console.ReadLine(), out endDate))
            {
                Console.WriteLine("Give End Date Course (yyyy/MM/dd): ");
            }
            Course course = new Course() { Title = title, Stream = stream, Type = type, StartDate = startDate, EndDate = endDate };
            return course;
        }

        private static Trainer InputDataTrainer()
        {
            Console.WriteLine();
            Console.WriteLine("______INPUT DATA - TRAINER______");
            Console.WriteLine();
            Console.WriteLine("Give First Name: ");
            string firstname = Console.ReadLine();
            Console.WriteLine("Give Last Name: ");
            string lastname = Console.ReadLine();
            Console.WriteLine("Give Last Name: ");
            string subject = Console.ReadLine();

            Trainer trainer = new Trainer() { FirstName = firstname, LastName = lastname, Subject = subject };
            return trainer;
        }

        private static Student InputDataStudent()
        {
            Console.WriteLine();
            Console.WriteLine("______INPUT DATA - STUDENT______");
            Console.WriteLine();
            Console.WriteLine("Give First Name: ");
            string firstname = Console.ReadLine();
            Console.WriteLine("Give Last Name: ");
            string lastname = Console.ReadLine();
            Console.WriteLine("Give Birthday (yyyy/MM/dd): ");
            DateTime birth;
            while (!DateTime.TryParse(Console.ReadLine(), out birth))
            {
                Console.WriteLine("Please input date to check (yyyy/MM/dd): ");
            }
            int tuitionFees;
            Console.WriteLine("Give Tuition Fees: ");
            string tuition = Console.ReadLine();
            bool check = int.TryParse(tuition, out tuitionFees);
            Student student = new Student() { FirstName = firstname, LastName = lastname, DateOfBirth = birth, TuitionFees = tuitionFees };
            return student;
        }

        private static Assignment InputDataAssignment()
        {
            Console.WriteLine();
            Console.WriteLine("______INPUT DATA - ASSIGNMENT______");
            Console.WriteLine();
            Console.WriteLine("Give Title Assignment: ");
            string title = Console.ReadLine();
            Console.WriteLine("Give Description Assignment: ");
            string description = Console.ReadLine();
            Console.WriteLine("Give Submission Assignment (yyyy/MM/dd): ");
            DateTime subTime;
            while (!DateTime.TryParse(Console.ReadLine(), out subTime))
            {
                Console.WriteLine("Please input date to check (yyyy/MM/dd): ");
            }
            double oralMark;
            Console.WriteLine("Give Oral Mark Assignment: ");
            string userCheck = Console.ReadLine();
            bool check = double.TryParse(userCheck, out oralMark);
            double totalMark;
            Console.WriteLine("Give Total Mark Assignment: ");
            string userCheck2 = Console.ReadLine();
            bool check2 = double.TryParse(userCheck2, out totalMark);
            Assignment assignment = new Assignment() { Title = title, Description = description, SubDateTime = subTime, OralMark = oralMark, TotalMark = totalMark };
            return assignment;
        }

        public static void InputData()
        {
            ShowInputData();
            string input = InputChoiceSynthetic();
            if (input == "1")
            {
                //Input Courses menu
                Course c12 = InputDataCourse();
                db.courses.Add(c12);
                InputData();
            }
            else if (input == "2")
            {
                //Input Trainers menu
                Trainer tr7 = InputDataTrainer();
                db.trainers.Add(tr7);
                InputData();
            }
            else if (input == "3")
            {
                //Input Students menu
                Student st11 = InputDataStudent();
                db.students.Add(st11);
                InputData();
            }
            else if (input == "4")
            {
                //Input Assignments menu
                Assignment a10 = InputDataAssignment();
                db.assignments.Add(a10);
                InputData();
            }
            else if (input == "5")
            {
                //Exit
                Exit.CheckToExitFolderInput();
            }

        }

        public static void InputCourses()
        {
            ShowCourses();
            string input = InputChoiceCourses();
            if (input == "1")
            {
                // Print All Courses
                db.PrintAllCourses();
                Exit.CheckAfterPrintSynteticCourses();
            }
            else if (input == "2")
            {
                //Print Course Per Trainers
                db.PrintCoursePerTrainers();
                Exit.CheckAfterPrintSynteticCourses();
            }
            else if (input == "3")
            {
                //Print Course Per Students
                db.PrintCoursePerStudent();
                Exit.CheckAfterPrintSynteticCourses();
            }
            else if (input == "4")
            {
                //Print Course Per Assignments
                db.PrintCoursePerAssignments();
                Exit.CheckAfterPrintSynteticCourses();
            }
            else if (input == "5")
            {
                //Exit
                Exit.CheckToExitFolderSyntetic();
            }


        }

        private static void InputTrainers()
        {
            ShowTrainers();
            string input = InputChoiceTrainers();
            if (input == "1")
            {
                // Print All Trainers
                db.PrintAllTrainers();
                InputSynthetic();
            }
            else if (input == "2")
            {
                //Exit
                Exit.CheckToExitFolderSyntetic();
            }


        }

        public static void InputStudents()
        {
            ShowStudents();
            string input = InputChoiceStudens();
            if (input == "1")
            {
                // Print All Students
                db.PrintAllStudents();
                Exit.CheckAfterPrintSynteticStudents();
            }
            else if (input == "2")
            {
                //Print Students Per Courses
                db.PrintStudentsPerCourses();
                Exit.CheckAfterPrintSynteticStudents();
            }
            else if (input == "3")
            {
                //Print Students Submit Assignments
                db.PrintStudentsSubmitAssignments();
                Exit.CheckAfterPrintSynteticStudents();
            }
            else if (input == "4")
            {
                //Exit
                Exit.CheckToExitFolderSyntetic();
            }

        }

        public static void InputAssignments()
        {
            ShowAssignments();
            string input = InputChoiceAssignments();
            if (input == "1")
            {
                // Print All Assignmets
                db.PrintAllAssignments();
                Exit.CheckAfterPrintSynteticAssignments();
            }
            else if (input == "2")
            {
                //Print Assignments Per Students
                db.PrintAssignmentsPerStudent();
                Exit.CheckAfterPrintSynteticAssignments();
            }
            else if (input == "3")
            {
                //Exit
                Exit.CheckToExitFolderSyntetic();
            }

        }

        private static string InputChoiceMenou()
        {
            Console.Write(" Press: ");
            string input = Console.ReadLine();
            while (input != "1" && input != "2" && input != "3")
            {
                Console.WriteLine("Please insert correct value");
                Console.Write(" Press: ");
                input = Console.ReadLine();
            }

            return input;
        }

        private static void ShowMenou()
        {
            Console.WriteLine("***************");
            Console.WriteLine("  ___MENU___  ");
            Console.WriteLine("***************");
            Console.WriteLine(" 1 - Input Data");
            Console.WriteLine(" 2 - Synthetic Data");
            Console.WriteLine(" 3 - Exit");
            Console.WriteLine("***************");
        }

        private static void ShowInputData()
        {
            Console.WriteLine("***************************");
            Console.WriteLine("___INPUT DATA - MENU___");
            Console.WriteLine("***************************");
            Console.WriteLine(" 1 - Input Course ");
            Console.WriteLine(" 2 - Input Trainer ");
            Console.WriteLine(" 3 - Input Student ");
            Console.WriteLine(" 4 - Input Assignmgent ");
            Console.WriteLine(" 5 - EXIT");
            Console.WriteLine("***************************");
        }

        private static void ShowSynthetic()
        {
            Console.WriteLine("***************************");
            Console.WriteLine("___SYNTHETIC DATA - MENU___");
            Console.WriteLine("***************************");
            Console.WriteLine(" 1 - Course menu");
            Console.WriteLine(" 2 - Trainer menu");
            Console.WriteLine(" 3 - Student menu");
            Console.WriteLine(" 4 - Assignmgent menu");
            Console.WriteLine(" 5 - EXIT");
            Console.WriteLine("***************************");
        }

        private static void ShowCourses()
        {
            Console.WriteLine("*****************");
            Console.WriteLine("___COURSE MENU___");
            Console.WriteLine("*****************");
            Console.WriteLine(" 1 - Print All Course");
            Console.WriteLine(" 2 - Print Course Per Trainers");
            Console.WriteLine(" 3 - Print Course Per Student");
            Console.WriteLine(" 4 - Print Course Per Assignmgents");
            Console.WriteLine(" 5 - EXIT");
            Console.WriteLine("*****************");
        }

        private static void ShowTrainers()
        {
            Console.WriteLine("******************");
            Console.WriteLine("___TRAINER MENU___");
            Console.WriteLine("******************");
            Console.WriteLine(" 1 - Print All Trainers");
            Console.WriteLine(" 2 - EXIT");
            Console.WriteLine("******************");
        }

        private static void ShowStudents()
        {
            Console.WriteLine("******************");
            Console.WriteLine("___STUDENT MENU___");
            Console.WriteLine("******************");
            Console.WriteLine(" 1 - Print All Students");
            Console.WriteLine(" 2 - Print Students Per Courses");
            Console.WriteLine(" 3 - Print Students Submit Assignments");
            Console.WriteLine(" 4 - EXIT");
            Console.WriteLine("******************");
        }

        private static void ShowAssignments()
        {
            Console.WriteLine("******************");
            Console.WriteLine("___ASSIGNMENT MENU___");
            Console.WriteLine("******************");
            Console.WriteLine(" 1 - Print All Assignments");
            Console.WriteLine(" 2 - Print Assignments Per Students");
            Console.WriteLine(" 3 -  EXIT");
            Console.WriteLine("******************");
        }

        private static string InputChoiceSynthetic()
        {
            Console.Write(" Press: ");
            string input = Console.ReadLine();
            while (input != "1" && input != "2" && input != "3" && input != "4" && input != "5")
            {
                Console.WriteLine("Please insert correct value");
                Console.Write(" Press: ");
                input = Console.ReadLine();
            }

            return input;
        }

        private static string InputChoiceCourses()
        {
            Console.Write(" Press: ");
            string input = Console.ReadLine();
            while (input != "1" && input != "2" && input != "3" && input != "4" && input != "5")
            {
                Console.WriteLine("Please insert correct value");
                Console.Write(" Press: ");
                input = Console.ReadLine();
            }

            return input;
        }

        private static string InputChoiceTrainers()
        {
            Console.Write(" Press: ");
            string input = Console.ReadLine();
            while (input != "1" && input != "2")
            {
                Console.WriteLine("Please insert correct value");
                Console.Write(" Press: ");
                input = Console.ReadLine();
            }

            return input;
        }

        private static string InputChoiceStudens()
        {
            Console.Write(" Press: ");
            string input = Console.ReadLine();
            while (input != "1" && input != "2" && input != "3" && input != "4")
            {
                Console.WriteLine("Please insert correct value");
                Console.Write(" Press: ");
                input = Console.ReadLine();
            }

            return input;
        }

        private static string InputChoiceAssignments()
        {
            Console.Write(" Press: ");
            string input = Console.ReadLine();
            while (input != "1" && input != "2" && input != "3")
            {
                Console.WriteLine("Please insert correct value");
                Console.Write(" Press: ");
                input = Console.ReadLine();
            }

            return input;
        }
    }
}
