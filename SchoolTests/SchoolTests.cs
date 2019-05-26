using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace School.Tests
{
    [TestClass()]
    public class SchoolTests
    {
        private static void CompareIEnumerable<T>(IEnumerable<T> one, IEnumerable<T> two, Func<T, T, bool> comparisonFunction)
        {
            var oneArray = one as T[] ?? one.ToArray();
            var twoArray = two as T[] ?? two.ToArray();

            if (oneArray.Length != twoArray.Length)
            {
                Assert.Fail("Collections are not same length");
            }

            for (int i = 0; i < oneArray.Length; i++)
            {
                var isEqual = comparisonFunction(oneArray[i], twoArray[i]);
                Assert.IsTrue(isEqual);
            }
        }

        [TestMethod()]
        public void FirstConstructor_CallConstructor_ListsAreEmpty()
        {
            //Act
            School school = new School();
            //Assert
            Assert.IsNull(school.classrooms);
            Assert.IsNull(school.pupils);
        }

        [TestMethod()]
        public void SecondConstructor_InputCorrectPupilParameters_ParametrsAreCorrect()
        {
            //Arrange
            List<Pupil> expectedPupils = new List<Pupil> {
                new Pupil("name1", "surname1"),
                new Pupil("name2", "surname2"),
                new Pupil("name3", "surname3")
            };

            //Act
            List<Pupil> actualdPupils = new List<Pupil> {
                new Pupil("name1", "surname1"),
                new Pupil("name2", "surname2"),
                new Pupil("name3", "surname3")
            };
            School school = new School(pupils: actualdPupils);
            //Assert
            CompareIEnumerable(expectedPupils, school.pupils,
                (x, y) => x.Name == y.Name && x.Surname == y.Surname);
        }

        [ExpectedException(typeof(ArgumentNullException))]
        [TestMethod()]
        public void SecondConstructor_ClassroomParametrsWithDublicate_GetArgumentNullException()
        {
            //Act
            School school = new School(classrooms: new List<Classroom> {
                Classroom.Create("SomeClass1", 1),
               Classroom.Create("SomeClass1", 1),
                Classroom.Create("SomeClass2", 2),
                Classroom.Create("SomeClass2", 2),
                Classroom.Create("SomeClass3", 3),
                Classroom.Create("SomeClass3", 3)
                });
        }
    }
}

