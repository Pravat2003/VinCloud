using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using services.DbContexts;
using services.Enitities;
using services.Enitities.Request;

namespace services.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly ApplicationContext appContext;
        public StudentController(ApplicationContext applicationContext)
        {
            appContext = applicationContext;
        }
        [HttpGet("getstudents")]
        public List<Student> GetStudents()
        {
            return appContext.students.ToList();
          
        }
        [HttpGet("getstudent/{studentId}")]
        public Student GetStudent(int studentId)
        {
            var student = appContext.students.Where(x => x.StudentId == studentId).FirstOrDefault();
            return student;
        }
        [HttpDelete("deletestudent/{studentId}")]
        public bool DelateStudent(int studentId)
        {
            try
            {
                var student = appContext.students.Where(x => x.StudentId == studentId).FirstOrDefault();
                appContext.students.Remove(student);
                appContext.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            //return false;

        }
        [HttpPost("updatestudent")]
        public bool UpdateStudent(StudentRequest studentRequest)
        {
            try
            {
                var student = appContext.students
                      .Where(obj => obj.StudentId == studentRequest.StudentId).FirstOrDefault();
                student.Name = studentRequest?.Name;
                student.StudyIn = studentRequest.StudyIn;
                student.Age = studentRequest.Age;
                student.Address = studentRequest.Address;
                appContext.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpPost("addstudent")]
        public bool AddStudent(StudentRequest studentRequest)
        {
            try
            {
                var student = new Student()
                {
                    Name = studentRequest?.Name,
                    StudyIn = studentRequest.StudyIn,
                    Age = studentRequest.Age,
                    Address = studentRequest.Address
                };
                appContext.students.Add(student);
                appContext.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}