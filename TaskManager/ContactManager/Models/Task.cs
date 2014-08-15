using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ContactManager.Models
{
    public class Task
    {
        public int TaskID { get; set; }
        public String Title { get; set; }
        public String Description { get; set; }
        public bool IsComplete { get; set; }
        
    }
}
