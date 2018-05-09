using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace FinalProject.Models
{
    public class OrganizeEvent
    {
        public virtual int EventId { get; set; }
        public virtual int OrganizeEventId { get; set; }
        public virtual int EventTypeId { get; set; }
        [Required]
        [StringLength(50, ErrorMessage = "Title")]
        public virtual string Title { get; set; }
        [Required]
        [StringLength(150, ErrorMessage = "Description")]
        public virtual string Description { get; set; }
        public virtual int StartDate { get; set; }
        public virtual int EndDate { get; set; }
        public virtual int StartTime { get; set; }
        public virtual int EndTime { get; set; }
        public virtual string Location { get; set; }
        public virtual EventType EventType { get; set; }
        public virtual Event Event { get; set; }
        public virtual string OrganizerName { get; set; }
        public virtual string ConntactInfo { get; set; }
        public virtual int MaxTickets { get; set; }
        [Range(0, 100, ErrorMessage = "Max Tickets allowed is 100")]
        public virtual int AvailableTickets { get; set; } 
    }
}