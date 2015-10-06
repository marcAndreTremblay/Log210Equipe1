using System;
using NUnit.Framework.Constraints;
using NUnit.Framework;
using NUnit.Core;

using GestionnaireLivre.Model.Services;

namespace GLTest.Model.Services
{
    [TestFixture]
    public class DataBaseServiceTest
    {

        [TestCase("test", "test", 1 , TestName="TestRightUserCrendential")]
        [TestCase("test1", "test", 2, TestName = "TestRightUserCrendential")]
        [TestCase("testxx", "testxx", -1, TestName = "TestWrongUserCrendential")]
        public void TestCheckUserCrendential(string username, string password, int result)
        {
            DataBaseService dbService = new DataBaseService();

            int testResult = dbService.CheckLogInCredentials(username, password);

            Assert.AreEqual(result, testResult);
        }


    }
}
