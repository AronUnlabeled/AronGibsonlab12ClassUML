using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AronGibsonlab12ClassUML
{
    class Staff : Person
    {
        public string school { get; set; }
        public double pay { get; set; }

        public Staff(string name,string address,string school, double pay):base(name, address) 
        {
            this.school = school;
            this.pay = pay;
        }

        public Staff() : base() 
        { 
        
        }

        public override string ToString()
        {
            return base.ToString()+$" School: {school} pay: {pay}" ;
        }


    }
}
