using System;
using System.Collections.Generic;

namespace School
{
    public class Classroom
    {
        private static List<string> listOfNames;

        public string Name { get; }
        public int NumberOfTeacher { get; }

        static Classroom()
        {
            listOfNames = new List<string>();
        }

        public static Classroom Create(string name, params Teacher[] teachers)
        {
            if (!listOfNames.Contains(name))
            {
                return new Classroom(name, teachers);
            }
            //TO DO: process this condition
            throw new ArgumentNullException() ;
        }
        public static Classroom Create(string name, int numberOfTeachers)
        {
            if (!listOfNames.Contains(name))
            {
                return new Classroom(name, numberOfTeachers);
            }
            //TO DO: process this condition
            throw new ArgumentNullException();
        }

        private Classroom(string name, int numberOfTeachers)
        {
            Name = name;
            listOfNames.Add(name);
            NumberOfTeacher = numberOfTeachers;
        }
        private Classroom(string name, params IPerson[] teachers)
        {
            Name = name;
            listOfNames.Add(name);
            NumberOfTeacher = teachers.Length;
        }
    }
}
