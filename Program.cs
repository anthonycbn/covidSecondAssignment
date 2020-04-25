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
                Gender = "Male"
            };

            Mentor mentor2 = new Mentor()
            {
                Name = "Ben",
                Location = "Nigeria",
                YearsOfExperience = 4,
                Category = "Ux/UI",
                RegisteredOnZoom = false,
                Gender =  "Male"
            };

            Mentor mentor3 = new Mentor()
            {
                Name = "Maureen",
                Location = "Italy",
                YearsOfExperience = 6,
                Category = "Programming",
                RegisteredOnZoom = true,
                Gender = "Female"
            };

           
            List<Mentor> MentorsList = new List<Mentor>();
            MentorsList.Add(mentor1);
            MentorsList.Add(mentor2);
            MentorsList.Add(mentor3);

            foreach (Mentor m in MentorsList)
            {
                Mentor y = ConvertGender(m);

                Console.WriteLine($"Our Mentor is {y.Name}, {y.DisplayGender} lives in {y.Location}, and has {y.YearsOfExperience} years of experience");
            }

        }

        private static Mentor ConvertGender (Mentor m)
        {
           
            if (m.Gender == "Male")
            {
                m.DisplayGender = "He";
            } 
            else
            {
                m.DisplayGender = "She";
            }
                        
            return m;
        }
    }

}
