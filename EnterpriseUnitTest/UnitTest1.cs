using System;
using Kpo4162_nvm.Lib;
using Kpo4162_nvm.Lib.Utility;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EnterpriseUnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void AppGlobalSettingsTest()
        {
            AppGlobalSettings.Initialize();
            Assert.AreEqual(AppGlobalSettings.DataFileName, "Enterprise.txt");
        }

        [TestMethod]
        public void AppConfigUtilityTest()
        {
            Assert.AreEqual(AppConfigUtility.AppSettings(""), "");
        }

        [TestMethod]
        public void EnterpriseLoaderTest()
        {
            var loader = new EnterpriseListSplitFileLoader("EnterpriseLoaderTest");

            loader.Execute();

            Assert.IsTrue(loader.LoadStatus == LoadStatus.FileNotExists);
        }


    }
}
