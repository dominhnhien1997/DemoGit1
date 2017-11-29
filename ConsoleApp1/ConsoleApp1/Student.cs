using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Student
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public float Mark{ get; set; }
        public Student()
        {

        }
        public Student(string id,string name,float mark)
        {
            Id = id;
            Name = name;
            Mark = mark;
        }
        public override string ToString()
        {
            return Id + "---" + Name + "---" + Mark;
        }
    }
}
