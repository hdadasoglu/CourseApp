using System.Collections.Generic;

namespace CourseApp.Models
{
    public static class Repository
    {
        private static List<Student> _student = new List<Student>();

        // private olan _student listemizi döndürüyoruz.
        public static List<Student> Students {
            get{
                return _student;
            }
        }
        // Listeye öğrenci ekleyiyoruz
        public static void AddStudent(Student student){
            _student.Add(student);
        }
    }
}