
namespace School
{
    public struct Lesson
    {
        public string Name { get; private set; }
        public uint NumberOfLectures { get; set; }
        public uint NumberOfTasks { get; set; }

        public Lesson(string name, uint numberOfLectures, uint numberOfTasks)
        {
            this.Name = name;
            this.NumberOfLectures = numberOfLectures;
            this.NumberOfTasks = numberOfTasks;
        }
    }
}
