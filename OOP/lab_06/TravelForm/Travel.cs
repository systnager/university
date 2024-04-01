using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelForm
{
    public class Travel
    {
        protected int voucherscount;
        public int VouchersCount { set { if (value >= 1) voucherscount = value; } get { return voucherscount; } }

        protected int dayscount;
         public int DaysCount { set { if (value >= 3) dayscount = value; } get { return dayscount; } }

        public int Countries { set; get; }
        public int Season { set; get; }
        public bool Guider { set; get; }

        public Travel(int voucherscount, int dayscount, int countries, int season,bool guider)
        {
            VouchersCount = voucherscount;
            DaysCount = dayscount;
            Countries = countries;
            Season = season;
            Guider = guider;
        }

        private int[,] price = new int[2, 3] { {100,160,120 },{150,200,180 } };

        public int CountPrices(){
            int res = VouchersCount*DaysCount*price[Season,Countries];
            if (Guider) res += 50;
            return res;

        }


    }
}
