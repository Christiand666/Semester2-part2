using System;
using System.Collections.Generic;
using System.Linq;
using DB;

namespace Service
{
   public static class ServiceCRUD
    {

        public static List<FullServiceData> GetAllServicesWithCases()
        {
            var Context = new AdvokaterneEntities();
            List<FullServiceData> Data = new List<FullServiceData>();
            

            foreach(var item in Context.Services)
            {
                var d = new FullServiceData();
                if(item.Name != "Dummy")
                {

                    if (Context.Cases.Where(z => z.ID == Context.CaseServices.Where(x => x.ServiceID == item.ID).FirstOrDefault().CaseID).FirstOrDefault().Name != "Dummy")
                    {
                        d.Service = item;
                        d.Case = Context.Cases.Where(x => x.ID == (Context.CaseServices.Where(z => z.ServiceID == item.ID).FirstOrDefault().CaseID)).FirstOrDefault();
                        Data.Add(d);
                    }
                }
            }
            return Data;
        }
        public static Boolean UpdateService(int ID, string Name, int price, bool IsHourlyPay, int CaseID)
        {
            var Context = new AdvokaterneEntities();
            var _Service = Context.Services.Where(x => x.ID == ID).FirstOrDefault();

            _Service.Name = Name;
            _Service.Price = price;
            _Service.isHourly = IsHourlyPay;

            var link = Context.CaseServices.Where(x => x.ServiceID == ID).FirstOrDefault();

            link.CaseID = CaseID;

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

        public static string CreateService(string Name, int price, bool isHourlyPay, int CaseID)
        {
            if (Name == "Dummy")
                return "Forbudt navn!";
            else if (Name == "5353223525235")
                Name = "Dummy";
            var Context = new AdvokaterneEntities();
            DB.Service service = new DB.Service();
            var check = Context.Services.Where(x => x.Name == Name).FirstOrDefault();
            if (check != null)
                return "Navn allerede i brug";

            service.Name = Name;
            service.Price = price;
            service.isHourly = isHourlyPay;

            Context.Services.Add(service);
            Context.SaveChanges();

            var Link = new CaseService();
            Link.CaseID = CaseID;
            Link.ServiceID = Context.Services.Where(x => x.Name == Name).FirstOrDefault().ID;

            Context.CaseServices.Add(Link);

            Context.SaveChanges();

            return "Service oprettet";
        }

        public static Client GetClientByID(Guid ID)
        {
            var Context = new AdvokaterneEntities();
            return Context.Clients.Where(x => x.ID == ID).FirstOrDefault();
        }

        public static FullServiceData GetServiceByID(int ID)
        {

            var Context = new AdvokaterneEntities();
            var Data = new FullServiceData();
            Data.Service = Context.Services.Where(x => x.ID == ID).FirstOrDefault();
            Data.Case = Context.Cases.Where(x => x.ID == Context.CaseServices.Where(z => z.ServiceID == ID).FirstOrDefault().CaseID).FirstOrDefault();
            return Data;
        }

        public static List<String> GetServID()
        {
            var Context = new AdvokaterneEntities();
            List<String> returned = new List<string>();
            foreach (var item in Context.Services)
            {
                returned.Add(item.ID.ToString());
            }
            return returned;
        }

        public static Boolean DeleteService(int ID)
        {
            var Context = new AdvokaterneEntities();

            var Data = Context.Services.Where(x => x.ID == ID).FirstOrDefault();
            var LinkData = Context.CaseServices.Where(x => x.ServiceID == ID).FirstOrDefault();

            LinkData.CaseID = Context.Cases.Where(x => x.Name == "Dummy").FirstOrDefault().ID;
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

    public class FullServiceData
    {
        public DB.Service Service;
        public DB.Case Case;
    }
}
