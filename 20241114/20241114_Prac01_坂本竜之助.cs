using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_._20241114
{
    internal class _20241114_Prac01_坂本竜之助
    {
        public record Course(string CourseName,int Credits);
        public record Student(string Name,List<Course> Courses);

        static void Main(string[] args)
        {
            List<Course> courses = new System.Collections.Generic.List<Course>();

            var course = new Course("A",10);
            var course1 = new Course("B", 10);
            var course2 = new Course("C", 10);

            courses.Add(course);
            courses.Add(course1);
            courses.Add(course2);
           
            var student = new Student("バリボ山本", courses);

            Console.WriteLine(student.Name);
            foreach (var str in student.Courses)
            {
                Console.WriteLine(str);
            }

           
        }
    }
}
