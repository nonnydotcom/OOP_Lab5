using System;
using System.Collections.Generic;

namespace LAB5
{
    public class TrainingCourse
    {
        private List<User> attendees = new List<User>();
        private List<ISpeaker> speakers = new List<ISpeaker>();

        public void AddAttendee(User user)
        {
            attendees.Add(user);
        }

        public void AddSpeaker(ISpeaker speaker)
        {
            speakers.Add(speaker);
        }

        public void ShowAllAttendees()
        {
            Console.WriteLine("\n=== List of Attendees ===");
            foreach (var member in attendees)
            {
                member.ShowDetails();
            }
        }

        public void ShowAllSpeakers()
        {
            Console.WriteLine("\n=== List of Speakers & Actions ===");
            foreach (var speaker in speakers)
            {
                if (speaker is User userSpeaker)
                {
                    userSpeaker.ShowDetails();
                }
                speaker.Train();
                speaker.Approve();
                Console.WriteLine("--------------------------------------------------");
            }
        }
    }
}