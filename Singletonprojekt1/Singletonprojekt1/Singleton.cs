using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singletonprojekt1
{
    
    public class Singleton
    {
        private static Singleton instance;
        private Singleton()
        {
            
        }

        private static List<int> data;

        public List<int> GetData()
        {
            return data;
        }

        public void SetData(List<int> data1)
        {
            data = data1;
        }


        public static Singleton GetInstance()
        {
            if(instance == null)
            {
                instance = new Singleton();
            }


            return instance;
        }

    }

}
