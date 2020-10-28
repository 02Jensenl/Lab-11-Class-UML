using System;
using System.Collections.Generic;
using System.Text;

namespace Laab_11_Class_UML
{
    class Staff : Person
    {
        private string School { get; set; }
        private double Pay { get; set; }

        public Staff()
        { }
        public Staff(string Name, string Address, string School, double Pay)
            :base(Name, Address)
        {
            this.School = School;
            this.Pay = Pay;
        }

      
        public override string ToString()
        {
            return $"Name:{Name}\tAddress:{Address}\tSchool:{School}\tPay:${Pay}";
           
        }

    }
}
