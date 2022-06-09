using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication4.Models;
using WebApplication4.ViewModel;

namespace WebApplication4.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        [HttpGet]
        public List<Student> Get()
        {
            SampleDB4Context db = new SampleDB4Context();
            return db.Students.ToList();
        }
        [HttpGet]
        [Route("StudentByCourse")]
        public List<StudentWithCourse> GetStudentByCourse()
        {
            SampleDB4Context db = new SampleDB4Context();
            return db.Students.Join(db.Courses, x => x.Id, y => y.CourseId, (x, y) => new StudentWithCourse { CourseName = y.CourseName, Name = x.Name, Id = x.Id }).ToList();
        }
        [HttpPost]
        public string Post([FromBody] string Name)
        {
            SampleDB4Context db = new SampleDB4Context();
            Student s = new Student();
            s.Name = Name;
            db.Students.Add(s);
            db.SaveChanges();
            return "Success";
        }

        [HttpPut]
        public string Put([FromBody] Student s)
        {
            SampleDB4Context db = new SampleDB4Context();
            var stuObj = db.Students.Where(x => x.Id == s.Id);
            if (stuObj != null)
            {
                db.Students.Update(s);
                db.SaveChanges();
                return "Success";
            }

            return "Fail";
        }

        [HttpDelete]
        public string Delete([FromBody] int Id)
        {
            SampleDB4Context db = new SampleDB4Context();
            var stuObj = db.Students.Where(x => x.Id == Id).FirstOrDefault();
            if (stuObj != null)
            {
                db.Students.Remove(stuObj);
                db.SaveChanges();
                return "Seccess";
            }
            return "Fail";
        }

    }
}
