using Microsoft.VisualStudio.TestTools.UnitTesting;
using Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Service.Tests;
using DB;

namespace Service.Tests
{
    [TestClass()]
    public class EmployeeCRUDTests
    {
        [TestMethod()]
        public void CreateEmployetest5()
        {

            //arrange
            var Context = new AdvokaterneEntities();

            //Guid ID = new Guid();
            //string fName = "rasmus";
            //string lName = "gerken";
            //int phone = 34545445;
            //string Special = "somethingrandom";
            //string email = "somethingrandom5";
            //EmployeeCRUD emp = new EmployeeCRUD(ID, fName, lName, phone, Special, email);
            //act


            Employee employee1 = new Employee();

            //EmployeeCRUDTests create = new EmployeeCRUDTests();
            employee1.ID = new Guid();
            employee1.fName = "rasmus";
            employee1.lName = "Gerken";
            employee1.phone = 34545445;
            employee1.Special = "somethingrandom";
            employee1.email = "somethingrandom5";

            //act
            try
            {
                Context.Employees.Add(employee1);

            }
            //assert
            catch (System.ArgumentOutOfRangeException e)
            {
                string prøve1 = employee1.fName;
                Assert.AreEqual(prøve1, employee1 + "desværre");

            }


        }

        [TestMethod()]
        public void GetSpecTest()
        {

            Assert.Fail();
        }

        [TestMethod()]
        public void GetNamesBySpecialTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void GetEmployeeListTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void GetEmplyeeByIDTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void CreateEmployeeTest()
        {
            var Context = new AdvokaterneEntities();
            //Guid ID = new Guid();
            //string fName = "rasmus";
            //string lName = "gerken";
            //int phone = 34545445;
            //string Special = "somethingrandom";
            //string email = "somethingrandom5";

            Employee employee1 = new Employee();

            //EmployeeCRUDTests create = new EmployeeCRUDTests();
            employee1.ID = new Guid();
            employee1.fName = "rasmus";
            employee1.lName = "Gerken";
            employee1.phone= 34545445;
            employee1.Special = "somethingrandom";
            employee1.email = "somethingrandom5";

            //act
            try
            {
               Context.Employees.Add(employee1);

            }
            //assert
            catch (System.ArgumentOutOfRangeException e)
            {
                string prøve1 = employee1.fName;
                Assert.AreEqual(prøve1, employee1 + "desværre");

            }
            
        }

        [TestMethod()]
        public void UpdateEmployeeTest()
        {
            Assert.Fail();
        }
    }
}