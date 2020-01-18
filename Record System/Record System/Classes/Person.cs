using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Record_System.Classes
{
    public abstract class Person
    {
        private string name { get; set; }
        private DateTime dob { get; set; }
        private string[] address { get; set; }

        public Person()
        {

        }

        public override string ToString()
        {
            return this.name + " " + this.dob + " " + this.address.ToString();
        }
    }
}
