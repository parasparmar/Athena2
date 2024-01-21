using Athena.Services;
using Microsoft.EntityFrameworkCore;

namespace Athena.Models
{
    class FMViewModel
    {
        
        
        public static List<Download> GetDownloads(MyDownloadTask t)
        {            
            using (Helper db = new Helper())
            {
               var d = db.DownloadTasks
                      .Include(b => b.Link.Downloads)
                      .SingleOrDefault(a => a.Id == t.DownloadTaskId)
                      .Link
                      .Downloads
                      .ToList();
                return d;
            }            
        }

        public static List<Download> GetOrCreateDownloads(MyDownloadTask t)
        {
            List<Download> d;
            using (Helper db = new Helper())
            {
                d = db.DownloadTasks
                      .Include(b => b.Link.Downloads)
                      .SingleOrDefault(a => a.Id == t.DownloadTaskId)
                      .Link
                      .Downloads
                      .ToList();
            }            
            return d;
        }

        // Operation : Add MyDownloadTask to List<MyDownloadTask>.
        public static List<MyDownloadTask> AddOrUpdateTasks(MyDownloadTask t)
        {
            List<MyDownloadTask> returnValue = new List<MyDownloadTask>();
            using (Helper db = new Helper())
            {
                var records = db.DownloadTasks
                    .Include(b => b.Link)
                    .Include(c => c.Exchange)
                    .SingleOrDefault(a => a.Id == t.DownloadTaskId);
                int count = records != null ? 1 : 0;
                bool isExistingTask = (count > 0) ? true : false;

                if (isExistingTask)
                {
                    //Id
                    records.Name = t.TaskName;
                    records.Link.Name = $"{t.TaskName} Link";
                    records.Link.SourceURL = t.SourceUrl;
                    records.Link.FormattedURL = t.UrlFormat;
                    records.Link.Destination = t.DownloadLocation;
                    records.Link.DestinationFormat = t.DestinationFileFormat;
                    db.SaveChanges();
                }
                else
                {


                    //Add a new record with this TaskName.
                    Link l = new Link
                    {
                        Name = $"{t.TaskName} Link",
                        SourceURL = t.SourceUrl,
                        FormattedURL = t.UrlFormat,
                        Destination = t.DownloadLocation,
                        DestinationFormat = t.DestinationFileFormat
                    };
                    db.Links.Add(l);

                    Download download = new Download { At = DateTime.Today, LinkId = l.Id, Status = "Pending", SourceLink = URLParser.getThisDownloadsUrl(t.UrlFormat, DateTime.Today) };
                    db.Downloads.Add(download);

                    Exchange exchange = new Exchange();
                    if (l.SourceURL.ToLower().Contains("nseindia"))
                    {
                        exchange = db.Exchanges.SingleOrDefault(x => x.Name == "NSE");
                    }
                    else if (l.SourceURL.ToLower().Contains("bseindia"))
                    {
                        exchange = db.Exchanges.SingleOrDefault(x => x.Name == "BSE");
                    }
                    else
                    {
                        Uri j = new Uri(l.SourceURL);
                        exchange = new Exchange { Name = j.Host };
                        db.Exchanges.Add(exchange);
                        db.SaveChanges();
                    }
                    db.SaveChanges();
                    DownloadTask dt = new DownloadTask
                    {
                        Name = t.TaskName,
                        LinkId = l.Id,
                        ExchangeId = exchange.Id
                    };
                    db.DownloadTasks.Add(dt);
                    db.SaveChanges();
                }
                returnValue = GetTaskList();
            }
            return returnValue;
        }

        // Operation : Remove DownloadTasks(Id) from List<MyDownloadTask>
        public static List<MyDownloadTask> RemoveTasks(MyDownloadTask t)
        {
            List<MyDownloadTask> returnValue;
            using (Helper db = new Helper())
            {
                var records = db.DownloadTasks.Include(b => b.Link).Include(c => c.Exchange).SingleOrDefault(a => a.Id == t.DownloadTaskId);
                int count = records != null ? 1 : 0;
                bool isExistingTask = (count > 0) ? true : false;
                if (isExistingTask)
                {
                    db.Links.Remove(records.Link);
                    db.DownloadTasks.Remove(records);
                    db.SaveChanges();
                }
                returnValue = GetTaskList();
            }
            return returnValue;
        }

        public static MyDownloadTask GetMyDownloadTaskById(int id)
        {
            MyDownloadTask tasks;
            using (Helper db = new Helper())
            {

                tasks = db.DownloadTasks
                    .Include(a => a.Link)
                    .Include(a => a.Link.Downloads)
                    .Where(a => a.Id == id)
                    .Select(a => new MyDownloadTask
                    {
                        DownloadTaskId = a.Id,
                        TaskName = a.Name,
                        DownloadLocation = a.Link.Destination,
                        Selected = false,
                        SourceUrl = a.Link.SourceURL,
                        UrlFormat = a.Link.FormattedURL,
                        DestinationFileFormat = a.Link.DestinationFormat,
                        FileDownloads = a.Link.Downloads.Select(b => new FileDownload
                        {
                            Id = b.Id,
                            Date = b.At,
                            Destination = b.Link.Destination,
                            FileName = b.Link.DestinationFormat,                            
                            Status = b.Status,
                            TaskId = b.LinkId,
                            Url = b.SourceLink
                            //, ZippedFiles = b.
                        }).ToList()
                    }).FirstOrDefault();
            }
            return tasks;
        }

        // Operation : Populate Individual Task Details using the Drag and Drop Feature.
        // Operation : Reset the Individual Task List
        public static List<MyDownloadTask> GetTaskList()
        
        {
            List<MyDownloadTask> tasks = new List<MyDownloadTask>();
            using (Helper db = new Helper())
            {
                tasks = db.DownloadTasks
                    .Include(a => a.Link)
                    .Include(a => a.Link.Downloads)
                    .Select(a => new MyDownloadTask
                    {
                        DownloadTaskId = a.Id,
                        TaskName = a.Name,
                        DownloadLocation = a.Link.Destination,
                        Selected = false,
                        SourceUrl = a.Link.SourceURL,
                        UrlFormat = a.Link.FormattedURL,
                        DestinationFileFormat = a.Link.DestinationFormat,
                        FileDownloads = a.Link.Downloads.Select(b => new FileDownload
                        {
                            Id = b.Id,
                            Date = b.At,
                            Destination = b.Link.Destination,
                            FileName = b.Link.DestinationFormat,                            
                            Status = b.Status,
                            TaskId = b.LinkId,
                            Url = b.SourceLink
                            //, ZippedFiles = b.
                        }).ToList()
                    }).ToList();
            }
            return tasks;
        }
    }
}
