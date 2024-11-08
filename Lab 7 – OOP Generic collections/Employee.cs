using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_7___OOP_Generic_collections
{
    internal class Employee(int id, string name, string gender, double salary)
    {
        public int Id { get; set; } = id;
        public string Name { get; set; } = name;
        public string Gender { get; set; } = gender;
        public double Salary { get; set; } = salary;
        public override string ToString()
        {
            return $"Id: {Id}, Namn: {Name}, Kön: {Gender}, Lön: {Salary:C}";
        }

        // Need to override these method to see if a objekt is matching in CheckEmployeeInList() based on ID property
        public override bool Equals(object? obj)
        {
            // Override Equals method to compare Employee objects based on their Id
            // Check if the passed object is an Employee instance
            if (obj is Employee emp)
            {
                return Id == emp.Id; // Return true if Ids are equal, otherwise false
            }
            return false; // If not an Employee, return false
        }  
        public override int GetHashCode()
        {
            // Override GetHashCode method to return a hash code based on the Id
            return Id.GetHashCode(); // Use the hash code of the Id for hashing
        }
    }
}
