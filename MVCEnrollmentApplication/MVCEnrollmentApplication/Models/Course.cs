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
        [StringLength(150, ErrorMessage = "Course Title")]
        public virtual string CourseTitle { get; set; }
        [Required(ErrorMessage = "Course Description")]
        public virtual string CourseDescription{ get; set; }
        [Required]
        [Range(1, 4, ErrorMessage = "Course Credits")]
        public virtual int CourseCredits { get; set; }
    }
}