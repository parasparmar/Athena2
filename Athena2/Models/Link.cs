using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Athena.Models
{
    class Link
    {
        //Id	Name	SourceURL	FormattedURL	Destination	DestinationFormat
        public int Id { get; set; }
        public string Name { get; set; }
        public string SourceURL { get; set; }
        public string FormattedURL { get; set; }
        public string Destination { get; set; }
        public string DestinationFormat { get; set; }

    }
}
