using CollegePortal.Entity.Models;
using System.Collections.Generic;

namespace CollegePortal.Services.Interfaces
{
    public interface IStudentService
    {
        #region Methods

        Student GetStudentByid(int id);

        IEnumerable<Student> GetAllStudents();

        void SaveStudent(Student objStudent);
        void UpdateStudent(Student objStudent);

        void DeleteStudent(Student objStudent);

        void DeleteStudent(int id);

        void RemoveStudent(Student objStudent);

        #endregion
    }
}
