using Microsoft.VisualStudio.TestTools.UnitTesting;
using Service;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using DB;
using System.


namespace Endelige_unittestprojekt
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            //var Context = new AdvokaterneEntities();

            //arrange
            Guid ID = new Guid();
            string fName = "rasmus";
            string lName = "gerken";
            int Phone = 34545445;
            string Special = "somethingrandom";
            string Email = "somethingrandom5";

            //act
            Boolean actuel = EmployeeCRUD.CreateEmployee(fName, lName, Special, Phone, Email);



            //assert
            try
            {
                Boolean expected = true;
                Assert.AreEqual(expected, actuel);

            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
