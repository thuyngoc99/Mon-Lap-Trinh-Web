using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Cau2.Models
{
    public class StudentList
    {
        private List<Student> sv = new List<Student>()
        {
            new Student
            {
                StudentID = 1,
                StudentName = "Thanh Thảo",
                StudentBirthday = "02/09/1999",
                StudentPhone = "0987032456",
                StudentEmail = "thao@gmail.com",
            },
            new Student
            {
                StudentID = 2,
                StudentName = "Mai Phương",
                StudentBirthday = "22/10/1998",
                StudentPhone = "0987032542",
                StudentEmail = "phuong@gmail.com",
            },
            new Student
            {
                StudentID = 3,
                StudentName = "Gia Huy",
                StudentBirthday = "28/07/2000",
                StudentPhone = "0362354512",
                StudentEmail = "huy@gmail.com",
            }
        };

        public List<Student> GetStudents()
        {
            var student = sv.Select(i => i);
            return student.ToList();
        }
    }
}