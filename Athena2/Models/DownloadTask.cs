using System.ComponentModel.DataAnnotations.Schema;

namespace Athena.Models
{

    class DownloadTask
    {       
        
        public int Id { get; set; }
        public string Name { get; set; }        
        public int LinkId { get; set; }        
        public int ExchangeId { get; set; }
        public virtual Link Link { get; set; }
        public virtual Exchange Exchange { get; set; }
    }
}
