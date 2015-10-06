using System;
using NUnit.Framework.Constraints;
using NUnit.Framework;
using NUnit.Core;

using GestionnaireLivre.Model;

namespace GLTest.Model
{
    [TestFixture]
    public class CryptingTest
    {
        [TestCase("passtest",  "passtest", true, TestName = "Same pass")]
        [TestCase("passtest", "pasfdsdsstest", false, TestName = "Different pass ")]
        public void TestSHA512Crypting( string password1, string password2 , bool expextedResult)
        {
            string code1 = Crypting.GetSHA512Hash(password1);
            string code2 = Crypting.GetSHA512Hash(password2);

            bool testResult = false;
            if(code1 == code2)
            {
                testResult = true;
            }

            Assert.AreEqual(expextedResult, testResult);
           
        }

        [TestCase("passtest", "passtest", true, TestName = "Same pass")]
        [TestCase("passtest", "pasfdsdsstest", false, TestName = "Different pass ")]
        public void TestMD5Crypting(string password1, string password2, bool expextedResult)
        {
            string code1 = Crypting.GetMd5Hash(password1);
            string code2 = Crypting.GetMd5Hash(password2);

            bool testResult = false;
            if (code1 == code2)
            {
                testResult = true;
            }

            Assert.AreEqual(expextedResult, testResult);

        }
    }
}
