using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo.Core.Entities
{
    public class Visitor
    {
        [Key]
        public int Id { get; private set; }
        public string TZ { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string City { get; set; }
        public DateTime LastVisitDate { get; set; }
        public int Rating { get; set; }


    

        public Visitor() { }


        public Visitor(Visitor v)
        {
            Id = v.Id;
            Id = v.Id;
            Name = v.Name;
            Email = v.Email;
            Phone = v.Phone;
            City = v.City;
            LastVisitDate = v.LastVisitDate;
            Rating = v.Rating;
        }
    
    }

}
