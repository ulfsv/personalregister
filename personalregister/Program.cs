using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks

namespace PersonalRegister
{
    class Program
    {

        public static void AddEmployee(register)
        {
            var employee = new Employee();
            Console.Write("Name: ");

            employee.Name = Console.ReadLine();
            
            Console.Write("Salary: ");
            {
                employee.Salary = float.Parse(Console.ReadLine());
            }            

            register.AddEmployee(employee);
        }


        static void Main(string[] args)
        {

            Register register = new Register();
            int menu = 0;          


            }

            Console.WriteLine("Program exit");
        }
    }
}
