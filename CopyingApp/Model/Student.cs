using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CopyingApp.Model
{
    internal class Student
    {
        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public Address? Address { get; set; }

        public Student() { }

        public Student(int id, string firstName, string lastName, Address address)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Address = address;
        }

        public override string ToString()
        {
            return $"{Id}: {FirstName} {LastName}, Address: {Address}";
        }

        // Returns a reference to the current instance
        public Student GetRef()
        {
            return this;
        }

        // Returns a shallow copy of the current instance
        public Student ShallowCopy()
        {
            return (Student)MemberwiseClone();
        }

        // Returns a deep copy of the current instance
        public Student GetDeepCopy()
        {
            Student student = (Student)MemberwiseClone();
            student.Address = new Address()
            {
                StreetName = Address!.StreetName,
                StreetNumber = Address!.StreetNumber, 
                ZipCode = Address!.ZipCode
            };
            return student;
        }
    }
}
