using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace ContosoUniversity.Models
{
    public class Student
    {
        //[DisplayName("Student Name")]

        public int ID { get; set; }

        [DisplayName("Last Name")]
        public string LastName { get; set; }

        [DisplayName("Middle Name")]
        public string FirstMidName { get; set; }

        [DisplayName("Enrollment Date")]
        public DateTime EnrollmentDate { get; set; }

        public virtual ICollection<Enrollment> Enrollments { get; set; }
    }
}