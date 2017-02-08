using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo04
{
    class Teacher : person
    {
        public string Room { get; set; }

        public Teacher()
        {

        }

        public Teacher(string firstname, string lastname, string room)
            :base(firstname, lastname)

        {
            Room = room;
        }


        public void TeacherMethod()
        {

            Console.WriteLine("Open metodi!!");

        }


        public override string ToString()
        {
            //base viittaa Yliluokkaan eli tuo Firstname + Lastname ... + Room
            return base.ToString() + " " + Room;
        }
    }


}
