using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo.Core.Entities
{
    public class Visitor
    {
        public int Id { get; private set; }
        public string TZ { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string City { get; set; }
        public DateTime LastVisitDate { get; set; }
        public int Rating { get; set; }


        private static int count = 1;

        public Visitor() { }


        public Visitor(Visitor v)
        {
            Id = count++;
            TZ = v.TZ;
            Name = v.Name;
            Email = v.Email;
            Phone = v.Phone;
            City = v.City;
            LastVisitDate = v.LastVisitDate;
            Rating = v.Rating;
        }
        public Visitor(int id, Visitor v)
        {
            Id = id;
            TZ = v.TZ;
            Name = v.Name;
            Email = v.Email;
            Phone = v.Phone;
            City = v.City;
            LastVisitDate = v.LastVisitDate;
            Rating = v.Rating;
        }
    }

}
