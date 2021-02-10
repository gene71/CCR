using System;
using CCR.Data;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CCRUnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod_testDataAccess_testconnection()
        {
            try
            {
                CCRDataAccess ccrda = new CCRDataAccess();
                ccrda.testConnection();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
           
        }
    }
}
