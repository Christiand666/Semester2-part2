using System;
using System.Collections.Generic;
using System.Linq;
using DB;

namespace Service
{
    public class CustomerCRUD
    {
        public static List<String> GetCustomerList ()
        {
            var Context = new AdvokaterneEntities();
            List<String> returned = new List<string>();
            foreach (var item in Context.Clients)
            {
                if(item.fName != "Dummy")
                    returned.Add(item.fName + " " + item.lName + " " + item.ID.ToString());
            }
            return returned;
        }

        public static Client GetClientByID(Guid ID)
        {
            var Context = new AdvokaterneEntities();
            return Context.Clients.Where(x => x.ID == ID).FirstOrDefault();
        }

        public static Client CreateClient(string fName, string lName, string Cpr, int Phone, string Email, int Ctele)
        {
            if (fName == "Dummy")
                return null;
            else if (fName == "5353223525235")
                fName = "Dummy";
            var Context = new AdvokaterneEntities();

            var client = Context.Clients.Where(x => x.email == Email || x.Phone == Phone || x.CPR == Cpr).FirstOrDefault();
            if (client != null)
                return null;

            Client Cli = new Client();
            Cli.ID = Guid.NewGuid();
            Cli.fName = fName;
            Cli.lName = lName;
            Cli.Phone = Phone;
            Cli.CPR = Cpr;
            Cli.email = Email;
            Cli.Telephone = Ctele;

            try
            {
                Context.Clients.Add(Cli);
                Context.SaveChanges();
                return Cli;
            }
            catch
            {
                return null;
            }
        }

        public static Boolean UpdateClient(Guid ID, string Email, string fName, string lName, int Phone, string CPR, int Ctele)
        {
            var Context = new AdvokaterneEntities();
            var Cli = Context.Clients.Where(X => X.ID == ID).FirstOrDefault();
            
            
            Cli.email = Email;
            Cli.fName = fName;
            Cli.lName = lName;
            Cli.Phone = Phone;
            Cli.CPR = CPR;
            Cli.Telephone = Ctele;
           
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

        public static Boolean DeleteClient(Guid ID)
        {
            var Context = new AdvokaterneEntities();
            var dummy = Context.Clients.Where(x => x.fName == "Dummy").FirstOrDefault();
            if (ID == dummy.ID)
                return false;

            var Client = Context.Clients.Where(x => x.ID == ID).FirstOrDefault();
            Context.Clients.Remove(Client);

            foreach (var item in Context.OrderLines.Where(x => x.EmployeeID == ID))
                item.ClientID = dummy.ID;

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
    }
}
