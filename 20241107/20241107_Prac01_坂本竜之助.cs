using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_._20241107
{
    internal class _20241107_Prac01_坂本竜之助
    {
        struct Student
        {
            private string Name;
            private int Score;
            private char Grade;

            public Student(string Name, int Score)
            {
                this.Name = Name;
                this.Score = Score;

                if(Score >= 90)
                {
                    this.Grade = char.Parse("S");
                }
                else if(Score >= 70)
                {
                    this.Grade = char.Parse("A");
                }
                else if (Score >= 50)
                {
                    this.Grade = char.Parse("B");
                }
                else if (Score >= 30)
                {
                    this.Grade = char.Parse("C");
                }
                else
                {
                    this.Grade = char.Parse("D");
                }
            }

            public void Display()
            {
                Console.WriteLine($"名前：{Name}\n点数：{Score}\n評価：{Grade}");
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("名前を入力してください");
            var name=Console.ReadLine();
            Console.WriteLine("点数を入力してください");
            var score = int.Parse(Console.ReadLine());

            Student student = new Student(name, score);
            student.Display();
        }
    }
}
