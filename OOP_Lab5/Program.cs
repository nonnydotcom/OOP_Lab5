using System;

namespace LAB5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            TrainingCourse course = new TrainingCourse();

            bool isRunning = true;

            while (isRunning)
            {
                Console.WriteLine("\n=== Training Registration System ===");
                Console.WriteLine("1. Add a new member");
                Console.WriteLine("2. Show all members and speakers");
                Console.WriteLine("3. Exit");
                Console.Write("Please select an option (1-3): ");

                string choice = Console.ReadLine();

                if (choice == "1")
                {
                    Console.WriteLine("\n--- Select Role ---");
                    Console.WriteLine("1. Student");
                    Console.WriteLine("2. Teacher");
                    Console.WriteLine("3. Guest");
                    Console.Write("Select role (1-3): ");
                    string roleChoice = Console.ReadLine();

                    if (roleChoice == "1" || roleChoice == "2" || roleChoice == "3")
                    {
                        Console.Write("Firstname: ");
                        string fName = Console.ReadLine();
                        Console.Write("Lastname: ");
                        string lName = Console.ReadLine();
                        Console.Write("Phone: ");
                        string phone = Console.ReadLine();
                        Console.Write("Email: ");
                        string email = Console.ReadLine();

                        if (roleChoice == "1")
                        {
                            Student newStudent = new Student();
                            Console.Write("Major: ");
                            string major = Console.ReadLine();
                            Console.Write("Student ID: ");
                            string studentId = Console.ReadLine();

                            newStudent.SetUserInfo(fName, lName, phone, email);
                            newStudent.SetStudentInfo(major, studentId);
                            newStudent.Register();
                            course.AddAttendee(newStudent);
                        }
                        else if (roleChoice == "2")
                        {
                            Teacher newTeacher = new Teacher();
                            Console.Write("Major: ");
                            string major = Console.ReadLine();
                            Console.Write("Academic Position (e.g., Asst. Prof.): ");
                            string position = Console.ReadLine();

                            newTeacher.SetUserInfo(fName, lName, phone, email);
                            newTeacher.SetTeacherInfo(major, position);
                            newTeacher.Register();
                            course.AddAttendee(newTeacher);
                            course.AddSpeaker(newTeacher);
                        }
                        else if (roleChoice == "3")
                        {
                            Guest newGuest = new Guest();
                            Console.Write("Workplace: ");
                            string workplace = Console.ReadLine();
                            Console.Write("Job Position: ");
                            string position = Console.ReadLine();

                            newGuest.SetUserInfo(fName, lName, phone, email);
                            newGuest.SetGuestInfo(workplace, position);
                            newGuest.Register();
                            course.AddAttendee(newGuest);
                            course.AddSpeaker(newGuest);
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid role. Going back to main menu.");
                    }
                }
                else if (choice == "2")
                {
                    course.ShowAllAttendees();
                    course.ShowAllSpeakers();
                }
                else if (choice == "3")
                {
                    isRunning = false;
                    Console.WriteLine("Exiting the program... Goodbye!");
                }
                else
                {
                    Console.WriteLine("Invalid choice! Please enter 1, 2, or 3.");
                }
            }
        }
    }
}