 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Athena.Services
{
    class BusinessDay
    {

        // Gets a list of trading dates
        public static List<DateTime> DateListGenerator(DateTime FromDate, DateTime ToDate)
        {
            List<DateTime> T = new List<DateTime>();
            if (FromDate.Date <= ToDate.Date)
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

        // Gets a list of trading dates
        public static List<DateTime> WorkingDays(DateTime FromDate, DateTime ToDate)
        {
            List<DateTime> T = new List<DateTime>();
            if (FromDate.Date <= ToDate.Date)
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

        public static List<DateTime> getMissingDates(string FolderToScan)
        {

            //List<DateTime> MissingDates = new List<DateTime>();
            string P = Path.GetFullPath(FolderToScan);
            List<string> Directories = Directory.EnumerateDirectories(P).ToList<string>();
            List<string> Files = new List<string>();
            foreach (string Folder in Directories)
            {
                Files.AddRange(Directory.GetFiles(Folder, "*.csv").ToList<string>());
            }
            List<DateTime> FoundDates = new List<DateTime>();
            foreach (string File in Files)
            {
                DateTime PathonDrive;
                if (DateTime.TryParseExact(Path.GetFileNameWithoutExtension(File), "yyyyMdd", null, System.Globalization.DateTimeStyles.AssumeLocal, out PathonDrive))
                {
                    FoundDates.Add(PathonDrive);
                }
            }
            DateTime MaxDate = FoundDates.Max<DateTime>();
            DateTime MinDate = FoundDates.Min<DateTime>();
            List<DateTime> ValidDates = DateListGenerator(MinDate, MaxDate);
            IEnumerable<DateTime> MissingDates = ValidDates.Except(FoundDates);

            return MissingDates.ToList<DateTime>();
        }
    }
}
