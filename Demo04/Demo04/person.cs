using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo04
{
    class person
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Address { get; set; }
        public string Age { get; set; }
        public string Number { get; set; }


        public person()

        {


        }


        public person(String firstname, string lastname)

        {

            Firstname = firstname;
            Lastname = lastname;

        }

        protected void personMethod()

        {

            Console.WriteLine("Personin metodi!!");

        }

        public override string ToString()
        {
            return Firstname + " " + Lastname + " " + Address + " " + Age + " " + Number;
        }

    }
}
