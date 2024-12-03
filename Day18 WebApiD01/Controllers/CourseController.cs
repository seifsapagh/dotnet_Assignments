using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApi_D01.Models;
namespace WebApi_D01.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CourseController : ControllerBase
    {
        static List<Course> Courses = new()
        {
            new Course(){ID=1,Name="Linear Algebra",Duration=5 },
            new Course(){ID=2,Name="Data structures & Algorithms",Duration=3 },
            new Course(){ID=3,Name="Discrete Mathmatics",Duration=3 },
            new Course(){ID=4,Name="Cryptography",Duration=2 },
            new Course(){ID=5,Name="Networks",Duration=4 }
        };

        [HttpGet]
        public List<Course> getAll()
        {
            return Courses;
        }
        
        [HttpGet("{name}")]
        public Course GetByName(string name)
        {
            
            Course course = Courses.Find(c=> c.Name == name);

            return course == null ?  new Course() { ID = 0, Name = "Course NoT Found", Duration = 5 } : course;
        }

        [HttpPost("add")]
        public List<Course> AddCourse(Course course)
        {
            Courses.Add(course);
            return Courses;
        }
    }
}
