using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_7___OOP_Generic_collections
{
    internal class HandleEmployee
    {
        // Properties to store list of employees and a stack of employees
        public List<Employee> Employees { get; set; }
        public Stack<Employee> EmployeesStack { get; set; }

        // Constructor to initialize Employees list and EmployeesStack
        public HandleEmployee()
        {
            // Initializing Employees with some predefined Employee objects
            Employees =
            [
                new Employee(1, "Alice", "Kvinna", 50000),
                new Employee(2, "Bob", "Man", 55000),
                new Employee(3, "Charlie", "Icke-binär", 52000),
                new Employee(4, "Diana", "Kvinna", 48000),
                new Employee(5, "Ethan", "Man", 60000),
            ];
            EmployeesStack = new Stack<Employee>(); // Initializing the stack
        }

        // Method to display all employees in the Employees list
        public void DisplayEmployeeList()
        {
            foreach (Employee emp in Employees)
            {
                Console.WriteLine(emp);
            }
        }

        // Method to push employees onto the stack and display stack details
        public void DisplayStack()
        {
            foreach (Employee e in Employees)
            {
                EmployeesStack.Push(e); // Push each employee onto the stack
                Console.WriteLine($"{e}\nCount in stack: {EmployeesStack.Count}");
            }
            Console.WriteLine("---------------------------------------------");
            HandleStack(); // Process the stack by calling HandleStack method
        }

        // Method to pop all employees from stack and then push them back
        public void HandleStack()
        {
            List<Employee> poppedEmployees = []; // List to hold popped employees

            // Pop each employee from the stack and add to poppedEmployees list
            while (EmployeesStack.Count > 0)
            {
                Employee e = EmployeesStack.Pop();
                poppedEmployees.Add(e);
                Console.WriteLine($"Popped: {e}\nRemaining in stack: {EmployeesStack.Count}");
            }

            Console.WriteLine("----------------------------------------");

            // Push each employee back onto the stack from poppedEmployees list
            foreach (Employee e in poppedEmployees)
            {
                EmployeesStack.Push(e);
                Console.WriteLine($"Pushed back: {e.Name}");
            }
        }

        // Method to peek at the top of the stack and check for specific employee
        public void PeekStack()
        {
            Console.WriteLine("------------------------------");
            Console.WriteLine(EmployeesStack.Peek()); // Display top employee in the stack

            var employee3 = Employees[2]; // Access employee with index 2 (Charlie)

            // Check if employee3 is present in the stack
            if (EmployeesStack.Contains(employee3))
            {
                Console.WriteLine(employee3);
            }
        }

        // Method to check if a specific employee exists in the Employees list
        public void CheckEmployeeInList()
        {
            Console.WriteLine("------------------------------------");
            var employee2 = new Employee(3, "Charlie", "Icke-binär", 52000);

            // Check if employee2 exists in Employees list
            if (Employees.Contains(employee2))
            {
                Console.WriteLine($"{employee2.Name} is in the list");
            }
            else
            {
                Console.WriteLine("Not in the list");
            }

            Console.WriteLine("---------------------------------------------------");

            // Find the first employee with gender "Man"
            var firstMan = Employees.Find(m => m.Gender == "Man");
            Console.WriteLine(firstMan);

            // Find all employees with gender "Man"
            var allMale = Employees.FindAll(m => m.Gender == "Man");
            Console.WriteLine("---------------------------------------------------\nAll males:");

            // Display each male employee
            foreach (Employee emp in allMale)
            {
                Console.WriteLine(emp);
            }
        }
    }
}
