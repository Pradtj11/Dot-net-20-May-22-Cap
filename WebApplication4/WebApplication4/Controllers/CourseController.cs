using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication4.Models;

namespace WebApplication4.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CourseController : ControllerBase
    {
        [HttpGet]
        public List<Course> Get()
        {
            SampleDB4Context db = new SampleDB4Context();
            return db.Courses.ToList();
        }
        [HttpPost]
        public string Post([FromBody] string CourseName)
        {
            SampleDB4Context db = new SampleDB4Context();
            Course c = new Course();
            c.CourseName = CourseName;
            db.Courses.Add(c);
            db.SaveChanges();
            return "Success";
        }

        [HttpPut]
        public string Put([FromBody] Course c)
        {
            SampleDB4Context db = new SampleDB4Context();
            var stuObj = db.Courses.Where(x => x.Id == c.Id);
            if (stuObj != null)
            {
                db.Courses.Update(c);
                db.SaveChanges();
                return "Success";
            }

            return "Fail";
        }

        [HttpDelete]
        public string Delete([FromBody] int Id)
        {
            SampleDB4Context db = new SampleDB4Context();
            var CoObj = db.Courses.Where(x => x.Id == Id).FirstOrDefault();
            if (CoObj != null)
            {
                db.Courses.Remove(CoObj);
                db.SaveChanges();
                return "Seccess";
            }
            return "Fail";
        }

    }
}
