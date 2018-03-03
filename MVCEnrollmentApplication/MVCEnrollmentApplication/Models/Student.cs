using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MVCEnrollmentApplication.Models
{
    public class Student
    {
        [Required(ErrorMessage = "Student ID")]
        public virtual int StudentId { get; set; }
        [Required]
            [StringLength(50, ErrorMessage = "Last Name")]
        public virtual string StudentLastName{ get; set; }
        [Required]
        [StringLength(50, ErrorMessage = "First Name")]
        public virtual string StudentFirstName { get; set; }
    }
}