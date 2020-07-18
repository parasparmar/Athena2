using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Athena.Models
{


    public class FileDownloads
    {
        public int Id { get; set; }
        public int TaskId { get; set; }
        public DateTime Date { get; set; }
        public string Url { get; set; }
        public string Destination { get; set; }
        public string FileName { get; set; }
        public int Progress { get; set; }
        public string Status { get; set; }
        public IList<string> Files { get; set; }
    }
}
