﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Athena.Models
{
    class Link
    {


        [Required]
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string SourceURL { get; set; }
        public string FormattedURL { get; set; }
        public string Destination { get; set; }
        public string DestinationFormat { get; set; }        
        public virtual IList<Download> Downloads { get; set; }

        internal Download Download1
        {
            get => default;
            set
            {
            }
        }
    }
}
