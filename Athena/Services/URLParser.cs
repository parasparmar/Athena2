﻿using System.Globalization;
using System.Text;
using System.Text.RegularExpressions;
using System.Web;

namespace Athena.Services
{
    class URLParser
    {
        public static string[] DateFormats = new string[] { "ddMMyy", "ddMMyyyy", "ddMMMyy", "ddMMMyyyy", "MMMddyyyy", "MMMddyy", "MMddyyyy", "yyyyMMdd", "yyyyMMMdd", "yyMMMdd", "yyyy", "YYYY", "yy", "MM", "MMM", "dd", "ddd" };
        public static string Tokenize(Uri sourceUrl)
        {

            string s = sourceUrl.AbsoluteUri;
            var reg = DatesWithoutAlphabets();
            var matchedDate = reg.Match(s).Value;
            DateTime dt;
            if (matchedDate != null && matchedDate.Length > 0)
            {
                foreach (var item in DateFormats)
                {
                    if (DateTime.TryParseExact(matchedDate, item, CultureInfo.InvariantCulture, DateTimeStyles.None, out dt))
                    {
                        //parsed correctly                   
                        s = s.Replace(dt.ToString(item), "{" + item + "}");
                        return s;
                    }
                }
            }

            return s;
        }
        public static string Tokenize(string sourceUrl)
        {
            var sourceurl = new Uri(sourceUrl);
            string s = string.Empty;
            if (sourceurl.IsWellFormedOriginalString())
            {

                s = sourceurl.AbsoluteUri;
                var reg = DatesWithoutAlphabets();
                var matchedDate = reg.Match(s).Value;
                if (matchedDate != null && matchedDate.Length > 0)
                {
                    DateTime dt;
                    foreach (var item in DateFormats)
                    {
                        if (DateTime.TryParseExact(matchedDate, item, CultureInfo.InvariantCulture, DateTimeStyles.None, out dt))
                        {
                            //parsed correctly                   
                            s = s.Replace(dt.ToString(item), "{" + item + "}");
                            return s;
                        }
                    }
                }
            }

            return s;
        }
        public static string getDestinationFileName(string sourceUrl, string destinationFolder)
        {
            Uri a = new Uri(sourceUrl);
            var fileName = a.Segments[a.Segments.Length - 1];
            fileName = HttpUtility.UrlDecode(fileName);
            DirectoryInfo d = new DirectoryInfo(destinationFolder);
            var combinedPath = string.Empty;
            if (d.Exists)
            {
                combinedPath = Path.Combine(new string[] { destinationFolder, fileName });
            }

            return combinedPath;
        }

        public static List<string> getDownloadUrls(string formattedUrl, IEnumerable<DateTime> days)
        {
            List<string> Urls = new List<string>();
            string dateFormat = string.Empty;

            int begin = formattedUrl.IndexOf('{') + 1;
            int end = formattedUrl.IndexOf('}') - 1;
            int chars = end - begin;
            dateFormat = formattedUrl.Substring(begin + 1, chars);
            //dateFormat = DateFormats.Where(a => formattedUrl.Equals(a)).FirstOrDefault();
            if (dateFormat != null)
            {
                foreach (var day in days)
                {
                    Urls.Add(formattedUrl.Replace($"{{{dateFormat}}}", day.ToString(dateFormat, CultureInfo.InvariantCulture)));
                }
            }

            return Urls;
        }

        public static string getThisDownloadsUrl(string formattedUrl, DateTime day)
        {
            string dateFormat = string.Empty;
            int begin = 0;
            int end = 0;
            int chars = 0;

            int beginTokenCount = 0;
            int endTokenCount = 0;
            beginTokenCount = formattedUrl.Count(c => c.Equals('{'));
            endTokenCount = formattedUrl.Count(c => c.Equals('}'));

            if (beginTokenCount == endTokenCount)
            {
                StringBuilder sb = new StringBuilder(formattedUrl);
                for (int i = 0; i < beginTokenCount; i++)
                {
                    begin = formattedUrl.IndexOf('{', begin) ;
                    end = formattedUrl.IndexOf('}', begin);
                    chars = end - (begin + 1);
                    dateFormat = formattedUrl.Substring(begin+1, chars);
                    if (dateFormat != null)
                    {
                        sb.Replace($"{{{dateFormat}}}", day.ToString(dateFormat, CultureInfo.InvariantCulture).ToUpper(CultureInfo.InvariantCulture));
                    }
                    begin++;
                }
                return sb.ToString();
            }
            return string.Empty;
        }

