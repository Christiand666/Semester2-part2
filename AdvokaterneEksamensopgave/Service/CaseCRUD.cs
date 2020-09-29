using System;
using System.Collections.Generic;
using System.Linq;
using DB;

namespace Service
{
    public class CaseCRUD
    {
       
        public static List<Case> GetAllCases()
        {
            var Context = new AdvokaterneEntities();
            return Context.Cases.Where(X => X.Name != "Dummy").ToList();
        }
        public static Case GetCaseByID(int ID)
        {
            var Context = new AdvokaterneEntities();
            return Context.Cases.Where(x => x.ID == ID).FirstOrDefault();
        }
        public static string CreateCase(string Name, string Description, Guid EmployeeID, Guid ClientID)
        {
            if (Name == "Dummy")
                return "Forbudt navn!";
            else if (Name == "5353223525235")
                Name = "Dummy";
            var Context = new AdvokaterneEntities();

            Case c = Context.Cases.Where(x => x.Name == Name).FirstOrDefault();
            if (c != null)
                return "Navn allerede i brug";

            c = new Case();
            c.Name = Name;
            c.Description = Description;

            Context.Cases.Add(c);

            try
            {
                Context.SaveChanges();
            }
            catch
            {
                return "Database fejl, prøv igen";
            }

            c = Context.Cases.Where(x => x.Name == Name).FirstOrDefault();

            OrderLine o = new OrderLine();
            o.CaseID = c.ID;
            o.EmployeeID = EmployeeID;
            o.ClientID = ClientID;

            Context.OrderLines.Add(o);
            try
            {
                Context.SaveChanges();
                return "Case oprettet";
            }catch
            {
                try
                {
                    Context.Cases.Remove(c);
                    Context.SaveChanges();
                    return "Databasefejl, prøv igen";
                }
                catch
                {
                    return "Ups, kunden oprettet skal slettes manuelt :(";
                }
            }
        }
        public static Boolean UpdateCase(int ID, string Name, string Description, Guid EmployeeID, Guid ClientID)
        {
            var Context = new AdvokaterneEntities();
            var Cas = Context.Cases.Where(x => x.ID == ID).FirstOrDefault();
            var Order = Context.OrderLines.Where(x => x.CaseID == ID).FirstOrDefault();

            Cas.Name = Name;
            Cas.Description = Description;

            Order.EmployeeID = EmployeeID;
            Order.ClientID = ClientID;


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
       

        public static FullCaseData GetClientByCaseID(int ID)
        {

            var Context = new AdvokaterneEntities();
            var Data = new FullCaseData();
            Data.Case = Context.Cases.Where(x => x.ID == ID).FirstOrDefault();
            Data.client = Context.Clients.Where(x => x.ID == Context.OrderLines.Where(z => z.CaseID == ID).FirstOrDefault().ClientID).FirstOrDefault();
            Data.Employee = Context.Employees.Where(x => x.ID == Context.OrderLines.Where(s => s.CaseID == ID).FirstOrDefault().EmployeeID).FirstOrDefault();
            return Data;
        }
        public static bool DeleteCase(int ID)
        {
            var Context = new AdvokaterneEntities();

            var dummyService = Context.Services.Where(x => x.Name == "Dummy").FirstOrDefault();
            var dummyCase = Context.Cases.Where(x => x.Name == "Dummy").FirstOrDefault();


            var Case = Context.Cases.Where(x => x.ID == ID).FirstOrDefault();
            List<DB.CaseService> ServiceLinks = Context.CaseServices.Where(x => x.CaseID == ID ).ToList();

            foreach(var item in ServiceLinks)
            {
                item.CaseID = dummyCase.ID;
                item.ServiceID = dummyService.ID;
            }

            var row = Context.OrderLines.Where(z => z.CaseID == ID).FirstOrDefault();
            row.CaseID = dummyCase.ID;

            Context.Cases.Remove(Case);
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

    public class FullCaseData
    {
        public DB.Client client;
        public DB.Case Case;
        public DB.Employee Employee;
    }
}

