using System;
using System.Collections.Generic;
using System.Text;

namespace Collection_Generics
{
    class Employee
    {

        // Properties that the Employee object can have.

        public string Name { get; set; }
        public int ID { get; set; }
        public string Gender { get; set; }
        public double Salary { get; set; }

        // Made a method

        public static void PrintInfo(Employee item)
        {
            Console.WriteLine("Name = {0}, ID = {1}, Gender = {2}, Salary = {3}", item.Name, item.ID, item.Gender, item.Salary);
        }

    }
}
