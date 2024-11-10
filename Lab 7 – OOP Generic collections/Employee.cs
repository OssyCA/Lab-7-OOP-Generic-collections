using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_7___OOP_Generic_collections
{
    // Employee class with properties and methods
    internal class Employee
    {
        // Constructor with parameters to initialize Employee properties
        public Employee(int id, string name, string gender, double salary)
        {
            Id = id;
            Name = name;
            Gender = gender;
            Salary = salary;
        }

        // Properties for Employee class
        public int Id { get; set; } // Employee ID
        public string Name { get; set; } // Employee Name
        public string Gender { get; set; } // Employee Gender
        public double Salary { get; set; } // Employee Salary

        // Override ToString method to display employee information
        public override string ToString()
        {
            return $"Id: {Id}, Name: {Name}, Gender: {Gender}, Salary: {Salary:C}";
        }

        // Override Equals method to compare Employee objects based on their Id
        public override bool Equals(object? obj)
        {
            // Check if the passed object is an Employee instance
            if (obj is Employee emp)
            {
                return Id == emp.Id; // Return true if Ids are equal, otherwise false
            }
            return false; // If not an Employee, return false
        }

        // Override GetHashCode method to return a hash code based on the Id
        public override int GetHashCode()
        {
            return Id.GetHashCode(); // Use the hash code of the Id for hashing
        }
    }
}
