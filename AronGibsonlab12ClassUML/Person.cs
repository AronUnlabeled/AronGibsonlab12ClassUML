using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AronGibsonlab12ClassUML
{
    class Person
    {
        public string Name { set; get; }
        public string Address { set; get; }
        public Person(string Name, string Address) {
            this.Name = Name;
            this.Address = Address;
        }
        public Person() 
        { 
        
        }

        public override string ToString()
        {
            return $"name: {Name} address: {Address}";
        }
    }
}
