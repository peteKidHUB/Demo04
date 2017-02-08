using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo04
{
    class Program
    {
        static void Main(string[] args)
        {

            Student student = new Student();
            student.Firstname = "Teppo";
            student.Lastname = "Tulppu";
            student.Address = "Parasiittitie 14";
            student.Age = "24";
            student.Number = "010-1235777";
            student.StudentID = "K2147";
            Console.WriteLine(student.ToString());

            Teacher teacher = new Teacher("Kirsi", "Kernel", "D566");
            teacher.Age = "35";
            teacher.Address = "Piippukatu 2";
            teacher.Number = "020-12345685";
            Console.WriteLine(teacher.ToString());

            teacher.TeacherMethod();
            student.StudentMethod();

            student.personMethod();

        }
    }
}
