using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using VideoMenuBLL.BusiessObjects;

namespace VideoMenuBLL.BusinessObjects
{
    public class VideoBO
    {
        public int Id { get; set; }
       [Required]
       [MaxLength(20)]
       [MinLength(2)]
        public string Name { get; set; }
        //public GenreBO Genre { get; set; }

    }
}
