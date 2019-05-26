using System;


namespace School
{
    public class Pupil : IPerson
    {
        //duplicate Guid is hardly ever possible
        public readonly Guid PupilId;

        public string Name { get; set; }
        public string Surname { get; set; }

        public Pupil(string name, string surname)
        {
            Name = name;
            Surname = surname;
            //TO DO: if need, can be implemented extra checking for Guid dublicate
            PupilId = Guid.NewGuid();
        }
    }
}
