using System;

namespace LAB5
{
    public class Student : User, IMember
    {
        private string major;
        private string studentId;

        public void SetStudentInfo(string major, string studentId)
        {
            this.major = major;
            this.studentId = studentId;
        }

        public void Register()
        {
            Console.WriteLine($"[Student] {firstname} {lastname} has successfully registered.");
        }

        public override void ShowDetails()
        {
            Console.WriteLine($"Student: {firstname} {lastname}, ID: {studentId}, Major: {major}, Phone: {phone}, Email: {email}");
        }
    }
}