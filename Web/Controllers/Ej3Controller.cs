using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Xml.Linq;
using Web.Ej3;

namespace Web.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class Ej3Controller : ControllerBase
    {
        private static List<Teacher> teachersList = new List<Teacher>();
        private static List<Student> studentsList = new List<Student>();

        public Ej3Controller() {
            teachersList.Add(new Teacher("Jhon", 36));
            studentsList.Add(new Student("George", 17));
        }

        [HttpPost("[action]")]//add new teacher to the teachers list
        public ActionResult AddTeacher([FromQuery] string name, [FromQuery] int age)
        {
            teachersList.Add(new Teacher(name, age));
            return Ok();
        }

        [HttpPost("[action]")]//add new student to the students list
        public ActionResult AddStudent([FromQuery] string name, [FromQuery] int age)
        {
            studentsList.Add(new Student(name, age));
            return Ok();
        }

        [HttpGet("[action]")]// search teacher for name and return a greeting
        public ActionResult<string> GetTeacherGreeting([FromQuery] string name)
        {
            Teacher teacher = teachersList.Find(p => p.Name == name);
            if (teacher != null)
            {
                return teacher.Greet();
            }else 
            { 
                return NotFound(); 
            }
        }

        [HttpGet("[action]")]// search teacher for name and make him explain
        public ActionResult<string> GetTeacherExplain([FromQuery] string name)
        {
            Teacher teacher = teachersList.Find(p => p.Name == name);
            if (teacher != null)
            {
                return teacher.Explain();
            }
            else
            {
                return NotFound();
            }
        }

        [HttpPut("[action]")]// search for a teacher and set his age
        public ActionResult UpdateTeacherAge([FromQuery] string name, [FromQuery] int age)
        {
            Teacher teacher = teachersList.Find(p => p.Name == name);
            if (teacher != null)
            {
                teacher.SetAge(age);
                return Ok();
            }
            else
            {
                return NotFound();
            }
        }

        [HttpPut("[action]")]// search for a student and set his age
        public ActionResult UpdateStudentAge([FromQuery] string name, [FromQuery] int age)
        {
            Student student = studentsList.Find(p => p.Name == name);
            if (student != null)
            {
                student.SetAge(age);
                return Ok();
            }
            else
            {
                return NotFound();
            }
        }

        [HttpGet("[action]")]// search student for name and return his age
        public ActionResult<string> GetStudentAge([FromQuery] string name)
        {
            Student student = studentsList.Find(p => p.Name == name);
            if (student != null)
            {
                return student.ShowAge();
            }
            else
            {
                return NotFound();
            }
        }

        [HttpGet("[action]")]// search student for name and return a greeting
        public ActionResult<string> GetStudentGreeting([FromQuery] string name)
        {
            Student student = studentsList.Find(p => p.Name == name);
            if (student != null)
            {
                return student.Greet();
            }
            else
            {
                return NotFound();
            }
        }

    }
}
