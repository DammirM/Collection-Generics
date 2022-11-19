using System;
using System.Collections.Generic;
using System.Linq;

namespace Collection_Generics
{
    class Program : Employee
    {
        static void Main(string[] args)
        {

            // Creating 5 objects of Employee

            Employee Emp1 = new Employee();
            Emp1.Name = "Jamie Vardy";
            Emp1.ID = 001;
            Emp1.Gender = "Male";
            Emp1.Salary = 25000;

            Employee Emp2 = new Employee();
            Emp2.Name = "Anna Anna";
            Emp2.ID = 002;
            Emp2.Gender = "Female";
            Emp2.Salary = 30000;

            Employee Emp3 = new Employee();
            Emp3.Name = "Didier Drogba";
            Emp3.ID = 003;
            Emp3.Gender = "Male";
            Emp3.Salary = 35000;

            Employee Emp4 = new Employee();
            Emp4.Name = "Karim Benzema";
            Emp4.ID = 004;
            Emp4.Gender = "Male";
            Emp4.Salary = 38000;

            Employee Emp5 = new Employee();
            Emp5.Name = "Sara Bengtsson";
            Emp5.ID = 005;
            Emp5.Gender = "Female";
            Emp5.Salary = 44000;

            Console.WriteLine("---------- Push + Count ---------\n");

            // Creating a stack and adding them in to the stack with Push.

            Stack<Employee> Em = new Stack<Employee>();
            Em.Push(Emp1);
            Em.Push(Emp2);
            Em.Push(Emp3);
            Em.Push(Emp4);
            Em.Push(Emp5);

            // Foreach loop to show them all.
            foreach (Employee item in Em)
            {
                PrintInfo(item);
                Console.WriteLine("Items left in stack = " + Em.Count);
            };

            Console.WriteLine("\n----------Pop + Count -----------\n");

            //

            while (Em.Count > 0)
            {
                Employee E = Em.Pop();
                PrintInfo(E);
                Console.WriteLine("Items left in stack = " + Em.Count);
            }

            // Adding them back in to the stack with push

            Em.Push(Emp1);
            Em.Push(Emp2);
            Em.Push(Emp3);
            Em.Push(Emp4);
            Em.Push(Emp5);

            Console.WriteLine("--------Peek ---------\n");


            Employee P = Em.Peek();
            PrintInfo(P);
            Console.WriteLine("Items left in stack = " + Em.Count);

            Em.Pop();

            Employee P1 = Em.Peek();
            PrintInfo(P1);
            Console.WriteLine("Items left in stack = " + Em.Count);

            Em.Pop();

            Console.WriteLine("\nChecking if item nr 3 is in the stack??\n");

            if (Em.Count == 3)
            {
                Console.WriteLine("Item number {0} is in the stack", Em.Count);
            }
            else
            {
                Console.WriteLine("Item {0} is not in the stack", Em.Count);
            }

            Console.WriteLine("\n----------List---------\n");

            List<Employee> Empl = new List<Employee>();
            Empl.Add(Emp1);
            Empl.Add(Emp2);
            Empl.Add(Emp3);
            Empl.Add(Emp4);
            Empl.Add(Emp5);

            if (Empl.Contains(Emp2))
            {
                Console.WriteLine("The item is in the list..." + Emp2.Name);
            }
            else
            {
                Console.WriteLine("The item is not in the list");
                
            }

            Console.WriteLine("\nFind the first Male in the List\n");

            Employee G = Empl.Find(g => g.Gender == "Male");

            PrintInfo(G);

            Console.WriteLine("\nFind all Males in the List\n");

            List<Employee> M = Empl.FindAll(m => m.Gender == "Male");

            foreach (Employee item in M)
            {
               PrintInfo(item);
            }


            Console.ReadKey();
        }

        
    }
}
