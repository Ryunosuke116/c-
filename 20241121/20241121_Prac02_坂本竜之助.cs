using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_._20241121
{
    internal class _20241121_Prac02_坂本竜之助
    {

        class Student
        {
            public string name { get; private set; }
            public int score { get; private set; }
            public string grade {  get; private set; }

            public Student(string name,int score)
            {
                this.name = name;
                this.score = score;
            }

            public void Judge()
            {
                if(score >= 80)
                {
                    grade = "合格";
                }
                else if(score >= 50)
                {
                    grade = "追試";
                }
                else
                {
                    grade = "不合格";
                }
            }
        }

        static void Main(string[] args)
        {
            var students = new List<Student>();

            while (true)
            {
                Console.WriteLine("名前を入力してね、もういないときはそのままエンターを押してね");
                string name = Console.ReadLine();
                if(name == "")
                {
                    break;
                }
                Console.WriteLine("0～100までで点数を入力してね");
                int score = 0;
                while (true)
                { 
                    score = int.Parse(Console.ReadLine());

                    if(score <=100 || score >= 0)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("書き直して");
                    }
                }

                students.Add(new Student(name, score));
            }

            var orderStudents = students.OrderByDescending(n => n.score).ToList();

            foreach(Student student in orderStudents)
            {
                student.Judge();
            }

            Console.WriteLine("合格者");
            foreach (Student student in orderStudents)
            {
                if (student.grade == "合格")
                {
                    Console.WriteLine($"名前：{student.name}　点数：{student.score}");
                }
            }

            Console.WriteLine("追試者");
            foreach (Student student in orderStudents)
            {
                if (student.grade == "追試")
                {
                    Console.WriteLine($"名前：{student.name}　点数：{student.score}");
                }
            }

            Console.WriteLine("不合格者");
            foreach(Student student in orderStudents)
            {
                if (student.grade == "不合格")
                {
                    Console.WriteLine($"名前：{student.name}　点数：{student.score}");
                }
            }


        }
    }
}
