using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using services.DbContexts;
using services.Enitities;
using services.Enitities.Request;
using services.Enitities.ViewModels;

namespace services.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeacherController : ControllerBase
    {
        private readonly ApplicationContext appContext;
        public TeacherController(ApplicationContext applicationContext)
        {
            appContext = applicationContext;
        }
        [HttpGet("getteachers")]
        public List<Teacher> GetTeachers()
        {
            return appContext.teachers.ToList();

        }
        [HttpGet("getteacher/{teacherId}")]
        public Teacher GetTeacher(int teacherId)
        {
            var teacher = appContext.teachers.Where(x => x.TeacherId == teacherId).FirstOrDefault();
            return teacher;
        }
        [HttpDelete("deleteteacher/{teacherId}")]
        public bool DelateTeacher(int teacherId)
        {
            try
            {
                var teacher = appContext.teachers.Where(x => x.TeacherId == teacherId).FirstOrDefault();
                appContext.teachers.Remove(teacher);
                appContext.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            //return false;

        }
        [HttpPost("updateteacher")]
        public bool UpdateTeacher(TeacherRequest teacher)
        {
            try
            {
                var teach = appContext.teachers
                      .Where(obj => obj.TeacherId == teacher.TeacherId).FirstOrDefault();
                teach.Name = teacher?.Name;
                teach.Expreance = teacher.Expreance;
                teach.Subject = teacher.Subject;
                appContext.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        [HttpPost("addteacher")]
        public bool AddStudent(TeacherRequest teacherRequest)
        {
            try
            {
                var teacher = new Teacher()
                {
                    Name = teacherRequest?.Name,
                    Subject = teacherRequest.Subject,
                    Expreance = teacherRequest.Expreance
                };
                appContext.teachers.Add(teacher);
                appContext.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        [HttpGet("getteacherforcourse")]
        public List<TeacherViewModel> GetTeacherForCourse()
        {
            return appContext.teachers.Select(x => new TeacherViewModel() { Name = x.Name, TeacherId = x.TeacherId }).ToList();
        }
    }
}