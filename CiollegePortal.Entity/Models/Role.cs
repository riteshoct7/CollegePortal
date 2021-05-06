using Microsoft.AspNetCore.Identity;

namespace CollegePortal.Entity.Models
{
    public class Role :IdentityRole<int>
    {
        #region Properties
        public string Description { get; set; } 

        #endregion
    }
}
