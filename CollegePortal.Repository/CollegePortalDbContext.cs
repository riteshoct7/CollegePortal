using CollegePortal.Entity.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CollegePortal.Repository
{
    public class CollegePortalDbContext : IdentityDbContext<User,Role,int>
    {

        #region Constructors

        public CollegePortalDbContext()
        {

        }

        public CollegePortalDbContext(DbContextOptions options) : base(options)
        {

        } 

        #endregion

        #region Properties

        public DbSet<Student> Students { get; set; }

        #endregion

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(@"Data Source=TBLSYS081\SQLEXPRESS;Initial Catalog=CollegePortal;Persist Security Info=True;User ID=sa;Password=tech123");

            }
            base.OnConfiguring(optionsBuilder);
        }
    }
}
