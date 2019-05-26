using System;
using System.Collections.Generic;

namespace School
{
    public class Teacher : IPerson
    {
        public readonly HashSet<Lesson> lesson = new HashSet<Lesson>();
        public string Name { get; set; }
        public string Surname { get; set; }

        public Teacher(string name, string surname, params Lesson[] lesson)
        {
            Name = name;
            Surname = surname;
            this.lesson = new HashSet<Lesson>(lesson);
        }

        public void Teach()
        {
            Console.WriteLine("I'm teaching");
        }
    }
}
