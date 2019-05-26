using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace School.Tests
{
    [TestClass()]
    public class LessonTest
    {
        [TestMethod()]
        public void Constructor_CallConstructor_ParametrsAreCorrect()
        {
            //Arrange
            string expectedName = "CS";
            uint expectedNumberOfLectures = 12;
            uint expectedNumberOfTasks = 11;
            //Act
            Lesson lesson = new Lesson("CS", 12, 11);
            //Assert
            Assert.AreEqual(expectedName, lesson.Name);
            Assert.AreEqual(expectedNumberOfLectures, lesson.NumberOfLectures);
            Assert.AreEqual(expectedNumberOfTasks, lesson.NumberOfTasks);
        }
    }
}
