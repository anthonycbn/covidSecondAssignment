using System;
using System.Collections.Generic;

namespace testing
{
    class Program
    {
        static void Main(string[] args)
        {
            Mentor mentor1 = new Mentor()
            {
                Name = "Ayo",
                Location = "Canada",
                YearsOfExperience = 10,
                Category = "Coding",
                RegisteredOnZoom = true,
            };

            Mentor mentor2 = new Mentor()
            {
                Name = "Ben",
                Location = "Nigeria",
                YearsOfExperience = 4,
                Category = "Ux/UI",
                RegisteredOnZoom = false,
            };

            List<Mentor> MentorsList = new List<Mentor>();
            MentorsList.Add(mentor1);
            MentorsList.Add(mentor2);

            foreach (Mentor m in MentorsList)
            {
                Console.WriteLine("Our Mentor is {0}, he is lives in {1}, and has {2} years of experience", m.Name, m.Location, m.YearsOfExperience);
            }
        }

    }

}
