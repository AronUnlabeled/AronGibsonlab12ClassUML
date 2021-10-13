using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AronGibsonlab12ClassUML
{
    class Person
    {
        public string name { set; get; }
        public string address { set; get; }
        public Person(string name, string address) {
            this.name = name;
            this.address = address;
        }
        public Person() 
        { 
        
        }

        public override string ToString()
        {
            return $"name: {name} address: {address}";
        }
    }
}
