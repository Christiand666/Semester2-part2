using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DB;

namespace Service
{
    public class EducationCRUD
    {
        public static bool EducateEmployee(Guid ID, string fName, string lName, string eduName, DateTime startDate, DateTime endDate)
        {
            var Employee = Service.EmployeeCRUD.GetEmplyeeByID(ID);
            if (Employee == null)
                return false;

            var Context = new AdvokaterneEntities();
            var Check = Context.Educations.Where(X => X.EmployeeID == Employee.ID).ToList();

            if(Check.Count != 0)
            {
                foreach (var item in Check)
                {
                    if((item.from.Ticks < startDate.Ticks && item.to.Ticks > startDate.Ticks) || (item.from.Ticks > endDate.Ticks && endDate.Ticks > item.to.Ticks))
                    {
                        return false;
                    }
                }
            }
            Education edu = new Education();
            edu.ID = Guid.NewGuid();
            edu.EmployeeID = Employee.ID;
            edu.from = startDate;
            edu.to = endDate;
            edu.EducationName = eduName;
            try
            {
                Context.Educations.Add(edu);
                Context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
            
        }

        public static List<EducationWithName> GetAllEmplyeesUnderEducation()
        {
            var Context = new AdvokaterneEntities();

            List<EducationWithName> returned = new List<EducationWithName>();
            foreach(var item in Context.Educations.Where(X => X.EmployeeID.ToString() != "").ToList())
            {
                var x = new EducationWithName();
                var emp = Context.Employees.Where(X => X.ID == item.EmployeeID).FirstOrDefault();
                x.EducationName = item.EducationName;
                x.StartDate = item.from;
                x.EndDate = item.to;
                x.EmplyeeName = emp.fName + " " + emp.lName;
                x.ID = item.ID;
                returned.Add(x);
            }

            return returned;
        }

        public static bool DeleteEducationByID(Guid ID)
        {
            var Context = new AdvokaterneEntities();

            try
            {
                Context.Educations.Remove(Context.Educations.Where(x => x.ID == ID).FirstOrDefault());
                Context.SaveChanges();
                return true;
            }catch
            {
                return false;
            }
        }
    }

    public class EducationWithName
    {
        public string EmplyeeName { get; set; }
        public string EducationName { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public Guid ID { get; set; }
        
    }
}
