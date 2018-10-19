using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch11_P1_SimpleIndexer
{
    class Student
    {
        public int RollNo { get; set; }
        public string Name { get; set; }

        public Student()
        {

        }
        public Student(int rollNo , string name)
        {
            RollNo = rollNo;
            Name = name;
        }

        public override string ToString()
        {
            return string.Format("\n Roll No : {0} , Name : {1} ", RollNo, Name);
        }
    }
}
