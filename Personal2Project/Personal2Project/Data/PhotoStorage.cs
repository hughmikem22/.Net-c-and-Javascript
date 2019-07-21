using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Personal2Project.Data
{
    public class PhotoStorage
    {
        [Key]
        public int ImgID { get; set; }
        public string ImageName { get; set; }
        
         public string ImageFile { get; set; }
    }
}
