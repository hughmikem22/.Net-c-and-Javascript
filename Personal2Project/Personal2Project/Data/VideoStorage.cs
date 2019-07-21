using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Personal2Project.Data
{
    public class VideoStorage
    {
        [Key]
        public int VideoId { get; set; }
        
        public string VideoName { get; set; }
        public string PersonName { get; set; }
        public string YoutubeCode { get; set; }

    }
}
