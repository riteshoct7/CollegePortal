using CollegePortal.Entity.Models;

namespace CollegePortal.Repository.Interfaces
{
    public interface IStudentRepository :IRepository<Student>
    {
        #region Methods

        Student GetStudentByFirstName(string firstName);

        Student GetStudentByLastName(string lastName); 

        #endregion
    }
}
