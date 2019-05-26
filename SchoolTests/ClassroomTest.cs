using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace School.Tests
{
    [TestClass()]
    public class ClassroomTest
    {
        [TestMethod()]
        public void FirstCreateMethod_CallFirstConstructor_GetObject()
        {
            //Arrange
            string expectedName = "room";
            int expectedNumber = 12;
            //Act
            Classroom classroom = Classroom.Create("room", 12);
            //Assert
            Assert.AreEqual(expectedName, classroom.Name);
            Assert.AreEqual(expectedNumber, classroom.NumberOfTeacher);
        }

        [TestMethod()]
        public void SecondCreateMethod_CallSecondConstructor_GetObject()
        {
            //Arrange
            string expectedName = "room";
            int expectedNumber = 2;
            //Act
            Classroom classroom = Classroom.Create("room",
                new Teacher("teach", "er", new Lesson("sad", 12, 22)),
                new Teacher("tea", "cher", new Lesson("as", 11, 42)));
            //Assert
            Assert.AreEqual(expectedName, classroom.Name);
            Assert.AreEqual(expectedNumber, classroom.NumberOfTeacher);
        }

        [ExpectedException(typeof(ArgumentNullException))]
        [TestMethod()]
        public void SecondConstructor_ParametrsWithDublicate_GetArgumentNullException()
        {
            //Act
            Classroom classroom = Classroom.Create("room",
                 new Teacher("teach", "er", new Lesson("sad", 12, 22)),
                 new Teacher("tea", "cher", new Lesson("as", 11, 42)),
                 new Teacher("tea", "cher", new Lesson("as", 11, 42)));
        }
    }
}
