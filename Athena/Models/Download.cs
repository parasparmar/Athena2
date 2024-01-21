using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Athena.Models
{
    class Download
    {  
        public int Id { get; set; }
        public int LinkId { get; set; }
        public string SourceLink { get; set; }
        public string Status { get; set; }
        public DateTime At { get; set; }
        public virtual Link Link { get; set; }
    }
}
