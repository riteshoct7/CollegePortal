using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;
using System;
using System.ComponentModel.DataAnnotations;

namespace CollegePortal.Entity.Models
{
    public class User : IdentityUser<int>
    {
        #region Properties

        [Required]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Display(Name = "Middle Initials")]
        public string MiddleInitials { get; set; }

        [Required]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Required]
        [Display(Name = "Subscribed For Promotions")]
        public bool SubscribedForPromotions { get; set; }

        [Required]        
        [Display(Name = "Accepted Terms Condition")]
        public bool AcceptedTermsCondition { get; set; }

        [NotMapped]
        public string[] Role { get; set; } 

        #endregion

    }
}
