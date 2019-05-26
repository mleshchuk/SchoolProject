using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;

namespace School.Tests
{
    [TestClass()]
    public class TeacherTests
    {
        [TestMethod()]
        public void Constructor_InputAllParameters_ParametersAreCorrect()
        {
            //Arrange
            string expectedName = "Stephen";
            string expectedSurname = "Hawking";
            //Act
            Teacher teacher = new Teacher("Stephen", "Hawking", new Lesson());
            //Assert
            Assert.AreEqual(expectedName, teacher.Name);
            Assert.AreEqual(expectedSurname, teacher.Surname);
            CollectionAssert.AllItemsAreNotNull(teacher.lesson.ToList());
        }

        [TestMethod()]
        public void Constructor_ParametersWithoutLessons_LessonAreEmpty()
        {
            //Arrange
            int expectedCountOfCollection = 0;
            //Act
            Teacher teacher = new Teacher("Steven", "Hocking");
            //Assert
            Assert.AreEqual(expectedCountOfCollection, teacher.lesson.Count);
        }

        [TestMethod()]
        public void Constructor_ParametersWithFewLessons_LessonsAreCorrect()
        {
            //Arrange
            HashSet<Lesson> listWithLessons = new HashSet<Lesson> {
                new Lesson("Math",12, 2),
                new Lesson("History", 14,3),
                new Lesson("Computer Science", 11 ,4)
            };
            //Act
            Teacher teacher = new Teacher("Steven", "Hocking",
                new Lesson("Math", 12, 2),
                new Lesson("History", 14, 3),
                new Lesson("Computer Science", 11, 4));
            //Assert
            CollectionAssert.AreEqual(listWithLessons.ToList(), teacher.lesson.ToList());
        }

        [TestMethod()]
        public void Constructor_ParameterLessonsWithDublicate_LessonsWithoutDublicate()
        {
            //Arrange
            HashSet<Lesson> listWithLessons = new HashSet<Lesson> {
                new Lesson("Math",12, 2),
                new Lesson("History", 14,3),
                new Lesson("Computer Science", 11 ,4)
            };
            //Act
            Teacher teacher = new Teacher("Steven", "Hocking",
                new Lesson("Math", 12, 2),
                new Lesson("Math", 12, 2),
                new Lesson("History", 14, 3),
                new Lesson("History", 14, 3),
                new Lesson("Computer Science", 11, 4),
                new Lesson("Computer Science", 11, 4));
            //Assert
            CollectionAssert.AreEqual(listWithLessons.ToList(), teacher.lesson.ToList());
        }
    }  
}
