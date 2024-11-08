using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_7___OOP_Generic_collections
{
    internal class HandleEmployee
    {
        public List<Employee> Employees{ get; set; }
        public Stack<Employee> EmployeesStack{ get; set; }
        public HandleEmployee()
        {
            Employees =
            [
                new Employee(1, "Alice", "Kvinna", 50000),
                new Employee(2, "Bob", "Man", 55000),
                new Employee(3, "Charlie", "Icke-binär", 52000),
                new Employee(4, "Diana", "Kvinna", 48000),
                new Employee(5, "Ethan", "Man", 60000),
            ];
            EmployeesStack = new Stack<Employee>();
        }
        public void DisplayEmployeeList()
        {
            foreach (Employee emp in Employees)
            {
                Console.WriteLine(emp);
            }
        }
        public void DisplayStack()
        {
            foreach (Employee e in Employees)
            {
                EmployeesStack.Push(e);
                Console.WriteLine($"{e}\nAntal i stacken: {EmployeesStack.Count}");
            }
            Console.WriteLine("---------------------------------------------");
            HandleStack();
        }
        public void HandleStack()
        {
            List<Employee> poppedEmployees = [];
            while (EmployeesStack.Count > 0)
            {
                Employee e = EmployeesStack.Pop();
                poppedEmployees.Add(e);
                Console.WriteLine($"Poppade: {e}\nAntal kvar i stacken: {EmployeesStack.Count}");
            }
            Console.WriteLine("----------------------------------------");
            foreach (Employee e in poppedEmployees)
            {
                EmployeesStack.Push(e);
                Console.WriteLine($"Lade tillbaka: {e.Name}");
            }
        }
        public void PeekStack()
        {
            Console.WriteLine("------------------------------");
            Console.WriteLine(EmployeesStack.Peek());

            var employee3 = Employees[2]; // Using 2 because the index starting from 0

            if (EmployeesStack.Contains(employee3))
            {
                Console.WriteLine(employee3);
            }
        }
        public void CheckEmployeeInList()
        {
            Console.WriteLine("------------------------------------");
            var employee2 = new Employee(3, "Charlie", "Icke-binär", 52000);

            if (Employees.Contains(employee2))
            {
                Console.WriteLine($"{employee2.Name} finns i listan");
            }
            else
            {
                Console.WriteLine("Finns inte i listan");
            }
            Console.WriteLine("---------------------------------------------------");
            var firstMan = Employees.Find(m => m.Gender == "Man");
            Console.WriteLine(firstMan);
            var allMale = Employees.FindAll(m => m.Gender == "Man");
            Console.WriteLine("---------------------------------------------------\nAlla killar:");

            foreach (Employee emp in allMale)
            {
                Console.WriteLine(emp);
            }
        }
    }
}
