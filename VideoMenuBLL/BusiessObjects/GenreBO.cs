using System;
using System.Collections.Generic;
using System.Text;
using VideoMenuBLL.BusinessObjects;

namespace VideoMenuBLL.BusiessObjects
{
    public class GenreBO
    {
        public int Id { get; set; }
        public String Horror { get; set; }
        public String Romance { get; set; }
        public String Minecraft { get; set; }
        public String Prank { get; set; }
        public VideoBO Video { get; set; }
    }
}
