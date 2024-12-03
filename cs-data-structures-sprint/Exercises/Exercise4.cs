using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_data_structures_sprint.Exercises
{
    public class Exercise4
    {
        static Dictionary<Student, int> studentGrades;
        public static Dictionary<string, Dictionary<string, int>> gradeBook;

        static Exercise4()
        {
            studentGrades = new();
            gradeBook = new();
        }
        public static void GradeStudent(Student student, int grade)
        {
            if(!studentGrades.ContainsKey(student)) studentGrades[student] = grade;
        }

        public static int CheckGrade(Student student)
        {
            if(studentGrades.ContainsKey(student)) return studentGrades[student];
            return int.MinValue;
        }

        public static void UpdateGrade(Student student, int grade)
        {
            if (studentGrades.ContainsKey(student)) studentGrades[student] = grade;
            GradeStudent(student, grade);
        }

        public static void UpdateGradeBook(Student student, string subject, int grade)
        {
            gradeBook.Add(student.Id, new Dictionary<string, int>());
            gradeBook[student.Id].Add(subject, grade);
        }

       
    }
}
