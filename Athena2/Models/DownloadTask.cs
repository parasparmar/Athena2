using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Athena.Models
{
    class DownloadTask
    {
        //Id Name    LinkId ExchangeId
        public int Id { get; set; }
        public string Name { get; set; }
        public int LinkId { get; set; }
        public int ExchangeId { get; set; }

        public virtual Link Link { get; set; }
        public virtual Exchange Exchange { get; set; }
    }
}
