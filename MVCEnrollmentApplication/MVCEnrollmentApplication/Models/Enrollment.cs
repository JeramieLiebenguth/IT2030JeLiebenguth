using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCEnrollmentApplication.Models
{
    public class Enrollment
    {
        public virtual int EnrollmentId { get; set; }
        public virtual int StudentId { get; set; }
        public virtual int CourseId { get; set; }
        public virtual int Grade { get; set; }
        public virtual int StudentObject { get; set; }
        public virtual int CourseObject { get; set; }
    }
}