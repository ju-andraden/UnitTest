using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyClasses;
using MyClasses.PersonClasses;

namespace MyClassesTest
{
    [TestClass]
    public class AssertClassTest
    {
        #region AreEqual/AreNotEqual Tests
        [TestMethod]
        public void AreEqualTest()
        {
            string str1 = "Juliana";
            string str2 = "Juliana";

            Assert.AreEqual(str1, str2);
        }

        [TestMethod]
        [Owner("Juliana")]
        [ExpectedException(typeof(AssertFailedException))]
        public void AreEqualCaseSensitiveTest()
        {
            string srt1 = "Juliana";
            string srt2 = "juliana";

            Assert.AreEqual(srt1, srt2, false);
        }

        [TestMethod]
        public void AreNotEqualTest()
        {
            string str1 = "Juliana";
            string srt2 = "Arthur";

            Assert.AreNotEqual(str1, srt2);
        }
        #endregion

        #region AreSame/AreNotSame Tests
        [TestMethod]
        public void AreSameTest()
        {
            FileProcess x = new FileProcess();
            FileProcess y = x;

            Assert.AreSame(x, y);
        }

        [TestMethod]
        public void AreNotSameTest()
        {
            FileProcess x = new FileProcess();
            FileProcess y = new FileProcess();

            Assert.AreNotSame(x, y);
        }
        #endregion

        #region IsInstanceOfType Test
        [TestMethod]
        public void IsInstanceOfTypeTest()
        {
            PersonManager mgr = new PersonManager();
            Person per;

            per = mgr.CreatePerson("Juliana", "Andrade", true);

            Assert.IsInstanceOfType(per, typeof(Supervisor));
        }

        [TestMethod]
        public void IsNull()
        {
            PersonManager mgr = new PersonManager();
            Person per;

            per = mgr.CreatePerson("", "Andrade", true);

            Assert.IsNull(per);
        }
        #endregion
    }
}