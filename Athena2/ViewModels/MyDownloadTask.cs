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
        public int TaskId { get; set; }
        [Required]
        public string TaskName { get; set; }
        [Required]
        public string SourceUrl { get; set; }
        public string UrlFormat { get; set; }
        public string DownloadLocation { get; set; }
        public string DestinationFileFormat { get; set; }
        public string TaskProgress { get; set; }
        public IList<Download> IndividualDownloads { get; set; }        
        public bool Selected { get; set; }
    }
}
