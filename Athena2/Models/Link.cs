namespace Athena.Models
{
    class Link
    {        
        public int Id { get; set; }
        public string Name { get; set; }
        public string SourceURL { get; set; }
        public string FormattedURL { get; set; }
        public string Destination { get; set; }
        public string DestinationFormat { get; set; }
    }
}