        /// <summary>
        /// Paras Parmar : https://regexr.com/57bgg 
        /// Here's a regex that checks the right number of days per month, including for February during leap years:
        /// var reg = new Regex(@"\b(((0?[469]|11)/(0?[1-9]|[12]\d|30)|(0?[13578]|1[02])/(0?[1-9]|[12]\d|3[01])|0?2/(0?[1-9]|1\d|2[0-8]))/([1-9]\d{3}|\d{2})|0?2/29/([1-9]\d)?([02468][048]|[13579][26]))\b", RegexOptions.ECMAScript | RegexOptions.ExplicitCapture);
        /// Breaking up the regex this way should be easy to understand:
        /// Months with 30 days: 0?[469]|11
        /// Days maxed at 30: 0?[1-9]|[12]\d|30
        /// Months with 31 days: 0?[13578]|1[02]
        /// Days maxed at 31: 0?[1-9]|[12]\d|3[01]
        /// Days maxed at 28: 0?[1-9]|1\d|2[0-8]
        /// Any year from 1000+ (including 2 digit years): [1-9]\d{3}|\d{2}
        /// Feb 29: 0?2/29
        /// Last two digits of leap years(divisible by 4): [02468] [048]|[13579]
        /// [26]
        /// RegexOptions.ECMAScript is important to specify to ensure \d only matches 0-9 digits from English.
        /// RegexOptions.ExplicitCapture eliminates the need for non-capturing groups of(?:)
        /// </summary>
        /// <returns></returns>
        private static Regex DatesWithoutAlphabets()
        {
            // Dates without seperators.
            //Regex reg = new Regex(@"((?:(?:0?[469]|11)(?:0?[1-9]|[12]\d|30)|(?:0?[13578]|1[02])(?:0?[1-9]|[12]\d|3[01])|0?2(?:0?[1-9]|1\d|2[0-8]))(?:\d{4}|\d{2})(?:\d{4}|\d{2})|0?2?29?(?:[1-9]\d)?(?:[02468][048]|[13579][26]))", RegexOptions.ECMAScript);
            Regex reg = new Regex(@"((?:(?:0?[469]|11)(?:0?[1-9]|[12]\d|30)|(?:0?[13578]|1[02])(?:0?[1-9]|[12]\d|3[01])|0?2(?:0?[1-9]|1\d|2[0-8]))(?:[_\/.\- ]?)(?:\d{4}|\d{2})(?:[_\/.\- ]?)(?:\d{4}|\d{2})|0?2?29?(?:[1-9]\d)?(?:[02468][048]|[13579][26]))", RegexOptions.ECMAScript);
            return reg;
        }
        private static Regex DatesWithAlphabets()
        {
            // Dates without seperators.
            //Regex reg = new Regex(@"((?:(?:0?[469]|11)(?:0?[1-9]|[12]\d|30)|(?:0?[13578]|1[02])(?:0?[1-9]|[12]\d|3[01])|0?2(?:0?[1-9]|1\d|2[0-8]))(?:\d{4}|\d{2})(?:\d{4}|\d{2})|0?2?29?(?:[1-9]\d)?(?:[02468][048]|[13579][26]))", RegexOptions.ECMAScript);
            Regex reg = new Regex(@"((?:(?:0?[469]|11)(?:0?[1-9]|[12]\d|30)|(?:0?[13578]|1[02])(?:0?[1-9]|[12]\d|3[01])|0?2(?:0?[1-9]|1\d|2[0-8]))(?:[_\/.\- ]?)(?:\d{4}|\d{2})(?:[_\/.\- ]?)(?:\d{4}|\d{2})|0?2?29?(?:[1-9]\d)?(?:[02468][048]|[13579][26]))", RegexOptions.ECMAScript);
            return reg;
        }
    }
}
