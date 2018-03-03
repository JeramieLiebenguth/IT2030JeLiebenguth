using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MVCEnrollmentApplication.Models
{
    public class Course
    {
        [Required(ErrorMessage = "Course ID")]
        public virtual int CourseId { get; set;}
        [Required]
        [Range(1, 150, ErrorMessage = "Course Title")]
        public virtual int CourseTitle { get; set; }
        [Required(ErrorMessage = "Course Description")]
        public virtual int CourseDescription{ get; set; }
        [Required]
        [Range(1, 4, ErrorMessage = "Course Credits")]
        public virtual int CourseCredits { get; set; }
    }
}