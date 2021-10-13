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
    public class CourseController : ControllerBase
    {
        private readonly ApplicationContext appContext;
        public CourseController(ApplicationContext applicationContext)
        {
            appContext = applicationContext;
        }
        [HttpGet("getcourses")]
        public List<Course> GetCourses()
        {
            //var courses = from teacher in appContext.teachers
            //              join course in appContext.courses on teacher.TeacherId equals course.TeacherId
            //              select new CourseViewModel { 
            //                  CourseId= course.CourseId,
            //                  CourseName = course.CourseName,
            //                  IsActive= course.IsActive,Name= teacher.Name };
            // appContext.courses.ToList();
            return appContext.courses.ToList();

        }
        //public List<CourseViewModel> GetCoursesByTeacher(int teacherId)
        //{
        //    var courses = from teacher in appContext.teachers
        //                  join course in appContext.courses on teacher.TeacherId equals course.TeacherId
        //                  where teacher.TeacherId == teacherId
        //                  select new CourseViewModel
        //                  {
        //                      CourseId = course.CourseId,
        //                      CourseName = course.CourseName,
        //                      IsActive = course.IsActive,
        //                      Name = teacher.Name
        //                  };
        //    // appContext.courses.ToList();
        //    return courses.ToList();
        //}
        [HttpGet("getcourse/{courseId}")]
        public Course GetCourse(int courseId)
        {
            var course = appContext.courses.Where(x => x.CourseId == courseId).FirstOrDefault();
            return course;
        }
        [HttpDelete("deletecourse/{courseId}")]
        public bool DeleteCourse(int courseId)
        {
            var course = appContext.courses.Where(x => x.CourseId == courseId).FirstOrDefault();
            appContext.courses.Remove(course);
            appContext.SaveChanges();
            return true;
        }
        [HttpPost("updatecourse")]
        public bool UpdateCourse(CourseRequest course)
        {
            var courseObj = appContext.courses.Where(x => x.CourseId == course.CourseId).FirstOrDefault();
            courseObj.CourseName = course?.CourseName;
            courseObj.IsActive = course.IsActive;
            appContext.SaveChanges();
            return true;
        }
        [HttpPost("addcourse")]
        public bool AddCourse(CourseRequest course)
        {
            var courseObj = new Course()
            {
                CourseName = course?.CourseName,
                IsActive = course.IsActive,

            };
            appContext.courses.Add(courseObj);
            appContext.SaveChanges();
            return true;
        }
    }
}