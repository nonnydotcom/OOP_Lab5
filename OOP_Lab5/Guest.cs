using System;

namespace LAB5
{
    public class Guest : User, IMember, ISpeaker
    {
        private string workplace;
        private string jobPosition;

        public void SetGuestInfo(string workplace, string jobPosition)
        {
            this.workplace = workplace;
            this.jobPosition = jobPosition;
        }

        public void Register()
        {
            Console.WriteLine($"[Guest] {firstname} {lastname} has successfully registered.");
        }

        public void Train()
        {
            Console.WriteLine($"[Speaker] Mr./Ms. {firstname} is conducting the training session.");
        }

        public void Approve()
        {
            Console.WriteLine($"[Speaker] Mr./Ms. {firstname} has approved the training results.");
        }

        public override void ShowDetails()
        {
            Console.WriteLine($"Guest: {firstname} {lastname}, Position: {jobPosition}, Workplace: {workplace}, Phone: {phone}, Email: {email}");
        }
    }
}