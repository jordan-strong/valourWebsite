using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace velour.Models
{
    public class ShowModel
    {
        public int showID { get; set; }
        public string showName { get; set; }
        public int artistID { get; set; }
        public string artistName { get; set; }
        public string genre { get; set; }
        public DateTime showTime { get; set; }
    }
}