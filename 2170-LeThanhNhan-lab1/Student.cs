using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2170_LeThanhNhan_lab1
{
    public class Student
    {
        public string studentId { get; set; }
        public string fullName { get; set; }
        public int averageScore { get; set; }
        public string faculty { get; set; }

        public  Student() { }
        public Student(string studentId, string fullName, string faculty, int averageScore)
        {
            this.studentId = studentId;
            this.fullName = fullName;
            this.faculty = faculty;
            this.averageScore = averageScore;
        }
    }
}