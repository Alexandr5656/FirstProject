using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace foods
{
    public abstract class Resturant
    {
        public string name;
        public double price;
        public int ratings;
        public string type;
        public string location;
        public int openHour;
        public int closeHour;
        public int[] busyHours;

        public string Hours {
            get {
                return (openHour + "-" + closeHour);
            }
            
        }
       


    }
    
}
