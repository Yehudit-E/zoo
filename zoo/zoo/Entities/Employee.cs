﻿namespace zoo.Entities
{
    public class Employee
    {
        public int Id { get; private set; }
        public string TZ { get;  set; }
        public string Name { get; set; }
        public string Role { get; set; }//enum
        public string Phone { get; set; }
        public string Email { get; set; }
        public string City { get; set; }
        public int Age { get; set; }
        public DateTime DateOfStartWork { get; set; }
        public double Salary { get; set; }
        public double HoursOfWork { get; set; }
        

        private static int count = 1;

        public Employee() { }


        public Employee(Employee e)
        {
            Id = count++;
            TZ= e.TZ;
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
        public Employee(int id, Employee e)
        {
            Id = id;
            TZ = e.TZ;
            Name = e.Name;
            Role = e.Role;
            Email = e.Email;
            Phone = e.Phone;
            City = e.City;
            Age = e.Age;
            DateOfStartWork = e.DateOfStartWork;
            Salary = e.Salary;
            HoursOfWork = e.HoursOfWork;
        }
    }

}
