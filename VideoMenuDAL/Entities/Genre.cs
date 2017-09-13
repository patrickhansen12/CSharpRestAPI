using System;
using System.Collections.Generic;
using System.Text;

namespace VideoMenuDAL.Entities
{
    public class Genre
    {
        public int Id { get; set; }
        public String Horror { get; set; }
        public String Romance { get; set; }
        public String Minecraft { get; set; }
        public String Prank { get; set; }
        public Video Video { get; set; }
    }
}
