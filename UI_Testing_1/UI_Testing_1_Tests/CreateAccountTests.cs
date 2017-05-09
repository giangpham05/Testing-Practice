using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UI_Testing_1;

namespace UI_Testing_1_Tests
{
    [TestClass]
    public class CreateAccountTests
    {
        [TestInitialize]
        public void Init()
        {
            Driver.Setup();
        }

        [TestMethod]
        public void Can_Create_Account_With_Valid_Postcode()
        {
            CreateAccount.Go();

            Assert.IsTrue(CreateAccount.HasTerritory(), "Failed to find territory");

            Assert.IsTrue(CreateAccount.HasSubTerritory(), "Failed to find Sub Territory");
        }

        [TestCleanup]
        public void Close()
        {
            Driver.Close();
        }
    }
}
