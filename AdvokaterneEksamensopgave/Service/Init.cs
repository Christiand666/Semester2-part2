using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using DB;

namespace Service
{
    public class Init
    {
        public static void CreateDummies()
        {
            var Context = new AdvokaterneEntities();
            
            var Client = Context.Clients.Where(x => x.fName == "Dummy").FirstOrDefault();
            if(Client == null)
            {
                Client = new DB.Client();
                Client.fName = "Dummy";
                Client.lName = "Dummy";
                Client.CPR = "000000-0000";
                Client.email = "dummyclient@noreply.com";
                Client.Phone = 00000000;
                Client.Telephone = 00000000;
                Client.ID = Guid.NewGuid();

                Context.Clients.Add(Client);
            }
            Context.SaveChanges();

            var Lawyer = Context.Employees.Where(x => x.fName == "Dummy").FirstOrDefault();
            if(Lawyer == null)
            {
                Lawyer = new Employee();
                Lawyer.fName = "Dummy";
                Lawyer.lName = "Dummy";
                Lawyer.email = "Dummy@noreply.com";
                Lawyer.phone = 00000000;
                Lawyer.Special = "None";
                Lawyer.ID = Guid.NewGuid();

                Context.Employees.Add(Lawyer);
            }
            Context.SaveChanges();

            Context = new AdvokaterneEntities();
            var Case = Context.Cases.Where(x => x.Name == "Dummy").FirstOrDefault();
            if(Case == null)
            {
                string response = CaseCRUD.CreateCase("5353223525235", "This is a dummy case", Lawyer.ID, Client.ID);
            }
                

            Context = new AdvokaterneEntities();
            Case = Context.Cases.Where(x => x.Name == "Dummy").FirstOrDefault();
            var Service = Context.Services.Where(x => x.Name == "Dummy").FirstOrDefault();
            if (Service == null)
                ServiceCRUD.CreateService("5353223525235", 0, true, Case.ID);
        }
    }
}
