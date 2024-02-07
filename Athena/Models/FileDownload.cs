/*
* URL of the file to download
* UserAgent for the browser to emulate
* Destination Folder to place the file in.
* Destination FileName to rename the file to.
* RETURNS
* ZippedFiles Status - Success or failure for the download of each file
*/
namespace Athena.Models
{
    public class FileDownload
    {
        public int Id { get; set; }
        public int TaskId { get; set; }
        public DateTime Date { get; set; }
        public string Url { get; set; }
        public string Destination { get; set; }
        public string FileName { get; set; }
        public string Status { get; set; }
        public IList<string> ZippedFiles { get; set; }
    }
}
