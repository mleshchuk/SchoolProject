using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace School.Tests
{
    [TestClass()]
    public class PupilTest
    {
        [TestMethod()]
        public void Constructor_CallConstructor_ParametrsAreCorrect()
        {
            //Arrange
            string expectedName = "bill";
            string expectedSurname = "gates";
            //Act
            Pupil pupil = new Pupil("bill", "gates");
            //Assert
            Assert.AreEqual(expectedName, pupil.Name);
            Assert.AreEqual(expectedSurname, pupil.Surname);
        }
    }
}
