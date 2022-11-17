using System;
using System.Collections.Generic;
using System.Linq;

namespace Collection_generics // Elin Linderholm SUT22
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee1 = new Employee()
            {
                id=001,
                name="Therese",
                gender="female",
                salary=37000,
            };
            Employee employee2 = new Employee()
            {
                id = 002,
                name = "Anna",
                gender = "female",
                salary = 34000,
            };
            Employee employee3 = new Employee()
            {
                id = 003,
                name = "Elin",
                gender = "female",
                salary = 33000,

            };
            Employee employee4 = new Employee()
            {
                id = 004,
                name = "Stefan",
                gender = "male",
                salary = 35000,
            };
            Employee employee5 = new Employee()
            {
                id = 005,
                name = "Ashok",
                gender = "male",
                salary = 38000,
            };

            Stack<Employee> employees = new Stack<Employee>();
            employees.Push(employee1);
            employees.Push(employee2);
            employees.Push(employee3);
            employees.Push(employee4);
            employees.Push(employee5);

            Console.WriteLine("----------The Stack-----------");

            foreach (Employee item in employees)
            {
                Console.WriteLine("-{0}-{1}-{2}-{3}-",item.id, item.name, item.gender, item.salary);
                Console.WriteLine("Employees left in the stack:" + employees.Count);             
            }
            Console.WriteLine("----------POP-method----------");

            while (employees.Count > 0)
            {
                Employee empltoDel = employees.Pop();                
                
                Console.WriteLine("-{0}-{1}-{2}-{3}-", empltoDel.id, empltoDel.name, empltoDel.gender, empltoDel.salary);
                Console.WriteLine("Employees left in the stack:" + employees.Count);               
            }
            employees.Push(employee1);
            employees.Push(employee2);
            employees.Push(employee3);
            employees.Push(employee4);
            employees.Push(employee5);

            Console.WriteLine("----------Peek-method----------");

            Employee empltoPeek = employees.Peek();
            Console.WriteLine("-{0}-{1}-{2}-{3}-", empltoPeek.id, empltoPeek.name, empltoPeek.gender, empltoPeek.salary);
            Console.WriteLine("Employees left in the stack:" + employees.Count);

            Employee empltoPeek2 = employees.Peek();
            Console.WriteLine("-{0}-{1}-{2}-{3}-", empltoPeek2.id, empltoPeek2.name, empltoPeek2.gender, empltoPeek2.salary);
            Console.WriteLine("Employees left in the stack:" + employees.Count);

            Console.WriteLine("---------Contains-method-------");

            if (employees.Contains(employee3))
            {
                Console.WriteLine("Employee nr 3 is in the stack");
            }
            else
            {
                Console.WriteLine("Employee nr 3 is not in the stack");
            }

            Console.WriteLine("-----------The List ------------");

            List<Employee> listEmployees = new List<Employee>();
            listEmployees.Add(employee1);
            listEmployees.Add(employee2);
            listEmployees.Add(employee3);
            listEmployees.Add(employee4);
            listEmployees.Add(employee5);

            if (listEmployees.Contains(employee2))
            {
                Console.WriteLine("Employee 2 is in the list");
            }
            else
            {
                Console.WriteLine("Employee 2 is not in the list");
            }

            Console.WriteLine("----First male employee in the list----");

            Employee ofMaleGender= listEmployees.Find(x => x.gender=="male");
            Console.WriteLine("-{0}-{1}-{2}-{3}-", ofMaleGender.id, ofMaleGender.name, ofMaleGender.gender, ofMaleGender.salary);

            Console.WriteLine("-----All male employees in the list-----");
            List<Employee> allofMaleGender = listEmployees.FindAll(x => x.gender == "male");
                foreach (Employee item  in allofMaleGender)
            {
                Console.WriteLine("-{0}-{1}-{2}-{3}-", item.id, item.name, item.gender, item.salary);
            }

            Console.ReadKey();














        }
    }
}
