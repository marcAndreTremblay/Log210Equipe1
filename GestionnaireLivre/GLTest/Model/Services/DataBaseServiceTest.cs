using System;
using NUnit.Framework.Constraints;
using NUnit.Framework;
using NUnit.Core;

using System.Collections.Generic;

using GLTest.Factory;

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
        [Test]
        public void TestConnection()
        {
            DataBaseService sut = new DataBaseService();
            bool sutResult = sut.TestConnection();
            Assert.AreEqual(true, sutResult);
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


        [TestCase(-1, true, TestName = "Coop dont exist")]
        [TestCase(100, false, TestName = "Coop dont exist")]
        [TestCase(1, true, TestName = "Coop exist")]
        public void TestRetriveSpecificCoopInfo(int coopId, bool expectedResult)
        {
            DataBaseService sut = new DataBaseService();

            Cooperative coopresult = sut.RetrieveSpecificCooperatives(coopId);
            bool sutresult = false;
            if (coopresult.id == coopId)
            {
                sutresult = true;

            }
            Assert.AreEqual(expectedResult, sutresult);
        }


        [Test]
        public void TestRetriveCooperativeDataAcess()
        {
            DataBaseService sut = new DataBaseService();
            List<Cooperative> coopList = sut.RetrieveCooperatives();
            bool result = false;
            if(coopList.Count > 0)
            {
                result = true;
            }
            Assert.AreEqual(true, result);
        }

        [Test]
        public void TestRegisterNewAdminWithCoop()
        {
            DataBaseService sut = new DataBaseService();
            NewCooperative newcoop = DataObjectFctory.BuildNewCoop();
            NewUser newAdmin = DataObjectFctory.BuildNewUserAdmin();

            bool sutResult = sut.RegisterAdminWithCoop(newAdmin, newcoop);
            Assert.AreEqual(true, sutResult);
        }

        [Test]
        public void TestRegisterNewUserClient()
        {
            DataBaseService sut = new DataBaseService();
            NewUser newu = DataObjectFctory.BuildNewUserClient();

            bool sutResult = sut.RegisterUser(newu);
            Assert.AreEqual(true, sutResult);

        }
        [Test]
        public void testResgisterNewBook()
        {
            DataBaseService sut = new DataBaseService();
            sut.loginID = 1;
            NewBook newBook = DataObjectFctory.BuildNewBook();

            bool sutResult = sut.RegisterBook(newBook);
            Assert.AreEqual(true, sutResult);
        }
    }
}
