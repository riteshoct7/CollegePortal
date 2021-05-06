using CollegePortal.Entity.Models;
using CollegePortal.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace CollegePortal.Repository.Implementations
{
    public class StudentRepository : Repository<Student>, IStudentRepository
    {

        #region Constructors

        public StudentRepository(DbContext db) : base(db)
        {

        }

        #endregion

        #region Properties
        CollegePortalDbContext collegePortalDbContext
        {
            get
            {
                return dbContext as CollegePortalDbContext;
            }
        }

        #endregion

        #region Methods

        public Student GetStudentByFirstName(string firstName)
        {
            return collegePortalDbContext.Students.Where(x => x.FirstName == firstName).FirstOrDefault();
        }

        public Student GetStudentByLastName(string lastName)
        {
            return collegePortalDbContext.Students.Where(x => x.LastName == lastName).FirstOrDefault();
        } 

        #endregion

    }
}
