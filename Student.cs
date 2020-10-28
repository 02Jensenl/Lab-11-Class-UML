using System;
using System.Collections.Generic;
using System.Net.Sockets;
using System.Text;

namespace Laab_11_Class_UML
{
    class Student : Person
    {
        private string Program { get; set; }
        private int Year { get; set; }
        private double Fee { get; set; }

        public Student()
        { }
        public Student(string Name, string Address, string Program, int Year, double Fee)
            : base(Name, Address)
        {
            this.Program = Program;
            this.Year = Year;
            this.Fee = Fee;
        }

        public override string ToString()
        {
            return $"Name:{Name}\tAddress:{Address}\tProgram:{Program}\tYear:{Year}\tFee:{Fee}";
            
        }
    }
}
