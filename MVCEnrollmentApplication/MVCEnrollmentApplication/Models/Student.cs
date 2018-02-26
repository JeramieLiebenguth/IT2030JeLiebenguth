using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCEnrollmentApplication.Models
{
    public class Student
    {
        public virtual int StudentId { get; set; }
        public virtual int StudentLastName{ get; set; }
        public virtual int StudentFirstName { get; set; }
    }
}