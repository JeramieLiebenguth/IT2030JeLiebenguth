using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCEnrollmentApplication.Models
{
    public class Course
    {
        public virtual int CourseId { get; set;}
        public virtual int CourseTitle { get; set; }
        public virtual int CourseDescription{ get; set; }
        public virtual int CourseCredits { get; set; }
    }
}