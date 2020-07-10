using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Athena.Models;

namespace Athena.ViewModels
{
    class MyDownloadTask
    {
        [Required]
        public int DownloadTaskId { get; set; }
        [Required]
        public string TaskName { get; set; }
        [Required]
        public string SourceUrl { get; set; }
        public string UrlFormat { get; set; }
        public string DownloadLocation { get; set; }
        public string DestinationFileFormat { get; set; }
        public int TaskProgress { get; set; }
        public string TaskStatus { get; set; }
        public bool Selected { get; set; }
        public virtual IList<Download> Downloads { get; set; }        
    }
}
