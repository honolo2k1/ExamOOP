using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExOOP
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Tạo giáo viên
            Teacher teacher = new Teacher();
            teacher.Input();

            // Tạo sinh viên
            Student student1 = new Student();
            student1.Input();
            Student student2 = new Student();
            student2.Input();

            // Tạo khóa học
            Course course = new Course("Managing Student List", teacher);

            // Đăng ký sinh viên vào khóa học
            course.Students.Add(student1);
            course.Students.Add(student2);

            // In thông tin về khóa học
            course.PrintInfo();

            // In thông tin về sinh viên
            foreach (Student student in course.Students)
            {
                student.PrintInfo();
            }
            Console.ReadKey();
        }
    }

}
