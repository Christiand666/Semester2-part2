using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Service;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DB;

namespace UnitTestEndelige
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CreateEmployeeTestMethod1()
        {
            //arrange
            Guid ID = new Guid();
            string fName = "Thomas";
            string lName = "gerkes";
            int Phone = 34545546;
            string Special = "Overfald";
            string Email = "somethingrandom55@yahoo.dk";

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
        [TestMethod]
        public void UpdateEmployeeTestMethod1()
        {

            //arrange
            string ID = ("471BE352-7027-4115-963C-F039284A04BB");
            string fName = "Christiann";
            string lName = "gerkess";
            int Phone = 34545446;
            string Special = "somethingrandomm";
            string Email = "somethingrandom55";

            //act
            Boolean actuel = EmployeeCRUD.UpdateEmployee(Guid.Parse(ID), Email, fName, lName, Phone, Special);

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

        [TestMethod]
        public void CreateCaseTestMethod1()
        {
            //arrange
            var Context = new AdvokaterneEntities();
            string EmployeeID = ("471BE352-7027-4115-963C-F039284A04BB");
            string ClientID = ("ED2EA23C-1454-4A47-9030-DEF44C84C1E1");
            string Name = "Christiann";
            string Description = "Noget random";

            //act
            string actuel = CaseCRUD.CreateCase(Name, Description, Guid.Parse(EmployeeID), Guid.Parse(ClientID));

            //assert
            try
            {
                Assert.IsNotNull(actuel);
                
            }
            catch (Exception)
            {

                throw;
            }
        }


            [TestMethod]
        public void GetSpectest()
        {

            var Context = new AdvokaterneEntities();
            List<String> returned = new List<string>();
            foreach (var item in Context.Employees.Where(x => x.Special != "").ToList())
            {
                if (item.Special != "Sekretær")
                    returned.Add(item.Special);

            }
            Assert.IsNotNull(returned);

        }
        [TestMethod]
        public void GetNamesBySpecial()
        {
            string Speciale = "Skilsmisse";
            var context = new AdvokaterneEntities();
            List<String> returned = new List<string>();
            foreach (var item in context.Employees.Where(x => x.Special == Speciale).ToList())
            {
                returned.Add(item.fName + " " + item.lName + " " + item.ID.ToString());
            }
            Assert.IsNotNull(returned);

        }
        [TestMethod]
        public void GetEmployeeList()
        {

            var Context = new AdvokaterneEntities();
            List<String> returned = new List<string>();
            foreach(var item in Context.Employees.Where(x => x.Special != "").ToList())
            {
                if (item.Special != "Sekretær")
                    returned.Add(item.Special);

            }
            Assert.IsNotNull(returned);
        }
        [TestMethod]
        public void GetEmplyeeByID()
        {
            Guid ID = Guid.Parse("64F87BD5-B061-47B7-9F6C-2AED52102645");
            var Context = new AdvokaterneEntities();
            Assert.IsNotNull(Context.Employees.Where(x => x.ID == ID).FirstOrDefault());

        }
    }
}
