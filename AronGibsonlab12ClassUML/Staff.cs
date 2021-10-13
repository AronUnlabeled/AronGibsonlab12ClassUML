using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AronGibsonlab12ClassUML
{
    class Staff : Person
    {
        public string School { get; set; }
        public double Pay { get; set; }

        public Staff(string Name,string Address,string School, double Pay):base(Name, Address) 
        {
            this.School = School;
            this.Pay = Pay;
        }

        public Staff() : base() 
        { 
        
        }

        public override string ToString()
        {
            return base.ToString()+$" School: {School} pay: {Pay}" ;
        }


    }
}
