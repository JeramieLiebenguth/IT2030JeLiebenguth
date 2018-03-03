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
            [Range (1, 50, ErrorMessage = "Last Name")]
        public virtual int StudentLastName{ get; set; }
        [Required]
        [Range(1, 50, ErrorMessage = "First Name")]
        public virtual int StudentFirstName { get; set; }
    }
}