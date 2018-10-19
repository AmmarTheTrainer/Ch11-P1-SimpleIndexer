using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch11_P1_SimpleIndexer
{
    class LectureHall : IEnumerable
    {
        private ArrayList StudentList = new ArrayList();

        //private Dictionary<>

        public Student this[int index]
        {
            get => (Student)StudentList[index];
            set => StudentList.Insert(index, value);
        }

        //public Student this[string nickName]
        //{
        //    get => (Student)StudentList[index];
        //    set => StudentList.Insert(index, value);
        //}

        public Student GetStudent(int position)
        {
            return (Student)StudentList[position];
        }

        public void AddStudent(Student stu)
        {
            StudentList.Add(stu);
        }
        public void ClearLectureHall()
        {
            StudentList.Clear();
        }

        public IEnumerator GetEnumerator()
        {
            return StudentList.GetEnumerator();
        }

        //public int Count()
        //{
        //    return StudentList.Count;
        //}
        public int Count => StudentList.Count;

    }
}
