using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ProjectTestExample;

namespace People_Test
{
    [TestClass]
    public class UnitTest1
    {
        People people = new People("samctum", "2033", "dima@yandex.ru", 79992647826);
        [TestMethod]
        public void GetNameTest()
        {
            Assert.AreEqual("samctum", people.Login);
        }
        public void GetPassTest()
        {
            Assert.AreEqual("2033", people.Pass);
        }
        public void GetEmailTest()
        {
            Assert.AreEqual("dima@yandex.ru", people.Email);
        }
        public void GetPhoneTest()
        {
            Assert.AreEqual(79992647826, people.Phone);
        }
    }
}