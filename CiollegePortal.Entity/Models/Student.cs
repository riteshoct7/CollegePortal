using System;
using System.ComponentModel.DataAnnotations;

namespace CollegePortal.Entity.Models
{
    public class Student
    {
        #region Properties
        public int StudentId { get; set; }

        [Required]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Display(Name = "Middle Initials")]
        public string MiddleInitials { get; set; }

        [Required]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }


        [Required]
        [Display(Name = "Birthday")]
        public DateTime DateOfBirth { get; set; } 
        #endregion
    }
}
