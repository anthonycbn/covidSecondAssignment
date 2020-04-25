using System;
using System.Collections.Generic;
using System.Text;

namespace testing
{
    public class Mentor : Student
    {
        public int YearsOfExperience { get; set; }
        public string Category { get; set; }

    }
    public class Student : Common
    {
        public int NumberOfCourses { get; set; }
    }
    public class Common
    {
        public string Name { get; set; }
        public bool RegisteredOnZoom { get; set; }
        public string Location { get; set; }
        public string Gender { get; set; }
        public string DisplayGender { get; set; }
    }
}
