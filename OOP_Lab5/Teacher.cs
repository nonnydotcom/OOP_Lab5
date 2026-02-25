using System;

namespace LAB5
{
    public class Teacher : User, IMember, ISpeaker
    {
        private string major;
        private string academicPosition;

        public void SetTeacherInfo(string major, string academicPosition)
        {
            this.major = major;
            this.academicPosition = academicPosition;
        }

        public void Register()
        {
            Console.WriteLine($"[Teacher] {academicPosition} {firstname} {lastname} has successfully registered.");
        }

        public void Train()
        {
            Console.WriteLine($"[Speaker] Teacher {firstname} is conducting the training session.");
        }

        public void Approve()
        {
            Console.WriteLine($"[Speaker] Teacher {firstname} has approved the training results.");
        }

        public override void ShowDetails()
        {
            Console.WriteLine($"Teacher: {academicPosition} {firstname} {lastname}, Major: {major}, Phone: {phone}, Email: {email}");
        }
    }
}