using Athena.Models;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Athena.Models
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
        public IList<FileDownload> FileDownloads { get; set; }

        public FileDownload FileDownload
        {
            get => default;
            set
            {
            }
        }
    }
}
