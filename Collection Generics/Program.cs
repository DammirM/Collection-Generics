using System;
using System.Collections.Generic;

namespace Collection_Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee Employ = new Employee();
            Employ.Name = "Jamie Vardy";
            Employ.Id = 001;
            Employ.Gender = "Male";
            Employ.Salary = 25000;


            Employee Employ1 = new Employee();
            Employ1.Name = "Anna Anna";
            Employ1.Id = 002;
            Employ1.Gender = "Female";
            Employ1.Salary = 30000;

            Employee Employ2 = new Employee();
            Employ2.Name = "Didier Drogba";
            Employ2.Id = 003;
            Employ2.Gender = "Male";
            Employ2.Salary = 35000;

            Employee Employ3 = new Employee();
            Employ3.Name = "Karim Benzema";
            Employ3.Id = 004;
            Employ3.Gender = "Male";
            Employ3.Salary = 38000;

            Employee Employ4 = new Employee();
            Employ4.Name = "Sara Bengtsson";
            Employ4.Id = 005;
            Employ4.Gender = "Female";
            Employ4.Salary = 44000;

            Console.WriteLine("---------- Push + Count ---------\n");


            Stack<Employee> Emp = new Stack<Employee>();
            Emp.Push(Employ);
            Emp.Push(Employ1);
            Emp.Push(Employ2);
            Emp.Push(Employ3);
            Emp.Push(Employ4);

            foreach (Employee item in Emp)
            {
                Console.WriteLine("Name = {0}, ID = {1}, Gender = {2}, Salary = {3}", item.Name, item.Id, item.Gender, item.Salary);
                Console.WriteLine("Items left in stack = " + Emp.Count);
            };

            Console.WriteLine("\n----------Pop + Count -----------\n");

            Employee E = Emp.Pop();
            Console.WriteLine("Name = {0}, ID = {1}, Gender = {2}, Salary = {3}", E.Name, E.Id, E.Gender, E.Salary);
            Console.WriteLine("Items left in stack = " + Emp.Count);
            Employee E1 = Emp.Pop();
            Console.WriteLine("Name = {0}, ID = {1}, Gender = {2}, Salary = {3}", E1.Name, E1.Id, E1.Gender, E1.Salary);
            Console.WriteLine("Items left in stack = " + Emp.Count);
            Employee E2 = Emp.Pop();
            Console.WriteLine("Name = {0}, ID = {1}, Gender = {2}, Salary = {3}", E2.Name, E2.Id, E2.Gender, E2.Salary);
            Console.WriteLine("Items left in stack = " + Emp.Count);
            Employee E3 = Emp.Pop();
            Console.WriteLine("Name = {0}, ID = {1}, Gender = {2}, Salary = {3}", E3.Name, E3.Id, E3.Gender, E3.Salary);
            Console.WriteLine("Items left in stack = " + Emp.Count);
            Employee E4 = Emp.Pop();
            Console.WriteLine("Name = {0}, ID = {1}, Gender = {2}, Salary = {3}", E4.Name, E4.Id, E4.Gender, E4.Salary);
            Console.WriteLine(Emp.Count);

            // Adding them back in to the stack with push

            Emp.Push(Employ);
            Emp.Push(Employ1);
            Emp.Push(Employ2);
            Emp.Push(Employ3);
            Emp.Push(Employ4);

            Console.WriteLine("--------Peek ---------\n");


            Employee P = Emp.Peek();
            Console.WriteLine("Name = {0}, ID = {1}, Gender = {2}, Salary = {3}", P.Name, P.Id, P.Gender, P.Salary);
            Console.WriteLine("Items left in stack = " + Emp.Count);

            Emp.Pop();

            Employee P1 = Emp.Peek();
            Console.WriteLine("Name = {0}, ID = {1}, Gender = {2}, Salary = {3}", P1.Name, P1.Id, P1.Gender, P1.Salary);
            Console.WriteLine("Items left in stack = " + Emp.Count);

            Emp.Pop();

            Console.WriteLine("Checking if item nr 3 is in the stack??\n");

            if (Emp.Count == 3)
            {
                Console.WriteLine("Item number 3 is in the stack");
            }
            else
            {
                Console.WriteLine("Item 3 is not in the stack");
            }

            Console.WriteLine("\n----------List---------\n");

            List<Employee> Empl = new List<Employee>();
            Empl.Add(Employ);
            Empl.Add(Employ1);
            Empl.Add(Employ2);
            Empl.Add(Employ3);
            Empl.Add(Employ4);

            if (Empl.Contains(Employ1))
            {
                Console.WriteLine("The item is in the list..." + Employ1.Name);
            }
            else
            {
                Console.WriteLine("The item is not in the list");
                
            }

            Console.WriteLine("\nFind the first Mmale in the List\n");

            Employee G = Empl.Find(g => g.Gender == "Male");

            Console.WriteLine("Name = {0}, ID = {1}, Gender = {2}, Salary = {3}", G.Name, G.Id, G.Gender, G.Salary);

            Console.WriteLine("\nFind all Males in the List\n");

            List<Employee> M = Empl.FindAll(m => m.Gender == "Male");

            foreach (Employee item in M)
            {
                Console.WriteLine("Name = {0}, ID = {1}, Gender = {2}, Salary = {3}", item.Name, item.Id, item.Gender, item.Salary);
            }









            Console.ReadKey();
        }
    }
}
