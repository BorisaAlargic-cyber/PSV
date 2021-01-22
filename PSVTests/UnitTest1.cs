using Microsoft.VisualStudio.TestTools.UnitTesting;
using PSV.Model;

namespace PSVTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestUser()
        {
            User user = new User();

            user.FirstName = "Test";
            user.LastName = "Test";

            Assert.AreEqual(user.FirstName, "Test");
            Assert.AreEqual(user.LastName, "Test");


        }
        public void TestDrug()
        {
            Drugs drugs = new Drugs();

            drugs.Name = "Brufen";
            drugs.Name = "Kafetin";

            Assert.AreEqual(drugs.Name, "Brufen");
            Assert.AreEqual(drugs.Name, "Kafetin");
        }
        public void TestFeedback()
        {
            Feedback feedback = new Feedback();

            feedback.Comment = "Sve je super";

            Assert.AreEqual(feedback.Comment, "Sve je super");
        }
    }
}
