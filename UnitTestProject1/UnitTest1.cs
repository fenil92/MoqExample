using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using MoqDemo;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var mockRepoObj = new Mock<Interface1>();
            //skipping the call to RepoClass method
            mockRepoObj.Setup(x => x.DoSomething(It.IsAny<int>())).Returns(true);

            var mockObj = new Class1(mockRepoObj.Object);
            int result = mockObj.DoSomething(5, 5);
            Assert.AreEqual(result, 20);

        }
    }
}
