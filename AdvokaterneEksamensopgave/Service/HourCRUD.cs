using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DB;

namespace Service
{
    public class HourCRUD
    {
        public static List<Hour> GetAllHours()
        {
            var Context = new AdvokaterneEntities();
            return Context.Hours.Where(x => x.Link.ToString() != "a").ToList();
        }

        public static string CreateHour(int Driven, int Worked, DateTime Date, int ServiceID)
        {
            var Context = new AdvokaterneEntities();
            string[] strings = Date.Date.ToString().Split(' ');
            string date = strings[0];

            var check = Context.Hours.Where(x => x.Date == date && x.Link == ServiceID).FirstOrDefault();
            if (check != null)
                return "Timer allerede indberettet for denne dato";

            Hour hour = new Hour();
            hour.Date = date;
            hour.HoursDriven = Driven;
            hour.HoursSpent = Worked;
            hour.Link = ServiceID;

            Context.Hours.Add(hour);
            try
            {
                Context.SaveChanges();
                return "Timer indberettet";
            }catch
            {
                return "Databasefejl, prøv igen eller kontakt systemadmistratoren";
            }
        }

        public static bool UpdateHour(int ID, int Driven, int Worked, DateTime Date, int ServiceID)
        {
            var Context = new AdvokaterneEntities();
            var row = Context.Hours.Where(x => x.ID == ID).FirstOrDefault();
            if (row == null)
                return false;

            row.HoursDriven = Driven;
            row.HoursSpent = Worked;
            row.Date = Date.Date.ToString().Split(' ')[0];
            row.Link = ServiceID;

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

        public static bool DeleteHour(int ID)
        {
            var Context = new AdvokaterneEntities();

            var Data = Context.Hours.Where(x => x.ID == ID).FirstOrDefault();
            if (Data == null)
                return false;

            Context.Hours.Remove(Data);
            Context.SaveChanges();
            return true;
        }
    }
}
