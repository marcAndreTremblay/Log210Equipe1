using System;
using NUnit.Framework.Constraints;
using NUnit.Framework;
using NUnit.Core;

using System.Collections.Generic;

using GestionnaireLivre.Model.Services;
using GestionnaireLivre.Model.DataObject;

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
            DataBaseService sut = new DataBaseService();

            int sutResult = sut.CheckLogInCredentials(username, password);

            Assert.AreEqual(result, sutResult);
        }
        [Test]
        public void TestGetBookConditionDataAcess()
        {
            DataBaseService sut = new DataBaseService();

            List<BookCondition> conditionList = sut.BookCondition;

            bool result = false;
            if(conditionList.Count > 0) result= true;

            Assert.AreEqual(true, result);
        }

        [Test]
        public void TestGetTransactionStatusDataAcess()
        {
            DataBaseService sut = new DataBaseService();

            List<TransactionStatus> resultList = sut.BookTransactionStatus;

            bool result = false;
            if (resultList.Count > 0) result = true;

            Assert.AreEqual(true, result);
        }

        [Test]
        public void TestGetUserTypeDataAcess()
        {
            DataBaseService sut = new DataBaseService();

            List<UserType> resultList = sut.UserType;

            bool result = false;
            if (resultList.Count > 0) result = true;

            Assert.AreEqual(true, result);
        }

        [Test]
        public void TestGetTransactionTypeDataAcess()
        {
            DataBaseService sut = new DataBaseService();

            List<TransactionType> resultList = sut.BookTransactionType;

            bool result = false;
            if (resultList.Count > 0) result = true;

            Assert.AreEqual(true, result);
        }


        [TestCase(-1, true,TestName = "User dont exist")]
        [TestCase(100, false, TestName = "User dont exist")]
        [TestCase(1,true, TestName = "User exist")]
        public void TestRetriveSpecificUserInfo(int userId,bool expectedResult)
        {
            DataBaseService sut = new DataBaseService();

            User userresult = sut.RetrieveSpecificUser(userId);
            bool sutresult = false;
            if(userresult.Id == userId)
            {
                sutresult = true;

            }
            Assert.AreEqual(expectedResult, sutresult);
        }
    }
}
