
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication3.Models;

namespace WebApplication3.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        [HttpGet]
        public List<Employee> Get()
        {
            SampleDB3Context db = new SampleDB3Context();
            return db.Employees.ToList();
        }
        [HttpPost]
        public string Post([FromBody] string sample)
        {
            SampleDB3Context db = new SampleDB3Context();
            Employee emp = new Employee();
            emp.FirstName = sample;
            db.Employees.Add(emp);
            db.SaveChanges();
            return "Success";
        }

        [HttpPut]
        public string Put([FromBody] Employee emp)
        {
            SampleDB3Context db = new SampleDB3Context();
            var empObj = db.Employees.Where(x => x.Id == emp.Id);
            if (empObj != null)
            {
                db.Employees.Update(emp);
                db.SaveChanges();
                return "Success";
            }

            return "Fail";
        }

        [HttpDelete]
        public string Delete([FromBody] int Id)
        {
            SampleDB3Context db = new SampleDB3Context();
            var empObj = db.Employees.Where(x => x.Id == Id).FirstOrDefault();
            if (empObj != null)
            {
                db.Employees.Remove(empObj);
                db.SaveChanges();
                return "Seccess";
            }
            return "Fail";
        }
    }
}
