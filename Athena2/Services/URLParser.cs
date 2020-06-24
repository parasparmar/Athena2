using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Athena.Services
{
    class URLParser
    {


        public static string Tokenize(Uri sourceUrl)
        {
            DateTime today = new DateTime();
            StringBuilder s = new StringBuilder(sourceUrl.AbsolutePath);
            s.Replace(today.Year.ToString("yyyy"), "{yyyy}");
            s.Replace(today.Month.ToString("MM"), "{MM}");
            s.Replace(today.Day.ToString(), "{dd}");
            return s.ToString();
        }
    }
}
