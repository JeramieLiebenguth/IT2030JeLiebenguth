using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FinalProject.Models
{
    public class EventType
    {
        public virtual int EventTypeID { get; set; }
        public virtual string EventTypeName { get; set; }
        public virtual List<OrganizeEvent> OrganizeEvent { get; set; }
    }
}