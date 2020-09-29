using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DB;

namespace Service
{
    public static class EmployeeCRUD
    {
        public static List<String> GetSpec()
        {
            var Context = new AdvokaterneEntities();
            List<String> returned = new List<string>();
            foreach (var item in Context.Employees.Where(x => x.Special != "None").ToList())
            {
                if (item.Special != "Sekretær" ||item.Special != "None")
                    returned.Add(item.Special);

            }
            return returned;
        }

        public static List<String> GetNamesBySpecial(string Speciale)
        {
            var context = new AdvokaterneEntities();
            List<String> returned = new List<string>();
            foreach (var item in context.Employees.Where(x => x.Special == Speciale).ToList())
            {
                returned.Add(item.fName + " " + item.lName + " " + item.ID.ToString());
            }
            return returned;


        }
        public static List<String> GetEmployeeList(bool WithSecretary)
        {
            var Context = new AdvokaterneEntities();
            List<String> returned = new List<string>();
            foreach(var item in Context.Employees)
            {
                if(item.fName != "Dummy")
                {
                    if (WithSecretary)
                    {
                        returned.Add(item.fName + " " + item.lName + " " + item.ID);
                    }
                    else
                    {
                        if (item.Special != "Sekretær")
                        {
                            returned.Add(item.fName + " " + item.lName + " " + item.ID);
                        }
                    }
                }
            }
            return returned;
        }

        public static Employee GetEmplyeeByID(Guid ID)
        {
            var Context = new AdvokaterneEntities();
            return Context.Employees.Where(x => x.ID == ID).FirstOrDefault();
        }

        public static Boolean CreateEmployee(string fName, string lName, string Special, int Phone, string Email)
        {
            if (fName == "Dummy")
                return false;
            var Context = new AdvokaterneEntities();

            var Employee = Context.Employees.Where(x => x.email == Email || x.phone == Phone).FirstOrDefault();
            if (Employee != null)
                return false;

            Employee emp = new Employee();
            emp.ID = Guid.NewGuid(); 
            emp.fName = fName;
            emp.lName = lName;
            emp.phone = Phone;
            emp.Special = Special;
            emp.email = Email;

            try
            {
                Context.Employees.Add(emp);
                Context.SaveChanges();
                return true;
            }catch
            {
                return false;
            }
        }

        public static Boolean UpdateEmployee(Guid ID, string Email, string fName, string lName, int Phone, string Special)
        {
            var Context = new AdvokaterneEntities();
            var Emp = Context.Employees.Where(X => X.ID == ID).FirstOrDefault();

            Emp.email = Email;
            Emp.fName = fName;
            Emp.lName = lName;
            Emp.phone = Phone;
            Emp.Special = Special;

            try
            {
                Context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static Boolean DeleteEmployee(Guid ID)
        {
            var Context = new AdvokaterneEntities();
            var dummy = Context.Employees.Where(x => x.fName == "Dummy").FirstOrDefault();
            if (ID == dummy.ID)
                return false;

            var Employee = Context.Employees.Where(x => x.ID == ID).FirstOrDefault();
            Context.Employees.Remove(Employee);

            foreach (var item in Context.Educations.Where(x => x.EmployeeID == ID))
                Context.Educations.Remove(item);

            foreach (var item in Context.OrderLines.Where(x => x.EmployeeID == ID))
                item.EmployeeID = dummy.ID;

            try
            {
                Context.SaveChanges();
                return true;
            }catch
            {
                return false;
            }
        }
    }
}
