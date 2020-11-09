using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibraryStudent;

namespace CSharpCourseUSTB
{
    public class Postgraduate :Student
    {
        public string Field;
        public Postgraduate(int student_id, string student_name, DateTime student_birthday, string introduction, string field) : base(student_id, student_name, student_birthday, introduction)
        {
            Field = field;
        }
    }
}
