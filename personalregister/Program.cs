using System;
using System.Collections.Generic;

namespace personalregister
{
    class Program
    {

        public static void AddEmployee(Register register)
        {
            var employee = new Employee();
            Console.Write("Namn: ");
            employee.Name = Console.ReadLine();
            Console.Write("Lön: ");
            employee.Salary = float.Parse(Console.ReadLine());

            register.AddEmployee(employee);
        }
        private static void Main(string[] args)
        {
            if (args is null)
            {
                throw new ArgumentNullException(nameof(args));
            }
            Register register = new Register();
            int menu = 0;
            while (menu != 2)
            {
                Console.WriteLine("Välj med 1 eller 2");
                //Console.WriteLine("1. Add employee\n2. Print employees\n3. quit ");
                Console.WriteLine("1. Lägg till anställd\n2. Avsluta ");
                menu = int.Parse(Console.ReadLine());
                
                switch (menu)
                {
                    case 1:
                        Console.WriteLine("Lägg till anställd");
                        AddEmployee(register);
                        //break;
                        //case 2:
                        Console.WriteLine("Anställda:");
                        List<Employee> list = register.GetEmployees();
                        {
                            foreach (Employee item in list)
                            {
                                Console.WriteLine(item);
                            }
                        }
                        Console.WriteLine("Tryck enter för att fortsätta mata in");
                        break;
                    case 2:
                        break;
                    default:
                        Console.WriteLine("Välj 1 eller 2 i menyn");
                        break;
                }
            }
            Console.WriteLine("Programmet avslutas");
        }
    }
}