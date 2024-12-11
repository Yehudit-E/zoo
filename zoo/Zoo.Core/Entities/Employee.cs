using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo.Core.Entities
{
    public class Employee
    {
        [Key]
        public int Id { get; private set; }
        public string TZ { get; set; }
        public string Name { get; set; }
        public string Role { get; set; }//enum
        public string Phone { get; set; }
        public string Email { get; set; }
        public string City { get; set; }
        public int Age { get; set; }
        public DateTime DateOfStartWork { get; set; }
        public double Salary { get; set; }
        public double HoursOfWork { get; set; }

        public Employee() { }


        public Employee(Employee e)
        {
            Id = e.Id; 
            TZ = e.TZ;
            Name = e.Name;
            Role = e.Role;
            Email = e.Email;
            Phone = e.Phone;
            City = e.City;
            Age = e.Age;
            DateOfStartWork= e.DateOfStartWork;
            Salary = e.Salary;
            HoursOfWork = e.HoursOfWork;


        }
        
    }

}
