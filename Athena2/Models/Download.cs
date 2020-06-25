using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Athena.Models
{
    class Download
    {

        //Id	Progress	LinkId	At(DateTime)	
        public int Id { get; set; }
        public int Progress { get; set; }
        public int LinkId { get; set; }
        public DateTime At { get; set; }

        public virtual Link Link { get; set; }
    }
}
