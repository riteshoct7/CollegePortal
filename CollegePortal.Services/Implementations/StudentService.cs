using CollegePortal.Entity.Models;
using CollegePortal.Repository.Interfaces;
using CollegePortal.Services.Interfaces;
using System.Collections.Generic;

namespace CollegePortal.Services.Implementations
{
    public class StudentService : IStudentService
    {
        #region Properties

        private readonly IStudentRepository studentRepository;

        #endregion

        #region Constructors

        public StudentService(IStudentRepository studentRepository)
        {
            this.studentRepository = studentRepository;
        }

        #endregion

        #region Methods

        public void DeleteStudent(Student objStudent)
        {
            studentRepository.Delete(objStudent);
            studentRepository.SaveChanges();
        }

        public void DeleteStudent(int id)
        {
            studentRepository.Delete(id);
            studentRepository.SaveChanges();
        }

        public IEnumerable<Student> GetAllStudents()
        {
            return studentRepository.GetAll();            
        }

        public Student GetStudentByid(int id)
        {
            return studentRepository.GetById(id);
        }

        public void RemoveStudent(Student objStudent)
        {
            studentRepository.Remove(objStudent);
            studentRepository.SaveChanges();
        }

        public void SaveStudent(Student objStudent)
        {
            studentRepository.Add(objStudent);
            studentRepository.SaveChanges();
        }

        public void UpdateStudent(Student objStudent)
        {
            studentRepository.Update(objStudent);
            studentRepository.SaveChanges();
        } 

        #endregion
    }
}
