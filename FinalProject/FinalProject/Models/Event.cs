using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FinalProject.Models
{
    public class Event
    {
        public virtual int EventId { get; set; }
        public virtual string Title { get; set; }
        public virtual string Description { get; set; }
        public virtual int StartDate { get; set; }
        public virtual int EndDate { get; set; }
        public virtual int StartTime { get; set; }
        public virtual int EndTime { get; set; }
        public virtual string Location { get; set; }
        public virtual string OrganizerName { get; set; }
        public virtual string ConntactInfo { get; set; }
    }
}