using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Athena2
{
    class Exchange
    {


        // Gets a list of trading dates
        public List<DateTime> DateListGenerator(DateTime FromDate, DateTime ToDate)
        {
            List<DateTime> T = new List<DateTime>();
            if (FromDate <= ToDate)
            {
                DateTime theDate = FromDate;
                while (theDate <= ToDate)
                {
                    if (theDate.DayOfWeek != DayOfWeek.Saturday && theDate.DayOfWeek != DayOfWeek.Sunday)
                    {
                        T.Add(theDate);

                    }
                    theDate = theDate.AddDays(1);
                }
            }
            return T;
        }

    }
}
