using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace personalregister
{
    class Employee
    {
        public string Name { get; set; }
        public float Salary { get; set; }

        public override string ToString()
        {
            return "Namn: " + Name + System.Environment.NewLine  + "Lön:  " + Salary.ToString();
        }

    }
}
