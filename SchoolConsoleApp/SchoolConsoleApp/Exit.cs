using System;

namespace SchoolConsoleApp
{
    class Exit
    {
        public static void CheckToExitProgram()
        {
            Console.WriteLine("Do you want to EXIT from PROGRAM: y/n? ");
            string user = Console.ReadLine();
            while (user != "y" && user != "n")
            {
                Console.WriteLine("Please insert correct value");
                Console.Write(" Chose: ");
                user = Console.ReadLine();
            }
            if (user == "n")
                FrontEnd.Start();
        }

        public static void CheckToExitFolderSyntetic()
        {
            Console.WriteLine("Do you want to EXIT from Menu: y/n? ");
            string user = Console.ReadLine();
            while (user != "y" && user != "n")
            {
                Console.WriteLine("Please insert correct value");
                Console.Write(" Chose: ");
                user = Console.ReadLine();
            }
            if (user == "y")
            {
                FrontEnd.Start();
            }
            else
            {
                FrontEnd.InputSynthetic();
            }

        }

        public static void CheckAfterPrintSynteticCourses()
        {
            Console.WriteLine("Do you want to EXIT from Menu: y/n? ");
            string user = Console.ReadLine();
            while (user != "y" && user != "n")
            {
                Console.WriteLine("Please insert correct value");
                Console.Write(" Chose: ");
                user = Console.ReadLine();
            }
            if (user == "y")
            {
                FrontEnd.InputSynthetic();
            }
            else
            {
                FrontEnd.InputCourses();
            }

        }

        public static void CheckAfterPrintSynteticStudents()
        {
            Console.WriteLine("Do you want to EXIT from Menu: y/n? ");
            string user = Console.ReadLine();
            while (user != "y" && user != "n")
            {
                Console.WriteLine("Please insert correct value");
                Console.Write(" Chose: ");
                user = Console.ReadLine();
            }
            if (user == "y")
            {
                FrontEnd.InputSynthetic();
            }
            else
            {
                FrontEnd.InputStudents();
            }

        }

        public static void CheckAfterPrintSynteticAssignments()
        {
            Console.WriteLine("Do you want to EXIT from Menu: y/n? ");
            string user = Console.ReadLine();
            while (user != "y" && user != "n")
            {
                Console.WriteLine("Please insert correct value");
                Console.Write(" Chose: ");
                user = Console.ReadLine();
            }
            if (user == "y")
            {
                FrontEnd.InputSynthetic();
            }
            else
            {
                FrontEnd.InputAssignments();
            }

        }


        public static void CheckToExitFolderInput()
        {
            Console.WriteLine("Do you want to EXIT from Menu: y/n? ");
            string user = Console.ReadLine();
            while (user != "y" && user != "n")
            {
                Console.WriteLine("Please insert correct value");
                Console.Write(" Chose: ");
                user = Console.ReadLine();
            }
            if (user == "y")
            {
                FrontEnd.Start();
            }
            else
            {
                FrontEnd.InputData();
            }
        }
    }
}
