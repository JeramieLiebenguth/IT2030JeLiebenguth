using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MVCEnrollmentApplication.Models
{
    public class Enrollment
    {
        public virtual int EnrollmentId { get; set; }
        public virtual int StudentId { get; set; }
        public virtual int CourseId { get; set; }
        [RegularExpression(@"[A-F]")]
        public virtual String Grade { get; set; }
        public virtual int StudentObject { get; set; }
        public virtual int CourseObject { get; set; }
        public virtual Boolean IsActive { get; set; }
        [Required(ErrorMessage = "Assigned Campus")]
        public virtual string AssignedCampus { get; set; }
        [Required(ErrorMessage = "Enrolled in Semester")]
        public virtual string EnrollmentSemester { get; set; }
        [Required]
        [Range(2018, 2022, ErrorMessage = "Cannot be Less than 2018")]
        public virtual string EnrollmentYear { get; set; }
    }
}